namespace Præsentationslag
{
   partial class gennemse_data
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
            this.datasætListBox = new System.Windows.Forms.ListBox();
            this.CPRTextBox = new System.Windows.Forms.TextBox();
            this.fornavnTextBox = new System.Windows.Forms.TextBox();
            this.efternavnTextBox = new System.Windows.Forms.TextBox();
            this.indlæsCPRKnap = new System.Windows.Forms.Button();
            this.analyserDataKnap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CPRnummer
            // 
            this.CPRnummer.AutoSize = true;
            this.CPRnummer.Location = new System.Drawing.Point(60, 40);
            this.CPRnummer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CPRnummer.Name = "CPRnummer";
            this.CPRnummer.Size = new System.Drawing.Size(145, 25);
            this.CPRnummer.TabIndex = 0;
            this.CPRnummer.Text = "CPR nummer:";
            // 
            // fornavn
            // 
            this.fornavn.AutoSize = true;
            this.fornavn.Location = new System.Drawing.Point(60, 225);
            this.fornavn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fornavn.Name = "fornavn";
            this.fornavn.Size = new System.Drawing.Size(91, 25);
            this.fornavn.TabIndex = 1;
            this.fornavn.Text = "Fornavn";
            // 
            // efternavn
            // 
            this.efternavn.AutoSize = true;
            this.efternavn.Location = new System.Drawing.Point(328, 225);
            this.efternavn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.efternavn.Name = "efternavn";
            this.efternavn.Size = new System.Drawing.Size(104, 25);
            this.efternavn.TabIndex = 2;
            this.efternavn.Text = "Efternavn";
            // 
            // datasætListBox
            // 
            this.datasætListBox.FormattingEnabled = true;
            this.datasætListBox.ItemHeight = 25;
            this.datasætListBox.Location = new System.Drawing.Point(66, 329);
            this.datasætListBox.Margin = new System.Windows.Forms.Padding(6);
            this.datasætListBox.Name = "datasætListBox";
            this.datasætListBox.Size = new System.Drawing.Size(364, 179);
            this.datasætListBox.TabIndex = 3;
            this.datasætListBox.SelectedIndexChanged += new System.EventHandler(this.datasætListBox_SelectedIndexChanged);
            // 
            // CPRTextBox
            // 
            this.CPRTextBox.Location = new System.Drawing.Point(66, 71);
            this.CPRTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CPRTextBox.MaxLength = 10;
            this.CPRTextBox.Name = "CPRTextBox";
            this.CPRTextBox.ShortcutsEnabled = false;
            this.CPRTextBox.Size = new System.Drawing.Size(196, 31);
            this.CPRTextBox.TabIndex = 4;
            this.CPRTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CPRTextBox_KeyPress);
            // 
            // fornavnTextBox
            // 
            this.fornavnTextBox.Enabled = false;
            this.fornavnTextBox.Location = new System.Drawing.Point(66, 258);
            this.fornavnTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.fornavnTextBox.Name = "fornavnTextBox";
            this.fornavnTextBox.Size = new System.Drawing.Size(196, 31);
            this.fornavnTextBox.TabIndex = 5;
            // 
            // efternavnTextBox
            // 
            this.efternavnTextBox.Enabled = false;
            this.efternavnTextBox.Location = new System.Drawing.Point(334, 258);
            this.efternavnTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.efternavnTextBox.Name = "efternavnTextBox";
            this.efternavnTextBox.Size = new System.Drawing.Size(196, 31);
            this.efternavnTextBox.TabIndex = 6;
            // 
            // indlæsCPRKnap
            // 
            this.indlæsCPRKnap.Location = new System.Drawing.Point(66, 121);
            this.indlæsCPRKnap.Margin = new System.Windows.Forms.Padding(6);
            this.indlæsCPRKnap.Name = "indlæsCPRKnap";
            this.indlæsCPRKnap.Size = new System.Drawing.Size(150, 44);
            this.indlæsCPRKnap.TabIndex = 7;
            this.indlæsCPRKnap.Text = "Indlæs";
            this.indlæsCPRKnap.UseVisualStyleBackColor = true;
            this.indlæsCPRKnap.Click += new System.EventHandler(this.indlæsCPRKnap_Click);
            // 
            // analyserDataKnap
            // 
            this.analyserDataKnap.Enabled = false;
            this.analyserDataKnap.Location = new System.Drawing.Point(490, 463);
            this.analyserDataKnap.Margin = new System.Windows.Forms.Padding(6);
            this.analyserDataKnap.Name = "analyserDataKnap";
            this.analyserDataKnap.Size = new System.Drawing.Size(174, 44);
            this.analyserDataKnap.TabIndex = 8;
            this.analyserDataKnap.Text = "Analyser data";
            this.analyserDataKnap.UseVisualStyleBackColor = true;
            this.analyserDataKnap.Click += new System.EventHandler(this.analyserDataKnap_Click);
            // 
            // gennemse_data
            // 
            this.AcceptButton = this.indlæsCPRKnap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 535);
            this.Controls.Add(this.analyserDataKnap);
            this.Controls.Add(this.indlæsCPRKnap);
            this.Controls.Add(this.efternavnTextBox);
            this.Controls.Add(this.fornavnTextBox);
            this.Controls.Add(this.CPRTextBox);
            this.Controls.Add(this.datasætListBox);
            this.Controls.Add(this.efternavn);
            this.Controls.Add(this.fornavn);
            this.Controls.Add(this.CPRnummer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "gennemse_data";
            this.Text = "Gennemse data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gennemse_data_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label CPRnummer;
      private System.Windows.Forms.Label fornavn;
      private System.Windows.Forms.Label efternavn;
      private System.Windows.Forms.ListBox datasætListBox;
      private System.Windows.Forms.TextBox CPRTextBox;
      private System.Windows.Forms.TextBox fornavnTextBox;
      private System.Windows.Forms.TextBox efternavnTextBox;
      private System.Windows.Forms.Button indlæsCPRKnap;
      private System.Windows.Forms.Button analyserDataKnap;
   }
}