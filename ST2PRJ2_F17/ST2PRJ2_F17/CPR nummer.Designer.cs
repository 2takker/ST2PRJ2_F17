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
            this.CPRnummer.Location = new System.Drawing.Point(66, 50);
            this.CPRnummer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CPRnummer.Name = "CPRnummer";
            this.CPRnummer.Size = new System.Drawing.Size(139, 25);
            this.CPRnummer.TabIndex = 1;
            this.CPRnummer.Text = "CPR nummer";
            // 
            // CPRTextBox
            // 
            this.CPRTextBox.Location = new System.Drawing.Point(72, 83);
            this.CPRTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CPRTextBox.MaxLength = 10;
            this.CPRTextBox.Name = "CPRTextBox";
            this.CPRTextBox.ShortcutsEnabled = false;
            this.CPRTextBox.Size = new System.Drawing.Size(196, 31);
            this.CPRTextBox.TabIndex = 2;
            this.CPRTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CPRTextBox_KeyDown);
            this.CPRTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CPRTextBox_KeyPress);
            // 
            // gemKnap
            // 
            this.gemKnap.Location = new System.Drawing.Point(72, 187);
            this.gemKnap.Margin = new System.Windows.Forms.Padding(6);
            this.gemKnap.Name = "gemKnap";
            this.gemKnap.Size = new System.Drawing.Size(150, 44);
            this.gemKnap.TabIndex = 3;
            this.gemKnap.Text = "Gem";
            this.gemKnap.UseVisualStyleBackColor = true;
            this.gemKnap.Click += new System.EventHandler(this.gemKnap_Click);
            // 
            // fortrydKnap
            // 
            this.fortrydKnap.Location = new System.Drawing.Point(272, 187);
            this.fortrydKnap.Margin = new System.Windows.Forms.Padding(6);
            this.fortrydKnap.Name = "fortrydKnap";
            this.fortrydKnap.Size = new System.Drawing.Size(150, 44);
            this.fortrydKnap.TabIndex = 4;
            this.fortrydKnap.Text = "Fortryd";
            this.fortrydKnap.UseVisualStyleBackColor = true;
            this.fortrydKnap.Click += new System.EventHandler(this.fortrydKnap_Click);
            // 
            // CPR_nummer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 257);
            this.Controls.Add(this.fortrydKnap);
            this.Controls.Add(this.gemKnap);
            this.Controls.Add(this.CPRTextBox);
            this.Controls.Add(this.CPRnummer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CPR_nummer";
            this.Text = "CPR nummer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CPR_nummer_FormClosing);
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