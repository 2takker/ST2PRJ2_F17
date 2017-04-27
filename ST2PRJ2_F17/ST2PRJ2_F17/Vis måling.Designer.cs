namespace ST2PRJ2_F17
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
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.gemKommentarKnap = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.analyseretData)).BeginInit();
         this.SuspendLayout();
         // 
         // efternavnTextBox
         // 
         this.efternavnTextBox.Enabled = false;
         this.efternavnTextBox.Location = new System.Drawing.Point(284, 25);
         this.efternavnTextBox.Name = "efternavnTextBox";
         this.efternavnTextBox.Size = new System.Drawing.Size(100, 20);
         this.efternavnTextBox.TabIndex = 13;
         // 
         // fornavnTextBox
         // 
         this.fornavnTextBox.Enabled = false;
         this.fornavnTextBox.Location = new System.Drawing.Point(150, 25);
         this.fornavnTextBox.Name = "fornavnTextBox";
         this.fornavnTextBox.Size = new System.Drawing.Size(100, 20);
         this.fornavnTextBox.TabIndex = 12;
         // 
         // CPRTextBox
         // 
         this.CPRTextBox.Location = new System.Drawing.Point(15, 25);
         this.CPRTextBox.Name = "CPRTextBox";
         this.CPRTextBox.Size = new System.Drawing.Size(100, 20);
         this.CPRTextBox.TabIndex = 11;
         // 
         // efternavn
         // 
         this.efternavn.AutoSize = true;
         this.efternavn.Location = new System.Drawing.Point(281, 8);
         this.efternavn.Name = "efternavn";
         this.efternavn.Size = new System.Drawing.Size(53, 13);
         this.efternavn.TabIndex = 10;
         this.efternavn.Text = "Efternavn";
         // 
         // fornavn
         // 
         this.fornavn.AutoSize = true;
         this.fornavn.Location = new System.Drawing.Point(147, 8);
         this.fornavn.Name = "fornavn";
         this.fornavn.Size = new System.Drawing.Size(46, 13);
         this.fornavn.TabIndex = 9;
         this.fornavn.Text = "Fornavn";
         // 
         // CPRnummer
         // 
         this.CPRnummer.AutoSize = true;
         this.CPRnummer.Location = new System.Drawing.Point(12, 9);
         this.CPRnummer.Name = "CPRnummer";
         this.CPRnummer.Size = new System.Drawing.Size(69, 13);
         this.CPRnummer.TabIndex = 8;
         this.CPRnummer.Text = "CPR nummer";
         // 
         // analyseretData
         // 
         chartArea2.Name = "ChartArea1";
         this.analyseretData.ChartAreas.Add(chartArea2);
         legend2.Name = "Legend1";
         this.analyseretData.Legends.Add(legend2);
         this.analyseretData.Location = new System.Drawing.Point(15, 71);
         this.analyseretData.Name = "analyseretData";
         series2.ChartArea = "ChartArea1";
         series2.Legend = "Legend1";
         series2.Name = "Series1";
         this.analyseretData.Series.Add(series2);
         this.analyseretData.Size = new System.Drawing.Size(649, 300);
         this.analyseretData.TabIndex = 14;
         this.analyseretData.Text = "analyseretData";
         // 
         // fremogtilbage
         // 
         this.fremogtilbage.AutoSize = true;
         this.fremogtilbage.Location = new System.Drawing.Point(94, 415);
         this.fremogtilbage.Name = "fremogtilbage";
         this.fremogtilbage.Size = new System.Drawing.Size(125, 13);
         this.fremogtilbage.TabIndex = 17;
         this.fremogtilbage.Text = "10 sekunder frem/tilbage";
         // 
         // tiSekFremKnap
         // 
         this.tiSekFremKnap.Location = new System.Drawing.Point(164, 389);
         this.tiSekFremKnap.Name = "tiSekFremKnap";
         this.tiSekFremKnap.Size = new System.Drawing.Size(31, 23);
         this.tiSekFremKnap.TabIndex = 16;
         this.tiSekFremKnap.Text = ">";
         this.tiSekFremKnap.UseVisualStyleBackColor = true;
         // 
         // tiSekTilbageKnap
         // 
         this.tiSekTilbageKnap.Location = new System.Drawing.Point(127, 389);
         this.tiSekTilbageKnap.Name = "tiSekTilbageKnap";
         this.tiSekTilbageKnap.Size = new System.Drawing.Size(31, 23);
         this.tiSekTilbageKnap.TabIndex = 15;
         this.tiSekTilbageKnap.Text = "<";
         this.tiSekTilbageKnap.UseVisualStyleBackColor = true;
         // 
         // springMellemIP
         // 
         this.springMellemIP.AutoSize = true;
         this.springMellemIP.Location = new System.Drawing.Point(403, 415);
         this.springMellemIP.Name = "springMellemIP";
         this.springMellemIP.Size = new System.Drawing.Size(86, 13);
         this.springMellemIP.TabIndex = 20;
         this.springMellemIP.Text = "Interessepunkter";
         // 
         // ipFremKnap
         // 
         this.ipFremKnap.Location = new System.Drawing.Point(449, 389);
         this.ipFremKnap.Name = "ipFremKnap";
         this.ipFremKnap.Size = new System.Drawing.Size(31, 23);
         this.ipFremKnap.TabIndex = 19;
         this.ipFremKnap.Text = ">";
         this.ipFremKnap.UseVisualStyleBackColor = true;
         // 
         // ipTilbageKnap
         // 
         this.ipTilbageKnap.Location = new System.Drawing.Point(412, 389);
         this.ipTilbageKnap.Name = "ipTilbageKnap";
         this.ipTilbageKnap.Size = new System.Drawing.Size(31, 23);
         this.ipTilbageKnap.TabIndex = 18;
         this.ipTilbageKnap.Text = "<";
         this.ipTilbageKnap.UseVisualStyleBackColor = true;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(15, 454);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(343, 86);
         this.textBox1.TabIndex = 21;
         // 
         // gemKommentarKnap
         // 
         this.gemKommentarKnap.Location = new System.Drawing.Point(384, 517);
         this.gemKommentarKnap.Name = "gemKommentarKnap";
         this.gemKommentarKnap.Size = new System.Drawing.Size(105, 23);
         this.gemKommentarKnap.TabIndex = 22;
         this.gemKommentarKnap.Text = "Gem kommentar";
         this.gemKommentarKnap.UseVisualStyleBackColor = true;
         // 
         // vis_måling
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(695, 552);
         this.Controls.Add(this.gemKommentarKnap);
         this.Controls.Add(this.textBox1);
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
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button gemKommentarKnap;
   }
}