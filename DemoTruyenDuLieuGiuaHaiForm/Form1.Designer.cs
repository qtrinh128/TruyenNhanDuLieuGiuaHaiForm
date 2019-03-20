namespace DemoTruyenDuLieuGiuaHaiForm
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
            this.txtF1 = new System.Windows.Forms.TextBox();
            this.bntF1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtF1
            // 
            this.txtF1.Location = new System.Drawing.Point(12, 12);
            this.txtF1.Name = "txtF1";
            this.txtF1.Size = new System.Drawing.Size(142, 20);
            this.txtF1.TabIndex = 0;
            // 
            // bntF1
            // 
            this.bntF1.Location = new System.Drawing.Point(86, 38);
            this.bntF1.Name = "bntF1";
            this.bntF1.Size = new System.Drawing.Size(68, 23);
            this.bntF1.TabIndex = 1;
            this.bntF1.Text = "Click";
            this.bntF1.UseVisualStyleBackColor = true;
            this.bntF1.Click += new System.EventHandler(this.bntF1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 84);
            this.Controls.Add(this.bntF1);
            this.Controls.Add(this.txtF1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtF1;
        private System.Windows.Forms.Button bntF1;
    }
}

