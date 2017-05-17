﻿namespace Præsentationslag
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
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            lineAnnotation3.AxisXName = "ChartArea1\\rX";
            lineAnnotation3.Height = -10D;
            lineAnnotation3.Name = "IP";
            lineAnnotation3.StartCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Arrow;
            lineAnnotation3.ToolTip = "Interessepunkt";
            lineAnnotation3.Width = 2D;
            lineAnnotation3.X = 3D;
            lineAnnotation3.Y = 1.5D;
            lineAnnotation3.YAxisName = "ChartArea1\\rY";
            this.analyseretData.Annotations.Add(lineAnnotation3);
            this.analyseretData.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.AxisX.MajorGrid.Interval = 0.2D;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.MajorTickMark.Interval = 0.04D;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.MinorGrid.Enabled = true;
            chartArea3.AxisX.MinorGrid.Interval = 0.04D;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY.Interval = 0.5D;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.MajorGrid.Interval = 0.5D;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisY.Maximum = 2D;
            chartArea3.AxisY.Minimum = -0.5D;
            chartArea3.AxisY.MinorGrid.Enabled = true;
            chartArea3.AxisY.MinorGrid.Interval = 0.1D;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.Name = "ChartArea1";
            this.analyseretData.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.analyseretData.Legends.Add(legend3);
            this.analyseretData.Location = new System.Drawing.Point(15, 71);
            this.analyseretData.Name = "analyseretData";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "EKG";
            this.analyseretData.Series.Add(series3);
            this.analyseretData.Size = new System.Drawing.Size(1400, 175);
            this.analyseretData.TabIndex = 14;
            this.analyseretData.Text = "analyseretData";
            // 
            // fremogtilbage
            // 
            this.fremogtilbage.AutoSize = true;
            this.fremogtilbage.Location = new System.Drawing.Point(12, 251);
            this.fremogtilbage.Name = "fremogtilbage";
            this.fremogtilbage.Size = new System.Drawing.Size(125, 13);
            this.fremogtilbage.TabIndex = 17;
            this.fremogtilbage.Text = "10 sekunder frem/tilbage";
            // 
            // tiSekFremKnap
            // 
            this.tiSekFremKnap.Location = new System.Drawing.Point(82, 225);
            this.tiSekFremKnap.Name = "tiSekFremKnap";
            this.tiSekFremKnap.Size = new System.Drawing.Size(31, 23);
            this.tiSekFremKnap.TabIndex = 16;
            this.tiSekFremKnap.Text = ">";
            this.tiSekFremKnap.UseVisualStyleBackColor = true;
            this.tiSekFremKnap.Click += new System.EventHandler(this.tiSekFremKnap_Click);
            // 
            // tiSekTilbageKnap
            // 
            this.tiSekTilbageKnap.Location = new System.Drawing.Point(46, 225);
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
            this.springMellemIP.Location = new System.Drawing.Point(594, 251);
            this.springMellemIP.Name = "springMellemIP";
            this.springMellemIP.Size = new System.Drawing.Size(86, 13);
            this.springMellemIP.TabIndex = 20;
            this.springMellemIP.Text = "Interessepunkter";
            // 
            // ipFremKnap
            // 
            this.ipFremKnap.Location = new System.Drawing.Point(640, 225);
            this.ipFremKnap.Name = "ipFremKnap";
            this.ipFremKnap.Size = new System.Drawing.Size(31, 23);
            this.ipFremKnap.TabIndex = 19;
            this.ipFremKnap.Text = ">";
            this.ipFremKnap.UseVisualStyleBackColor = true;
            this.ipFremKnap.Click += new System.EventHandler(this.ipFremKnap_Click);
            // 
            // ipTilbageKnap
            // 
            this.ipTilbageKnap.Location = new System.Drawing.Point(602, 225);
            this.ipTilbageKnap.Name = "ipTilbageKnap";
            this.ipTilbageKnap.Size = new System.Drawing.Size(31, 23);
            this.ipTilbageKnap.TabIndex = 18;
            this.ipTilbageKnap.Text = "<";
            this.ipTilbageKnap.UseVisualStyleBackColor = true;
            this.ipTilbageKnap.Click += new System.EventHandler(this.ipTilbageKnap_Click);
            // 
            // kommentarTextBox
            // 
            this.kommentarTextBox.Location = new System.Drawing.Point(392, 289);
            this.kommentarTextBox.Multiline = true;
            this.kommentarTextBox.Name = "kommentarTextBox";
            this.kommentarTextBox.Size = new System.Drawing.Size(324, 150);
            this.kommentarTextBox.TabIndex = 21;
            // 
            // gemKommentarKnap
            // 
            this.gemKommentarKnap.Location = new System.Drawing.Point(610, 444);
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
            this.labelNoIP.Location = new System.Drawing.Point(566, 264);
            this.labelNoIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoIP.Name = "labelNoIP";
            this.labelNoIP.Size = new System.Drawing.Size(148, 13);
            this.labelNoIP.TabIndex = 23;
            this.labelNoIP.Text = "Ingen interessepunkter fundet";
            this.labelNoIP.Visible = false;
            // 
            // gammelKommentartextBox
            // 
            this.gammelKommentartextBox.Location = new System.Drawing.Point(15, 289);
            this.gammelKommentartextBox.Multiline = true;
            this.gammelKommentartextBox.Name = "gammelKommentartextBox";
            this.gammelKommentartextBox.ReadOnly = true;
            this.gammelKommentartextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gammelKommentartextBox.Size = new System.Drawing.Size(374, 150);
            this.gammelKommentartextBox.TabIndex = 24;
            // 
            // GemAnalyseretDataKnap
            // 
            this.GemAnalyseretDataKnap.Location = new System.Drawing.Point(589, 21);
            this.GemAnalyseretDataKnap.Name = "GemAnalyseretDataKnap";
            this.GemAnalyseretDataKnap.Size = new System.Drawing.Size(125, 23);
            this.GemAnalyseretDataKnap.TabIndex = 25;
            this.GemAnalyseretDataKnap.Text = "Gem analyseret data";
            this.GemAnalyseretDataKnap.UseVisualStyleBackColor = true;
            this.GemAnalyseretDataKnap.Click += new System.EventHandler(this.GemAnalyseretDataKnap_Click);
            // 
            // vis_måling
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1410, 506);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
   }
}