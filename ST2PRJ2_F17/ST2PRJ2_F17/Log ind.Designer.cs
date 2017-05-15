namespace Præsentationslag
{
   partial class log_ind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_ind));
            this.brugernavnTextBox = new System.Windows.Forms.TextBox();
            this.adgangskodeTextBox = new System.Windows.Forms.TextBox();
            this.brugernavn = new System.Windows.Forms.Label();
            this.adgangskode = new System.Windows.Forms.Label();
            this.LogIndKnap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // brugernavnTextBox
            // 
            this.brugernavnTextBox.Location = new System.Drawing.Point(87, 42);
            this.brugernavnTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.brugernavnTextBox.MaxLength = 3456;
            this.brugernavnTextBox.Name = "brugernavnTextBox";
            this.brugernavnTextBox.Size = new System.Drawing.Size(100, 20);
            this.brugernavnTextBox.TabIndex = 0;
            // 
            // adgangskodeTextBox
            // 
            this.adgangskodeTextBox.Location = new System.Drawing.Point(87, 85);
            this.adgangskodeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.adgangskodeTextBox.Name = "adgangskodeTextBox";
            this.adgangskodeTextBox.PasswordChar = '*';
            this.adgangskodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.adgangskodeTextBox.TabIndex = 1;
            this.adgangskodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adgangskodeTextBox_KeyPress);
            // 
            // brugernavn
            // 
            this.brugernavn.AutoSize = true;
            this.brugernavn.Location = new System.Drawing.Point(84, 26);
            this.brugernavn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.brugernavn.Name = "brugernavn";
            this.brugernavn.Size = new System.Drawing.Size(62, 13);
            this.brugernavn.TabIndex = 2;
            this.brugernavn.Text = "Brugernavn";
            // 
            // adgangskode
            // 
            this.adgangskode.AutoSize = true;
            this.adgangskode.Location = new System.Drawing.Point(84, 69);
            this.adgangskode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.adgangskode.Name = "adgangskode";
            this.adgangskode.Size = new System.Drawing.Size(73, 13);
            this.adgangskode.TabIndex = 3;
            this.adgangskode.Text = "Adgangskode";
            // 
            // LogIndKnap
            // 
            this.LogIndKnap.Location = new System.Drawing.Point(87, 125);
            this.LogIndKnap.Margin = new System.Windows.Forms.Padding(6);
            this.LogIndKnap.Name = "LogIndKnap";
            this.LogIndKnap.Size = new System.Drawing.Size(100, 23);
            this.LogIndKnap.TabIndex = 4;
            this.LogIndKnap.Text = "Log ind";
            this.LogIndKnap.UseVisualStyleBackColor = true;
            this.LogIndKnap.Click += new System.EventHandler(this.LogIndKnap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // log_ind
            // 
            this.AcceptButton = this.LogIndKnap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LogIndKnap);
            this.Controls.Add(this.adgangskode);
            this.Controls.Add(this.brugernavn);
            this.Controls.Add(this.adgangskodeTextBox);
            this.Controls.Add(this.brugernavnTextBox);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "log_ind";
            this.Text = "Log ind";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.log_ind_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox brugernavnTextBox;
      private System.Windows.Forms.TextBox adgangskodeTextBox;
      private System.Windows.Forms.Label brugernavn;
      private System.Windows.Forms.Label adgangskode;
      private System.Windows.Forms.Button LogIndKnap;
      private System.Windows.Forms.PictureBox pictureBox1;
   }
}