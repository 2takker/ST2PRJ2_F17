namespace Præsentationslag
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hjemmeskærm));
         this.previewKnap = new System.Windows.Forms.Button();
         this.opretNyPatientKnap = new System.Windows.Forms.Button();
         this.GennemseDataKnap = new System.Windows.Forms.Button();
         this.downloadKnap = new System.Windows.Forms.Button();
         this.UploadKnap = new System.Windows.Forms.Button();
         this.LogUdKnap = new System.Windows.Forms.Button();
         this.LoggetIndSomtextBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // previewKnap
         // 
         this.previewKnap.Location = new System.Drawing.Point(7, 7);
         this.previewKnap.Name = "previewKnap";
         this.previewKnap.Size = new System.Drawing.Size(100, 22);
         this.previewKnap.TabIndex = 0;
         this.previewKnap.Text = "Preview";
         this.previewKnap.UseVisualStyleBackColor = true;
         this.previewKnap.Click += new System.EventHandler(this.previewKnap_Click);
         // 
         // opretNyPatientKnap
         // 
         this.opretNyPatientKnap.Location = new System.Drawing.Point(143, 109);
         this.opretNyPatientKnap.Name = "opretNyPatientKnap";
         this.opretNyPatientKnap.Size = new System.Drawing.Size(100, 22);
         this.opretNyPatientKnap.TabIndex = 1;
         this.opretNyPatientKnap.Text = "Opret ny patient";
         this.opretNyPatientKnap.UseVisualStyleBackColor = true;
         this.opretNyPatientKnap.Click += new System.EventHandler(this.opretNyPatientKnap_Click);
         // 
         // GennemseDataKnap
         // 
         this.GennemseDataKnap.Location = new System.Drawing.Point(7, 35);
         this.GennemseDataKnap.Name = "GennemseDataKnap";
         this.GennemseDataKnap.Size = new System.Drawing.Size(100, 22);
         this.GennemseDataKnap.TabIndex = 2;
         this.GennemseDataKnap.Text = "Gennemse data";
         this.GennemseDataKnap.UseVisualStyleBackColor = true;
         this.GennemseDataKnap.Click += new System.EventHandler(this.GennemseDataKnap_Click);
         // 
         // downloadKnap
         // 
         this.downloadKnap.Location = new System.Drawing.Point(7, 81);
         this.downloadKnap.Name = "downloadKnap";
         this.downloadKnap.Size = new System.Drawing.Size(100, 22);
         this.downloadKnap.TabIndex = 3;
         this.downloadKnap.Text = "Download";
         this.downloadKnap.UseVisualStyleBackColor = true;
         this.downloadKnap.Click += new System.EventHandler(this.downloadKnap_Click);
         // 
         // UploadKnap
         // 
         this.UploadKnap.Location = new System.Drawing.Point(7, 109);
         this.UploadKnap.Name = "UploadKnap";
         this.UploadKnap.Size = new System.Drawing.Size(100, 22);
         this.UploadKnap.TabIndex = 4;
         this.UploadKnap.Text = "Upload";
         this.UploadKnap.UseVisualStyleBackColor = true;
         this.UploadKnap.Click += new System.EventHandler(this.UploadKnap_Click);
         // 
         // LogUdKnap
         // 
         this.LogUdKnap.Location = new System.Drawing.Point(143, 47);
         this.LogUdKnap.Name = "LogUdKnap";
         this.LogUdKnap.Size = new System.Drawing.Size(100, 22);
         this.LogUdKnap.TabIndex = 5;
         this.LogUdKnap.Text = "Log ud";
         this.LogUdKnap.UseVisualStyleBackColor = true;
         this.LogUdKnap.Click += new System.EventHandler(this.LogUdKnap_Click);
         // 
         // LoggetIndSomtextBox
         // 
         this.LoggetIndSomtextBox.Enabled = false;
         this.LoggetIndSomtextBox.Location = new System.Drawing.Point(143, 23);
         this.LoggetIndSomtextBox.Name = "LoggetIndSomtextBox";
         this.LoggetIndSomtextBox.Size = new System.Drawing.Size(100, 20);
         this.LoggetIndSomtextBox.TabIndex = 6;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(141, 7);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(82, 13);
         this.label1.TabIndex = 7;
         this.label1.Text = "Logget ind som:";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(84, 137);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(186, 99);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 8;
         this.pictureBox1.TabStop = false;
         // 
         // Hjemmeskærm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         this.AutoSize = true;
         this.ClientSize = new System.Drawing.Size(255, 243);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.LoggetIndSomtextBox);
         this.Controls.Add(this.LogUdKnap);
         this.Controls.Add(this.UploadKnap);
         this.Controls.Add(this.downloadKnap);
         this.Controls.Add(this.GennemseDataKnap);
         this.Controls.Add(this.opretNyPatientKnap);
         this.Controls.Add(this.previewKnap);
         this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.Name = "Hjemmeskærm";
         this.Text = "Hjemmeskærm";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
      private System.Windows.Forms.TextBox LoggetIndSomtextBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.PictureBox pictureBox1;
   }
}

