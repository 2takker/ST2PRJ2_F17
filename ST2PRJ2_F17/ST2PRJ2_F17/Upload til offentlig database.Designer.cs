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
            this.efternavnTextBox = new System.Windows.Forms.TextBox();
            this.fornavnTextBox = new System.Windows.Forms.TextBox();
            this.efternavn = new System.Windows.Forms.Label();
            this.fornavn = new System.Windows.Forms.Label();
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
            this.CPRTextBox.MaxLength = 10;
            this.CPRTextBox.Name = "CPRTextBox";
            this.CPRTextBox.ShortcutsEnabled = false;
            this.CPRTextBox.Size = new System.Drawing.Size(196, 31);
            this.CPRTextBox.TabIndex = 3;
            this.CPRTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CPRTextBox_KeyDown);
            this.CPRTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CPRTextBox_KeyPress);
            // 
            // valgAfDatasætListBox
            // 
            this.valgAfDatasætListBox.FormattingEnabled = true;
            this.valgAfDatasætListBox.ItemHeight = 25;
            this.valgAfDatasætListBox.Location = new System.Drawing.Point(52, 308);
            this.valgAfDatasætListBox.Margin = new System.Windows.Forms.Padding(6);
            this.valgAfDatasætListBox.Name = "valgAfDatasætListBox";
            this.valgAfDatasætListBox.Size = new System.Drawing.Size(362, 279);
            this.valgAfDatasætListBox.TabIndex = 6;
            this.valgAfDatasætListBox.SelectedIndexChanged += new System.EventHandler(this.valgAfDatasætListBox_SelectedIndexChanged);
            // 
            // uploadKnap
            // 
            this.uploadKnap.Enabled = false;
            this.uploadKnap.Location = new System.Drawing.Point(430, 546);
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
            this.UdenPatientDataCheckBox.Location = new System.Drawing.Point(432, 502);
            this.UdenPatientDataCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.UdenPatientDataCheckBox.Name = "UdenPatientDataCheckBox";
            this.UdenPatientDataCheckBox.Size = new System.Drawing.Size(279, 29);
            this.UdenPatientDataCheckBox.TabIndex = 8;
            this.UdenPatientDataCheckBox.Text = "Upload uden patientdata";
            this.UdenPatientDataCheckBox.UseVisualStyleBackColor = true;
            this.UdenPatientDataCheckBox.CheckedChanged += new System.EventHandler(this.UdenPatientDataCheckBox_CheckedChanged);
            // 
            // efternavnTextBox
            // 
            this.efternavnTextBox.Enabled = false;
            this.efternavnTextBox.Location = new System.Drawing.Point(320, 220);
            this.efternavnTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.efternavnTextBox.Name = "efternavnTextBox";
            this.efternavnTextBox.Size = new System.Drawing.Size(196, 31);
            this.efternavnTextBox.TabIndex = 12;
            // 
            // fornavnTextBox
            // 
            this.fornavnTextBox.Enabled = false;
            this.fornavnTextBox.Location = new System.Drawing.Point(52, 220);
            this.fornavnTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.fornavnTextBox.Name = "fornavnTextBox";
            this.fornavnTextBox.Size = new System.Drawing.Size(196, 31);
            this.fornavnTextBox.TabIndex = 11;
            // 
            // efternavn
            // 
            this.efternavn.AutoSize = true;
            this.efternavn.Location = new System.Drawing.Point(315, 187);
            this.efternavn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.efternavn.Name = "efternavn";
            this.efternavn.Size = new System.Drawing.Size(104, 25);
            this.efternavn.TabIndex = 10;
            this.efternavn.Text = "Efternavn";
            // 
            // fornavn
            // 
            this.fornavn.AutoSize = true;
            this.fornavn.Location = new System.Drawing.Point(52, 187);
            this.fornavn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fornavn.Name = "fornavn";
            this.fornavn.Size = new System.Drawing.Size(91, 25);
            this.fornavn.TabIndex = 9;
            this.fornavn.Text = "Fornavn";
            // 
            // upload_til_offentlig_database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 644);
            this.Controls.Add(this.efternavnTextBox);
            this.Controls.Add(this.fornavnTextBox);
            this.Controls.Add(this.efternavn);
            this.Controls.Add(this.fornavn);
            this.Controls.Add(this.UdenPatientDataCheckBox);
            this.Controls.Add(this.uploadKnap);
            this.Controls.Add(this.valgAfDatasætListBox);
            this.Controls.Add(this.IndlæsCPRKnap);
            this.Controls.Add(this.CPRnummer);
            this.Controls.Add(this.CPRTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.TextBox efternavnTextBox;
        private System.Windows.Forms.TextBox fornavnTextBox;
        private System.Windows.Forms.Label efternavn;
        private System.Windows.Forms.Label fornavn;
    }
}