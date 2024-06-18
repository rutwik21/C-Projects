namespace RoomClass
{
    partial class Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDelimiter = new System.Windows.Forms.Label();
            this.lblFileFormat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbExportFileDelimiter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbExportFileFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExportFolder = new System.Windows.Forms.Label();
            this.btnSelectExportFolder = new System.Windows.Forms.Button();
            this.txtExportFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblImportFolder = new System.Windows.Forms.Label();
            this.btnSelectImportFolder = new System.Windows.Forms.Button();
            this.txtImportFolder = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDelimiter);
            this.groupBox1.Controls.Add(this.lblFileFormat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbExportFileDelimiter);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbExportFileFormat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblExportFolder);
            this.groupBox1.Controls.Add(this.btnSelectExportFolder);
            this.groupBox1.Controls.Add(this.txtExportFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 347);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Settings";
            // 
            // lblDelimiter
            // 
            this.lblDelimiter.AutoSize = true;
            this.lblDelimiter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDelimiter.Location = new System.Drawing.Point(528, 277);
            this.lblDelimiter.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDelimiter.Name = "lblDelimiter";
            this.lblDelimiter.Size = new System.Drawing.Size(60, 28);
            this.lblDelimiter.TabIndex = 17;
            this.lblDelimiter.Text = "None";
            // 
            // lblFileFormat
            // 
            this.lblFileFormat.AutoSize = true;
            this.lblFileFormat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFileFormat.Location = new System.Drawing.Point(141, 277);
            this.lblFileFormat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFileFormat.Name = "lblFileFormat";
            this.lblFileFormat.Size = new System.Drawing.Size(60, 28);
            this.lblFileFormat.TabIndex = 16;
            this.lblFileFormat.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(412, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Selected : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(27, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Selected : ";
            // 
            // cmbExportFileDelimiter
            // 
            this.cmbExportFileDelimiter.FormattingEnabled = true;
            this.cmbExportFileDelimiter.Items.AddRange(new object[] {
            "Comma",
            "Tab"});
            this.cmbExportFileDelimiter.Location = new System.Drawing.Point(418, 235);
            this.cmbExportFileDelimiter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbExportFileDelimiter.Name = "cmbExportFileDelimiter";
            this.cmbExportFileDelimiter.Size = new System.Drawing.Size(281, 36);
            this.cmbExportFileDelimiter.TabIndex = 13;
            this.cmbExportFileDelimiter.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Select Delimiter";
            // 
            // cmbExportFileFormat
            // 
            this.cmbExportFileFormat.FormattingEnabled = true;
            this.cmbExportFileFormat.Items.AddRange(new object[] {
            ".txt",
            ".csv",
            ".xlsx",
            ".pdf"});
            this.cmbExportFileFormat.Location = new System.Drawing.Point(32, 235);
            this.cmbExportFileFormat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbExportFileFormat.Name = "cmbExportFileFormat";
            this.cmbExportFileFormat.Size = new System.Drawing.Size(286, 36);
            this.cmbExportFileFormat.TabIndex = 10;
            this.cmbExportFileFormat.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(27, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selected : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select file format";
            // 
            // lblExportFolder
            // 
            this.lblExportFolder.AutoSize = true;
            this.lblExportFolder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblExportFolder.Location = new System.Drawing.Point(141, 132);
            this.lblExportFolder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblExportFolder.Name = "lblExportFolder";
            this.lblExportFolder.Size = new System.Drawing.Size(60, 28);
            this.lblExportFolder.TabIndex = 3;
            this.lblExportFolder.Text = "None";
            // 
            // btnSelectExportFolder
            // 
            this.btnSelectExportFolder.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectExportFolder.Location = new System.Drawing.Point(533, 91);
            this.btnSelectExportFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectExportFolder.Name = "btnSelectExportFolder";
            this.btnSelectExportFolder.Size = new System.Drawing.Size(166, 36);
            this.btnSelectExportFolder.TabIndex = 2;
            this.btnSelectExportFolder.Text = "Select folder";
            this.btnSelectExportFolder.UseVisualStyleBackColor = true;
            this.btnSelectExportFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtExportFolder
            // 
            this.txtExportFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExportFolder.Enabled = false;
            this.txtExportFolder.Location = new System.Drawing.Point(33, 91);
            this.txtExportFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtExportFolder.Name = "txtExportFolder";
            this.txtExportFolder.Size = new System.Drawing.Size(492, 34);
            this.txtExportFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Export folder";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(580, 574);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(166, 45);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblImportFolder);
            this.groupBox2.Controls.Add(this.btnSelectImportFolder);
            this.groupBox2.Controls.Add(this.txtImportFolder);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 203);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Import Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(27, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "Selected : ";
            // 
            // lblImportFolder
            // 
            this.lblImportFolder.AutoSize = true;
            this.lblImportFolder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblImportFolder.Location = new System.Drawing.Point(141, 132);
            this.lblImportFolder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblImportFolder.Name = "lblImportFolder";
            this.lblImportFolder.Size = new System.Drawing.Size(60, 28);
            this.lblImportFolder.TabIndex = 3;
            this.lblImportFolder.Text = "None";
            // 
            // btnSelectImportFolder
            // 
            this.btnSelectImportFolder.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImportFolder.Location = new System.Drawing.Point(533, 91);
            this.btnSelectImportFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectImportFolder.Name = "btnSelectImportFolder";
            this.btnSelectImportFolder.Size = new System.Drawing.Size(166, 36);
            this.btnSelectImportFolder.TabIndex = 2;
            this.btnSelectImportFolder.Text = "Select folder";
            this.btnSelectImportFolder.UseVisualStyleBackColor = true;
            this.btnSelectImportFolder.Click += new System.EventHandler(this.btnSelectImportFolder_Click);
            // 
            // txtImportFolder
            // 
            this.txtImportFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImportFolder.Enabled = false;
            this.txtImportFolder.Location = new System.Drawing.Point(33, 91);
            this.txtImportFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtImportFolder.Name = "txtImportFolder";
            this.txtImportFolder.Size = new System.Drawing.Size(492, 34);
            this.txtImportFolder.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 49);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 31);
            this.label14.TabIndex = 0;
            this.label14.Text = "Import folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "(All the files should be in .xlsx format)";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 632);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Settings";
            this.Text = "Settings ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDelimiter;
        private System.Windows.Forms.Label lblFileFormat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbExportFileDelimiter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbExportFileFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExportFolder;
        private System.Windows.Forms.Button btnSelectExportFolder;
        private System.Windows.Forms.TextBox txtExportFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblImportFolder;
        private System.Windows.Forms.Button btnSelectImportFolder;
        private System.Windows.Forms.TextBox txtImportFolder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
    }
}