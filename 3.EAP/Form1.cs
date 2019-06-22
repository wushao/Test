using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.EAP
{
    public partial class Form1 : Form
    {
        public int DownloadSize = 0;
        public string downloadPath = null;
        long totalSize = 0;
        const int BufferSize = 2048;
        byte[] BufferRead = new byte[BufferSize];
        FileStream filestream = null;
        HttpWebResponse myWebResponse = null;
        public Form1()
        {
            InitializeComponent();
           string url = "http://download.microsoft.com/download/7/0/3/703455ee-a747-4cc8-bd3e-98a615c3aedb/dotNetFx35setup.exe";
            textBox1.Text = url;
            this.button2.Enabled = false;

            GetTotalSize();
            downloadPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + Path.GetFileName(this.textBox1.Text.Trim());
            if (File.Exists(downloadPath))
            {
                FileInfo fileInfo = new FileInfo(downloadPath);
                DownloadSize = (int)fileInfo.Length;
                progressBar1.Value = (int)((float)DownloadSize / (float)totalSize * 100);
            }
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgworker = sender as BackgroundWorker;
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(textBox1.Text.Trim());
                if (DownloadSize != 0)
                {
                    myHttpWebRequest.AddRange(DownloadSize);
                }

                myWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                Stream responseStream = myWebResponse.GetResponseStream();
                int readSize = 0;
                while (true)
                {
                    if (backgroundWorker1.CancellationPending == true)
                    {
                        e.Cancel = true;break;
                    }
                    readSize = responseStream.Read(BufferRead, 0, BufferRead.Length);
                    if (readSize > 0)
                    {
                        DownloadSize += readSize;
                        int percentComplete = (int)((float)DownloadSize / (float)totalSize * 100);
                        filestream.Write(BufferRead, 0, readSize);
                        backgroundWorker1.ReportProgress(percentComplete);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
                myWebResponse.Close();
            }
            else if (e.Cancelled)
            {
                MessageBox.Show(string.Format("下载暂停，下载的文件地址为：{0}\n 已经下载的字节数为:{1}字节",downloadPath,DownloadSize));
                myWebResponse.Close();
                filestream.Close();

                this.button1.Enabled = true;
                this.button2.Enabled = false;

            }
            else
            {
                MessageBox.Show(string.Format("下载完成，下载的地址为:{0}，文件的总字节数为：{1}字节",downloadPath,totalSize));
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                myWebResponse.Close();
                filestream.Close();
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
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
                filestream = new FileStream(downloadPath, FileMode.OpenOrCreate);
                filestream.Seek(DownloadSize, SeekOrigin.Begin);
                button1.Enabled = false;
                this.button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("正在执行操作，请稍后");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy && backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
            }
        }
    }
}
