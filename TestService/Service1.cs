using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    public partial class Service1 : ServiceBase
    {
        readonly System.Timers.Timer tmBak = new System.Timers.Timer();
        public Service1()
        {
            InitializeComponent();
            tmBak.Interval = 1000;
            tmBak.AutoReset = true;
            tmBak.Enabled = true;
            tmBak.Elapsed += (sender, eventArgs) =>
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter("F:\\log.txt", true))
                {
                    sw.WriteLine($"antdeply windows 服务:{DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                }
            };
        }

        protected override void OnStart(string[] args)
        {
            tmBak.Start();
        }

        protected override void OnStop()
        {
            tmBak.Stop();
        }
    }
}
