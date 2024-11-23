using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;

// Vytas Gadliauskas  2024.11.19  add import csv file form

namespace SessionManagement.Forms
{
    public partial class frmImportCsv : Form
    {
        private TreeNode treeNode;

        public frmImportCsv()
        {
            InitializeComponent();
        }

        private void toolStripButtonOpenCsvFile_Click(object sender, EventArgs e)
        {
            openDialogCsvFile("csv");
        }

        private void openDialogCsvFile(string fileType) { 
         try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (fileType == "csv")
                {
                    openFileDialog.Filter = "Csv Files (*.csv)|*.csv";
                    openFileDialog.Title = "Open Csv file";
                }
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\CsvFiles";
                if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName.Length > 0)
                {
                    string fileName = openFileDialog.FileName;
                    richTextBoxCsvFile.Text = "";
                    richTextBoxCsvFile.Lines = File.ReadAllLines(fileName);
                    toolStripButtonImportCsvToNodeTree.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                // Vytas Gadliauskas added exception logging
                Logs.writeLog(ex.Message);
            }
        }

        private void toolStripButtonImportCsvToNodeTree_Click(object sender, EventArgs e)
        {
            if (richTextBoxCsvFile.Lines.Length > 0)
            {
                if (int.Parse(Global.treeSessions.SelectedNode.Name) <= 0)
                {
                    int error = 0;
                    int progressStep = 1;
                    string[] lines = richTextBoxCsvFile.Lines;
                    if (lines.Length >= 100)
                    {
                        progressStep = lines.Length / 100;
                    }
                    else 
                    {
                        progressStep = 100 / lines.Length;
                    }

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] strs = lines[i].Split(',');
                        if (strs.Length == 9 && !"".Equals(strs[0]) && !"".Equals(strs[1]) && !"".Equals(strs[2]) && !"".Equals(strs[3]) &&
                             !"".Equals(strs[5]) && !"".Equals(strs[6]))
                        {
                            // adding to nodes 
                            createNewNode(strs);
                            lines[i] = lines[i] + "  -- OK";
                        }
                        else
                        {
                            lines[i] = lines[i] + "  -- ERROR Bad Format";
                            error++;
                        }
                    }
                    richTextBoxCsvFile.Text = "";
                    richTextBoxCsvFile.Lines = lines;
                    richTextBoxCsvFile.Text += ("\n\n\n ------------------------------------ \n Finished import, errors : " + error);
                    richTextBoxCsvFile.SelectionStart = richTextBoxCsvFile.Text.Length;
                    richTextBoxCsvFile.ScrollToCaret();

                    toolStripProgressBarImport.Value = 100;
                }
                else 
                {
                    DialogResult result =  MessageBox.Show("Selected not folder for import in Session Manager", "Import error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            else 
            {
                MessageBox.Show("CSV file empty", "Import error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void createNewNode(string[] strs)
        {
            if ( this.treeNode == null || !treeNode.Text.Equals(strs[0]))
            {
                TreeNode treeNode2 = new TreeNode();
                treeNode2.Name = "0";
                treeNode2.Text = strs[0];
                treeNode2.ContextMenuStrip = Global.contextForFolder;
                treeNode2.ImageIndex = 1;
                treeNode2.SelectedImageIndex = 1;
                treeNode2.EnsureVisible();
                Global.treeNodeSelected.Nodes.Add(treeNode2);
                Global.treeSessions.SelectedNode = treeNode2;
                this.treeNode = treeNode2;
            }

            try
            {   
                Session sess = new Session();
                if (Global.arrAvailableSessions == null)
                {
                  sess.sessionID = 1;
                }
                else
                {
                  sess.sessionID = Global.arrAvailableSessions.Count + 1;
                }
                sess.sessionName = strs[1];
                sess.sessionHost = strs[3];
                sess.sessionProtocol = strs[2];
                sess.sessionPort = int.Parse(strs[4]);
                sess.sessionConfig = "Default";
                sess.sessionDescription = strs[8];
                sess.sessionUserName = strs[5];
                sess.sessionPassword = strs[6];
                sess.publicKey = "yes".Equals(strs[7])?true:false;
                sess.ftpUserName = strs[5];
                sess.ftpPassword = strs[6];
                sess.sftpUserName = strs[5];
                sess.sftpPassword = strs[6];
                sess.vcXsrvUserName = strs[5];
                sess.vcXsrvPassword = strs[6];
                sess.postLogin = false;
                sess.connectionTimeout = 1000;
                sess.usernameTimeout = 1000;
                sess.passwordTimeout = 1000;
                sess.commandTimeout = 1000;
                sess.postLoginCommands = new ArrayList();

                try
                {
                    TreeNode selectedNode = Global.treeSessions.SelectedNode;


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
                       // this.setToolTipsForSessionNode(treeNode, sess);
                        Global.treeSessions.SelectedNode.Nodes.Add(treeNode);
                       // this.alertWhenDuplicateNodeName(treeNode);
                    }

                }
                catch (Exception ex)
                {
                    // Vytas Gadliauskas added exception logging
                    Logs.writeLog(ex.Message);
                }


                //  base.Close();
            }
            catch (Exception ex)
            {
                // Vytas Gadliauskas added exception logging
                Logs.writeLog(ex.Message);
            }
        }

    }
}
