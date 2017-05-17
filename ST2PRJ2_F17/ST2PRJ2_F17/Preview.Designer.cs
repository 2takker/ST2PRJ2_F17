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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.gammelKommentartextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewData)).BeginInit();
            this.SuspendLayout();
            // 
            // genKnap
            // 
            this.genKnap.Location = new System.Drawing.Point(93, 12);
            this.genKnap.Name = "genKnap";
            this.genKnap.Size = new System.Drawing.Size(75, 23);
            this.genKnap.TabIndex = 0;
            this.genKnap.Text = "Gem";
            this.genKnap.UseVisualStyleBackColor = true;
            this.genKnap.Click += new System.EventHandler(this.genKnap_Click);
            // 
            // kasserKnap
            // 
            this.kasserKnap.Location = new System.Drawing.Point(174, 12);
            this.kasserKnap.Name = "kasserKnap";
            this.kasserKnap.Size = new System.Drawing.Size(75, 23);
            this.kasserKnap.TabIndex = 1;
            this.kasserKnap.Text = "Kassér";
            this.kasserKnap.UseVisualStyleBackColor = true;
            this.kasserKnap.Click += new System.EventHandler(this.kasserKnap_Click);
            // 
            // previewData
            // 
            this.previewData.BackColor = System.Drawing.SystemColors.Control;
            chartArea10.AxisX.MajorGrid.Interval = 0.2D;
            chartArea10.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea10.AxisX.MajorTickMark.Interval = 1D;
            chartArea10.AxisX.MinorGrid.Enabled = true;
            chartArea10.AxisX.MinorGrid.Interval = 0.04D;
            chartArea10.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea10.AxisX.Title = "Tid [s]";
            chartArea10.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea10.AxisY.MajorGrid.Interval = 0.5D;
            chartArea10.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea10.AxisY.MajorTickMark.Interval = 0.5D;
            chartArea10.AxisY.MinorGrid.Enabled = true;
            chartArea10.AxisY.MinorGrid.Interval = 0.1D;
            chartArea10.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea10.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90;
            chartArea10.AxisY.Title = "EKG [mV]";
            chartArea10.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea10.BackColor = System.Drawing.Color.White;
            chartArea10.Name = "ChartArea1";
            chartArea10.Position.Auto = false;
            chartArea10.Position.Height = 100F;
            chartArea10.Position.Width = 100F;
            this.previewData.ChartAreas.Add(chartArea10);
            legend10.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend10.Enabled = false;
            legend10.Name = "Legend1";
            this.previewData.Legends.Add(legend10);
            this.previewData.Location = new System.Drawing.Point(15, 51);
            this.previewData.Name = "previewData";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.Name = "EKG";
            this.previewData.Series.Add(series10);
            this.previewData.Size = new System.Drawing.Size(1200, 150);
            this.previewData.TabIndex = 2;
            this.previewData.Text = "previewData";
            // 
            // tiSekTilbageKnap
            // 
            this.tiSekTilbageKnap.Location = new System.Drawing.Point(100, 211);
            this.tiSekTilbageKnap.Name = "tiSekTilbageKnap";
            this.tiSekTilbageKnap.Size = new System.Drawing.Size(31, 23);
            this.tiSekTilbageKnap.TabIndex = 3;
            this.tiSekTilbageKnap.Text = "<";
            this.tiSekTilbageKnap.UseVisualStyleBackColor = true;
            this.tiSekTilbageKnap.Click += new System.EventHandler(this.tiSekTilbageKnap_Click);
            // 
            // tiSekFremKnap
            // 
            this.tiSekFremKnap.Location = new System.Drawing.Point(137, 211);
            this.tiSekFremKnap.Name = "tiSekFremKnap";
            this.tiSekFremKnap.Size = new System.Drawing.Size(31, 23);
            this.tiSekFremKnap.TabIndex = 4;
            this.tiSekFremKnap.Text = ">";
            this.tiSekFremKnap.UseVisualStyleBackColor = true;
            this.tiSekFremKnap.Click += new System.EventHandler(this.tiSekFremKnap_Click);
            // 
            // fremogtilbage
            // 
            this.fremogtilbage.AutoSize = true;
            this.fremogtilbage.Location = new System.Drawing.Point(72, 237);
            this.fremogtilbage.Name = "fremogtilbage";
            this.fremogtilbage.Size = new System.Drawing.Size(125, 13);
            this.fremogtilbage.TabIndex = 5;
            this.fremogtilbage.Text = "10 sekunder frem/tilbage";
            // 
            // kommentarTextBox
            // 
            this.kommentarTextBox.Location = new System.Drawing.Point(675, 323);
            this.kommentarTextBox.Multiline = true;
            this.kommentarTextBox.Name = "kommentarTextBox";
            this.kommentarTextBox.Size = new System.Drawing.Size(530, 200);
            this.kommentarTextBox.TabIndex = 6;
            // 
            // kommentar
            // 
            this.kommentar.AutoSize = true;
            this.kommentar.Location = new System.Drawing.Point(672, 304);
            this.kommentar.Name = "kommentar";
            this.kommentar.Size = new System.Drawing.Size(60, 13);
            this.kommentar.TabIndex = 7;
            this.kommentar.Text = "Kommentar";
            // 
            // gemKommentar
            // 
            this.gemKommentar.Location = new System.Drawing.Point(1100, 529);
            this.gemKommentar.Name = "gemKommentar";
            this.gemKommentar.Size = new System.Drawing.Size(105, 23);
            this.gemKommentar.TabIndex = 8;
            this.gemKommentar.Text = "Gem kommentar";
            this.gemKommentar.UseVisualStyleBackColor = true;
            this.gemKommentar.Click += new System.EventHandler(this.gemKommentar_Click);
            // 
            // importerFilKnap
            // 
            this.importerFilKnap.Location = new System.Drawing.Point(12, 12);
            this.importerFilKnap.Name = "importerFilKnap";
            this.importerFilKnap.Size = new System.Drawing.Size(75, 23);
            this.importerFilKnap.TabIndex = 9;
            this.importerFilKnap.Text = "Importer fil";
            this.importerFilKnap.UseVisualStyleBackColor = true;
            this.importerFilKnap.Click += new System.EventHandler(this.importerFilKnap_Click);
            // 
            // gammelKommentartextBox
            // 
            this.gammelKommentartextBox.Location = new System.Drawing.Point(15, 323);
            this.gammelKommentartextBox.Multiline = true;
            this.gammelKommentartextBox.Name = "gammelKommentartextBox";
            this.gammelKommentartextBox.ReadOnly = true;
            this.gammelKommentartextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gammelKommentartextBox.Size = new System.Drawing.Size(654, 200);
            this.gammelKommentartextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tidligere kommentarer";
            // 
            // preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1234, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gammelKommentartextBox);
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
            this.Name = "preview";
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
        private System.Windows.Forms.TextBox gammelKommentartextBox;
        private System.Windows.Forms.Label label1;
    }
}