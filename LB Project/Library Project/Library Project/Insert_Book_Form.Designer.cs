namespace Library_Project
{
    partial class Insert_Book_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insert_Book_Form));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Book_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Register = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Delivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(4, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 594);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert Book";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            this.groupBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GroupBox2_PreviewKeyDown);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Library_Project.Properties.Resources.Folders_Uploads_Folder_icon;
            this.button4.Location = new System.Drawing.Point(8, 539);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "Insert Book";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_ID,
            this.Book_Image,
            this.Book_Name,
            this.User_Book,
            this.Book_Register,
            this.Book_Delivery});
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(383, 170);
            this.dataGridView2.TabIndex = 1;
            // 
            // Book_ID
            // 
            this.Book_ID.HeaderText = "ID";
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.Width = 40;
            // 
            // Book_Image
            // 
            this.Book_Image.HeaderText = "Image";
            this.Book_Image.Name = "Book_Image";
            // 
            // Book_Name
            // 
            this.Book_Name.HeaderText = "Book Name";
            this.Book_Name.Name = "Book_Name";
            this.Book_Name.Width = 200;
            // 
            // User_Book
            // 
            this.User_Book.HeaderText = "User";
            this.User_Book.Name = "User_Book";
            this.User_Book.Width = 150;
            // 
            // Book_Register
            // 
            this.Book_Register.HeaderText = "Register Date";
            this.Book_Register.Name = "Book_Register";
            // 
            // Book_Delivery
            // 
            this.Book_Delivery.HeaderText = "Delivery Date";
            this.Book_Delivery.Name = "Book_Delivery";
            this.Book_Delivery.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Book ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.MouseLeave += new System.EventHandler(this.TextBox1_MouseLeave);
            // 
            // Insert_Book_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(411, 618);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Insert_Book_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Insert_Book_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Insert_Book_Form_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.DataGridViewImageColumn Book_Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Register;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Delivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}