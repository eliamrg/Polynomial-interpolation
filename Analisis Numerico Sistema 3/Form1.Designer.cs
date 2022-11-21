namespace Analisis_Numerico_Sistema_3
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_solucion = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_x = new System.Windows.Forms.NumericUpDown();
            this.rtb_proceso = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_zoom = new System.Windows.Forms.PictureBox();
            this.pbx_Evaluacion = new System.Windows.Forms.PictureBox();
            this.pbx_Ecuacion = new System.Windows.Forms.PictureBox();
            this.pbx_menos = new System.Windows.Forms.PictureBox();
            this.pbx_mas = new System.Windows.Forms.PictureBox();
            this.px_info = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_solucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Evaluacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Ecuacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_menos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_mas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.px_info)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.px_info);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 60);
            this.panel1.TabIndex = 22;
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
            this.label4.Size = new System.Drawing.Size(631, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Análisis Numérico Sistema 3 - Método de interpolación unico";
            // 
            // dgv_solucion
            // 
            this.dgv_solucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_solucion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgv_solucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_solucion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_solucion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_solucion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_solucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_solucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_solucion.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_solucion.Location = new System.Drawing.Point(23, 140);
            this.dgv_solucion.Name = "dgv_solucion";
            this.dgv_solucion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_solucion.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_solucion.RowHeadersVisible = false;
            this.dgv_solucion.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Format = "N4";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_solucion.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_solucion.RowTemplate.Height = 28;
            this.dgv_solucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_solucion.Size = new System.Drawing.Size(254, 313);
            this.dgv_solucion.TabIndex = 23;
            this.dgv_solucion.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_solucion_CellValidating);
            // 
            // x
            // 
            this.x.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "N4";
            dataGridViewCellStyle2.NullValue = null;
            this.x.DefaultCellStyle = dataGridViewCellStyle2;
            this.x.HeaderText = "x";
            this.x.MinimumWidth = 8;
            this.x.Name = "x";
            this.x.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // y
            // 
            this.y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "N4";
            dataGridViewCellStyle3.NullValue = null;
            this.y.DefaultCellStyle = dataGridViewCellStyle3;
            this.y.HeaderText = "y";
            this.y.MinimumWidth = 8;
            this.y.Name = "y";
            // 
            // num_x
            // 
            this.num_x.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_x.DecimalPlaces = 4;
            this.num_x.Location = new System.Drawing.Point(158, 94);
            this.num_x.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_x.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_x.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_x.Name = "num_x";
            this.num_x.Size = new System.Drawing.Size(108, 25);
            this.num_x.TabIndex = 25;
            // 
            // rtb_proceso
            // 
            this.rtb_proceso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_proceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.rtb_proceso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_proceso.ForeColor = System.Drawing.Color.White;
            this.rtb_proceso.Location = new System.Drawing.Point(859, 140);
            this.rtb_proceso.Name = "rtb_proceso";
            this.rtb_proceso.ReadOnly = true;
            this.rtb_proceso.Size = new System.Drawing.Size(271, 242);
            this.rtb_proceso.TabIndex = 27;
            this.rtb_proceso.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(855, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Proceso:";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.ForeColor = System.Drawing.Color.Black;
            this.btn_limpiar.Location = new System.Drawing.Point(909, 552);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(200, 31);
            this.btn_limpiar.TabIndex = 30;
            this.btn_limpiar.Text = "Limpiar datos";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "NOTA: No se pueden repetir valores de x en la tabla";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_calcular.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_calcular.FlatAppearance.BorderSize = 0;
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.ForeColor = System.Drawing.Color.Black;
            this.btn_calcular.Location = new System.Drawing.Point(23, 552);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(200, 31);
            this.btn_calcular.TabIndex = 28;
            this.btn_calcular.Text = "Calcular solución";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Evaluar f(x); x=";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(855, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Resultado de la Evaluación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(327, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Función:";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.chart1.Location = new System.Drawing.Point(331, 228);
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
            this.chart1.Size = new System.Drawing.Size(519, 269);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // btn_zoom
            // 
            this.btn_zoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_zoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_zoom.Enabled = false;
            this.btn_zoom.Image = global::Analisis_Numerico_Sistema_3.Properties.Resources.loupe;
            this.btn_zoom.Location = new System.Drawing.Point(331, 467);
            this.btn_zoom.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btn_zoom.Name = "btn_zoom";
            this.btn_zoom.Size = new System.Drawing.Size(30, 30);
            this.btn_zoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_zoom.TabIndex = 42;
            this.btn_zoom.TabStop = false;
            this.btn_zoom.Click += new System.EventHandler(this.btn_zoom_Click);
            // 
            // pbx_Evaluacion
            // 
            this.pbx_Evaluacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_Evaluacion.BackColor = System.Drawing.Color.White;
            this.pbx_Evaluacion.Location = new System.Drawing.Point(859, 418);
            this.pbx_Evaluacion.Margin = new System.Windows.Forms.Padding(6);
            this.pbx_Evaluacion.Name = "pbx_Evaluacion";
            this.pbx_Evaluacion.Size = new System.Drawing.Size(273, 79);
            this.pbx_Evaluacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Evaluacion.TabIndex = 40;
            this.pbx_Evaluacion.TabStop = false;
            // 
            // pbx_Ecuacion
            // 
            this.pbx_Ecuacion.BackColor = System.Drawing.Color.White;
            this.pbx_Ecuacion.Location = new System.Drawing.Point(331, 140);
            this.pbx_Ecuacion.Margin = new System.Windows.Forms.Padding(6);
            this.pbx_Ecuacion.Name = "pbx_Ecuacion";
            this.pbx_Ecuacion.Size = new System.Drawing.Size(519, 79);
            this.pbx_Ecuacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Ecuacion.TabIndex = 37;
            this.pbx_Ecuacion.TabStop = false;
            // 
            // pbx_menos
            // 
            this.pbx_menos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_menos.Image = global::Analisis_Numerico_Sistema_3.Properties.Resources.minus_3_;
            this.pbx_menos.Location = new System.Drawing.Point(289, 177);
            this.pbx_menos.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pbx_menos.Name = "pbx_menos";
            this.pbx_menos.Size = new System.Drawing.Size(30, 30);
            this.pbx_menos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_menos.TabIndex = 33;
            this.pbx_menos.TabStop = false;
            this.pbx_menos.Click += new System.EventHandler(this.pbx_menos_Click);
            // 
            // pbx_mas
            // 
            this.pbx_mas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_mas.Image = global::Analisis_Numerico_Sistema_3.Properties.Resources.plus__3_;
            this.pbx_mas.Location = new System.Drawing.Point(289, 139);
            this.pbx_mas.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pbx_mas.Name = "pbx_mas";
            this.pbx_mas.Size = new System.Drawing.Size(30, 30);
            this.pbx_mas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_mas.TabIndex = 32;
            this.pbx_mas.TabStop = false;
            this.pbx_mas.Click += new System.EventHandler(this.pbx_mas_Click);
            // 
            // px_info
            // 
            this.px_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.px_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.px_info.Image = global::Analisis_Numerico_Sistema_3.Properties.Resources.info_120px;
            this.px_info.Location = new System.Drawing.Point(1084, 10);
            this.px_info.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.px_info.Name = "px_info";
            this.px_info.Size = new System.Drawing.Size(40, 40);
            this.px_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.px_info.TabIndex = 12;
            this.px_info.TabStop = false;
            this.px_info.Click += new System.EventHandler(this.px_info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1142, 595);
            this.Controls.Add(this.btn_zoom);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbx_Evaluacion);
            this.Controls.Add(this.pbx_Ecuacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbx_menos);
            this.Controls.Add(this.pbx_mas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.rtb_proceso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_x);
            this.Controls.Add(this.dgv_solucion);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1158, 634);
            this.Name = "Form1";
            this.Text = "Ramirez Garcia, Sanchez Carrillo, Perez Garza";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_solucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Evaluacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Ecuacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_menos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_mas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.px_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox px_info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_solucion;
        private System.Windows.Forms.NumericUpDown num_x;
        private System.Windows.Forms.RichTextBox rtb_proceso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbx_mas;
        private System.Windows.Forms.PictureBox pbx_menos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.PictureBox pbx_Ecuacion;
        private System.Windows.Forms.PictureBox pbx_Evaluacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox btn_zoom;
    }
}

