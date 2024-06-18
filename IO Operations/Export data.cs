using OfficeOpenXml;
using RoomClass.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace RoomClass
{
    public partial class Export_Data : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        DataTable dt = new DataTable();
        string importFolder;
        string exportFolder;
        string format;
        string delimiter;

        public Export_Data()
        {
            InitializeComponent();
        }
        private bool isValidSettings()
        {
            if (importFolder != "" && exportFolder != "" && format != "" && delimiter != "")
            {
                return true;
            }
            return false;
        }
        
        private void getSettings()
        {
            try
            {
                importFolder = Properties.Settings.Default.importFolder;
                exportFolder = Properties.Settings.Default.exportFolder;
                format = Properties.Settings.Default.format;
                delimiter = Properties.Settings.Default.delimiter;
                if (delimiter == "Tab") delimiter = "\t";
                if (delimiter == "Comma") delimiter = ",";
            }
            catch (Exception ex) 
            {
                Error_Handler.logError(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("nl-NL");
                getSettings();
                if (!isValidSettings())
                {
                    var a = new Settings();
                    a.Show();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                Error_Handler.logError(ex.Message);
            }
            
        }


        private  async Task<List<RoomClass>> LoadExcelFile(string file)
        {
            try
            {
                using (var package = new ExcelPackage(file))
                {
                    List<RoomClass> output = new List<RoomClass>();
                    await package.LoadAsync(file);
                    if(package.Workbook.Worksheets.Count > 0)
                    {
                        for (int i = 0; i < package.Workbook.Worksheets.Count; i++)
                        {
                            var ws = package.Workbook.Worksheets[i];
                            int row = 6;
                            int col = 1;
                            bool str = string.IsNullOrEmpty(ws.Cells[row, col].Value?.ToString());
                            try
                            {
                                while (!str)
                                {
                                
                                    var a = new RoomClass();
                                    a.Hotel_Brand_Code = ws.Cells[1, 2].Value.ToString().Trim();
                                    a.Hotel_Name = ws.Cells[2, 2].Value.ToString().Trim();
                                    a.Room_Type_Code = ws.Cells[row, col].Value.ToString().Trim();
                                    a.Room_Description = ws.Cells[row, col + 1].Value.ToString().Trim();
                                    a.No_Of_Rooms = Convert.ToInt32(ws.Cells[row, col + 2].Value.ToString().Trim());
                                    a.Room_Class = ws.Cells[row, col + 3].Value.ToString().Trim();
                                    output.Add(a);
                                    row = row + 1;
                                    str = string.IsNullOrEmpty(ws.Cells[row, col].Value?.ToString());
                                }
                            }
                            catch(Exception ex)
                            {
                                Error_Handler.logError(ex.Message);
                            }
                        }
                    }
                    package.Dispose();
                    return output;
                    

                }
            }
            catch (Exception ex)
            {
                Error_Handler.logError(ex.Message);
                return null;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isValidSettings())
                {
                    throw new Exception("Please check export settings");
                }
                
                var dateTime = DateTime.Now.AddDays(-1);
                string folderPath = Properties.Settings.Default.exportFolder + '\\' + $"{dateTime.ToShortDateString()}";
                if(System.IO.Directory.Exists(folderPath))
                {
                    throw new Exception("File exist already!");
                }
                else
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                    ExportFile(dt, folderPath + '\\' + "Output" + format );
                    MessageBox.Show("File Exported Successfully.");
                }
            }
            catch(Exception ex) 
            {
                Error_Handler.logError(ex.Message);
            }
        }

        private void ExportFile(DataTable dtDataTable, string strFilePath)
        {
            try { 
                StreamWriter sw = new StreamWriter(strFilePath, false);

                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    sw.Write(dtDataTable.Columns[i]);
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(delimiter);
                    }
                }
                sw.Write(sw.NewLine);
                foreach (DataRow dr in dtDataTable.Rows)
                {
                    for (int i = 0; i < dtDataTable.Columns.Count; i++)
                    {
                        if (!Convert.IsDBNull(dr[i]))
                        {
                            string value = dr[i].ToString();
                            if (value.Contains(delimiter))
                            {
                                value = String.Format("\"{0}\"", value);
                                sw.Write(value);
                            }
                            else
                            {
                                sw.Write(dr[i].ToString());
                            }
                        }
                        if (i < dtDataTable.Columns.Count - 1)
                        {
                            sw.Write(delimiter);
                        }
                    }
                    sw.Write(sw.NewLine);
                }
                sw.Close();
            }
            catch(Exception ex) 
            {
                Error_Handler.logError(ex.Message);
            }
        }

        private void btnExportFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var a = new Settings();
                a.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                Error_Handler.logError(ex.Message);
            }
        }

        private async void btnImportData_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isValidSettings())
                {
                    throw new Exception("Please check export settings");
                }
                string[] fyles = Directory.GetFiles(importFolder, "*", SearchOption.TopDirectoryOnly);
                
                /*OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";*/
                if (fyles.Length > 0)
                {
                    lblNumOfFiles.Text = "Number of files : " + fyles.Length.ToString();
                    lblNumOfFiles.Visible = true;
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add(new DataColumn("Hotel_Brand_Code", typeof(string)));
                    dataTable.Columns.Add(new DataColumn("Hotel_Name", typeof(string)));
                    dataTable.Columns.Add(new DataColumn("Room_Type_Code", typeof(string)));
                    dataTable.Columns.Add(new DataColumn("Room_Description", typeof(string)));
                    dataTable.Columns.Add(new DataColumn("No_Of_Rooms", typeof(Int32)));
                    dataTable.Columns.Add(new DataColumn("Room_Class", typeof(string)));
                    dataTable.Columns.Add(new DataColumn("Category", typeof(string)));

                    foreach (string file in fyles)
                    {
                        if(txtSelectedFiles.Text == "") txtSelectedFiles.Text = file;
                        else txtSelectedFiles.Text = txtSelectedFiles.Text + System.Environment.NewLine + file;
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                        List<RoomClass> fileData = await LoadExcelFile(file);
                        if (fileData != null)
                        {

                            try
                            {
                                string category = System.IO.Path.GetFileNameWithoutExtension(file).Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace("_", "").Replace("'", "").Replace("Category", "-").Split('-')[1];
                                /*using (SqlConnection connection = new SqlConnection(connectionString))
                                {

                                    connection.Open();
                                    using (SqlCommand command = new SqlCommand($"create table {tblName} (ID int identity,Hotel_Brand_Code varchar(50) not null,Hotel_Name nvarchar(255) not null,Room_Type_Code varchar(50) not null,Room_Description nvarchar(max) not null,#_Of_Room int not null,Room_Class varchar(50) not null);", connection))
                                    {
                                        command.ExecuteNonQuery();
                                    }

                                    connection.Close();
                                }*/
                                //string a = "";
                                foreach (RoomClass roomClass in fileData)
                                {
                                    if (roomClass != null)
                                    {
                                        DataRow dr = dataTable.NewRow();
                                        dr["Hotel_Brand_Code"] = roomClass.Hotel_Brand_Code;
                                        dr["Hotel_Name"] = roomClass.Hotel_Name;
                                        dr["Room_Type_Code"] = roomClass.Room_Type_Code;
                                        dr["Room_Description"] = roomClass.Room_Description;
                                        dr["No_Of_Rooms"] = roomClass.No_Of_Rooms;
                                        dr["Room_Class"] = roomClass.Room_Class;
                                        dr["Category"] = category;

                                        dataTable.Rows.Add(dr);
                                        /*using (SqlConnection connection = new SqlConnection(connectionString))
                                        {
                                            connection.Open();
                                            using (SqlCommand command = new SqlCommand($"INSERT INTO dbo.Room_Class (Hotel_Brand_Code,Hotel_Name,Room_Type_Code,Room_Description,#_Of_Room,Room_Class) VALUES('{roomClass.Hotel_Brand_Code}','{roomClass.Hotel_Name}','{roomClass.Room_Type_Code}','{roomClass.Room_Description}','{roomClass.No_Of_Rooms}','{roomClass.Room_Class}')", connection))
                                            {
                                                command.ExecuteNonQuery();
                                            }

                                            connection.Close();
                                        }*/
                                        //a = a + $"{roomClass.Hotel_Brand_Code}  {roomClass.Hotel_Name}  {roomClass.Room_Type_Code}  {roomClass.Room_Description}    {roomClass.No_Of_Rooms} {roomClass.Room_Class}/";
                                    }
                                }
                                //dataTxt.Text = dataTxt.Text + System.Environment.NewLine + a.Replace("/", System.Environment.NewLine);
                                dataGridView1.DataSource = dataTable;
                                this.dt = dataTable;
                            }
                            catch (Exception ex)
                            {
                                Error_Handler.logError(ex.Message);
                            }

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Error_Handler.logError(ex.Message);
            }
        }

        private void btnBackupDB_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //create object of SqlBulkCopy which help to insert
                    SqlBulkCopy objbulk = new SqlBulkCopy(connection);
                    //assign Destination table name
                    objbulk.DestinationTableName = "bulkInsertData";
                    objbulk.ColumnMappings.Add("Hotel_Brand_Code", "Hotel_Brand_Code");
                    objbulk.ColumnMappings.Add("Hotel_Name", "Hotel_Name");
                    objbulk.ColumnMappings.Add("Room_Type_Code", "Room_Type_Code");
                    objbulk.ColumnMappings.Add("Room_Description", "Room_Description");
                    objbulk.ColumnMappings.Add("No_Of_Rooms", "#_Of_Room");
                    objbulk.ColumnMappings.Add("Room_Class", "Room_Class");
                    objbulk.ColumnMappings.Add("Category", "Category");
                    connection.Open();
                    //insert bulk Records into DataBase.
                    objbulk.WriteToServer(dt);
                    connection.Close();
                }
                MessageBox.Show("Backup successful");
            }
            catch (Exception ex)
            {
                Error_Handler.logError(ex.Message);
            }
            
        }

        private void Export_Data_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
