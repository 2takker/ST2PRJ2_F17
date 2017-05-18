namespace Præsentationslag
{
   partial class upload_til_offentlig_database
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
            this.IndlæsCPRKnap = new System.Windows.Forms.Button();
            this.CPRnummer = new System.Windows.Forms.Label();
            this.CPRTextBox = new System.Windows.Forms.TextBox();
            this.valgAfDatasætListBox = new System.Windows.Forms.ListBox();
            this.uploadKnap = new System.Windows.Forms.Button();
            this.UdenPatientDataCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // IndlæsCPRKnap
            // 
            this.IndlæsCPRKnap.Location = new System.Drawing.Point(264, 87);
            this.IndlæsCPRKnap.Margin = new System.Windows.Forms.Padding(6);
            this.IndlæsCPRKnap.Name = "IndlæsCPRKnap";
            this.IndlæsCPRKnap.Size = new System.Drawing.Size(154, 44);
            this.IndlæsCPRKnap.TabIndex = 5;
            this.IndlæsCPRKnap.Text = "Indlæs CPR";
            this.IndlæsCPRKnap.UseVisualStyleBackColor = true;
            this.IndlæsCPRKnap.Click += new System.EventHandler(this.IndlæsCPRKnap_Click);
            // 
            // CPRnummer
            // 
            this.CPRnummer.AutoSize = true;
            this.CPRnummer.Location = new System.Drawing.Point(52, 56);
            this.CPRnummer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CPRnummer.Name = "CPRnummer";
            this.CPRnummer.Size = new System.Drawing.Size(139, 25);
            this.CPRnummer.TabIndex = 4;
            this.CPRnummer.Text = "CPR nummer";
            // 
            // CPRTextBox
            // 
            this.CPRTextBox.Location = new System.Drawing.Point(52, 92);
            this.CPRTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CPRTextBox.Name = "CPRTextBox";
            this.CPRTextBox.Size = new System.Drawing.Size(196, 31);
            this.CPRTextBox.TabIndex = 3;
            this.CPRTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CPRTextBox_KeyDown);
            // 
            // valgAfDatasætListBox
            // 
            this.valgAfDatasætListBox.FormattingEnabled = true;
            this.valgAfDatasætListBox.ItemHeight = 25;
            this.valgAfDatasætListBox.Location = new System.Drawing.Point(52, 202);
            this.valgAfDatasætListBox.Margin = new System.Windows.Forms.Padding(6);
            this.valgAfDatasætListBox.Name = "valgAfDatasætListBox";
            this.valgAfDatasætListBox.Size = new System.Drawing.Size(362, 279);
            this.valgAfDatasætListBox.TabIndex = 6;
            // 
            // uploadKnap
            // 
            this.uploadKnap.Location = new System.Drawing.Point(430, 440);
            this.uploadKnap.Margin = new System.Windows.Forms.Padding(6);
            this.uploadKnap.Name = "uploadKnap";
            this.uploadKnap.Size = new System.Drawing.Size(150, 44);
            this.uploadKnap.TabIndex = 7;
            this.uploadKnap.Text = "Upload";
            this.uploadKnap.UseVisualStyleBackColor = true;
            this.uploadKnap.Click += new System.EventHandler(this.uploadKnap_Click);
            // 
            // UdenPatientDataCheckBox
            // 
            this.UdenPatientDataCheckBox.AutoSize = true;
            this.UdenPatientDataCheckBox.Location = new System.Drawing.Point(432, 396);
            this.UdenPatientDataCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.UdenPatientDataCheckBox.Name = "UdenPatientDataCheckBox";
            this.UdenPatientDataCheckBox.Size = new System.Drawing.Size(279, 29);
            this.UdenPatientDataCheckBox.TabIndex = 8;
            this.UdenPatientDataCheckBox.Text = "Upload uden patientdata";
            this.UdenPatientDataCheckBox.UseVisualStyleBackColor = true;
            this.UdenPatientDataCheckBox.CheckedChanged += new System.EventHandler(this.UdenPatientDataCheckBox_CheckedChanged);
            // 
            // upload_til_offentlig_database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 488);
            this.Controls.Add(this.UdenPatientDataCheckBox);
            this.Controls.Add(this.uploadKnap);
            this.Controls.Add(this.valgAfDatasætListBox);
            this.Controls.Add(this.IndlæsCPRKnap);
            this.Controls.Add(this.CPRnummer);
            this.Controls.Add(this.CPRTextBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(744, 559);
            this.MinimumSize = new System.Drawing.Size(744, 559);
            this.Name = "upload_til_offentlig_database";
            this.Text = "Upload til offentlig database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.upload_til_offentlig_database_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button IndlæsCPRKnap;
      private System.Windows.Forms.Label CPRnummer;
      private System.Windows.Forms.TextBox CPRTextBox;
      private System.Windows.Forms.ListBox valgAfDatasætListBox;
      private System.Windows.Forms.Button uploadKnap;
      private System.Windows.Forms.CheckBox UdenPatientDataCheckBox;
   }
}