namespace FlightSimulation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boxHeight = new System.Windows.Forms.NumericUpDown();
            this.boxSpeed = new System.Windows.Forms.NumericUpDown();
            this.boxAngle = new System.Windows.Forms.NumericUpDown();
            this.boxWeight = new System.Windows.Forms.NumericUpDown();
            this.boxSize = new System.Windows.Forms.NumericUpDown();
            this.boxStep = new System.Windows.Forms.NumericUpDown();
            this.btClear = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.EndSpeed5 = new System.Windows.Forms.TextBox();
            this.MH5 = new System.Windows.Forms.TextBox();
            this.Distance5 = new System.Windows.Forms.TextBox();
            this.TimeStep5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EndSpeed4 = new System.Windows.Forms.TextBox();
            this.MH4 = new System.Windows.Forms.TextBox();
            this.Distance4 = new System.Windows.Forms.TextBox();
            this.TimeStep4 = new System.Windows.Forms.TextBox();
            this.EndSpeed3 = new System.Windows.Forms.TextBox();
            this.MH3 = new System.Windows.Forms.TextBox();
            this.Distance3 = new System.Windows.Forms.TextBox();
            this.TimeStep3 = new System.Windows.Forms.TextBox();
            this.EndSpeed2 = new System.Windows.Forms.TextBox();
            this.MH2 = new System.Windows.Forms.TextBox();
            this.Distance2 = new System.Windows.Forms.TextBox();
            this.TimeStep2 = new System.Windows.Forms.TextBox();
            this.EndSpeed1 = new System.Windows.Forms.TextBox();
            this.MH1 = new System.Windows.Forms.TextBox();
            this.Distance1 = new System.Windows.Forms.TextBox();
            this.TimeStep1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.boxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speed";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Angle";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weight";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Step";
            // 
            // boxHeight
            // 
            this.boxHeight.Location = new System.Drawing.Point(53, 5);
            this.boxHeight.Name = "boxHeight";
            this.boxHeight.Size = new System.Drawing.Size(120, 20);
            this.boxHeight.TabIndex = 6;
            // 
            // boxSpeed
            // 
            this.boxSpeed.Location = new System.Drawing.Point(53, 29);
            this.boxSpeed.Name = "boxSpeed";
            this.boxSpeed.Size = new System.Drawing.Size(120, 20);
            this.boxSpeed.TabIndex = 7;
            this.boxSpeed.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // boxAngle
            // 
            this.boxAngle.Location = new System.Drawing.Point(53, 52);
            this.boxAngle.Name = "boxAngle";
            this.boxAngle.Size = new System.Drawing.Size(120, 20);
            this.boxAngle.TabIndex = 8;
            this.boxAngle.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // boxWeight
            // 
            this.boxWeight.Location = new System.Drawing.Point(53, 74);
            this.boxWeight.Name = "boxWeight";
            this.boxWeight.Size = new System.Drawing.Size(120, 20);
            this.boxWeight.TabIndex = 9;
            this.boxWeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // boxSize
            // 
            this.boxSize.Location = new System.Drawing.Point(53, 98);
            this.boxSize.Name = "boxSize";
            this.boxSize.Size = new System.Drawing.Size(120, 20);
            this.boxSize.TabIndex = 10;
            this.boxSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // boxStep
            // 
            this.boxStep.Location = new System.Drawing.Point(53, 121);
            this.boxStep.Name = "boxStep";
            this.boxStep.Size = new System.Drawing.Size(120, 20);
            this.boxStep.TabIndex = 11;
            this.boxStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(103, 147);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(88, 40);
            this.btClear.TabIndex = 13;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(9, 147);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(88, 40);
            this.btStart.TabIndex = 14;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 25D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 190);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Legend = "Legend1";
            series5.Name = "Series5";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(853, 456);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.EndSpeed5);
            this.panel1.Controls.Add(this.MH5);
            this.panel1.Controls.Add(this.Distance5);
            this.panel1.Controls.Add(this.TimeStep5);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.EndSpeed4);
            this.panel1.Controls.Add(this.MH4);
            this.panel1.Controls.Add(this.Distance4);
            this.panel1.Controls.Add(this.TimeStep4);
            this.panel1.Controls.Add(this.EndSpeed3);
            this.panel1.Controls.Add(this.MH3);
            this.panel1.Controls.Add(this.Distance3);
            this.panel1.Controls.Add(this.TimeStep3);
            this.panel1.Controls.Add(this.EndSpeed2);
            this.panel1.Controls.Add(this.MH2);
            this.panel1.Controls.Add(this.Distance2);
            this.panel1.Controls.Add(this.TimeStep2);
            this.panel1.Controls.Add(this.EndSpeed1);
            this.panel1.Controls.Add(this.MH1);
            this.panel1.Controls.Add(this.Distance1);
            this.panel1.Controls.Add(this.TimeStep1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.boxAngle);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.boxStep);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.boxSize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.boxWeight);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.boxHeight);
            this.panel1.Controls.Add(this.boxSpeed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 194);
            this.panel1.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(921, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "[5]";
            // 
            // EndSpeed5
            // 
            this.EndSpeed5.Location = new System.Drawing.Point(881, 96);
            this.EndSpeed5.Name = "EndSpeed5";
            this.EndSpeed5.Size = new System.Drawing.Size(100, 20);
            this.EndSpeed5.TabIndex = 43;
            // 
            // MH5
            // 
            this.MH5.Location = new System.Drawing.Point(881, 75);
            this.MH5.Name = "MH5";
            this.MH5.Size = new System.Drawing.Size(100, 20);
            this.MH5.TabIndex = 42;
            // 
            // Distance5
            // 
            this.Distance5.Location = new System.Drawing.Point(881, 52);
            this.Distance5.Name = "Distance5";
            this.Distance5.Size = new System.Drawing.Size(100, 20);
            this.Distance5.TabIndex = 41;
            // 
            // TimeStep5
            // 
            this.TimeStep5.Location = new System.Drawing.Point(881, 30);
            this.TimeStep5.Name = "TimeStep5";
            this.TimeStep5.Size = new System.Drawing.Size(100, 20);
            this.TimeStep5.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(805, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "[4]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(688, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "[3]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(577, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "[2]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(450, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "[1]";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // EndSpeed4
            // 
            this.EndSpeed4.Location = new System.Drawing.Point(765, 96);
            this.EndSpeed4.Name = "EndSpeed4";
            this.EndSpeed4.Size = new System.Drawing.Size(100, 20);
            this.EndSpeed4.TabIndex = 36;
            // 
            // MH4
            // 
            this.MH4.Location = new System.Drawing.Point(765, 75);
            this.MH4.Name = "MH4";
            this.MH4.Size = new System.Drawing.Size(100, 20);
            this.MH4.TabIndex = 35;
            // 
            // Distance4
            // 
            this.Distance4.Location = new System.Drawing.Point(765, 52);
            this.Distance4.Name = "Distance4";
            this.Distance4.Size = new System.Drawing.Size(100, 20);
            this.Distance4.TabIndex = 34;
            // 
            // TimeStep4
            // 
            this.TimeStep4.Location = new System.Drawing.Point(765, 30);
            this.TimeStep4.Name = "TimeStep4";
            this.TimeStep4.Size = new System.Drawing.Size(100, 20);
            this.TimeStep4.TabIndex = 33;
            // 
            // EndSpeed3
            // 
            this.EndSpeed3.Location = new System.Drawing.Point(652, 95);
            this.EndSpeed3.Name = "EndSpeed3";
            this.EndSpeed3.Size = new System.Drawing.Size(100, 20);
            this.EndSpeed3.TabIndex = 32;
            // 
            // MH3
            // 
            this.MH3.Location = new System.Drawing.Point(652, 74);
            this.MH3.Name = "MH3";
            this.MH3.Size = new System.Drawing.Size(100, 20);
            this.MH3.TabIndex = 31;
            // 
            // Distance3
            // 
            this.Distance3.Location = new System.Drawing.Point(652, 51);
            this.Distance3.Name = "Distance3";
            this.Distance3.Size = new System.Drawing.Size(100, 20);
            this.Distance3.TabIndex = 30;
            // 
            // TimeStep3
            // 
            this.TimeStep3.Location = new System.Drawing.Point(652, 29);
            this.TimeStep3.Name = "TimeStep3";
            this.TimeStep3.Size = new System.Drawing.Size(100, 20);
            this.TimeStep3.TabIndex = 29;
            // 
            // EndSpeed2
            // 
            this.EndSpeed2.Location = new System.Drawing.Point(536, 95);
            this.EndSpeed2.Name = "EndSpeed2";
            this.EndSpeed2.Size = new System.Drawing.Size(100, 20);
            this.EndSpeed2.TabIndex = 28;
            // 
            // MH2
            // 
            this.MH2.Location = new System.Drawing.Point(536, 74);
            this.MH2.Name = "MH2";
            this.MH2.Size = new System.Drawing.Size(100, 20);
            this.MH2.TabIndex = 27;
            // 
            // Distance2
            // 
            this.Distance2.Location = new System.Drawing.Point(536, 51);
            this.Distance2.Name = "Distance2";
            this.Distance2.Size = new System.Drawing.Size(100, 20);
            this.Distance2.TabIndex = 26;
            // 
            // TimeStep2
            // 
            this.TimeStep2.Location = new System.Drawing.Point(536, 29);
            this.TimeStep2.Name = "TimeStep2";
            this.TimeStep2.Size = new System.Drawing.Size(100, 20);
            this.TimeStep2.TabIndex = 25;
            // 
            // EndSpeed1
            // 
            this.EndSpeed1.Location = new System.Drawing.Point(418, 95);
            this.EndSpeed1.Name = "EndSpeed1";
            this.EndSpeed1.Size = new System.Drawing.Size(100, 20);
            this.EndSpeed1.TabIndex = 24;
            // 
            // MH1
            // 
            this.MH1.Location = new System.Drawing.Point(418, 74);
            this.MH1.Name = "MH1";
            this.MH1.Size = new System.Drawing.Size(100, 20);
            this.MH1.TabIndex = 23;
            // 
            // Distance1
            // 
            this.Distance1.Location = new System.Drawing.Point(418, 51);
            this.Distance1.Name = "Distance1";
            this.Distance1.Size = new System.Drawing.Size(100, 20);
            this.Distance1.TabIndex = 22;
            // 
            // TimeStep1
            // 
            this.TimeStep1.Location = new System.Drawing.Point(418, 29);
            this.TimeStep1.Name = "TimeStep1";
            this.TimeStep1.Size = new System.Drawing.Size(100, 20);
            this.TimeStep1.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "MaxHeight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "SpeedAtTheEndPoint";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Distance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "TimeStep";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown boxHeight;
        private System.Windows.Forms.NumericUpDown boxSpeed;
        private System.Windows.Forms.NumericUpDown boxAngle;
        private System.Windows.Forms.NumericUpDown boxWeight;
        private System.Windows.Forms.NumericUpDown boxSize;
        private System.Windows.Forms.NumericUpDown boxStep;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EndSpeed4;
        private System.Windows.Forms.TextBox MH4;
        private System.Windows.Forms.TextBox Distance4;
        private System.Windows.Forms.TextBox TimeStep4;
        private System.Windows.Forms.TextBox EndSpeed3;
        private System.Windows.Forms.TextBox MH3;
        private System.Windows.Forms.TextBox Distance3;
        private System.Windows.Forms.TextBox TimeStep3;
        private System.Windows.Forms.TextBox EndSpeed2;
        private System.Windows.Forms.TextBox MH2;
        private System.Windows.Forms.TextBox Distance2;
        private System.Windows.Forms.TextBox TimeStep2;
        private System.Windows.Forms.TextBox EndSpeed1;
        private System.Windows.Forms.TextBox MH1;
        private System.Windows.Forms.TextBox Distance1;
        private System.Windows.Forms.TextBox TimeStep1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox EndSpeed5;
        private System.Windows.Forms.TextBox MH5;
        private System.Windows.Forms.TextBox Distance5;
        private System.Windows.Forms.TextBox TimeStep5;
    }
}

