using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

//// Vytas Gadliauskas  Port Scanner (finds ip's with ssh(tcp/22, ... ports adds to database hosts)
namespace SessionManagement
{
    public partial class frmPortScanner : Form
    {
        public frmPortScanner()
        {
            InitializeComponent();
        }

        private void frmPortScanner_Load(object sender, EventArgs e)
        {
            maskedTextBoxStartIP.ValidatingType = typeof(System.Net.IPAddress);
            maskedTextBoxStopIP.ValidatingType = typeof(System.Net.IPAddress);
        }

        private void buttonScann_Click(object sender, EventArgs e)
        {
            if (!"".Equals(maskedTextBoxStartIP))
            {
                string host = maskedTextBoxStartIP.Text;
                int port = int.Parse(numericUpDownPort.Value.ToString());
                scannHost(host,port);

                string[] row = new string[7] { host, "ssh", host, port.ToString(), "user", "password", "no" };
                dataGridViewScanTable.Rows.Add(row);
            }

        }

        private void scannHost(string host, int port) {
            TcpClient TcpScan = new TcpClient();
            try
            {
                TcpScan.Connect(host, port);
                string[] row = new string[7] {host,"ssh",host,port.ToString(),"user","password","no"};
                dataGridViewScanTable.Rows.Add(row);                
            }
            catch
            {
            }
        }

    }
}
