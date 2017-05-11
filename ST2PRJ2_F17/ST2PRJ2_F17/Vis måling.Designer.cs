namespace Præsentationslag
{
   partial class vis_måling
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.efternavnTextBox = new System.Windows.Forms.TextBox();
            this.fornavnTextBox = new System.Windows.Forms.TextBox();
            this.CPRTextBox = new System.Windows.Forms.TextBox();
            this.efternavn = new System.Windows.Forms.Label();
            this.fornavn = new System.Windows.Forms.Label();
            this.CPRnummer = new System.Windows.Forms.Label();
            this.analyseretData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fremogtilbage = new System.Windows.Forms.Label();
            this.tiSekFremKnap = new System.Windows.Forms.Button();
            this.tiSekTilbageKnap = new System.Windows.Forms.Button();
            this.springMellemIP = new System.Windows.Forms.Label();
            this.ipFremKnap = new System.Windows.Forms.Button();
            this.ipTilbageKnap = new System.Windows.Forms.Button();
            this.kommentarTextBox = new System.Windows.Forms.TextBox();
            this.gemKommentarKnap = new System.Windows.Forms.Button();
            this.labelNoIP = new System.Windows.Forms.Label();
            this.gammelKommentartextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.analyseretData)).BeginInit();
            this.SuspendLayout();
            // 
            // efternavnTextBox
            // 
            this.efternavnTextBox.Enabled = false;
            this.efternavnTextBox.Location = new System.Drawing.Point(568, 48);
            this.efternavnTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.efternavnTextBox.Name = "efternavnTextBox";
            this.efternavnTextBox.Size = new System.Drawing.Size(196, 31);
            this.efternavnTextBox.TabIndex = 13;
            // 
            // fornavnTextBox
            // 
            this.fornavnTextBox.Enabled = false;
            this.fornavnTextBox.Location = new System.Drawing.Point(300, 48);
            this.fornavnTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.fornavnTextBox.Name = "fornavnTextBox";
            this.fornavnTextBox.Size = new System.Drawing.Size(196, 31);
            this.fornavnTextBox.TabIndex = 12;
            // 
            // CPRTextBox
            // 
            this.CPRTextBox.Enabled = false;
            this.CPRTextBox.Location = new System.Drawing.Point(30, 48);
            this.CPRTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CPRTextBox.Name = "CPRTextBox";
            this.CPRTextBox.Size = new System.Drawing.Size(196, 31);
            this.CPRTextBox.TabIndex = 11;
            // 
            // efternavn
            // 
            this.efternavn.AutoSize = true;
            this.efternavn.Location = new System.Drawing.Point(562, 15);
            this.efternavn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.efternavn.Name = "efternavn";
            this.efternavn.Size = new System.Drawing.Size(104, 25);
            this.efternavn.TabIndex = 10;
            this.efternavn.Text = "Efternavn";
            // 
            // fornavn
            // 
            this.fornavn.AutoSize = true;
            this.fornavn.Location = new System.Drawing.Point(294, 15);
            this.fornavn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fornavn.Name = "fornavn";
            this.fornavn.Size = new System.Drawing.Size(91, 25);
            this.fornavn.TabIndex = 9;
            this.fornavn.Text = "Fornavn";
            // 
            // CPRnummer
            // 
            this.CPRnummer.AutoSize = true;
            this.CPRnummer.Location = new System.Drawing.Point(24, 17);
            this.CPRnummer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CPRnummer.Name = "CPRnummer";
            this.CPRnummer.Size = new System.Drawing.Size(139, 25);
            this.CPRnummer.TabIndex = 8;
            this.CPRnummer.Text = "CPR nummer";
            // 
            // analyseretData
            // 
            chartArea2.Name = "ChartArea1";
            this.analyseretData.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.analyseretData.Legends.Add(legend2);
            this.analyseretData.Location = new System.Drawing.Point(30, 137);
            this.analyseretData.Margin = new System.Windows.Forms.Padding(6);
            this.analyseretData.Name = "analyseretData";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "EKG";
            this.analyseretData.Series.Add(series2);
            this.analyseretData.Size = new System.Drawing.Size(1681, 577);
            this.analyseretData.TabIndex = 14;
            this.analyseretData.Text = "analyseretData";
            // 
            // fremogtilbage
            // 
            this.fremogtilbage.AutoSize = true;
            this.fremogtilbage.Location = new System.Drawing.Point(188, 798);
            this.fremogtilbage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fremogtilbage.Name = "fremogtilbage";
            this.fremogtilbage.Size = new System.Drawing.Size(249, 25);
            this.fremogtilbage.TabIndex = 17;
            this.fremogtilbage.Text = "10 sekunder frem/tilbage";
            // 
            // tiSekFremKnap
            // 
            this.tiSekFremKnap.Location = new System.Drawing.Point(328, 748);
            this.tiSekFremKnap.Margin = new System.Windows.Forms.Padding(6);
            this.tiSekFremKnap.Name = "tiSekFremKnap";
            this.tiSekFremKnap.Size = new System.Drawing.Size(62, 44);
            this.tiSekFremKnap.TabIndex = 16;
            this.tiSekFremKnap.Text = ">";
            this.tiSekFremKnap.UseVisualStyleBackColor = true;
            this.tiSekFremKnap.Click += new System.EventHandler(this.tiSekFremKnap_Click);
            // 
            // tiSekTilbageKnap
            // 
            this.tiSekTilbageKnap.Location = new System.Drawing.Point(254, 748);
            this.tiSekTilbageKnap.Margin = new System.Windows.Forms.Padding(6);
            this.tiSekTilbageKnap.Name = "tiSekTilbageKnap";
            this.tiSekTilbageKnap.Size = new System.Drawing.Size(62, 44);
            this.tiSekTilbageKnap.TabIndex = 15;
            this.tiSekTilbageKnap.Text = "<";
            this.tiSekTilbageKnap.UseVisualStyleBackColor = true;
            this.tiSekTilbageKnap.Click += new System.EventHandler(this.tiSekTilbageKnap_Click);
            // 
            // springMellemIP
            // 
            this.springMellemIP.AutoSize = true;
            this.springMellemIP.Location = new System.Drawing.Point(1419, 798);
            this.springMellemIP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.springMellemIP.Name = "springMellemIP";
            this.springMellemIP.Size = new System.Drawing.Size(172, 25);
            this.springMellemIP.TabIndex = 20;
            this.springMellemIP.Text = "Interessepunkter";
            // 
            // ipFremKnap
            // 
            this.ipFremKnap.Location = new System.Drawing.Point(1511, 748);
            this.ipFremKnap.Margin = new System.Windows.Forms.Padding(6);
            this.ipFremKnap.Name = "ipFremKnap";
            this.ipFremKnap.Size = new System.Drawing.Size(62, 44);
            this.ipFremKnap.TabIndex = 19;
            this.ipFremKnap.Text = ">";
            this.ipFremKnap.UseVisualStyleBackColor = true;
            this.ipFremKnap.Click += new System.EventHandler(this.ipFremKnap_Click);
            // 
            // ipTilbageKnap
            // 
            this.ipTilbageKnap.Location = new System.Drawing.Point(1437, 748);
            this.ipTilbageKnap.Margin = new System.Windows.Forms.Padding(6);
            this.ipTilbageKnap.Name = "ipTilbageKnap";
            this.ipTilbageKnap.Size = new System.Drawing.Size(62, 44);
            this.ipTilbageKnap.TabIndex = 18;
            this.ipTilbageKnap.Text = "<";
            this.ipTilbageKnap.UseVisualStyleBackColor = true;
            this.ipTilbageKnap.Click += new System.EventHandler(this.ipTilbageKnap_Click);
            // 
            // kommentarTextBox
            // 
            this.kommentarTextBox.Location = new System.Drawing.Point(853, 887);
            this.kommentarTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.kommentarTextBox.Multiline = true;
            this.kommentarTextBox.Name = "kommentarTextBox";
            this.kommentarTextBox.Size = new System.Drawing.Size(818, 294);
            this.kommentarTextBox.TabIndex = 21;
            // 
            // gemKommentarKnap
            // 
            this.gemKommentarKnap.Location = new System.Drawing.Point(1461, 1193);
            this.gemKommentarKnap.Margin = new System.Windows.Forms.Padding(6);
            this.gemKommentarKnap.Name = "gemKommentarKnap";
            this.gemKommentarKnap.Size = new System.Drawing.Size(210, 44);
            this.gemKommentarKnap.TabIndex = 22;
            this.gemKommentarKnap.Text = "Gem kommentar";
            this.gemKommentarKnap.UseVisualStyleBackColor = true;
            // 
            // labelNoIP
            // 
            this.labelNoIP.AutoSize = true;
            this.labelNoIP.ForeColor = System.Drawing.Color.Red;
            this.labelNoIP.Location = new System.Drawing.Point(1362, 823);
            this.labelNoIP.Name = "labelNoIP";
            this.labelNoIP.Size = new System.Drawing.Size(297, 25);
            this.labelNoIP.TabIndex = 23;
            this.labelNoIP.Text = "Ingen interessepunkter fundet";
            this.labelNoIP.Visible = false;
            // 
            // gammelKommentartextBox
            // 
            this.gammelKommentartextBox.Enabled = false;
            this.gammelKommentartextBox.Location = new System.Drawing.Point(41, 887);
            this.gammelKommentartextBox.Margin = new System.Windows.Forms.Padding(6);
            this.gammelKommentartextBox.Multiline = true;
            this.gammelKommentartextBox.Name = "gammelKommentartextBox";
            this.gammelKommentartextBox.Size = new System.Drawing.Size(723, 294);
            this.gammelKommentartextBox.TabIndex = 24;
            // 
            // vis_måling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 1252);
            this.Controls.Add(this.gammelKommentartextBox);
            this.Controls.Add(this.labelNoIP);
            this.Controls.Add(this.gemKommentarKnap);
            this.Controls.Add(this.kommentarTextBox);
            this.Controls.Add(this.springMellemIP);
            this.Controls.Add(this.ipFremKnap);
            this.Controls.Add(this.ipTilbageKnap);
            this.Controls.Add(this.fremogtilbage);
            this.Controls.Add(this.tiSekFremKnap);
            this.Controls.Add(this.tiSekTilbageKnap);
            this.Controls.Add(this.analyseretData);
            this.Controls.Add(this.efternavnTextBox);
            this.Controls.Add(this.fornavnTextBox);
            this.Controls.Add(this.CPRTextBox);
            this.Controls.Add(this.efternavn);
            this.Controls.Add(this.fornavn);
            this.Controls.Add(this.CPRnummer);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "vis_måling";
            this.Text = "Vis måling";
            ((System.ComponentModel.ISupportInitialize)(this.analyseretData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox efternavnTextBox;
      private System.Windows.Forms.TextBox fornavnTextBox;
      private System.Windows.Forms.TextBox CPRTextBox;
      private System.Windows.Forms.Label efternavn;
      private System.Windows.Forms.Label fornavn;
      private System.Windows.Forms.Label CPRnummer;
      private System.Windows.Forms.DataVisualization.Charting.Chart analyseretData;
      private System.Windows.Forms.Label fremogtilbage;
      private System.Windows.Forms.Button tiSekFremKnap;
      private System.Windows.Forms.Button tiSekTilbageKnap;
      private System.Windows.Forms.Label springMellemIP;
      private System.Windows.Forms.Button ipFremKnap;
      private System.Windows.Forms.Button ipTilbageKnap;
      private System.Windows.Forms.TextBox kommentarTextBox;
      private System.Windows.Forms.Button gemKommentarKnap;
        private System.Windows.Forms.Label labelNoIP;
        private System.Windows.Forms.TextBox gammelKommentartextBox;
    }
}