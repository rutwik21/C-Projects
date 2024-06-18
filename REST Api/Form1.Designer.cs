namespace REST_Api
{
    partial class Form1
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
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnGetAllProducts = new System.Windows.Forms.Button();
            this.btnGetCategories = new System.Windows.Forms.Button();
            this.txtPostOrUpdate = new System.Windows.Forms.RichTextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetProduct = new System.Windows.Forms.Button();
            this.txtGetProduct = new System.Windows.Forms.TextBox();
            this.Heading = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Location = new System.Drawing.Point(376, 67);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(516, 542);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "";
            // 
            // btnGetAllProducts
            // 
            this.btnGetAllProducts.Location = new System.Drawing.Point(12, 67);
            this.btnGetAllProducts.Name = "btnGetAllProducts";
            this.btnGetAllProducts.Size = new System.Drawing.Size(358, 36);
            this.btnGetAllProducts.TabIndex = 1;
            this.btnGetAllProducts.Text = "Get All Products";
            this.btnGetAllProducts.UseVisualStyleBackColor = true;
            this.btnGetAllProducts.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnGetCategories
            // 
            this.btnGetCategories.Location = new System.Drawing.Point(12, 109);
            this.btnGetCategories.Name = "btnGetCategories";
            this.btnGetCategories.Size = new System.Drawing.Size(358, 36);
            this.btnGetCategories.TabIndex = 2;
            this.btnGetCategories.Text = "Get Categories";
            this.btnGetCategories.UseVisualStyleBackColor = true;
            this.btnGetCategories.Click += new System.EventHandler(this.btnGetCategories_Click);
            // 
            // txtPostOrUpdate
            // 
            this.txtPostOrUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostOrUpdate.Location = new System.Drawing.Point(12, 308);
            this.txtPostOrUpdate.Name = "txtPostOrUpdate";
            this.txtPostOrUpdate.Size = new System.Drawing.Size(358, 204);
            this.txtPostOrUpdate.TabIndex = 3;
            this.txtPostOrUpdate.Text = "{\n     title: \'test product\',\n     price: 13.5,\n     description: \'lorem ipsum se" +
    "t\',\n     image: \'https://i.pravatar.cc\',\n     category: \'electronic\'\n}";
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(12, 516);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(358, 36);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "Post Product";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDelete.Location = new System.Drawing.Point(11, 231);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(168, 31);
            this.txtDelete.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 36);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(11, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Product ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(185, 574);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(185, 36);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdate.Location = new System.Drawing.Point(12, 578);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(167, 31);
            this.txtUpdate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Post or Update Product ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(10, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Product ID";
            // 
            // btnGetProduct
            // 
            this.btnGetProduct.Location = new System.Drawing.Point(184, 170);
            this.btnGetProduct.Name = "btnGetProduct";
            this.btnGetProduct.Size = new System.Drawing.Size(185, 36);
            this.btnGetProduct.TabIndex = 13;
            this.btnGetProduct.Text = "Get Product";
            this.btnGetProduct.UseVisualStyleBackColor = true;
            this.btnGetProduct.Click += new System.EventHandler(this.btnGetProduct_Click);
            // 
            // txtGetProduct
            // 
            this.txtGetProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetProduct.Location = new System.Drawing.Point(10, 174);
            this.txtGetProduct.Name = "txtGetProduct";
            this.txtGetProduct.Size = new System.Drawing.Size(168, 31);
            this.txtGetProduct.TabIndex = 12;
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(4, 22);
            this.Heading.Name = "Heading";
            this.Heading.Padding = new System.Windows.Forms.Padding(2);
            this.Heading.Size = new System.Drawing.Size(271, 35);
            this.Heading.TabIndex = 15;
            this.Heading.Text = "Operations to perform :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 22);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(2);
            this.label5.Size = new System.Drawing.Size(107, 35);
            this.label5.TabIndex = 16;
            this.label5.Text = "Output :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 621);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGetProduct);
            this.Controls.Add(this.txtGetProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtPostOrUpdate);
            this.Controls.Add(this.btnGetCategories);
            this.Controls.Add(this.btnGetAllProducts);
            this.Controls.Add(this.txtResult);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "CRUD Operations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnGetAllProducts;
        private System.Windows.Forms.Button btnGetCategories;
        private System.Windows.Forms.RichTextBox txtPostOrUpdate;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetProduct;
        private System.Windows.Forms.TextBox txtGetProduct;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label label5;
    }
}

