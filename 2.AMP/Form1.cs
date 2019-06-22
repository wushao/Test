using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "http://download.microsoft.com/download/7/0/3/703455ee-a747-4cc8-bd3e-98a615c3aedb/dotNetFx35setup.exe";
        }
        SynchronizationContext sc;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "下载中·····";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入地址");
                return;
            }

            sc = SynchronizationContext.Current;
            AsyncMethodCaller methodCaller = new AsyncMethodCaller(DownLoadFileASync);

            methodCaller.BeginInvoke(textBox1.Text.Trim(), GetResult, null);
        }
        public string DownLoadFileASync(string url)
            {
                int BufferSize = 2048;

                byte[] BufferRead = new byte[BufferSize];

                string savepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\dotNetFx 25setup.exe";

                FileStream filestream = null;

                HttpWebResponse myWebResponse = null;

                if (File.Exists(savepath))
                {
                    File.Delete(savepath);
                }

                filestream = new FileStream(savepath, FileMode.OpenOrCreate);

                try
                {
                    HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);

                    if (myHttpWebRequest != null)
                    {

                    myWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();                  
                    Stream responseStream = myWebResponse.GetResponseStream();

                        int readSize = responseStream.Read(BufferRead, 0, BufferSize);

                        while (readSize > 0)
                        {
                            filestream.Write(BufferRead, 0, readSize);
                            readSize = responseStream.Read(BufferRead, 0, BufferSize);
                        }
                    }
                    return "文件下载完成" + filestream.Length + "路径" + savepath;
                }
                catch (Exception e)
                {
                   return "下载发生异常" + e.Message;
                }
                finally
                {
                    if (myWebResponse != null)
                    {
                        myWebResponse.Close();
                    }

                    if (filestream != null)
                    {
                        filestream.Close();
                    }

                }
            }

        private delegate string AsyncMethodCaller(string fileUrl);
        private void GetResult(IAsyncResult result)
        {
            AsyncMethodCaller caller = (AsyncMethodCaller)((AsyncResult)result).AsyncDelegate;
            string returnstring = caller.EndInvoke(result);
           
        }

       
    }
}
