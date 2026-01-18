using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SessionManagement.Operations;
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

        private void buttonScann_Click(object sender, EventArgs e)
        {
            buttonScann.Enabled = false;
            try
            {
                if (Int32.Parse(maskedTextBox4.Text) <= Int32.Parse(maskedTextBoxEnd.Text))
                {
                    for (int i = Int32.Parse(maskedTextBox4.Text); i < Int32.Parse(maskedTextBoxEnd.Text) + 1; i++)
                    {
                        System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
                        System.Net.NetworkInformation.PingReply pingReply;

                        string IP = maskedTextBox1.Text + "." + maskedTextBox2.Text + "." + maskedTextBox3.Text + "." + i;
                        richTextBoxLog.AppendText(IP + " - ");

                        pingReply = ping.Send(IP, 500);

                        // If there is a successful ping then return true.
                        if (pingReply != null && pingReply.Status == System.Net.NetworkInformation.IPStatus.Success)
                        {
                            richTextBoxLog.AppendText("UP ... ");
                            if (ScanOperations.IsPortOpen(IP, (int)numericUpDownPort.Value, 1000))
                            {
                                richTextBoxLog.AppendText(" Port " + (int)numericUpDownPort.Value + " open\r\n");
                                dataGridViewScanTable.Rows.Add(IP, ScanOperations.resolveIp(IP), (int)numericUpDownPort.Value);
                            }
                            else
                            {
                                richTextBoxLog.AppendText("...\r\n");
                            }
                        }
                        else
                        {
                            richTextBoxLog.AppendText("...\r\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                richTextBoxLog.AppendText(ex.Message + "\r\n");
            }
            buttonScann.Enabled = true;
        }


        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            maskedTextBox1.BackColor = Color.White;
            if (e.KeyData == Keys.Decimal || ScanOperations.validateTextLenth(maskedTextBox1.Text))
            {
                maskedTextBox5.Text = maskedTextBox1.Text;
                if (!ScanOperations.validateIpOctet(maskedTextBox1.Text))
                {
                    maskedTextBox1.BackColor = Color.Red;
                }
                maskedTextBox2.Focus();
            }
            else
            {
                maskedTextBox1.Text = ScanOperations.removeNotNumbers(maskedTextBox1.Text);
            }
        }

        private void maskedTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            maskedTextBox2.BackColor = Color.White;

            if (e.KeyData == Keys.Back && maskedTextBox2.Text == "")
            {
                maskedTextBox1.Focus();
            }
            else if (e.KeyData == Keys.Decimal || ScanOperations.validateTextLenth(maskedTextBox2.Text))
            {
                maskedTextBox6.Text = maskedTextBox2.Text;
                if (!ScanOperations.validateIpOctet(maskedTextBox2.Text))
                {
                    maskedTextBox2.BackColor = Color.Red;
                }
                maskedTextBox3.Focus();
            }
            else
            {
                maskedTextBox2.Text = ScanOperations.removeNotNumbers(maskedTextBox2.Text);
            }
        }

        private void maskedTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            maskedTextBox3.BackColor = Color.White;

            if (e.KeyData == Keys.Back && maskedTextBox3.Text == "")
            {
                maskedTextBox2.Focus();
            }
            else if (e.KeyData == Keys.Decimal || ScanOperations.validateTextLenth(maskedTextBox3.Text))
            {
                maskedTextBox7.Text = maskedTextBox3.Text;
                if (!ScanOperations.validateIpOctet(maskedTextBox3.Text))
                {
                    maskedTextBox3.BackColor = Color.Red;
                }
                maskedTextBox4.Focus();
            }
            else
            {
                maskedTextBox3.Text = ScanOperations.removeNotNumbers(maskedTextBox3.Text);
            }
        }

        private void maskedTextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            maskedTextBox4.BackColor = Color.White;

            if (e.KeyData == Keys.Back && maskedTextBox4.Text == "")
            {
                maskedTextBox3.Focus();
            }
            else if (e.KeyData == Keys.Decimal || ScanOperations.validateTextLenth(maskedTextBox4.Text))
            {
                if (!ScanOperations.validateIpOctet(maskedTextBox4.Text))
                {
                    maskedTextBox4.BackColor = Color.Red;
                }
                maskedTextBoxEnd.Focus();
            }
            else
            {
                maskedTextBox4.Text = ScanOperations.removeNotNumbers(maskedTextBox4.Text);
            }
        }

        private void maskedTextBoxEnd_KeyDown(object sender, KeyEventArgs e)
        {
            maskedTextBox4.BackColor = Color.White;

            if (e.KeyData == Keys.Back && maskedTextBoxEnd.Text == "")
            {
                maskedTextBox4.Focus();
            }
            else if (e.KeyData == Keys.Decimal || ScanOperations.validateTextLenth(maskedTextBoxEnd.Text))
            {
                if (!ScanOperations.validateIpOctet(maskedTextBoxEnd.Text))
                {
                    maskedTextBox4.BackColor = Color.Red;
                }
                buttonScann.Enabled = false;
            }
            else
            {
                maskedTextBoxEnd.Text = ScanOperations.removeNotNumbers(maskedTextBoxEnd.Text);
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            maskedTextBox5.Text = maskedTextBox1.Text;
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            maskedTextBox6.Text = maskedTextBox2.Text;
        }

        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            maskedTextBox7.Text = maskedTextBox3.Text;
        }

        private void richTextBoxLog_TextChanged(object sender, EventArgs e)
        {
            richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            richTextBoxLog.ScrollToCaret();
        }


        public void createOrUpdateSession(Session sess)
        {
            try
            {
                TreeNode selectedNode = Global.treeSessions.SelectedNode;
                // Vytas Gadliauskas if selected node is Folder create session in it
                if (int.Parse(selectedNode.Name) <= 0)
                {
                    if (Global.arrAvailableSessions == null)
                    {
                        Global.arrAvailableSessions = new ArrayList();
                    }
                    Global.arrAvailableSessions.Add(sess);
                    TreeNode treeNode = new TreeNode();
                    treeNode.Name = sess.sessionID.ToString();
                    treeNode.Text = sess.sessionName;
                    treeNode.ContextMenuStrip = Global.contextForSession;
                    treeNode.ImageIndex = 2;
                    treeNode.SelectedImageIndex = 2;
                    treeNode.EnsureVisible();
                    treeNode.BeginEdit();
                    this.setToolTipsForSessionNode(treeNode, sess);
                    selectedNode.Nodes.Add(treeNode);
                    this.alertWhenDuplicateNodeName(treeNode);
                }
                else
                {
                // Vytas Gadliauskas if selected node is not Folder then create in Parent node (which will be folder)
                    if (selectedNode.Parent != null)
                    {
                        if (Global.arrAvailableSessions == null)
                        {
                            Global.arrAvailableSessions = new ArrayList();
                        }
                        Global.arrAvailableSessions.Add(sess);
                        TreeNode treeNode = new TreeNode();
                        treeNode.Name = sess.sessionID.ToString();
                        treeNode.Text = sess.sessionName;
                        treeNode.ContextMenuStrip = Global.contextForSession;
                        treeNode.ImageIndex = 2;
                        treeNode.SelectedImageIndex = 2;
                        treeNode.EnsureVisible();
                        treeNode.BeginEdit();
                        this.setToolTipsForSessionNode(treeNode, sess);
                        selectedNode.Parent.Nodes.Add(treeNode);
                        this.alertWhenDuplicateNodeName(treeNode);
                    }
                }
            }
            catch (Exception ex)
            {
                // Vytas Gadliauskas added exception logging
                Logs.writeLog(ex.Message);
            }
        }


        public void setToolTipsForSessionNode(TreeNode treeNode, Session sess)
        {
            if (sess.sessionUserName != "")
            {
                treeNode.ToolTipText = string.Concat(new string[]
                {
                    sess.sessionUserName,
                    "@",
                    sess.sessionHost,
                    " (",
                    sess.sessionProtocol,
                    "/",
                    sess.sessionPort.ToString(),
                    ")"
                });
            }
            else
            {
                treeNode.ToolTipText = string.Concat(new string[]
                {
                    sess.sessionHost,
                    " (",
                    sess.sessionProtocol,
                    "/",
                    sess.sessionPort.ToString(),
                    ")"
                });
            }
        }

        public void alertWhenDuplicateNodeName(TreeNode treeNode)
        {
            if (treeNode.Parent != null)
            {
                foreach (object obj in treeNode.Parent.Nodes)
                {
                    TreeNode treeNode2 = (TreeNode)obj;
                    if (treeNode2 != treeNode && treeNode2.Text == treeNode.Text)
                    {
                        if (int.Parse(treeNode2.Name) == 0 && int.Parse(treeNode.Name) == 0)
                        {
                            MessageBox.Show("This name is used for another folder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        }
                        if (int.Parse(treeNode2.Name) > 0 && int.Parse(treeNode.Name) > 0)
                        {
                            MessageBox.Show("This name is used for another session", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        }
                    }
                }
            }
        }

        private void toolStripMenuItemAddSession_Click(object sender, EventArgs e)
        {
            frmSession frmSession = new frmSession();
            Session sess = new Session();
            if (Global.arrAvailableSessions == null)
            {
                sess.sessionID = 1;
            }
            else
            {
                sess.sessionID = Global.arrAvailableSessions.Count + 1;
            }
            DataGridViewRow row = dataGridViewScanTable.Rows[dataGridViewScanTable.CurrentCell.RowIndex];
            sess.sessionName = row.Cells[1].Value.ToString();
            sess.sessionHost = row.Cells[0].Value.ToString();
            sess.sessionProtocol = "SSH";
            sess.sessionPort = int.Parse(this.numericUpDownPort.Value.ToString());
            sess.sessionConfig = "Default";
            sess.sessionDescription = "";
            sess.sessionUserName = "";
            sess.sessionPassword = "";
            //// Vytas Gadliauskas public key
            sess.publicKey = false;
            sess.ftpUserName = "";
            sess.ftpPassword = "";
            sess.sftpUserName = "";
            sess.sftpPassword = "";
            /// Vytas Gadliauskas  XWindows VcXsrv
            sess.vcXsrvUserName = "";
            sess.vcXsrvPassword = "";

            sess.postLogin = false;
            sess.connectionTimeout = 2000;
            sess.usernameTimeout = 1000;
            sess.passwordTimeout = 1000;
            sess.commandTimeout = 1000;
            frmSession.loadExistingSession(sess);
            frmSession.createOrUpdateSession = new frmSession.CreateOrUpdateSession(this.createOrUpdateSession);
            frmSession.ShowDialog();
        }

    }

}
