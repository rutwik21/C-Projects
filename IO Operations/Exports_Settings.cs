using OfficeOpenXml.Drawing.Slicer.Style;
using RoomClass.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomClass
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.ShowDialog();

                if (dialog.SelectedPath.ToString() != "")
                {
                    Properties.Settings.Default.exportFolder = dialog.SelectedPath;
                    txtExportFolder.Text = dialog.SelectedPath;
                    lblExportFolder.Text = dialog.SelectedPath;
                    lblExportFolder.ForeColor = Color.Black;
                }
                else
                {
                    throw new Exception("Please select export folder");
                }
            }
            catch (Exception ex)
            {
                Error_Handler.logError(ex.Message);
            }
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.format = cmbExportFileFormat.SelectedItem.ToString();
            lblFileFormat.Text = cmbExportFileFormat.SelectedItem.ToString();
            lblFileFormat.ForeColor = Color.Black;
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.delimiter = cmbExportFileDelimiter.SelectedItem.ToString();
            lblDelimiter.Text = cmbExportFileDelimiter.SelectedItem.ToString();
            lblDelimiter.ForeColor = Color.Black;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string exportFolder = Properties.Settings.Default.exportFolder;
                string format = Properties.Settings.Default.format;
                string delimiter = Properties.Settings.Default.delimiter;
                string importFolder = Properties.Settings.Default.importFolder;
                /*string importFileFormat = Properties.Settings.Default.importFileFormat;
                string importFileDelimiter = Properties.Settings.Default.importFileDelimiter;*/
                if (exportFolder != "" && format != "" && delimiter != "" && importFolder != "")
                {
                    var a = new Export_Data();
                    a.Show();
                    this.Hide();
                }
                else throw new Exception("Please select all the fields.");
            }
            catch (Exception ex) 
            {
                Error_Handler.logError(ex.Message);
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                lblExportFolder.Text = Properties.Settings.Default.exportFolder;
                lblExportFolder.ForeColor = Color.Black;
                lblFileFormat.Text = Properties.Settings.Default.format;
                lblFileFormat.ForeColor = Color.Black;
                lblDelimiter.Text = Properties.Settings.Default.delimiter;
                lblDelimiter.ForeColor = Color.Black;
                lblImportFolder.Text = Properties.Settings.Default.importFolder;
                lblImportFolder.ForeColor = Color.Black;
                /*lblImportFileFormat.Text = Properties.Settings.Default.importFileFormat;
                lblImportFileFormat.ForeColor = Color.Black;
                lblImportFileDelimiter.Text = Properties.Settings.Default.importFileDelimiter;
                lblImportFileDelimiter.ForeColor = Color.Black;*/
            }
            catch (Exception ex)
            {
                Error_Handler.logError(ex.Message);
            }
        }

        private void btnSelectImportFolder_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.ShowDialog();

                if (dialog.SelectedPath.ToString() != "")
                {
                    Properties.Settings.Default.importFolder = dialog.SelectedPath;
                    txtImportFolder.Text = dialog.SelectedPath;
                    lblImportFolder.Text = dialog.SelectedPath;
                    lblImportFolder.ForeColor = Color.Black;
                }
                else
                {
                    throw new Exception("Please select import folder");
                }
            }
            catch (Exception ex)
            {
                Error_Handler.logError(ex.Message);
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /*private void cmbImportFileFormat_SelectedValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.importFileFormat = cmbImportFileFormat.SelectedItem.ToString();
            lblImportFileFormat.Text = cmbImportFileFormat.SelectedItem.ToString();
            lblImportFileFormat.ForeColor = Color.Black;
        }

        private void cmbImportFileDelimiter_SelectedValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.importFileDelimiter = cmbImportFileDelimiter.SelectedItem.ToString();
            lblImportFileDelimiter.Text = cmbImportFileDelimiter.SelectedItem.ToString();
            lblImportFileDelimiter.ForeColor = Color.Black;
        }*/
    }
}
