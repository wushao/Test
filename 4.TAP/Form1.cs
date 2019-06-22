using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.TAP
{
    public partial class Form1 : Form
    {
        int DownloadSize = 0;
        string downloadPath = null;
        long totalSize = 0;
        FileStream filestream;

        CancellationTokenSource cts = null;
        Task task = null;
        SynchronizationContext sc;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "http://download.microsoft.com/download/7/0/3/703455ee-a747-4cc8-bd3e-98a615c3aedb/dotNetFx35setup.exe";
            button2.Enabled = false;
            GetTotalSize();
            downloadPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + Path.GetFileName(this.textBox1.Text.Trim());
            if (File.Exists(downloadPath))
            {
                FileInfo fileInfo = new FileInfo(downloadPath);
                DownloadSize = (int)fileInfo.Length;
                progressBar1.Value = (int)((float)DownloadSize / (float)totalSize * 100);

            }
        }


        private void GetTotalSize()
        {
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(textBox1.Text.Trim());
            HttpWebResponse response = (HttpWebResponse)myHttpWebRequest.GetResponse();
            totalSize = response.ContentLength;
            response.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filestream = new FileStream(downloadPath, FileMode.OpenOrCreate);
            this.button1.Enabled = false;
            button2.Enabled = true;
            filestream.Seek(DownloadSize, SeekOrigin.Begin);

            sc = SynchronizationContext.Current;
            cts = new CancellationTokenSource();

            task = new Task(()=>DownloadFileWithTAP(textBox1.Text.Trim(),cts.Token,new Progress<int>(p=> { sc.Post(new SendOrPostCallback((result)=>progressBar1.Value=(int)result),p); })));
            task.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cts.Cancel();

        }

        public void DownloadFileWithTAP(string url,CancellationToken ct,IProgress<int> progress)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream responseSteam = null;
            int bufferSize = 2048;
            byte[] bufferBytes = new byte[bufferSize];
            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                if (DownloadSize != 0)
                {
                    request.AddRange(DownloadSize);
                }
                response = (HttpWebResponse)request.GetResponse();
                responseSteam = response.GetResponseStream();
                int readSize = 0;
                while (true)
                {
                    if (ct.IsCancellationRequested == true)
                    {
                        MessageBox.Show(string.Format("下载暂停,已下字节数为{0}", DownloadSize));
                        response.Close();
                        filestream.Close();
                        sc.Post((state) =>
                        {
                            button1.Enabled = true;
                            button2.Enabled = false;
                        }, null);
                        break;
                    }

                    readSize = responseSteam.Read(bufferBytes, 0, bufferBytes.Length);
                    if (readSize > 0)
                    {
                        DownloadSize += readSize;
                        int percentComplete = (int)((float)DownloadSize / (float)totalSize * 100);
                        filestream.Write(bufferBytes, 0, readSize);
                        progress.Report(percentComplete);
                    }
                    else
                    {
                        MessageBox.Show(string.Format("下载已完成，下载的文件地址为:{0}，文件总字节为：{1}字节", downloadPath, totalSize));
                        sc.Post((state) => {
                            button1.Enabled = false;
                            button2.Enabled = false;
                        },null);

                        response.Close();
                        filestream.Close();
                        break;
                    }
                }
            }
            catch(AggregateException ex)
            {
                ex.Handle(e => e is OperationCanceledException);
              
            }
        }
    }
}
