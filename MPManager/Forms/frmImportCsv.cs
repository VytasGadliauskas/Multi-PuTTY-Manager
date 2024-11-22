using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

// Vytas Gadliauskas  2024.11.19  add import csv file form

namespace SessionManagement.Forms
{
    public partial class frmImportCsv : Form
    {
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
                int error = 0;
                string[] lines = richTextBoxCsvFile.Lines;
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] strs =lines[i].Split(',');
                    if (strs.Length == 8)
                    {
                       lines[i] = lines[i] + " OK";
                       // adding to nodes 

                    }
                    else 
                    {
                        lines[i] = lines[i] + " ERROR Bad Format";
                        error++;
                    }
                }
                richTextBoxCsvFile.Text = "";
                richTextBoxCsvFile.Lines = lines;
                richTextBoxCsvFile.Text += (" \n Finished import, errors : "+error);
                toolStripProgressBarImport.Value = 100;
            }
        }
    }
}
