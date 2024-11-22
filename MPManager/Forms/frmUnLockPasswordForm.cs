using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

////   2024.05.20 Added by Vytas Gadliauskas   https://github.com/VytasGadliauskas/Multi-PuTTY-Manager
////   Dialog called then unlocking aplication with "Lock Application" button 

namespace SessionManagement
{
    public partial class frmUnLockPasswordForm : Form
    {
        public frmUnLockPasswordForm()
        {
            InitializeComponent();
            label1.ForeColor = Color.Black;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length >= 8)
            {
                Global.DatabasePassword = textBoxPassword.Text;
                this.Close();
            }
            else 
            {
                label1.ForeColor = Color.Red;
            }
        }
    }
}
