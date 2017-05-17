namespace Præsentationslag
{
   partial class opret_ny_patient
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
            this.fornavn = new System.Windows.Forms.Label();
            this.efternavn = new System.Windows.Forms.Label();
            this.CPRTextBox = new System.Windows.Forms.TextBox();
            this.fornavnTextBox = new System.Windows.Forms.TextBox();
            this.efternavnTextBox = new System.Windows.Forms.TextBox();
            this.gemKnap = new System.Windows.Forms.Button();
            this.fortrydKnap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CPRnummer
            // 
            this.CPRnummer.AutoSize = true;
            this.CPRnummer.Location = new System.Drawing.Point(89, 29);
            this.CPRnummer.Name = "CPRnummer";
            this.CPRnummer.Size = new System.Drawing.Size(72, 13);
            this.CPRnummer.TabIndex = 0;
            this.CPRnummer.Text = "CPR- nummer";
            // 
            // fornavn
            // 
            this.fornavn.AutoSize = true;
            this.fornavn.Location = new System.Drawing.Point(89, 86);
            this.fornavn.Name = "fornavn";
            this.fornavn.Size = new System.Drawing.Size(49, 13);
            this.fornavn.TabIndex = 1;
            this.fornavn.Text = "Fornavn:";
            // 
            // efternavn
            // 
            this.efternavn.AutoSize = true;
            this.efternavn.Location = new System.Drawing.Point(89, 147);
            this.efternavn.Name = "efternavn";
            this.efternavn.Size = new System.Drawing.Size(56, 13);
            this.efternavn.TabIndex = 2;
            this.efternavn.Text = "Efternavn:";
            // 
            // CPRTextBox
            // 
            this.CPRTextBox.Location = new System.Drawing.Point(92, 45);
            this.CPRTextBox.Name = "CPRTextBox";
            this.CPRTextBox.Size = new System.Drawing.Size(100, 20);
            this.CPRTextBox.TabIndex = 3;
            // 
            // fornavnTextBox
            // 
            this.fornavnTextBox.Location = new System.Drawing.Point(92, 102);
            this.fornavnTextBox.Name = "fornavnTextBox";
            this.fornavnTextBox.Size = new System.Drawing.Size(100, 20);
            this.fornavnTextBox.TabIndex = 4;
            // 
            // efternavnTextBox
            // 
            this.efternavnTextBox.Location = new System.Drawing.Point(92, 163);
            this.efternavnTextBox.Name = "efternavnTextBox";
            this.efternavnTextBox.Size = new System.Drawing.Size(100, 20);
            this.efternavnTextBox.TabIndex = 5;
            // 
            // gemKnap
            // 
            this.gemKnap.Location = new System.Drawing.Point(45, 212);
            this.gemKnap.Name = "gemKnap";
            this.gemKnap.Size = new System.Drawing.Size(75, 23);
            this.gemKnap.TabIndex = 6;
            this.gemKnap.Text = "Gem";
            this.gemKnap.UseVisualStyleBackColor = true;
            this.gemKnap.Click += new System.EventHandler(this.gemKnap_Click);
            // 
            // fortrydKnap
            // 
            this.fortrydKnap.Location = new System.Drawing.Point(152, 212);
            this.fortrydKnap.Name = "fortrydKnap";
            this.fortrydKnap.Size = new System.Drawing.Size(75, 23);
            this.fortrydKnap.TabIndex = 7;
            this.fortrydKnap.Text = "Fortryd";
            this.fortrydKnap.UseVisualStyleBackColor = true;
            this.fortrydKnap.Click += new System.EventHandler(this.fortrydKnap_Click);
            // 
            // opret_ny_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fortrydKnap);
            this.Controls.Add(this.gemKnap);
            this.Controls.Add(this.efternavnTextBox);
            this.Controls.Add(this.fornavnTextBox);
            this.Controls.Add(this.CPRTextBox);
            this.Controls.Add(this.efternavn);
            this.Controls.Add(this.fornavn);
            this.Controls.Add(this.CPRnummer);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "opret_ny_patient";
            this.Text = "Opret ny patient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.opret_ny_patient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label CPRnummer;
      private System.Windows.Forms.Label fornavn;
      private System.Windows.Forms.Label efternavn;
      private System.Windows.Forms.TextBox CPRTextBox;
      private System.Windows.Forms.TextBox fornavnTextBox;
      private System.Windows.Forms.TextBox efternavnTextBox;
      private System.Windows.Forms.Button gemKnap;
      private System.Windows.Forms.Button fortrydKnap;
   }
}