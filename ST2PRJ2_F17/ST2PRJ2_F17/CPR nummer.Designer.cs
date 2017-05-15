namespace Præsentationslag
{
   partial class CPR_nummer
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
            this.CPRnummer = new System.Windows.Forms.Label();
            this.CPRTextBox = new System.Windows.Forms.TextBox();
            this.gemKnap = new System.Windows.Forms.Button();
            this.fortrydKnap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CPRnummer
            // 
            this.CPRnummer.AutoSize = true;
            this.CPRnummer.Location = new System.Drawing.Point(33, 26);
            this.CPRnummer.Name = "CPRnummer";
            this.CPRnummer.Size = new System.Drawing.Size(69, 13);
            this.CPRnummer.TabIndex = 1;
            this.CPRnummer.Text = "CPR nummer";
            // 
            // CPRTextBox
            // 
            this.CPRTextBox.Location = new System.Drawing.Point(36, 43);
            this.CPRTextBox.Name = "CPRTextBox";
            this.CPRTextBox.Size = new System.Drawing.Size(100, 20);
            this.CPRTextBox.TabIndex = 2;
            this.CPRTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CPRTextBox_KeyDown);
            // 
            // gemKnap
            // 
            this.gemKnap.Location = new System.Drawing.Point(36, 97);
            this.gemKnap.Name = "gemKnap";
            this.gemKnap.Size = new System.Drawing.Size(75, 23);
            this.gemKnap.TabIndex = 3;
            this.gemKnap.Text = "Gem";
            this.gemKnap.UseVisualStyleBackColor = true;
            this.gemKnap.Click += new System.EventHandler(this.gemKnap_Click);
            // 
            // fortrydKnap
            // 
            this.fortrydKnap.Location = new System.Drawing.Point(136, 97);
            this.fortrydKnap.Name = "fortrydKnap";
            this.fortrydKnap.Size = new System.Drawing.Size(75, 23);
            this.fortrydKnap.TabIndex = 4;
            this.fortrydKnap.Text = "Fortryd";
            this.fortrydKnap.UseVisualStyleBackColor = true;
            this.fortrydKnap.Click += new System.EventHandler(this.fortrydKnap_Click);
            // 
            // CPR_nummer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 141);
            this.Controls.Add(this.fortrydKnap);
            this.Controls.Add(this.gemKnap);
            this.Controls.Add(this.CPRTextBox);
            this.Controls.Add(this.CPRnummer);
            this.MaximumSize = new System.Drawing.Size(250, 180);
            this.MinimumSize = new System.Drawing.Size(250, 180);
            this.Name = "CPR_nummer";
            this.Text = "CPR nummer";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label CPRnummer;
      private System.Windows.Forms.TextBox CPRTextBox;
      private System.Windows.Forms.Button gemKnap;
      private System.Windows.Forms.Button fortrydKnap;
   }
}