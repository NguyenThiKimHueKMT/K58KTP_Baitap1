namespace ThoWindowsForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnMakePoem;
        private System.Windows.Forms.TextBox txtOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnMakePoem = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(20, 20);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(400, 80);
            this.txtInput.TabIndex = 0;
            // 
            // btnMakePoem
            // 
            this.btnMakePoem.Location = new System.Drawing.Point(20, 110);
            this.btnMakePoem.Name = "btnMakePoem";
            this.btnMakePoem.Size = new System.Drawing.Size(100, 30);
            this.btnMakePoem.TabIndex = 1;
            this.btnMakePoem.Text = "Làm Thơ";
            this.btnMakePoem.UseVisualStyleBackColor = true;
            this.btnMakePoem.Click += new System.EventHandler(this.btnMakePoem_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(20, 160);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(400, 150);
            this.txtOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 330);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnMakePoem);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Thơ Văn Bản - WinForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
