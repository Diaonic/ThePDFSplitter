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
            this.SuspendLayout();
            // 
            // btnSelectPDF
            // 
            this.btnSelectPDF.Location = new System.Drawing.Point(27, 40);
            this.btnSelectPDF.Name = "btnSelectPDF";
            this.btnSelectPDF.Size = new System.Drawing.Size(94, 29);
            this.btnSelectPDF.TabIndex = 0;
            this.btnSelectPDF.Text = "Select PDF";
            this.btnSelectPDF.UseVisualStyleBackColor = true;
            this.btnSelectPDF.Click += new System.EventHandler(this.btnSelectPDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 147);
            this.Controls.Add(this.btnSelectPDF);
            this.Name = "Form1";
            this.Text = "PDFSplitter";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSelectPDF;
    }
}