namespace RoomClass
{
    partial class Export_Data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExportData = new System.Windows.Forms.Button();
            this.btnBackupDB = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.txtSelectedFiles = new System.Windows.Forms.TextBox();
            this.btnImportData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumOfFiles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExportData
            // 
            this.btnExportData.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExportData.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExportData.Location = new System.Drawing.Point(835, 651);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(184, 38);
            this.btnExportData.TabIndex = 4;
            this.btnExportData.Text = "Export Data";
            this.btnExportData.UseVisualStyleBackColor = false;
            this.btnExportData.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBackupDB
            // 
            this.btnBackupDB.BackColor = System.Drawing.Color.Gray;
            this.btnBackupDB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBackupDB.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupDB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackupDB.Location = new System.Drawing.Point(865, 121);
            this.btnBackupDB.Name = "btnBackupDB";
            this.btnBackupDB.Size = new System.Drawing.Size(154, 38);
            this.btnBackupDB.TabIndex = 1;
            this.btnBackupDB.Text = "Backup to DB";
            this.btnBackupDB.UseVisualStyleBackColor = false;
            this.btnBackupDB.Click += new System.EventHandler(this.btnBackupDB_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSetting.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Location = new System.Drawing.Point(645, 651);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(184, 38);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnExportFolder_Click);
            // 
            // txtSelectedFiles
            // 
            this.txtSelectedFiles.Location = new System.Drawing.Point(17, 77);
            this.txtSelectedFiles.Multiline = true;
            this.txtSelectedFiles.Name = "txtSelectedFiles";
            this.txtSelectedFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSelectedFiles.Size = new System.Drawing.Size(842, 82);
            this.txtSelectedFiles.TabIndex = 0;
            // 
            // btnImportData
            // 
            this.btnImportData.BackColor = System.Drawing.Color.Gray;
            this.btnImportData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImportData.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImportData.Location = new System.Drawing.Point(865, 77);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(154, 38);
            this.btnImportData.TabIndex = 9;
            this.btnImportData.Text = "Import Data";
            this.btnImportData.UseVisualStyleBackColor = false;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 480);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selected Files";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumOfFiles);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnImportData);
            this.groupBox1.Controls.Add(this.txtSelectedFiles);
            this.groupBox1.Controls.Add(this.btnSetting);
            this.groupBox1.Controls.Add(this.btnBackupDB);
            this.groupBox1.Controls.Add(this.btnExportData);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1035, 700);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transform Data";
            // 
            // lblNumOfFiles
            // 
            this.lblNumOfFiles.AutoSize = true;
            this.lblNumOfFiles.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNumOfFiles.Location = new System.Drawing.Point(677, 43);
            this.lblNumOfFiles.Name = "lblNumOfFiles";
            this.lblNumOfFiles.Size = new System.Drawing.Size(182, 31);
            this.lblNumOfFiles.TabIndex = 11;
            this.lblNumOfFiles.Text = "Number of files :";
            this.lblNumOfFiles.Visible = false;
            // 
            // Export_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 712);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Export_Data";
            this.Text = "Transform Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Export_Data_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.Button btnBackupDB;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.TextBox txtSelectedFiles;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumOfFiles;
    }
}

