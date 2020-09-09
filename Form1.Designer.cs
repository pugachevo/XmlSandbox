namespace XmlSandbox
{
    partial class frmXMLconv
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbIn = new System.Windows.Forms.GroupBox();
            this.txtInPath = new System.Windows.Forms.TextBox();
            this.btnbrowseIn = new System.Windows.Forms.Button();
            this.gbIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "XML File Conversion";
            // 
            // gbIn
            // 
            this.gbIn.Controls.Add(this.btnbrowseIn);
            this.gbIn.Controls.Add(this.txtInPath);
            this.gbIn.Location = new System.Drawing.Point(13, 49);
            this.gbIn.Name = "gbIn";
            this.gbIn.Size = new System.Drawing.Size(930, 235);
            this.gbIn.TabIndex = 1;
            this.gbIn.TabStop = false;
            this.gbIn.Text = "XML In";
            // 
            // txtInPath
            // 
            this.txtInPath.Location = new System.Drawing.Point(3, 23);
            this.txtInPath.Name = "txtInPath";
            this.txtInPath.Size = new System.Drawing.Size(771, 27);
            this.txtInPath.TabIndex = 0;
            // 
            // btnbrowseIn
            // 
            this.btnbrowseIn.Location = new System.Drawing.Point(780, 23);
            this.btnbrowseIn.Name = "btnbrowseIn";
            this.btnbrowseIn.Size = new System.Drawing.Size(144, 27);
            this.btnbrowseIn.TabIndex = 1;
            this.btnbrowseIn.Text = "Input File";
            this.btnbrowseIn.UseVisualStyleBackColor = true;
            // 
            // frmXMLconv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 773);
            this.Controls.Add(this.gbIn);
            this.Controls.Add(this.label1);
            this.Name = "frmXMLconv";
            this.Text = "XML Converter";
            this.gbIn.ResumeLayout(false);
            this.gbIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbIn;
        private System.Windows.Forms.Button btnbrowseIn;
        private System.Windows.Forms.TextBox txtInPath;
    }
}

