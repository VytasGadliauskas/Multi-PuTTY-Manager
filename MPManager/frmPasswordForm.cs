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
////   Password form called on database open if password set in database, password will be used to descript 
////   session passwords

namespace SessionManagement
{
    public partial class frmPasswordForm : Form
    {
        public frmPasswordForm()
        {
            InitializeComponent();
        }

        private bool boolAllowClose;

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!textBoxDBPassword.Text.Equals("") && textBoxDBPassword.Text != null)
            {
                if ( textBoxDBPassword.Text.Equals(AESoperations.Decrypt(textBoxDBPassword.Text, Global.strEnscriptedDatabasePassword)))
                {
                    Global.strDatabasePassword = textBoxDBPassword.Text;
                    boolAllowClose = true;
                    this.Close();

                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Wrong password !!!";
                }
            }
            else 
            {
                label1.ForeColor = Color.Red;
                label1.Text = "No password !!!";
            }
        }

        private void frmPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.boolAllowClose)
            {
                e.Cancel = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            boolAllowClose = true;
        }
    }
}
