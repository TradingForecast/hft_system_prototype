
namespace DolarLSTM_1_
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxDiaSimulador = new System.Windows.Forms.TextBox();
            this.labelPosicaoAtualStop = new System.Windows.Forms.Label();
            this.labelResumoPosicaoStop = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxStopLoss = new System.Windows.Forms.TextBox();
            this.labelPosicaoComStop = new System.Windows.Forms.Label();
            this.pictureBoxQ2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxQ1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxQ4 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelPosicao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VerResultados = new System.Windows.Forms.Button();
            this.Aplicar = new System.Windows.Forms.Button();
            this.GerarImagem = new System.Windows.Forms.Button();
            this.pictureBoxQ3 = new System.Windows.Forms.PictureBox();
            this.button0 = new System.Windows.Forms.Button();
            this.labelCotacoes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQ4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQ3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            this.chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            this.chart1.BackColor = System.Drawing.Color.Black;
            chartArea6.AlignWithChartArea = "ChartArea1";
            chartArea6.AxisX.LabelStyle.Enabled = false;
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea6.AxisX.MajorGrid.Interval = 60D;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea6.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea6.AxisX.MinorGrid.Interval = 600D;
            chartArea6.AxisX.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea6.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Empty;
            chartArea6.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea6.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea6.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea6.AxisX.ScrollBar.Enabled = false;
            chartArea6.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea6.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea6.AxisX.ScrollBar.Size = 15D;
            chartArea6.AxisY.LabelStyle.Enabled = false;
            chartArea6.AxisY.MajorGrid.Enabled = false;
            chartArea6.AxisY.MajorTickMark.Enabled = false;
            chartArea6.AxisY.MinorGrid.Enabled = true;
            chartArea6.AxisY.MinorGrid.Interval = 1D;
            chartArea6.AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkSlateBlue;
            chartArea6.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea6.AxisY2.MajorGrid.Enabled = false;
            chartArea6.AxisY2.MajorTickMark.Enabled = false;
            chartArea6.AxisY2.MaximumAutoSize = 10F;
            chartArea6.AxisY2.MinorGrid.Interval = 1D;
            chartArea6.BackColor = System.Drawing.Color.Black;
            chartArea6.CursorX.IsUserEnabled = true;
            chartArea6.CursorX.LineColor = System.Drawing.Color.DarkMagenta;
            chartArea6.IsSameFontSizeForAllAxes = true;
            chartArea6.Name = "ChartArea0";
            chartArea7.AlignWithChartArea = "ChartArea0";
            chartArea7.AxisX.LabelStyle.Enabled = false;
            chartArea7.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea7.AxisX.MajorGrid.Interval = 60D;
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea7.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea7.AxisX.MinorGrid.Interval = 600D;
            chartArea7.AxisX.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea7.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Empty;
            chartArea7.AxisX.ScrollBar.Enabled = false;
            chartArea7.AxisY.LabelStyle.Enabled = false;
            chartArea7.AxisY.MajorGrid.Enabled = false;
            chartArea7.AxisY.MajorTickMark.Enabled = false;
            chartArea7.AxisY.MinorGrid.Interval = 0.01D;
            chartArea7.AxisY2.MajorGrid.Enabled = false;
            chartArea7.AxisY2.MajorTickMark.Enabled = false;
            chartArea7.AxisY2.MaximumAutoSize = 10F;
            chartArea7.AxisY2.MinorGrid.Interval = 1D;
            chartArea7.BackColor = System.Drawing.Color.Black;
            chartArea7.CursorX.IsUserEnabled = true;
            chartArea7.CursorX.LineColor = System.Drawing.Color.DarkMagenta;
            chartArea7.IsSameFontSizeForAllAxes = true;
            chartArea7.Name = "ChartArea1";
            chartArea8.AlignWithChartArea = "ChartArea0";
            chartArea8.AxisX.LabelStyle.Enabled = false;
            chartArea8.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea8.AxisX.MajorGrid.Interval = 60D;
            chartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea8.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea8.AxisX.MinorGrid.Interval = 600D;
            chartArea8.AxisX.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea8.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Empty;
            chartArea8.AxisX.ScrollBar.Enabled = false;
            chartArea8.AxisY.LabelStyle.Enabled = false;
            chartArea8.AxisY.MajorGrid.Enabled = false;
            chartArea8.AxisY.MajorTickMark.Enabled = false;
            chartArea8.AxisY.MinorGrid.Interval = 4D;
            chartArea8.AxisY2.MajorGrid.Enabled = false;
            chartArea8.AxisY2.MajorTickMark.Enabled = false;
            chartArea8.AxisY2.MaximumAutoSize = 10F;
            chartArea8.AxisY2.MinorGrid.Interval = 1D;
            chartArea8.BackColor = System.Drawing.Color.Black;
            chartArea8.CursorX.IsUserEnabled = true;
            chartArea8.CursorX.LineColor = System.Drawing.Color.DarkMagenta;
            chartArea8.IsSameFontSizeForAllAxes = true;
            chartArea8.Name = "ChartArea2";
            chartArea9.AlignWithChartArea = "ChartArea0";
            chartArea9.AxisX.LabelStyle.Enabled = false;
            chartArea9.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea9.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea9.AxisX.MajorGrid.Interval = 60D;
            chartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea9.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea9.AxisX.MinorGrid.Interval = 600D;
            chartArea9.AxisX.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea9.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Empty;
            chartArea9.AxisX.ScrollBar.Enabled = false;
            chartArea9.AxisY.LabelStyle.Enabled = false;
            chartArea9.AxisY.MajorGrid.Enabled = false;
            chartArea9.AxisY.MinorGrid.Interval = 1D;
            chartArea9.AxisY2.MajorGrid.Enabled = false;
            chartArea9.AxisY2.MaximumAutoSize = 10F;
            chartArea9.AxisY2.MinorGrid.Interval = 1D;
            chartArea9.BackColor = System.Drawing.Color.Black;
            chartArea9.CursorX.IsUserEnabled = true;
            chartArea9.CursorX.LineColor = System.Drawing.Color.DarkMagenta;
            chartArea9.IsSameFontSizeForAllAxes = true;
            chartArea9.Name = "ChartArea3";
            chartArea10.AlignWithChartArea = "ChartArea0";
            chartArea10.AxisX.LabelStyle.Enabled = false;
            chartArea10.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea10.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea10.AxisX.MajorGrid.Interval = 60D;
            chartArea10.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea10.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea10.AxisX.MinorGrid.Interval = 600D;
            chartArea10.AxisX.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea10.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Empty;
            chartArea10.AxisX.ScrollBar.Enabled = false;
            chartArea10.AxisY.LabelStyle.Enabled = false;
            chartArea10.AxisY.MajorGrid.Enabled = false;
            chartArea10.AxisY.MinorGrid.Interval = 1D;
            chartArea10.AxisY2.MajorGrid.Enabled = false;
            chartArea10.AxisY2.MaximumAutoSize = 10F;
            chartArea10.AxisY2.MinorGrid.Interval = 1D;
            chartArea10.BackColor = System.Drawing.Color.Black;
            chartArea10.CursorX.IsUserEnabled = true;
            chartArea10.CursorX.LineColor = System.Drawing.Color.DarkMagenta;
            chartArea10.IsSameFontSizeForAllAxes = true;
            chartArea10.Name = "ChartArea4";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.ChartAreas.Add(chartArea8);
            this.chart1.ChartAreas.Add(chartArea9);
            this.chart1.ChartAreas.Add(chartArea10);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series11.ChartArea = "ChartArea0";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Color = System.Drawing.Color.Gray;
            series11.EmptyPointStyle.CustomProperties = "LabelStyle=Center";
            series11.Legend = "Legend1";
            series11.Name = "Series0";
            series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series11.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series12.ChartArea = "ChartArea0";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series12.Color = System.Drawing.Color.White;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            series12.YValuesPerPoint = 4;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series13.Color = System.Drawing.Color.White;
            series13.Legend = "Legend1";
            series13.Name = "Series2";
            series13.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series14.Color = System.Drawing.Color.Yellow;
            series14.Legend = "Legend1";
            series14.Name = "Series3";
            series15.ChartArea = "ChartArea2";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series15.Color = System.Drawing.Color.White;
            series15.Legend = "Legend1";
            series15.Name = "Series4";
            series15.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series16.ChartArea = "ChartArea2";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series16.Color = System.Drawing.Color.DimGray;
            series16.Legend = "Legend1";
            series16.Name = "Series5";
            series17.ChartArea = "ChartArea3";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series17.Color = System.Drawing.Color.OrangeRed;
            series17.Legend = "Legend1";
            series17.Name = "Series6";
            series17.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series18.ChartArea = "ChartArea3";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series18.Color = System.Drawing.Color.GreenYellow;
            series18.Legend = "Legend1";
            series18.Name = "Series7";
            series19.ChartArea = "ChartArea4";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series19.Color = System.Drawing.Color.White;
            series19.Legend = "Legend1";
            series19.Name = "Series8";
            series19.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series20.ChartArea = "ChartArea4";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series20.Color = System.Drawing.Color.Magenta;
            series20.Legend = "Legend1";
            series20.Name = "Series9";
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            this.chart1.Series.Add(series17);
            this.chart1.Series.Add(series18);
            this.chart1.Series.Add(series19);
            this.chart1.Series.Add(series20);
            this.chart1.Size = new System.Drawing.Size(715, 233);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelCotacoes);
            this.splitContainer1.Panel1.Controls.Add(this.chart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDiaSimulador);
            this.splitContainer1.Panel2.Controls.Add(this.labelPosicaoAtualStop);
            this.splitContainer1.Panel2.Controls.Add(this.labelResumoPosicaoStop);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxStopLoss);
            this.splitContainer1.Panel2.Controls.Add(this.labelPosicaoComStop);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxQ2);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxQ1);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxQ4);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.labelPosicao);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.VerResultados);
            this.splitContainer1.Panel2.Controls.Add(this.Aplicar);
            this.splitContainer1.Panel2.Controls.Add(this.GerarImagem);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxQ3);
            this.splitContainer1.Panel2.Controls.Add(this.button0);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(715, 638);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 4;
            // 
            // textBoxDiaSimulador
            // 
            this.textBoxDiaSimulador.Location = new System.Drawing.Point(12, 209);
            this.textBoxDiaSimulador.Name = "textBoxDiaSimulador";
            this.textBoxDiaSimulador.Size = new System.Drawing.Size(75, 20);
            this.textBoxDiaSimulador.TabIndex = 29;
            this.textBoxDiaSimulador.Text = "4jan.csv";
            // 
            // labelPosicaoAtualStop
            // 
            this.labelPosicaoAtualStop.AutoSize = true;
            this.labelPosicaoAtualStop.Location = new System.Drawing.Point(12, 370);
            this.labelPosicaoAtualStop.Name = "labelPosicaoAtualStop";
            this.labelPosicaoAtualStop.Size = new System.Drawing.Size(35, 13);
            this.labelPosicaoAtualStop.TabIndex = 28;
            this.labelPosicaoAtualStop.Text = "label5";
            // 
            // labelResumoPosicaoStop
            // 
            this.labelResumoPosicaoStop.AutoSize = true;
            this.labelResumoPosicaoStop.Location = new System.Drawing.Point(12, 350);
            this.labelResumoPosicaoStop.Name = "labelResumoPosicaoStop";
            this.labelResumoPosicaoStop.Size = new System.Drawing.Size(41, 13);
            this.labelResumoPosicaoStop.TabIndex = 27;
            this.labelResumoPosicaoStop.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "StopLoss:";
            // 
            // textBoxStopLoss
            // 
            this.textBoxStopLoss.Location = new System.Drawing.Point(63, 264);
            this.textBoxStopLoss.Name = "textBoxStopLoss";
            this.textBoxStopLoss.Size = new System.Drawing.Size(39, 20);
            this.textBoxStopLoss.TabIndex = 25;
            this.textBoxStopLoss.Text = "10";
            // 
            // labelPosicaoComStop
            // 
            this.labelPosicaoComStop.AutoSize = true;
            this.labelPosicaoComStop.Location = new System.Drawing.Point(593, 17);
            this.labelPosicaoComStop.Name = "labelPosicaoComStop";
            this.labelPosicaoComStop.Size = new System.Drawing.Size(110, 13);
            this.labelPosicaoComStop.TabIndex = 24;
            this.labelPosicaoComStop.Text = "labelPosicaoComStop";
            // 
            // pictureBoxQ2
            // 
            this.pictureBoxQ2.Location = new System.Drawing.Point(213, 98);
            this.pictureBoxQ2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxQ2.Name = "pictureBoxQ2";
            this.pictureBoxQ2.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxQ2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQ2.TabIndex = 23;
            this.pictureBoxQ2.TabStop = false;
            // 
            // pictureBoxQ1
            // 
            this.pictureBoxQ1.Location = new System.Drawing.Point(113, 98);
            this.pictureBoxQ1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxQ1.Name = "pictureBoxQ1";
            this.pictureBoxQ1.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxQ1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQ1.TabIndex = 22;
            this.pictureBoxQ1.TabStop = false;
            // 
            // pictureBoxQ4
            // 
            this.pictureBoxQ4.Location = new System.Drawing.Point(213, 198);
            this.pictureBoxQ4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxQ4.Name = "pictureBoxQ4";
            this.pictureBoxQ4.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxQ4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQ4.TabIndex = 21;
            this.pictureBoxQ4.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Simulador";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "DifMix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "DifDol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "OperacionaisSelecionados:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(333, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // labelPosicao
            // 
            this.labelPosicao.AutoSize = true;
            this.labelPosicao.Location = new System.Drawing.Point(96, 13);
            this.labelPosicao.Name = "labelPosicao";
            this.labelPosicao.Size = new System.Drawing.Size(67, 13);
            this.labelPosicao.TabIndex = 12;
            this.labelPosicao.Text = "labelPosicao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "0 / 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "0 / 0";
            // 
            // VerResultados
            // 
            this.VerResultados.Location = new System.Drawing.Point(12, 164);
            this.VerResultados.Name = "VerResultados";
            this.VerResultados.Size = new System.Drawing.Size(75, 23);
            this.VerResultados.TabIndex = 8;
            this.VerResultados.Text = "Comprar";
            this.VerResultados.UseVisualStyleBackColor = true;
            this.VerResultados.Click += new System.EventHandler(this.VerResultados_Click);
            // 
            // Aplicar
            // 
            this.Aplicar.Location = new System.Drawing.Point(13, 105);
            this.Aplicar.Name = "Aplicar";
            this.Aplicar.Size = new System.Drawing.Size(75, 23);
            this.Aplicar.TabIndex = 7;
            this.Aplicar.Text = "Aplicar";
            this.Aplicar.UseVisualStyleBackColor = true;
            this.Aplicar.Click += new System.EventHandler(this.Aplicar_Click);
            // 
            // GerarImagem
            // 
            this.GerarImagem.Location = new System.Drawing.Point(12, 135);
            this.GerarImagem.Name = "GerarImagem";
            this.GerarImagem.Size = new System.Drawing.Size(75, 23);
            this.GerarImagem.TabIndex = 4;
            this.GerarImagem.Text = "Vender";
            this.GerarImagem.UseVisualStyleBackColor = true;
            this.GerarImagem.Click += new System.EventHandler(this.GerarImagem_Click);
            // 
            // pictureBoxQ3
            // 
            this.pictureBoxQ3.Location = new System.Drawing.Point(113, 198);
            this.pictureBoxQ3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxQ3.Name = "pictureBoxQ3";
            this.pictureBoxQ3.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxQ3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQ3.TabIndex = 3;
            this.pictureBoxQ3.TabStop = false;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(13, 12);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 23);
            this.button0.TabIndex = 2;
            this.button0.Text = "Realtime";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // labelCotacoes
            // 
            this.labelCotacoes.AutoSize = true;
            this.labelCotacoes.BackColor = System.Drawing.Color.Transparent;
            this.labelCotacoes.ForeColor = System.Drawing.Color.White;
            this.labelCotacoes.Location = new System.Drawing.Point(629, 9);
            this.labelCotacoes.Name = "labelCotacoes";
            this.labelCotacoes.Size = new System.Drawing.Size(74, 13);
            this.labelCotacoes.TabIndex = 4;
            this.labelCotacoes.Text = "labelCotacoes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 638);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQ4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQ3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button GerarImagem;
        private System.Windows.Forms.PictureBox pictureBoxQ3;
        private System.Windows.Forms.Button Aplicar;
        private System.Windows.Forms.Button VerResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPosicao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBoxQ2;
        private System.Windows.Forms.PictureBox pictureBoxQ1;
        private System.Windows.Forms.PictureBox pictureBoxQ4;
        private System.Windows.Forms.Label labelPosicaoComStop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxStopLoss;
        private System.Windows.Forms.Label labelResumoPosicaoStop;
        private System.Windows.Forms.Label labelPosicaoAtualStop;
        private System.Windows.Forms.TextBox textBoxDiaSimulador;
        private System.Windows.Forms.Label labelCotacoes;
    }
}

