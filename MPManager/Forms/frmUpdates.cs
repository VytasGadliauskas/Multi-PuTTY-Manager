using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionManagement
{
    public partial class FormUpdates : Form
    {
        public FormUpdates()
        {
            InitializeComponent();
        }

        public string strDownloadUrl = "";

        private void FormUpdates_Load(object sender, EventArgs e)
        {
            if (!"".Equals(strDownloadUrl))
            {
                linkLabelDownloadUrl.Text = strDownloadUrl;
                labelDescription.Text = "Application version " +Global.strAppVersion+". New version download url :";
            }
            else
            {
                labelDescription.Text = "Application version is latest " + Global.strAppVersion;
            }
        }

        private void linkLabelDownloadUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(strDownloadUrl);
        }
    }
}
