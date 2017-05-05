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
         System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
         System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
         System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
         this.genKnap.Location = new System.Drawing.Point(24, 64);
         this.genKnap.Name = "genKnap";
         this.genKnap.Size = new System.Drawing.Size(75, 23);
         this.genKnap.TabIndex = 0;
         this.genKnap.Text = "Gem";
         this.genKnap.UseVisualStyleBackColor = true;
         this.genKnap.Click += new System.EventHandler(this.genKnap_Click);
         // 
         // kasserKnap
         // 
         this.kasserKnap.Location = new System.Drawing.Point(24, 102);
         this.kasserKnap.Name = "kasserKnap";
         this.kasserKnap.Size = new System.Drawing.Size(75, 23);
         this.kasserKnap.TabIndex = 1;
         this.kasserKnap.Text = "Kassér";
         this.kasserKnap.UseVisualStyleBackColor = true;
         this.kasserKnap.Click += new System.EventHandler(this.kasserKnap_Click);
         // 
         // previewData
         // 
         chartArea2.Name = "ChartArea1";
         this.previewData.ChartAreas.Add(chartArea2);
         legend2.Name = "Legend1";
         this.previewData.Legends.Add(legend2);
         this.previewData.Location = new System.Drawing.Point(125, 24);
         this.previewData.Name = "previewData";
         series2.ChartArea = "ChartArea1";
         series2.Legend = "Legend1";
         series2.Name = "Series1";
         this.previewData.Series.Add(series2);
         this.previewData.Size = new System.Drawing.Size(432, 241);
         this.previewData.TabIndex = 2;
         this.previewData.Text = "previewData";
         // 
         // tiSekTilbageKnap
         // 
         this.tiSekTilbageKnap.Location = new System.Drawing.Point(465, 271);
         this.tiSekTilbageKnap.Name = "tiSekTilbageKnap";
         this.tiSekTilbageKnap.Size = new System.Drawing.Size(31, 23);
         this.tiSekTilbageKnap.TabIndex = 3;
         this.tiSekTilbageKnap.Text = "<";
         this.tiSekTilbageKnap.UseVisualStyleBackColor = true;
         //this.tiSekTilbageKnap.Click += new System.EventHandler(this.tiSekTilbageKnap_Click);
         // 
         // tiSekFremKnap
         // 
         this.tiSekFremKnap.Location = new System.Drawing.Point(502, 271);
         this.tiSekFremKnap.Name = "tiSekFremKnap";
         this.tiSekFremKnap.Size = new System.Drawing.Size(31, 23);
         this.tiSekFremKnap.TabIndex = 4;
         this.tiSekFremKnap.Text = ">";
         this.tiSekFremKnap.UseVisualStyleBackColor = true;
         //this.tiSekFremKnap.Click += new System.EventHandler(this.tiSekFremKnap_Click);
         // 
         // fremogtilbage
         // 
         this.fremogtilbage.AutoSize = true;
         this.fremogtilbage.Location = new System.Drawing.Point(432, 297);
         this.fremogtilbage.Name = "fremogtilbage";
         this.fremogtilbage.Size = new System.Drawing.Size(125, 13);
         this.fremogtilbage.TabIndex = 5;
         this.fremogtilbage.Text = "10 sekunder frem/tilbage";
         // 
         // kommentarTextBox
         // 
         this.kommentarTextBox.Location = new System.Drawing.Point(125, 337);
         this.kommentarTextBox.Multiline = true;
         this.kommentarTextBox.Name = "kommentarTextBox";
         this.kommentarTextBox.Size = new System.Drawing.Size(266, 68);
         this.kommentarTextBox.TabIndex = 6;
         // 
         // kommentar
         // 
         this.kommentar.AutoSize = true;
         this.kommentar.Location = new System.Drawing.Point(125, 318);
         this.kommentar.Name = "kommentar";
         this.kommentar.Size = new System.Drawing.Size(60, 13);
         this.kommentar.TabIndex = 7;
         this.kommentar.Text = "Kommentar";
         // 
         // gemKommentar
         // 
         this.gemKommentar.Location = new System.Drawing.Point(289, 411);
         this.gemKommentar.Name = "gemKommentar";
         this.gemKommentar.Size = new System.Drawing.Size(102, 23);
         this.gemKommentar.TabIndex = 8;
         this.gemKommentar.Text = "Gem kommentar";
         this.gemKommentar.UseVisualStyleBackColor = true;
         this.gemKommentar.Click += new System.EventHandler(this.gemKommentar_Click);
         // 
         // importerFilKnap
         // 
         this.importerFilKnap.Location = new System.Drawing.Point(24, 24);
         this.importerFilKnap.Name = "importerFilKnap";
         this.importerFilKnap.Size = new System.Drawing.Size(75, 23);
         this.importerFilKnap.TabIndex = 9;
         this.importerFilKnap.Text = "Importer fil";
         this.importerFilKnap.UseVisualStyleBackColor = true;
         //this.importerFilKnap.Click += new System.EventHandler(this.importerFilKnap_Click);
         // 
         // preview
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(593, 467);
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
   }
}