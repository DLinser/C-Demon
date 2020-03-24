using StartWithBootServices.Theard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace StartWithBootServices
{
    partial class AutoStartService : ServiceBase
    {
        AtuoStartControl atuoStartControl;
        public AutoStartService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            atuoStartControl = new AtuoStartControl();
            Task task = new Task(() =>
            {
                atuoStartControl.Start();
            });
            task.Start();
        }

        protected override void OnStop()
        {
            atuoStartControl.Stop();
        }
    }
}
