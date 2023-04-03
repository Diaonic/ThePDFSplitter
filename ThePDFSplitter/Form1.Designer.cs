namespace ThePDFSplitter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.txt_starting = new System.Windows.Forms.TextBox();
            this.txt_ending = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectPDF
            // 
            this.btnSelectPDF.Location = new System.Drawing.Point(12, 26);
            this.btnSelectPDF.Name = "btnSelectPDF";
            this.btnSelectPDF.Size = new System.Drawing.Size(94, 29);
            this.btnSelectPDF.TabIndex = 0;
            this.btnSelectPDF.Text = "Select PDF";
            this.btnSelectPDF.UseVisualStyleBackColor = true;
            this.btnSelectPDF.Click += new System.EventHandler(this.btnSelectPDF_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_status.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_status.Location = new System.Drawing.Point(100, 333);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(259, 34);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_starting
            // 
            this.txt_starting.Location = new System.Drawing.Point(12, 110);
            this.txt_starting.Name = "txt_starting";
            this.txt_starting.PlaceholderText = "Starting text...";
            this.txt_starting.Size = new System.Drawing.Size(206, 27);
            this.txt_starting.TabIndex = 2;
            // 
            // txt_ending
            // 
            this.txt_ending.Location = new System.Drawing.Point(255, 110);
            this.txt_ending.Name = "txt_ending";
            this.txt_ending.PlaceholderText = "...Ending Text";
            this.txt_ending.Size = new System.Drawing.Size(222, 27);
            this.txt_ending.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extract the text between these two fields.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teacher: agreement between";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teacher: hereinafter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Support: agreement made between";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Support: hereinafter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 376);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ending);
            this.Controls.Add(this.txt_starting);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectPDF);
            this.Name = "Form1";
            this.Text = "PDFSplitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSelectPDF;
        private Label label1;
        private Label lbl_status;
        private TextBox txt_starting;
        private TextBox txt_ending;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}