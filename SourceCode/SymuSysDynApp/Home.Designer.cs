﻿namespace SymuSysDynApp
{
    partial class Home
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries4 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo4 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo2 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries5 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo5 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries6 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo6 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbResults = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStop = new System.Windows.Forms.TextBox();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbDt = new System.Windows.Forms.TextBox();
            this.Simulation = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPause = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbGroups = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.tbEquation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbVariables = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbOptimized = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.Simulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Open xmile File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbResults
            // 
            this.cbResults.Enabled = false;
            this.cbResults.FormattingEnabled = true;
            this.cbResults.Location = new System.Drawing.Point(124, 160);
            this.cbResults.Name = "cbResults";
            this.cbResults.Size = new System.Drawing.Size(206, 24);
            this.cbResults.TabIndex = 4;
            this.cbResults.SelectedIndexChanged += new System.EventHandler(this.cbVariables_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Results";
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "[none]";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(548, 81);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(846, 211);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            chartSeries4.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries4.Name = "Default0";
            chartSeries4.Resolution = 0D;
            chartSeries4.StackingGroup = "Default Group";
            chartSeries4.Style.AltTagFormat = "";
            chartSeries4.Style.Border.Width = 2F;
            chartSeries4.Style.DisplayShadow = true;
            chartSeries4.Style.DrawTextShape = false;
            chartLineInfo2.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo2.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo2.DashPattern = null;
            chartLineInfo2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo2.Width = 1F;
            chartCustomShapeInfo4.Border = chartLineInfo2;
            chartCustomShapeInfo4.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo4.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries4.Style.TextShape = chartCustomShapeInfo4;
            chartSeries4.Text = "Default0";
            chartSeries4.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Spline;
            chartSeries5.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries5.Name = "Default1";
            chartSeries5.Resolution = 0D;
            chartSeries5.StackingGroup = "Default Group";
            chartSeries5.Style.AltTagFormat = "";
            chartSeries5.Style.Border.Width = 2F;
            chartSeries5.Style.DisplayShadow = true;
            chartSeries5.Style.DrawTextShape = false;
            chartCustomShapeInfo5.Border = chartLineInfo2;
            chartCustomShapeInfo5.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo5.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries5.Style.TextShape = chartCustomShapeInfo5;
            chartSeries5.Text = "Default1";
            chartSeries5.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Spline;
            chartSeries6.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries6.Name = "Default2";
            chartSeries6.Resolution = 0D;
            chartSeries6.StackingGroup = "Default Group";
            chartSeries6.Style.AltTagFormat = "";
            chartSeries6.Style.Border.Width = 2F;
            chartSeries6.Style.DisplayShadow = true;
            chartSeries6.Style.DrawTextShape = false;
            chartCustomShapeInfo6.Border = chartLineInfo2;
            chartCustomShapeInfo6.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo6.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries6.Style.TextShape = chartCustomShapeInfo6;
            chartSeries6.Text = "Default2";
            chartSeries6.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Spline;
            this.chartControl1.Series.Add(chartSeries4);
            this.chartControl1.Series.Add(chartSeries5);
            this.chartControl1.Series.Add(chartSeries6);
            this.chartControl1.Size = new System.Drawing.Size(671, 480);
            this.chartControl1.TabIndex = 6;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.VisualTheme = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Delta time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stop";
            // 
            // tbStop
            // 
            this.tbStop.Location = new System.Drawing.Point(109, 44);
            this.tbStop.Name = "tbStop";
            this.tbStop.Size = new System.Drawing.Size(47, 22);
            this.tbStop.TabIndex = 10;
            this.tbStop.TextChanged += new System.EventHandler(this.tbStop_TextChanged);
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(109, 19);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(47, 22);
            this.tbStart.TabIndex = 11;
            this.tbStart.TextChanged += new System.EventHandler(this.tbStart_TextChanged);
            // 
            // tbDt
            // 
            this.tbDt.Location = new System.Drawing.Point(109, 69);
            this.tbDt.Name = "tbDt";
            this.tbDt.Size = new System.Drawing.Size(47, 22);
            this.tbDt.TabIndex = 12;
            this.tbDt.TextChanged += new System.EventHandler(this.tbDt_TextChanged);
            // 
            // Simulation
            // 
            this.Simulation.Controls.Add(this.btnClear);
            this.Simulation.Controls.Add(this.cbOptimized);
            this.Simulation.Controls.Add(this.lblTime);
            this.Simulation.Controls.Add(this.label6);
            this.Simulation.Controls.Add(this.tbPause);
            this.Simulation.Controls.Add(this.label5);
            this.Simulation.Controls.Add(this.tbStart);
            this.Simulation.Controls.Add(this.tbDt);
            this.Simulation.Controls.Add(this.label3);
            this.Simulation.Controls.Add(this.label1);
            this.Simulation.Controls.Add(this.label2);
            this.Simulation.Controls.Add(this.cbResults);
            this.Simulation.Controls.Add(this.tbStop);
            this.Simulation.Controls.Add(this.label4);
            this.Simulation.Controls.Add(this.button1);
            this.Simulation.Location = new System.Drawing.Point(1179, 12);
            this.Simulation.Name = "Simulation";
            this.Simulation.Size = new System.Drawing.Size(338, 199);
            this.Simulation.TabIndex = 13;
            this.Simulation.TabStop = false;
            this.Simulation.Text = "Simulation";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(263, 103);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(16, 17);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Time";
            // 
            // tbPause
            // 
            this.tbPause.Location = new System.Drawing.Point(109, 95);
            this.tbPause.Name = "tbPause";
            this.tbPause.Size = new System.Drawing.Size(47, 22);
            this.tbPause.TabIndex = 14;
            this.tbPause.TextChanged += new System.EventHandler(this.tbPause_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pause";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xmile";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "xmile files (*.xmile)|*.xmile|stmx files (*.stmx)|*.stmx|itmx files (*.itmx)|*.it" +
    "mx|xml files (*.xml)|*.xml|All files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\laure\\Dropbox\\Symu\\SourceCode\\Symu.SysDyn\\Github\\SourceCode\\SymuSysDyn\\T" +
    "emplates\\";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Xmile file";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(12, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(815, 673);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 15;
            this.picImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Groups";
            // 
            // cbGroups
            // 
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.Location = new System.Drawing.Point(106, 42);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(195, 24);
            this.cbGroups.TabIndex = 18;
            this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbValue);
            this.groupBox1.Controls.Add(this.tbEquation);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbVariables);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cbGroups);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(846, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 199);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(106, 164);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(95, 22);
            this.tbValue.TabIndex = 18;
            // 
            // tbEquation
            // 
            this.tbEquation.Enabled = false;
            this.tbEquation.Location = new System.Drawing.Point(106, 100);
            this.tbEquation.Multiline = true;
            this.tbEquation.Name = "tbEquation";
            this.tbEquation.Size = new System.Drawing.Size(195, 62);
            this.tbEquation.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Equation";
            // 
            // cbVariables
            // 
            this.cbVariables.FormattingEnabled = true;
            this.cbVariables.Location = new System.Drawing.Point(106, 71);
            this.cbVariables.Name = "cbVariables";
            this.cbVariables.Size = new System.Drawing.Size(195, 24);
            this.cbVariables.TabIndex = 20;
            this.cbVariables.SelectedIndexChanged += new System.EventHandler(this.cbVariables_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Variables";
            // 
            // cbOptimized
            // 
            this.cbOptimized.AutoSize = true;
            this.cbOptimized.Location = new System.Drawing.Point(14, 124);
            this.cbOptimized.Name = "cbOptimized";
            this.cbOptimized.Size = new System.Drawing.Size(93, 21);
            this.cbOptimized.TabIndex = 17;
            this.cbOptimized.Text = "Optimized";
            this.cbOptimized.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(200, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 25);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 708);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.Simulation);
            this.Controls.Add(this.chartControl1);
            this.Name = "Home";
            this.Text = "Symu.SysDyn : system dynamics";
            this.Simulation.ResumeLayout(false);
            this.Simulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbResults;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStop;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.TextBox tbDt;
        private System.Windows.Forms.GroupBox Simulation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TextBox tbPause;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbGroups;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbVariables;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEquation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbOptimized;
        private System.Windows.Forms.Button btnClear;
    }
}

