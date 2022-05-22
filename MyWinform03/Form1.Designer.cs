
namespace MyWinform03
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
            this.BTN_COPY = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PERCENT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_COPY
            // 
            this.BTN_COPY.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_COPY.Location = new System.Drawing.Point(253, 102);
            this.BTN_COPY.Name = "BTN_COPY";
            this.BTN_COPY.Size = new System.Drawing.Size(268, 94);
            this.BTN_COPY.TabIndex = 0;
            this.BTN_COPY.Text = "파일복사";
            this.BTN_COPY.UseVisualStyleBackColor = true;
            this.BTN_COPY.Click += new System.EventHandler(this.BTN_COPY_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(41, 279);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(718, 29);
            this.progressBar1.TabIndex = 1;
            // 
            // PERCENT
            // 
            this.PERCENT.AutoSize = true;
            this.PERCENT.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PERCENT.Location = new System.Drawing.Point(383, 365);
            this.PERCENT.Name = "PERCENT";
            this.PERCENT.Size = new System.Drawing.Size(19, 23);
            this.PERCENT.TabIndex = 2;
            this.PERCENT.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PERCENT);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BTN_COPY);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_COPY;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label PERCENT;
    }
}

