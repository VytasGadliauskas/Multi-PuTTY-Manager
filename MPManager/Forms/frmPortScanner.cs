using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

//// Vytas Gadliauskas  Port Scanner (finds ip's with ssh(tcp/22, ... ports adds to database hosts)
namespace SessionManagement
{
    public partial class frmPortScanner : DockContent
    {
        public frmPortScanner()
        {
            InitializeComponent();
        }
    }
}
