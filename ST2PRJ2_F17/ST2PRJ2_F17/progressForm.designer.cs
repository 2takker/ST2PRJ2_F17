namespace Progress
{
    partial class progressForm
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
            this.prgrsBar = new System.Windows.Forms.ProgressBar();
            this.lblProces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prgrsBar
            // 
            this.prgrsBar.Location = new System.Drawing.Point(12, 16);
            this.prgrsBar.Name = "prgrsBar";
            this.prgrsBar.Size = new System.Drawing.Size(264, 23);
            this.prgrsBar.TabIndex = 0;
            this.prgrsBar.UseWaitCursor = true;
            // 
            // lblProces
            // 
            this.lblProces.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblProces.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProces.Location = new System.Drawing.Point(0, 0);
            this.lblProces.Name = "lblProces";
            this.lblProces.Size = new System.Drawing.Size(288, 13);
            this.lblProces.TabIndex = 1;
            this.lblProces.Text = "textAboveBar";
            this.lblProces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProces.UseWaitCursor = true;
            // 
            // progressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 51);
            this.ControlBox = false;
            this.Controls.Add(this.lblProces);
            this.Controls.Add(this.prgrsBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "progressForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgrsBar;
        private System.Windows.Forms.Label lblProces;
    }
}