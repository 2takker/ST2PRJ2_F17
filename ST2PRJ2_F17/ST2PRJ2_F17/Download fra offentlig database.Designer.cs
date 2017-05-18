namespace Præsentationslag
{
   partial class Download_fra_offentlig_database
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
            this.SøgeTextBox = new System.Windows.Forms.TextBox();
            this.søgeord = new System.Windows.Forms.Label();
            this.søgKnap = new System.Windows.Forms.Button();
            this.SøgeresultaterListBox = new System.Windows.Forms.ListBox();
            this.downloadKnap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SøgeTextBox
            // 
            this.SøgeTextBox.Location = new System.Drawing.Point(42, 54);
            this.SøgeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.SøgeTextBox.Name = "SøgeTextBox";
            this.SøgeTextBox.Size = new System.Drawing.Size(196, 31);
            this.SøgeTextBox.TabIndex = 0;
            this.SøgeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SøgeTextBox_KeyDown);
            // 
            // søgeord
            // 
            this.søgeord.AutoSize = true;
            this.søgeord.Location = new System.Drawing.Point(42, 17);
            this.søgeord.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.søgeord.Name = "søgeord";
            this.søgeord.Size = new System.Drawing.Size(93, 25);
            this.søgeord.TabIndex = 1;
            this.søgeord.Text = "Søgeord";
            // 
            // søgKnap
            // 
            this.søgKnap.Location = new System.Drawing.Point(254, 50);
            this.søgKnap.Margin = new System.Windows.Forms.Padding(6);
            this.søgKnap.Name = "søgKnap";
            this.søgKnap.Size = new System.Drawing.Size(98, 44);
            this.søgKnap.TabIndex = 2;
            this.søgKnap.Text = "Søg";
            this.søgKnap.UseVisualStyleBackColor = true;
            this.søgKnap.Click += new System.EventHandler(this.søgKnap_Click);
            // 
            // SøgeresultaterListBox
            // 
            this.SøgeresultaterListBox.FormattingEnabled = true;
            this.SøgeresultaterListBox.ItemHeight = 25;
            this.SøgeresultaterListBox.Location = new System.Drawing.Point(48, 146);
            this.SøgeresultaterListBox.Margin = new System.Windows.Forms.Padding(6);
            this.SøgeresultaterListBox.Name = "SøgeresultaterListBox";
            this.SøgeresultaterListBox.Size = new System.Drawing.Size(810, 879);
            this.SøgeresultaterListBox.TabIndex = 3;
            this.SøgeresultaterListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SøgeresultaterListBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(SøgeresultaterListBox_MeasureItem);
            this.SøgeresultaterListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(SøgeresultaterListBox_DrawItem);    
            // 
            // downloadKnap
            // 
            this.downloadKnap.Location = new System.Drawing.Point(874, 985);
            this.downloadKnap.Margin = new System.Windows.Forms.Padding(6);
            this.downloadKnap.Name = "downloadKnap";
            this.downloadKnap.Size = new System.Drawing.Size(150, 44);
            this.downloadKnap.TabIndex = 4;
            this.downloadKnap.Text = "Download";
            this.downloadKnap.UseVisualStyleBackColor = true;
            this.downloadKnap.Click += new System.EventHandler(this.downloadKnap_Click);
            // 
            // Download_fra_offentlig_database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 1079);
            this.Controls.Add(this.downloadKnap);
            this.Controls.Add(this.SøgeresultaterListBox);
            this.Controls.Add(this.søgKnap);
            this.Controls.Add(this.søgeord);
            this.Controls.Add(this.SøgeTextBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Download_fra_offentlig_database";
            this.Text = "Download fra offentlig database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Download_fra_offentlig_database_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox SøgeTextBox;
      private System.Windows.Forms.Label søgeord;
      private System.Windows.Forms.Button søgKnap;
      private System.Windows.Forms.ListBox SøgeresultaterListBox;
      private System.Windows.Forms.Button downloadKnap;
   }
}