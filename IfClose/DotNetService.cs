using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IfClose
    {
    public partial class DotNetService : ServiceBase
        {
        public DotNetService()
            {
            InitializeComponent();
            }

        Alert.Alert a = new Alert.Alert();
        protected override void OnStart(string[] args)
            {
            while (true)
                {
                if (a.IsDisposed)
                    {
                    a.Show();
                    }
                }
            }
        protected override void OnStop()
            {
            
            }
        }
    }
