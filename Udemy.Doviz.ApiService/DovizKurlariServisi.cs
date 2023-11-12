using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Udemy.Doviz.Core;

namespace Udemy.Doviz.ApiService
{
    public partial class DovizKurlariServisi : ServiceBase
    {
        public System.Timers.Timer timer;
        public DovizKurlariServisi()
        {
            InitializeComponent();
            timer = new System.Timers.Timer();
            timer.Interval = 120000; // 2 dakika olarak ayarlandı...
            timer.Elapsed += T_Elapsed;
        }

        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            Core.BusinessLogicLayer BLL = new BusinessLogicLayer();
            BLL.KurBilgileriniGuncelle();
        }

        protected override void OnStart(string[] args)
        {
            timer.Start();
        }
        protected override void OnContinue()
        {
            timer.Stop();
        }
        protected override void OnPause()
        {
            timer.Start();
        }
        protected override void OnStop()
        {
            timer.Stop();
        }
        protected override void OnShutdown()
        {
            timer.Stop();
        }
    }
}
