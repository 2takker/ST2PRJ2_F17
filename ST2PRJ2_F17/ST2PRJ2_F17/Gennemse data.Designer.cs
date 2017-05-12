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
         this.CPRnummer.Location = new System.Drawing.Point(30, 21);
         this.CPRnummer.Name = "CPRnummer";
         this.CPRnummer.Size = new System.Drawing.Size(72, 13);
         this.CPRnummer.TabIndex = 0;
         this.CPRnummer.Text = "CPR nummer:";
         // 
         // fornavn
         // 
         this.fornavn.AutoSize = true;
         this.fornavn.Location = new System.Drawing.Point(30, 117);
         this.fornavn.Name = "fornavn";
         this.fornavn.Size = new System.Drawing.Size(46, 13);
         this.fornavn.TabIndex = 1;
         this.fornavn.Text = "Fornavn";
         // 
         // efternavn
         // 
         this.efternavn.AutoSize = true;
         this.efternavn.Location = new System.Drawing.Point(164, 117);
         this.efternavn.Name = "efternavn";
         this.efternavn.Size = new System.Drawing.Size(53, 13);
         this.efternavn.TabIndex = 2;
         this.efternavn.Text = "Efternavn";
         // 
         // datasætListBox
         // 
         this.datasætListBox.FormattingEnabled = true;
         this.datasætListBox.Location = new System.Drawing.Point(33, 171);
         this.datasætListBox.Name = "datasætListBox";
         this.datasætListBox.Size = new System.Drawing.Size(184, 95);
         this.datasætListBox.TabIndex = 3;
         this.datasætListBox.SelectedIndexChanged += new System.EventHandler(this.datasætListBox_SelectedIndexChanged);
         // 
         // CPRTextBox
         // 
         this.CPRTextBox.Location = new System.Drawing.Point(33, 37);
         this.CPRTextBox.MaxLength = 10;
         this.CPRTextBox.Name = "CPRTextBox";
         this.CPRTextBox.Size = new System.Drawing.Size(100, 20);
         this.CPRTextBox.TabIndex = 4;
         // 
         // fornavnTextBox
         // 
         this.fornavnTextBox.Enabled = false;
         this.fornavnTextBox.Location = new System.Drawing.Point(33, 134);
         this.fornavnTextBox.Name = "fornavnTextBox";
         this.fornavnTextBox.Size = new System.Drawing.Size(100, 20);
         this.fornavnTextBox.TabIndex = 5;
         // 
         // efternavnTextBox
         // 
         this.efternavnTextBox.Enabled = false;
         this.efternavnTextBox.Location = new System.Drawing.Point(167, 134);
         this.efternavnTextBox.Name = "efternavnTextBox";
         this.efternavnTextBox.Size = new System.Drawing.Size(100, 20);
         this.efternavnTextBox.TabIndex = 6;
         // 
         // indlæsCPRKnap
         // 
         this.indlæsCPRKnap.Location = new System.Drawing.Point(33, 63);
         this.indlæsCPRKnap.Name = "indlæsCPRKnap";
         this.indlæsCPRKnap.Size = new System.Drawing.Size(75, 23);
         this.indlæsCPRKnap.TabIndex = 7;
         this.indlæsCPRKnap.Text = "Indlæs";
         this.indlæsCPRKnap.UseVisualStyleBackColor = true;
         this.indlæsCPRKnap.Click += new System.EventHandler(this.indlæsCPRKnap_Click);
         // 
         // analyserDataKnap
         // 
         this.analyserDataKnap.Enabled = false;
         this.analyserDataKnap.Location = new System.Drawing.Point(245, 241);
         this.analyserDataKnap.Name = "analyserDataKnap";
         this.analyserDataKnap.Size = new System.Drawing.Size(87, 23);
         this.analyserDataKnap.TabIndex = 8;
         this.analyserDataKnap.Text = "Analyser data";
         this.analyserDataKnap.UseVisualStyleBackColor = true;
         this.analyserDataKnap.Click += new System.EventHandler(this.analyserDataKnap_Click);
         // 
         // gennemse_data
         // 
         this.AcceptButton = this.indlæsCPRKnap;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(360, 307);
         this.Controls.Add(this.analyserDataKnap);
         this.Controls.Add(this.indlæsCPRKnap);
         this.Controls.Add(this.efternavnTextBox);
         this.Controls.Add(this.fornavnTextBox);
         this.Controls.Add(this.CPRTextBox);
         this.Controls.Add(this.datasætListBox);
         this.Controls.Add(this.efternavn);
         this.Controls.Add(this.fornavn);
         this.Controls.Add(this.CPRnummer);
         this.Name = "gennemse_data";
         this.Text = "Gennemse data";
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