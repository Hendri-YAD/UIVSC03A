namespace UIVSC03A
{
    partial class Form3
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
            this.uI6_1 = new UIVSC03A.UI6_1();
            this.SuspendLayout();
            // 
            // uI6_21
            // 
            this.uI6_1.AutoSize = true;
            this.uI6_1.Location = new System.Drawing.Point(209, 129);
            this.uI6_1.Name = "uI6_21";
            this.uI6_1.Size = new System.Drawing.Size(190, 149);
            this.uI6_1.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 422);
            this.Controls.Add(this.uI6_1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI6_1 uI6_1;
    }
}