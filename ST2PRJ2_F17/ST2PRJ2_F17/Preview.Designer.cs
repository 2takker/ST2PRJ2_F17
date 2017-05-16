namespace Præsentationslag
{
   partial class preview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.genKnap = new System.Windows.Forms.Button();
            this.kasserKnap = new System.Windows.Forms.Button();
            this.previewData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tiSekTilbageKnap = new System.Windows.Forms.Button();
            this.tiSekFremKnap = new System.Windows.Forms.Button();
            this.fremogtilbage = new System.Windows.Forms.Label();
            this.kommentarTextBox = new System.Windows.Forms.TextBox();
            this.kommentar = new System.Windows.Forms.Label();
            this.gemKommentar = new System.Windows.Forms.Button();
            this.importerFilKnap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previewData)).BeginInit();
            this.SuspendLayout();
            // 
            // genKnap
            // 
            this.genKnap.Location = new System.Drawing.Point(48, 128);
            this.genKnap.Margin = new System.Windows.Forms.Padding(6);
            this.genKnap.Name = "genKnap";
            this.genKnap.Size = new System.Drawing.Size(150, 46);
            this.genKnap.TabIndex = 0;
            this.genKnap.Text = "Gem";
            this.genKnap.UseVisualStyleBackColor = true;
            this.genKnap.Click += new System.EventHandler(this.genKnap_Click);
            // 
            // kasserKnap
            // 
            this.kasserKnap.Location = new System.Drawing.Point(48, 204);
            this.kasserKnap.Margin = new System.Windows.Forms.Padding(6);
            this.kasserKnap.Name = "kasserKnap";
            this.kasserKnap.Size = new System.Drawing.Size(150, 46);
            this.kasserKnap.TabIndex = 1;
            this.kasserKnap.Text = "Kassér";
            this.kasserKnap.UseVisualStyleBackColor = true;
            this.kasserKnap.Click += new System.EventHandler(this.kasserKnap_Click);
            // 
            // previewData
            // 
            this.previewData.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.MajorGrid.Interval = 0.2D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorTickMark.Interval = 1D;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.Interval = 0.04D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.Title = "s";
            chartArea1.AxisY.MajorGrid.Interval = 0.5D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorTickMark.Interval = 0.5D;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.Interval = 0.1D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.Title = "mV";
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.previewData.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.previewData.Legends.Add(legend1);
            this.previewData.Location = new System.Drawing.Point(250, 48);
            this.previewData.Margin = new System.Windows.Forms.Padding(6);
            this.previewData.Name = "previewData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "EKG";
            this.previewData.Series.Add(series1);
            this.previewData.Size = new System.Drawing.Size(1400, 175);
            this.previewData.TabIndex = 2;
            this.previewData.Text = "previewData";
            // 
            // tiSekTilbageKnap
            // 
            this.tiSekTilbageKnap.Location = new System.Drawing.Point(1452, 316);
            this.tiSekTilbageKnap.Margin = new System.Windows.Forms.Padding(6);
            this.tiSekTilbageKnap.Name = "tiSekTilbageKnap";
            this.tiSekTilbageKnap.Size = new System.Drawing.Size(62, 46);
            this.tiSekTilbageKnap.TabIndex = 3;
            this.tiSekTilbageKnap.Text = "<";
            this.tiSekTilbageKnap.UseVisualStyleBackColor = true;
            this.tiSekTilbageKnap.Click += new System.EventHandler(this.tiSekTilbageKnap_Click);
            // 
            // tiSekFremKnap
            // 
            this.tiSekFremKnap.Location = new System.Drawing.Point(1526, 316);
            this.tiSekFremKnap.Margin = new System.Windows.Forms.Padding(6);
            this.tiSekFremKnap.Name = "tiSekFremKnap";
            this.tiSekFremKnap.Size = new System.Drawing.Size(62, 46);
            this.tiSekFremKnap.TabIndex = 4;
            this.tiSekFremKnap.Text = ">";
            this.tiSekFremKnap.UseVisualStyleBackColor = true;
            this.tiSekFremKnap.Click += new System.EventHandler(this.tiSekFremKnap_Click);
            // 
            // fremogtilbage
            // 
            this.fremogtilbage.AutoSize = true;
            this.fremogtilbage.Location = new System.Drawing.Point(1401, 368);
            this.fremogtilbage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fremogtilbage.Name = "fremogtilbage";
            this.fremogtilbage.Size = new System.Drawing.Size(249, 25);
            this.fremogtilbage.TabIndex = 5;
            this.fremogtilbage.Text = "10 sekunder frem/tilbage";
            // 
            // kommentarTextBox
            // 
            this.kommentarTextBox.Location = new System.Drawing.Point(43, 329);
            this.kommentarTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.kommentarTextBox.Multiline = true;
            this.kommentarTextBox.Name = "kommentarTextBox";
            this.kommentarTextBox.Size = new System.Drawing.Size(934, 132);
            this.kommentarTextBox.TabIndex = 6;
            // 
            // kommentar
            // 
            this.kommentar.AutoSize = true;
            this.kommentar.Location = new System.Drawing.Point(43, 291);
            this.kommentar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.kommentar.Name = "kommentar";
            this.kommentar.Size = new System.Drawing.Size(121, 25);
            this.kommentar.TabIndex = 7;
            this.kommentar.Text = "Kommentar";
            // 
            // gemKommentar
            // 
            this.gemKommentar.Location = new System.Drawing.Point(773, 473);
            this.gemKommentar.Margin = new System.Windows.Forms.Padding(6);
            this.gemKommentar.Name = "gemKommentar";
            this.gemKommentar.Size = new System.Drawing.Size(204, 46);
            this.gemKommentar.TabIndex = 8;
            this.gemKommentar.Text = "Gem kommentar";
            this.gemKommentar.UseVisualStyleBackColor = true;
            this.gemKommentar.Click += new System.EventHandler(this.gemKommentar_Click);
            // 
            // importerFilKnap
            // 
            this.importerFilKnap.Location = new System.Drawing.Point(48, 48);
            this.importerFilKnap.Margin = new System.Windows.Forms.Padding(6);
            this.importerFilKnap.Name = "importerFilKnap";
            this.importerFilKnap.Size = new System.Drawing.Size(150, 46);
            this.importerFilKnap.TabIndex = 9;
            this.importerFilKnap.Text = "Importer fil";
            this.importerFilKnap.UseVisualStyleBackColor = true;
            this.importerFilKnap.Click += new System.EventHandler(this.importerFilKnap_Click);
            // 
            // preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2714, 1424);
            this.Controls.Add(this.importerFilKnap);
            this.Controls.Add(this.gemKommentar);
            this.Controls.Add(this.kommentar);
            this.Controls.Add(this.kommentarTextBox);
            this.Controls.Add(this.fremogtilbage);
            this.Controls.Add(this.tiSekFremKnap);
            this.Controls.Add(this.tiSekTilbageKnap);
            this.Controls.Add(this.previewData);
            this.Controls.Add(this.kasserKnap);
            this.Controls.Add(this.genKnap);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Preview";
            ((System.ComponentModel.ISupportInitialize)(this.previewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button genKnap;
      private System.Windows.Forms.Button kasserKnap;
      private System.Windows.Forms.DataVisualization.Charting.Chart previewData;
      private System.Windows.Forms.Button tiSekTilbageKnap;
      private System.Windows.Forms.Button tiSekFremKnap;
      private System.Windows.Forms.Label fremogtilbage;
      private System.Windows.Forms.TextBox kommentarTextBox;
      private System.Windows.Forms.Label kommentar;
      private System.Windows.Forms.Button gemKommentar;
      private System.Windows.Forms.Button importerFilKnap;
   }
}