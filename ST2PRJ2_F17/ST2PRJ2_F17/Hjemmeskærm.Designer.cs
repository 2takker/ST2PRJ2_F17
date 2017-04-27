namespace ST2PRJ2_F17
{
    partial class Hjemmeskærm
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
         this.previewKnap = new System.Windows.Forms.Button();
         this.opretNyPatientKnap = new System.Windows.Forms.Button();
         this.GennemseDataKnap = new System.Windows.Forms.Button();
         this.downloadKnap = new System.Windows.Forms.Button();
         this.UploadKnap = new System.Windows.Forms.Button();
         this.LogUdKnap = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.SundhedspersonaleTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // previewKnap
         // 
         this.previewKnap.Location = new System.Drawing.Point(172, 118);
         this.previewKnap.Name = "previewKnap";
         this.previewKnap.Size = new System.Drawing.Size(122, 35);
         this.previewKnap.TabIndex = 0;
         this.previewKnap.Text = "Preview";
         this.previewKnap.UseVisualStyleBackColor = true;
         // 
         // opretNyPatientKnap
         // 
         this.opretNyPatientKnap.Location = new System.Drawing.Point(27, 118);
         this.opretNyPatientKnap.Name = "opretNyPatientKnap";
         this.opretNyPatientKnap.Size = new System.Drawing.Size(122, 35);
         this.opretNyPatientKnap.TabIndex = 1;
         this.opretNyPatientKnap.Text = "Opret ny patient";
         this.opretNyPatientKnap.UseVisualStyleBackColor = true;
         // 
         // GennemseDataKnap
         // 
         this.GennemseDataKnap.Location = new System.Drawing.Point(315, 118);
         this.GennemseDataKnap.Name = "GennemseDataKnap";
         this.GennemseDataKnap.Size = new System.Drawing.Size(122, 35);
         this.GennemseDataKnap.TabIndex = 2;
         this.GennemseDataKnap.Text = "Gennemse data";
         this.GennemseDataKnap.UseVisualStyleBackColor = true;
         // 
         // downloadKnap
         // 
         this.downloadKnap.Location = new System.Drawing.Point(248, 186);
         this.downloadKnap.Name = "downloadKnap";
         this.downloadKnap.Size = new System.Drawing.Size(122, 35);
         this.downloadKnap.TabIndex = 3;
         this.downloadKnap.Text = "Download";
         this.downloadKnap.UseVisualStyleBackColor = true;
         // 
         // UploadKnap
         // 
         this.UploadKnap.Location = new System.Drawing.Point(101, 186);
         this.UploadKnap.Name = "UploadKnap";
         this.UploadKnap.Size = new System.Drawing.Size(122, 35);
         this.UploadKnap.TabIndex = 4;
         this.UploadKnap.Text = "Upload";
         this.UploadKnap.UseVisualStyleBackColor = true;
         // 
         // LogUdKnap
         // 
         this.LogUdKnap.Location = new System.Drawing.Point(387, 54);
         this.LogUdKnap.Name = "LogUdKnap";
         this.LogUdKnap.Size = new System.Drawing.Size(100, 23);
         this.LogUdKnap.TabIndex = 5;
         this.LogUdKnap.Text = "Log ud";
         this.LogUdKnap.UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(384, 12);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(79, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "Logget ind som";
         // 
         // SundhedspersonaleTextBox
         // 
         this.SundhedspersonaleTextBox.Enabled = false;
         this.SundhedspersonaleTextBox.Location = new System.Drawing.Point(387, 28);
         this.SundhedspersonaleTextBox.Name = "SundhedspersonaleTextBox";
         this.SundhedspersonaleTextBox.Size = new System.Drawing.Size(100, 20);
         this.SundhedspersonaleTextBox.TabIndex = 7;
         // 
         // Hjemmeskærm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(505, 335);
         this.Controls.Add(this.SundhedspersonaleTextBox);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.LogUdKnap);
         this.Controls.Add(this.UploadKnap);
         this.Controls.Add(this.downloadKnap);
         this.Controls.Add(this.GennemseDataKnap);
         this.Controls.Add(this.opretNyPatientKnap);
         this.Controls.Add(this.previewKnap);
         this.Margin = new System.Windows.Forms.Padding(2);
         this.Name = "Hjemmeskærm";
         this.Text = "Hjemmeskærm";
         this.ResumeLayout(false);
         this.PerformLayout();

        }

      #endregion

      private System.Windows.Forms.Button previewKnap;
      private System.Windows.Forms.Button opretNyPatientKnap;
      private System.Windows.Forms.Button GennemseDataKnap;
      private System.Windows.Forms.Button downloadKnap;
      private System.Windows.Forms.Button UploadKnap;
      private System.Windows.Forms.Button LogUdKnap;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox SundhedspersonaleTextBox;
   }
}

