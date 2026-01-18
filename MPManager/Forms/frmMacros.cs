using SessionManagement.Operations;
using SessionManagement.Data;
using System;
using System.Windows.Forms;


namespace SessionManagement.Forms
{
    public partial class frmMacros : Form
    {
        public frmMacros()
        {
            InitializeComponent();
        }

        public ToolStripComboBox toolStripComboBox;

        private void frmMacros_Load(object sender, EventArgs e)
        {
            try {
                MacrosOperations.loadMacrosFromXMLDatabase();
                if (MacrosOperations.macrosList != null) 
                {
                    loadListValues();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void toolStripButtonSaveMacros_Click(object sender, EventArgs e)
        {
            try
            {
                if (!"".Equals(this.toolStripTextBoxMacrosName.Text))
                {
                    Macros macros = new Macros(this.toolStripTextBoxMacrosName.Text, this.richTextBoxMacrosCommands.Text);
                    MacrosOperations.addMacroToList(macros);
                    loadListValues();
                    this.toolStripTextBoxMacrosName.Text = "";
                }
                else 
                {
                    MessageBox.Show("Macros name empty !", "Error");
                }
            }
            catch
            {

            }
        }

        private void toolStripButtonDeleteMacros_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listBoxMacrosNames.SelectedItem != null)
                {
                    MacrosOperations.deleteMacroFromList(this.listBoxMacrosNames.SelectedItem.ToString());
                    loadListValues();
                    this.toolStripTextBoxMacrosName.Text = "";
                    this.richTextBoxMacrosCommands.Text = "";
                }
            }
            catch
            {

            }
        }

        private void listBoxMacrosNames_Click(object sender, EventArgs e)
        {
            if (this.listBoxMacrosNames.SelectedItem != null)
            {
                try
                {
                    this.toolStripTextBoxMacrosName.Text = this.listBoxMacrosNames.SelectedItem.ToString();
                    this.richTextBoxMacrosCommands.Text = MacrosOperations.getMacroFromList(listBoxMacrosNames.SelectedItem.ToString());
                }
                catch (Exception ex)
                {
                    // Vytas Gadliauskas added exception logging
                    Logs.writeLog(ex.Message);
                }

            }
        }

        public void loadListValues()
        {
            if (MacrosOperations.macrosList != null)
            {
                this.listBoxMacrosNames.Items.Clear();
                foreach (string name2 in MacrosOperations.getmacrosNames())
                {
                    this.listBoxMacrosNames.Items.Add(name2);
                }
                this.toolStripStatusLabelTotalMacrosNumber.Text = MacrosOperations.getmacrosNames().Length.ToString();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.toolStripTextBoxMacrosName.Text = "";
            this.richTextBoxMacrosCommands.Text = "";
        }

        private void toolStripButtonUseMacros_Click(object sender, EventArgs e)
        {
            if (this.listBoxMacrosNames.SelectedItem != null)
            {
                try
                {
                    MacrosOperations.saveMacrosToXMLDatabase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                this.toolStripComboBox.Text = richTextBoxMacrosCommands.Text;
                this.Close();
            }
        }

        private void frmMacros_FormClosing(object sender, FormClosingEventArgs e)
        {
            MacrosOperations.saveMacrosToXMLDatabase();
        }

        private void listBoxMacrosNames_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.listBoxMacrosNames.SelectedItem != null)
            {
                try
                {
                    MacrosOperations.saveMacrosToXMLDatabase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                this.toolStripComboBox.Text = richTextBoxMacrosCommands.Text;
                this.Close();
            }
        }
    }
}
