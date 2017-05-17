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
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.GemAnalyseretDataKnap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.CPRTextBox.Enabled = false;
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
            lineAnnotation1.AxisXName = "ChartArea1\\rX";
            lineAnnotation1.Height = -10D;
            lineAnnotation1.Name = "IP";
            lineAnnotation1.StartCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Arrow;
            lineAnnotation1.ToolTip = "Interessepunkt";
            lineAnnotation1.Width = 2D;
            lineAnnotation1.X = 3D;
            lineAnnotation1.Y = 1.5D;
            lineAnnotation1.YAxisName = "ChartArea1\\rY";
            this.analyseretData.Annotations.Add(lineAnnotation1);
            this.analyseretData.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.MajorGrid.Interval = 0.2D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorTickMark.Interval = 0.04D;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.Interval = 0.04D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.Title = "Tid [s]";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.Interval = 0.5D;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.MajorGrid.Interval = 0.5D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.Maximum = 2D;
            chartArea1.AxisY.Minimum = -0.5D;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.Interval = 0.1D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90;
            chartArea1.AxisY.Title = "EKG [mV]";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.analyseretData.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.analyseretData.Legends.Add(legend1);
            this.analyseretData.Location = new System.Drawing.Point(15, 51);
            this.analyseretData.Name = "analyseretData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "EKG";
            this.analyseretData.Series.Add(series1);
            this.analyseretData.Size = new System.Drawing.Size(1200, 150);
            this.analyseretData.TabIndex = 14;
            this.analyseretData.Text = "analyseretData";
            // 
            // fremogtilbage
            // 
            this.fremogtilbage.AutoSize = true;
            this.fremogtilbage.Location = new System.Drawing.Point(72, 237);
            this.fremogtilbage.Name = "fremogtilbage";
            this.fremogtilbage.Size = new System.Drawing.Size(125, 13);
            this.fremogtilbage.TabIndex = 17;
            this.fremogtilbage.Text = "10 sekunder frem/tilbage";
            // 
            // tiSekFremKnap
            // 
            this.tiSekFremKnap.Location = new System.Drawing.Point(137, 211);
            this.tiSekFremKnap.Name = "tiSekFremKnap";
            this.tiSekFremKnap.Size = new System.Drawing.Size(31, 23);
            this.tiSekFremKnap.TabIndex = 16;
            this.tiSekFremKnap.Text = ">";
            this.tiSekFremKnap.UseVisualStyleBackColor = true;
            this.tiSekFremKnap.Click += new System.EventHandler(this.tiSekFremKnap_Click);
            // 
            // tiSekTilbageKnap
            // 
            this.tiSekTilbageKnap.Location = new System.Drawing.Point(100, 211);
            this.tiSekTilbageKnap.Name = "tiSekTilbageKnap";
            this.tiSekTilbageKnap.Size = new System.Drawing.Size(31, 23);
            this.tiSekTilbageKnap.TabIndex = 15;
            this.tiSekTilbageKnap.Text = "<";
            this.tiSekTilbageKnap.UseVisualStyleBackColor = true;
            this.tiSekTilbageKnap.Click += new System.EventHandler(this.tiSekTilbageKnap_Click);
            // 
            // springMellemIP
            // 
            this.springMellemIP.AutoSize = true;
            this.springMellemIP.Location = new System.Drawing.Point(1085, 237);
            this.springMellemIP.Name = "springMellemIP";
            this.springMellemIP.Size = new System.Drawing.Size(86, 13);
            this.springMellemIP.TabIndex = 20;
            this.springMellemIP.Text = "Interessepunkter";
            // 
            // ipFremKnap
            // 
            this.ipFremKnap.Location = new System.Drawing.Point(1131, 211);
            this.ipFremKnap.Name = "ipFremKnap";
            this.ipFremKnap.Size = new System.Drawing.Size(31, 23);
            this.ipFremKnap.TabIndex = 19;
            this.ipFremKnap.Text = ">";
            this.ipFremKnap.UseVisualStyleBackColor = true;
            this.ipFremKnap.Click += new System.EventHandler(this.ipFremKnap_Click);
            // 
            // ipTilbageKnap
            // 
            this.ipTilbageKnap.Location = new System.Drawing.Point(1093, 211);
            this.ipTilbageKnap.Name = "ipTilbageKnap";
            this.ipTilbageKnap.Size = new System.Drawing.Size(31, 23);
            this.ipTilbageKnap.TabIndex = 18;
            this.ipTilbageKnap.Text = "<";
            this.ipTilbageKnap.UseVisualStyleBackColor = true;
            this.ipTilbageKnap.Click += new System.EventHandler(this.ipTilbageKnap_Click);
            // 
            // kommentarTextBox
            // 
            this.kommentarTextBox.Location = new System.Drawing.Point(675, 323);
            this.kommentarTextBox.Multiline = true;
            this.kommentarTextBox.Name = "kommentarTextBox";
            this.kommentarTextBox.Size = new System.Drawing.Size(530, 200);
            this.kommentarTextBox.TabIndex = 21;
            // 
            // gemKommentarKnap
            // 
            this.gemKommentarKnap.Location = new System.Drawing.Point(1100, 529);
            this.gemKommentarKnap.Name = "gemKommentarKnap";
            this.gemKommentarKnap.Size = new System.Drawing.Size(105, 23);
            this.gemKommentarKnap.TabIndex = 22;
            this.gemKommentarKnap.Text = "Gem kommentar";
            this.gemKommentarKnap.UseVisualStyleBackColor = true;
            this.gemKommentarKnap.Click += new System.EventHandler(this.gemKommentarKnap_Click);
            // 
            // labelNoIP
            // 
            this.labelNoIP.AutoSize = true;
            this.labelNoIP.ForeColor = System.Drawing.Color.Red;
            this.labelNoIP.Location = new System.Drawing.Point(1057, 250);
            this.labelNoIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoIP.Name = "labelNoIP";
            this.labelNoIP.Size = new System.Drawing.Size(148, 13);
            this.labelNoIP.TabIndex = 23;
            this.labelNoIP.Text = "Ingen interessepunkter fundet";
            this.labelNoIP.Visible = false;
            // 
            // gammelKommentartextBox
            // 
            this.gammelKommentartextBox.Location = new System.Drawing.Point(15, 323);
            this.gammelKommentartextBox.Multiline = true;
            this.gammelKommentartextBox.Name = "gammelKommentartextBox";
            this.gammelKommentartextBox.ReadOnly = true;
            this.gammelKommentartextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gammelKommentartextBox.Size = new System.Drawing.Size(654, 200);
            this.gammelKommentartextBox.TabIndex = 24;
            // 
            // GemAnalyseretDataKnap
            // 
            this.GemAnalyseretDataKnap.Location = new System.Drawing.Point(1080, 25);
            this.GemAnalyseretDataKnap.Name = "GemAnalyseretDataKnap";
            this.GemAnalyseretDataKnap.Size = new System.Drawing.Size(125, 23);
            this.GemAnalyseretDataKnap.TabIndex = 25;
            this.GemAnalyseretDataKnap.Text = "Gem analyseret data";
            this.GemAnalyseretDataKnap.UseVisualStyleBackColor = true;
            this.GemAnalyseretDataKnap.Click += new System.EventHandler(this.GemAnalyseretDataKnap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tidligere kommentarer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Kommentar";
            // 
            // vis_måling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1234, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GemAnalyseretDataKnap);
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
            this.Name = "vis_måling";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Vis måling";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.vis_måling_FormClosing);
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
      private System.Windows.Forms.Button GemAnalyseretDataKnap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}