namespace Data_Structure__I_P_P_Project_
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
            this.Equation_TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Methods = new System.Windows.Forms.ComboBox();
            this.Stack_Operators = new System.Windows.Forms.ListBox();
            this.lblEquation = new System.Windows.Forms.Label();
            this.Stack_Operands = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.Answer_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Equation_TextBox
            // 
            this.Equation_TextBox.Enabled = false;
            this.Equation_TextBox.Location = new System.Drawing.Point(116, 331);
            this.Equation_TextBox.Name = "Equation_TextBox";
            this.Equation_TextBox.Size = new System.Drawing.Size(349, 22);
            this.Equation_TextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(10, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(455, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Methods
            // 
            this.Methods.FormattingEnabled = true;
            this.Methods.Items.AddRange(new object[] {
            "Infix -> Prefix",
            "Infix -> Postfix",
            "Prefix -> Infix",
            "Postfix -> Infix",
            "Prefix -> Postfix",
            "Postfix -> Prefix"});
            this.Methods.Location = new System.Drawing.Point(101, 420);
            this.Methods.Name = "Methods";
            this.Methods.Size = new System.Drawing.Size(364, 24);
            this.Methods.TabIndex = 2;
            this.Methods.SelectedIndexChanged += new System.EventHandler(this.Methods_SelectedIndexChanged);
            // 
            // Stack_Operators
            // 
            this.Stack_Operators.Font = new System.Drawing.Font("Sakkal Majalla", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stack_Operators.FormattingEnabled = true;
            this.Stack_Operators.ItemHeight = 42;
            this.Stack_Operators.Location = new System.Drawing.Point(12, 12);
            this.Stack_Operators.Name = "Stack_Operators";
            this.Stack_Operators.Size = new System.Drawing.Size(209, 298);
            this.Stack_Operators.TabIndex = 3;
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.Location = new System.Drawing.Point(52, 334);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(61, 17);
            this.lblEquation.TabIndex = 4;
            this.lblEquation.Text = "Nothing:";
            // 
            // Stack_Operands
            // 
            this.Stack_Operands.Font = new System.Drawing.Font("Sakkal Majalla", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stack_Operands.FormattingEnabled = true;
            this.Stack_Operands.ItemHeight = 42;
            this.Stack_Operands.Location = new System.Drawing.Point(260, 12);
            this.Stack_Operands.Name = "Stack_Operands";
            this.Stack_Operands.Size = new System.Drawing.Size(209, 298);
            this.Stack_Operands.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Which one?";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(52, 359);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(61, 17);
            this.lblAnswer.TabIndex = 8;
            this.lblAnswer.Text = "Nothing:";
            // 
            // Answer_TextBox
            // 
            this.Answer_TextBox.Location = new System.Drawing.Point(116, 359);
            this.Answer_TextBox.Name = "Answer_TextBox";
            this.Answer_TextBox.ReadOnly = true;
            this.Answer_TextBox.Size = new System.Drawing.Size(349, 22);
            this.Answer_TextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 494);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.Answer_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stack_Operands);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.Stack_Operators);
            this.Controls.Add(this.Methods);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Equation_TextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Structure (I-P-P Project)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Equation_TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Methods;
        private System.Windows.Forms.ListBox Stack_Operators;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.ListBox Stack_Operands;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox Answer_TextBox;
    }
}

