namespace Analisis_Numerico_Sistema_3
{
    partial class Grafica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafica));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pbx_menos = new System.Windows.Forms.PictureBox();
            this.pbx_mas = new System.Windows.Forms.PictureBox();
            this.cbx_Negativos = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_menos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_mas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 60);
            this.panel1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(868, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Análisis Numérico Sistema 3 - Método de interpolación unico - Gráfica de la Funci" +
    "ón";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.chart1.BorderlineWidth = 5;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.ForeColor = System.Drawing.Color.Wheat;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 61);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Funcion";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(986, 435);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            // 
            // pbx_menos
            // 
            this.pbx_menos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_menos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_menos.Image = global::Analisis_Numerico_Sistema_3.Properties.Resources.minus_3_;
            this.pbx_menos.Location = new System.Drawing.Point(904, 509);
            this.pbx_menos.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pbx_menos.Name = "pbx_menos";
            this.pbx_menos.Size = new System.Drawing.Size(30, 30);
            this.pbx_menos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_menos.TabIndex = 35;
            this.pbx_menos.TabStop = false;
            this.pbx_menos.Click += new System.EventHandler(this.pbx_menos_Click);
            // 
            // pbx_mas
            // 
            this.pbx_mas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_mas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_mas.Image = global::Analisis_Numerico_Sistema_3.Properties.Resources.plus__3_;
            this.pbx_mas.Location = new System.Drawing.Point(938, 509);
            this.pbx_mas.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pbx_mas.Name = "pbx_mas";
            this.pbx_mas.Size = new System.Drawing.Size(30, 30);
            this.pbx_mas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_mas.TabIndex = 34;
            this.pbx_mas.TabStop = false;
            this.pbx_mas.Click += new System.EventHandler(this.pbx_mas_Click);
            // 
            // cbx_Negativos
            // 
            this.cbx_Negativos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_Negativos.AutoSize = true;
            this.cbx_Negativos.ForeColor = System.Drawing.Color.White;
            this.cbx_Negativos.Location = new System.Drawing.Point(63, 509);
            this.cbx_Negativos.Name = "cbx_Negativos";
            this.cbx_Negativos.Size = new System.Drawing.Size(256, 25);
            this.cbx_Negativos.TabIndex = 36;
            this.cbx_Negativos.Text = "Mostrar valores Negativos de x";
            this.cbx_Negativos.UseVisualStyleBackColor = true;
            this.cbx_Negativos.CheckedChanged += new System.EventHandler(this.cbx_Negativos_CheckedChanged);
            // 
            // Grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(986, 545);
            this.Controls.Add(this.cbx_Negativos);
            this.Controls.Add(this.pbx_menos);
            this.Controls.Add(this.pbx_mas);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1002, 584);
            this.Name = "Grafica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafica";
            this.Load += new System.EventHandler(this.Grafica_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_menos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_mas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pbx_menos;
        private System.Windows.Forms.PictureBox pbx_mas;
        private System.Windows.Forms.CheckBox cbx_Negativos;
    }
}