namespace DemoTruyenDuLieuGiuaHaiForm
{
    partial class Form2
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
            this.txtF2 = new System.Windows.Forms.TextBox();
            this.btnF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtF2
            // 
            this.txtF2.Location = new System.Drawing.Point(12, 12);
            this.txtF2.Name = "txtF2";
            this.txtF2.Size = new System.Drawing.Size(217, 20);
            this.txtF2.TabIndex = 0;
            // 
            // btnF2
            // 
            this.btnF2.Location = new System.Drawing.Point(154, 38);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(75, 23);
            this.btnF2.TabIndex = 1;
            this.btnF2.Text = "Click";
            this.btnF2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 78);
            this.Controls.Add(this.btnF2);
            this.Controls.Add(this.txtF2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtF2;
        private System.Windows.Forms.Button btnF2;
    }
}