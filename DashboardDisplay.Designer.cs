namespace Dash4572
{
    partial class DashboardDisplay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.distanceToTargetTextBox = new System.Windows.Forms.TextBox();
            this.angleToTargetTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.visionProcessingTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.luminocityUpperUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.luminocityLowerUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.saturationUpperUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.saturationLowerUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hueUpperUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.hueLowerUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.brightnessUpDown = new System.Windows.Forms.NumericUpDown();
            this.saturationUpDown = new System.Windows.Forms.NumericUpDown();
            this.autoExposureCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gammaUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contrastUpDown = new System.Windows.Forms.NumericUpDown();
            this.exposureUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.frameRateTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.performanceTab = new System.Windows.Forms.TabPage();
            this.roboRioProcessingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.shooterTab = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.videoPanel = new Dash4572.DoubleBufferedPanel();
            this.drivePanel = new Dash4572.DoubleBufferedPanel();
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.visionProcessingTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luminocityUpperUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luminocityLowerUpDown)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saturationUpperUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationLowerUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hueUpperUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueLowerUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposureUpDown)).BeginInit();
            this.performanceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roboRioProcessingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.visionProcessingTab);
            this.tabControl1.Controls.Add(this.performanceTab);
            this.tabControl1.Controls.Add(this.shooterTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1137, 647);
            this.tabControl1.TabIndex = 2;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.distanceToTargetTextBox);
            this.mainTab.Controls.Add(this.angleToTargetTextBox);
            this.mainTab.Controls.Add(this.label4);
            this.mainTab.Controls.Add(this.videoPanel);
            this.mainTab.Controls.Add(this.label3);
            this.mainTab.Controls.Add(this.drivePanel);
            this.mainTab.Location = new System.Drawing.Point(4, 22);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(1129, 621);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // distanceToTargetTextBox
            // 
            this.distanceToTargetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceToTargetTextBox.Location = new System.Drawing.Point(163, 545);
            this.distanceToTargetTextBox.Name = "distanceToTargetTextBox";
            this.distanceToTargetTextBox.ReadOnly = true;
            this.distanceToTargetTextBox.Size = new System.Drawing.Size(156, 26);
            this.distanceToTargetTextBox.TabIndex = 22;
            // 
            // angleToTargetTextBox
            // 
            this.angleToTargetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angleToTargetTextBox.Location = new System.Drawing.Point(163, 510);
            this.angleToTargetTextBox.Name = "angleToTargetTextBox";
            this.angleToTargetTextBox.ReadOnly = true;
            this.angleToTargetTextBox.Size = new System.Drawing.Size(156, 26);
            this.angleToTargetTextBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Distance to Target";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Angle To Target";
            // 
            // visionProcessingTab
            // 
            this.visionProcessingTab.Controls.Add(this.groupBox1);
            this.visionProcessingTab.Controls.Add(this.frameRateTextBox);
            this.visionProcessingTab.Controls.Add(this.label14);
            this.visionProcessingTab.Location = new System.Drawing.Point(4, 22);
            this.visionProcessingTab.Name = "visionProcessingTab";
            this.visionProcessingTab.Size = new System.Drawing.Size(1129, 621);
            this.visionProcessingTab.TabIndex = 1;
            this.visionProcessingTab.Text = "Vision Processing";
            this.visionProcessingTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 369);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Powerport Video Processing";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(237, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 322);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Target Pipeline Settings";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.luminocityUpperUpDown);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.luminocityLowerUpDown);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(15, 211);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(187, 84);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Luminance";
            // 
            // luminocityUpperUpDown
            // 
            this.luminocityUpperUpDown.Location = new System.Drawing.Point(49, 43);
            this.luminocityUpperUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.luminocityUpperUpDown.Name = "luminocityUpperUpDown";
            this.luminocityUpperUpDown.Size = new System.Drawing.Size(120, 20);
            this.luminocityUpperUpDown.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Upper";
            // 
            // luminocityLowerUpDown
            // 
            this.luminocityLowerUpDown.Location = new System.Drawing.Point(49, 17);
            this.luminocityLowerUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.luminocityLowerUpDown.Name = "luminocityLowerUpDown";
            this.luminocityLowerUpDown.Size = new System.Drawing.Size(120, 20);
            this.luminocityLowerUpDown.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Lower";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.saturationUpperUpDown);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.saturationLowerUpDown);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(15, 121);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(187, 84);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Saturation";
            // 
            // saturationUpperUpDown
            // 
            this.saturationUpperUpDown.Location = new System.Drawing.Point(49, 43);
            this.saturationUpperUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.saturationUpperUpDown.Name = "saturationUpperUpDown";
            this.saturationUpperUpDown.Size = new System.Drawing.Size(120, 20);
            this.saturationUpperUpDown.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Upper";
            // 
            // saturationLowerUpDown
            // 
            this.saturationLowerUpDown.Location = new System.Drawing.Point(49, 17);
            this.saturationLowerUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.saturationLowerUpDown.Name = "saturationLowerUpDown";
            this.saturationLowerUpDown.Size = new System.Drawing.Size(120, 20);
            this.saturationLowerUpDown.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Lower";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.hueUpperUpDown);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.hueLowerUpDown);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(15, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 84);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hue";
            // 
            // hueUpperUpDown
            // 
            this.hueUpperUpDown.Location = new System.Drawing.Point(49, 43);
            this.hueUpperUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.hueUpperUpDown.Name = "hueUpperUpDown";
            this.hueUpperUpDown.Size = new System.Drawing.Size(120, 20);
            this.hueUpperUpDown.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Upper";
            // 
            // hueLowerUpDown
            // 
            this.hueLowerUpDown.Location = new System.Drawing.Point(49, 17);
            this.hueLowerUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.hueLowerUpDown.Name = "hueLowerUpDown";
            this.hueLowerUpDown.Size = new System.Drawing.Size(120, 20);
            this.hueLowerUpDown.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lower";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.brightnessUpDown);
            this.groupBox2.Controls.Add(this.saturationUpDown);
            this.groupBox2.Controls.Add(this.autoExposureCheckBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.gammaUpDown);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.contrastUpDown);
            this.groupBox2.Controls.Add(this.exposureUpDown);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 322);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Realsense Camera Settings";
            // 
            // brightnessUpDown
            // 
            this.brightnessUpDown.Location = new System.Drawing.Point(73, 64);
            this.brightnessUpDown.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.brightnessUpDown.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            -2147483648});
            this.brightnessUpDown.Name = "brightnessUpDown";
            this.brightnessUpDown.Size = new System.Drawing.Size(120, 20);
            this.brightnessUpDown.TabIndex = 16;
            // 
            // saturationUpDown
            // 
            this.saturationUpDown.Location = new System.Drawing.Point(73, 240);
            this.saturationUpDown.Name = "saturationUpDown";
            this.saturationUpDown.Size = new System.Drawing.Size(120, 20);
            this.saturationUpDown.TabIndex = 24;
            // 
            // autoExposureCheckBox
            // 
            this.autoExposureCheckBox.AutoSize = true;
            this.autoExposureCheckBox.Location = new System.Drawing.Point(13, 30);
            this.autoExposureCheckBox.Name = "autoExposureCheckBox";
            this.autoExposureCheckBox.Size = new System.Drawing.Size(95, 17);
            this.autoExposureCheckBox.TabIndex = 0;
            this.autoExposureCheckBox.Text = "Auto Exposure";
            this.autoExposureCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Saturation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brightness";
            // 
            // gammaUpDown
            // 
            this.gammaUpDown.Location = new System.Drawing.Point(73, 198);
            this.gammaUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.gammaUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.gammaUpDown.Name = "gammaUpDown";
            this.gammaUpDown.Size = new System.Drawing.Size(120, 20);
            this.gammaUpDown.TabIndex = 22;
            this.gammaUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contrast";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Gamma";
            // 
            // contrastUpDown
            // 
            this.contrastUpDown.Location = new System.Drawing.Point(73, 109);
            this.contrastUpDown.Name = "contrastUpDown";
            this.contrastUpDown.Size = new System.Drawing.Size(120, 20);
            this.contrastUpDown.TabIndex = 18;
            // 
            // exposureUpDown
            // 
            this.exposureUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.exposureUpDown.Location = new System.Drawing.Point(73, 155);
            this.exposureUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.exposureUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.exposureUpDown.Name = "exposureUpDown";
            this.exposureUpDown.Size = new System.Drawing.Size(120, 20);
            this.exposureUpDown.TabIndex = 20;
            this.exposureUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Exposure";
            // 
            // frameRateTextBox
            // 
            this.frameRateTextBox.Location = new System.Drawing.Point(76, 391);
            this.frameRateTextBox.Name = "frameRateTextBox";
            this.frameRateTextBox.ReadOnly = true;
            this.frameRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.frameRateTextBox.TabIndex = 32;
            this.frameRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 394);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Frame Rate";
            // 
            // performanceTab
            // 
            this.performanceTab.Controls.Add(this.roboRioProcessingChart);
            this.performanceTab.Location = new System.Drawing.Point(4, 22);
            this.performanceTab.Name = "performanceTab";
            this.performanceTab.Size = new System.Drawing.Size(1129, 621);
            this.performanceTab.TabIndex = 2;
            this.performanceTab.Text = "Performance";
            this.performanceTab.UseVisualStyleBackColor = true;
            // 
            // roboRioProcessingChart
            // 
            chartArea1.Name = "ChartArea1";
            this.roboRioProcessingChart.ChartAreas.Add(chartArea1);
            this.roboRioProcessingChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.roboRioProcessingChart.Legends.Add(legend1);
            this.roboRioProcessingChart.Location = new System.Drawing.Point(0, 0);
            this.roboRioProcessingChart.Name = "roboRioProcessingChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Frame Time";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Loop Time";
            this.roboRioProcessingChart.Series.Add(series1);
            this.roboRioProcessingChart.Series.Add(series2);
            this.roboRioProcessingChart.Size = new System.Drawing.Size(1129, 621);
            this.roboRioProcessingChart.TabIndex = 0;
            this.roboRioProcessingChart.Text = "Robo-Rio Processing Rate";
            // 
            // shooterTab
            // 
            this.shooterTab.Location = new System.Drawing.Point(4, 22);
            this.shooterTab.Name = "shooterTab";
            this.shooterTab.Size = new System.Drawing.Size(1129, 621);
            this.shooterTab.TabIndex = 3;
            this.shooterTab.Text = "Shooter Parameters";
            this.shooterTab.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // videoPanel
            // 
            this.videoPanel.BackColor = System.Drawing.Color.Black;
            this.videoPanel.Location = new System.Drawing.Point(469, 70);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(640, 360);
            this.videoPanel.TabIndex = 24;
            this.videoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.videoPanel_Paint);
            // 
            // drivePanel
            // 
            this.drivePanel.Location = new System.Drawing.Point(21, 29);
            this.drivePanel.Name = "drivePanel";
            this.drivePanel.Size = new System.Drawing.Size(426, 468);
            this.drivePanel.TabIndex = 16;
            // 
            // DashboardDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 647);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashboardDisplay";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardDisplay_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.visionProcessingTab.ResumeLayout(false);
            this.visionProcessingTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luminocityUpperUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luminocityLowerUpDown)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saturationUpperUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationLowerUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hueUpperUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueLowerUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposureUpDown)).EndInit();
            this.performanceTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roboRioProcessingChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private DoubleBufferedPanel drivePanel;
        private System.Windows.Forms.TextBox distanceToTargetTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox angleToTargetTextBox;
        private System.Windows.Forms.Label label3;
        private DoubleBufferedPanel videoPanel;
        private System.Windows.Forms.TabPage visionProcessingTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown luminocityUpperUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown luminocityLowerUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown saturationUpperUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown saturationLowerUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown hueUpperUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown hueLowerUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown brightnessUpDown;
        private System.Windows.Forms.NumericUpDown saturationUpDown;
        private System.Windows.Forms.CheckBox autoExposureCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown gammaUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown contrastUpDown;
        private System.Windows.Forms.NumericUpDown exposureUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox frameRateTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage performanceTab;
        private System.Windows.Forms.TabPage shooterTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart roboRioProcessingChart;
    }
}

