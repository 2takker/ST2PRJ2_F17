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
            this.SuspendLayout();
            // 
            // brugernavnTextBox
            // 
            this.brugernavnTextBox.Location = new System.Drawing.Point(174, 81);
            this.brugernavnTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.brugernavnTextBox.Name = "brugernavnTextBox";
            this.brugernavnTextBox.Size = new System.Drawing.Size(196, 31);
            this.brugernavnTextBox.TabIndex = 0;
            // 
            // adgangskodeTextBox
            // 
            this.adgangskodeTextBox.Location = new System.Drawing.Point(174, 187);
            this.adgangskodeTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.adgangskodeTextBox.Name = "adgangskodeTextBox";
            this.adgangskodeTextBox.Size = new System.Drawing.Size(196, 31);
            this.adgangskodeTextBox.TabIndex = 1;
            // 
            // brugernavn
            // 
            this.brugernavn.AutoSize = true;
            this.brugernavn.Location = new System.Drawing.Point(168, 50);
            this.brugernavn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.brugernavn.Name = "brugernavn";
            this.brugernavn.Size = new System.Drawing.Size(123, 25);
            this.brugernavn.TabIndex = 2;
            this.brugernavn.Text = "Brugernavn";
            // 
            // adgangskode
            // 
            this.adgangskode.AutoSize = true;
            this.adgangskode.Location = new System.Drawing.Point(168, 156);
            this.adgangskode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.adgangskode.Name = "adgangskode";
            this.adgangskode.Size = new System.Drawing.Size(144, 25);
            this.adgangskode.TabIndex = 3;
            this.adgangskode.Text = "Adgangskode";
            // 
            // LogIndKnap
            // 
            this.LogIndKnap.Location = new System.Drawing.Point(174, 319);
            this.LogIndKnap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LogIndKnap.Name = "LogIndKnap";
            this.LogIndKnap.Size = new System.Drawing.Size(200, 44);
            this.LogIndKnap.TabIndex = 4;
            this.LogIndKnap.Text = "Log ind";
            this.LogIndKnap.UseVisualStyleBackColor = true;
            this.LogIndKnap.Click += new System.EventHandler(this.LogIndKnap_Click);
            // 
            // log_ind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 502);
            this.Controls.Add(this.LogIndKnap);
            this.Controls.Add(this.adgangskode);
            this.Controls.Add(this.brugernavn);
            this.Controls.Add(this.adgangskodeTextBox);
            this.Controls.Add(this.brugernavnTextBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "log_ind";
            this.Text = "Log ind";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.log_ind_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox brugernavnTextBox;
      private System.Windows.Forms.TextBox adgangskodeTextBox;
      private System.Windows.Forms.Label brugernavn;
      private System.Windows.Forms.Label adgangskode;
      private System.Windows.Forms.Button LogIndKnap;
   }
}