using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionManagement
{
    public partial class frmNewPasswordForm : Form
    {
        public frmNewPasswordForm()
        {
            InitializeComponent();
            label1.ForeColor = Color.Black;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length >= 8)
            {
                Global.strDatabasePassword = textBoxPassword.Text;
                this.Close();
            }
            else 
            {
                label1.ForeColor = Color.Red;
            }
        }
    }
}
