using System;

namespace TSP
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOriginalCoord = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPlotOriginal = new System.Windows.Forms.Button();
            this.tbCrossover = new System.Windows.Forms.TextBox();
            this.lblCrossover = new System.Windows.Forms.Label();
            this.lblMutation = new System.Windows.Forms.Label();
            this.tbMutation = new System.Windows.Forms.TextBox();
            this.tbNumGenerations = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPathLength = new System.Windows.Forms.Label();
            this.buttonProduce = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPopulationSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGenerationCoordinates = new System.Windows.Forms.TextBox();
            this.lblGenerationNum = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.rbTwoPointCrossover = new System.Windows.Forms.RadioButton();
            this.rbUniformCrossover = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbElite = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbProblemSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbElite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProblemSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(495, 9);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(12, 9);
            this.tbFile.Multiline = true;
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(477, 23);
            this.tbFile.TabIndex = 1;
            this.tbFile.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original Coordinates (x, y)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbOriginalCoord
            // 
            this.tbOriginalCoord.Location = new System.Drawing.Point(12, 277);
            this.tbOriginalCoord.Multiline = true;
            this.tbOriginalCoord.Name = "tbOriginalCoord";
            this.tbOriginalCoord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOriginalCoord.Size = new System.Drawing.Size(217, 260);
            this.tbOriginalCoord.TabIndex = 3;
            this.tbOriginalCoord.TextChanged += new System.EventHandler(this.tbOriginalCoord_TextChanged);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Location = new System.Drawing.Point(238, 44);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "original";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1290, 797);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnPlotOriginal
            // 
            this.btnPlotOriginal.Location = new System.Drawing.Point(576, 9);
            this.btnPlotOriginal.Name = "btnPlotOriginal";
            this.btnPlotOriginal.Size = new System.Drawing.Size(149, 23);
            this.btnPlotOriginal.TabIndex = 7;
            this.btnPlotOriginal.Text = "Plot Original";
            this.btnPlotOriginal.UseVisualStyleBackColor = true;
            this.btnPlotOriginal.Click += new System.EventHandler(this.btnPlotOriginal_Click);
            // 
            // tbCrossover
            // 
            this.tbCrossover.Location = new System.Drawing.Point(132, 99);
            this.tbCrossover.Multiline = true;
            this.tbCrossover.Name = "tbCrossover";
            this.tbCrossover.Size = new System.Drawing.Size(100, 22);
            this.tbCrossover.TabIndex = 9;
            // 
            // lblCrossover
            // 
            this.lblCrossover.Location = new System.Drawing.Point(12, 98);
            this.lblCrossover.Name = "lblCrossover";
            this.lblCrossover.Size = new System.Drawing.Size(109, 23);
            this.lblCrossover.TabIndex = 10;
            this.lblCrossover.Text = "Crossover Rate";
            // 
            // lblMutation
            // 
            this.lblMutation.Location = new System.Drawing.Point(12, 127);
            this.lblMutation.Name = "lblMutation";
            this.lblMutation.Size = new System.Drawing.Size(100, 22);
            this.lblMutation.TabIndex = 11;
            this.lblMutation.Text = "Mutation Rate";
            // 
            // tbMutation
            // 
            this.tbMutation.Location = new System.Drawing.Point(132, 127);
            this.tbMutation.Name = "tbMutation";
            this.tbMutation.Size = new System.Drawing.Size(100, 22);
            this.tbMutation.TabIndex = 12;
            // 
            // tbNumGenerations
            // 
            this.tbNumGenerations.Location = new System.Drawing.Point(132, 44);
            this.tbNumGenerations.Name = "tbNumGenerations";
            this.tbNumGenerations.Size = new System.Drawing.Size(100, 22);
            this.tbNumGenerations.TabIndex = 17;
            this.tbNumGenerations.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "# of Generations";
            // 
            // lblPathLength
            // 
            this.lblPathLength.AutoSize = true;
            this.lblPathLength.Location = new System.Drawing.Point(895, 12);
            this.lblPathLength.Name = "lblPathLength";
            this.lblPathLength.Size = new System.Drawing.Size(93, 17);
            this.lblPathLength.TabIndex = 19;
            this.lblPathLength.Text = "Path Length: ";
            // 
            // buttonProduce
            // 
            this.buttonProduce.Location = new System.Drawing.Point(731, 9);
            this.buttonProduce.Name = "buttonProduce";
            this.buttonProduce.Size = new System.Drawing.Size(158, 23);
            this.buttonProduce.TabIndex = 20;
            this.buttonProduce.Text = "Produce Generations";
            this.buttonProduce.UseVisualStyleBackColor = true;
            this.buttonProduce.Click += new System.EventHandler(this.buttonProduce_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Population Size";
            // 
            // tbPopulationSize
            // 
            this.tbPopulationSize.Location = new System.Drawing.Point(132, 71);
            this.tbPopulationSize.Name = "tbPopulationSize";
            this.tbPopulationSize.Size = new System.Drawing.Size(100, 22);
            this.tbPopulationSize.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Generation Coordinates (x, y)";
            // 
            // tbGenerationCoordinates
            // 
            this.tbGenerationCoordinates.Location = new System.Drawing.Point(12, 590);
            this.tbGenerationCoordinates.Multiline = true;
            this.tbGenerationCoordinates.Name = "tbGenerationCoordinates";
            this.tbGenerationCoordinates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGenerationCoordinates.Size = new System.Drawing.Size(217, 251);
            this.tbGenerationCoordinates.TabIndex = 24;
            // 
            // lblGenerationNum
            // 
            this.lblGenerationNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGenerationNum.Location = new System.Drawing.Point(1259, 8);
            this.lblGenerationNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenerationNum.Name = "lblGenerationNum";
            this.lblGenerationNum.Size = new System.Drawing.Size(165, 23);
            this.lblGenerationNum.TabIndex = 29;
            this.lblGenerationNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(1481, 8);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(47, 24);
            this.buttonLast.TabIndex = 28;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(1432, 8);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(47, 24);
            this.buttonNext.TabIndex = 27;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(1205, 8);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(47, 24);
            this.buttonPrevious.TabIndex = 26;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(1156, 8);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(47, 24);
            this.buttonFirst.TabIndex = 25;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // rbTwoPointCrossover
            // 
            this.rbTwoPointCrossover.AutoSize = true;
            this.rbTwoPointCrossover.Checked = true;
            this.rbTwoPointCrossover.Location = new System.Drawing.Point(15, 152);
            this.rbTwoPointCrossover.Name = "rbTwoPointCrossover";
            this.rbTwoPointCrossover.Size = new System.Drawing.Size(159, 21);
            this.rbTwoPointCrossover.TabIndex = 30;
            this.rbTwoPointCrossover.TabStop = true;
            this.rbTwoPointCrossover.Text = "Two Point Crossover";
            this.rbTwoPointCrossover.UseVisualStyleBackColor = true;
            this.rbTwoPointCrossover.CheckedChanged += new System.EventHandler(this.rbTwoPointCrossover_CheckedChanged);
            // 
            // rbUniformCrossover
            // 
            this.rbUniformCrossover.AutoSize = true;
            this.rbUniformCrossover.Location = new System.Drawing.Point(16, 177);
            this.rbUniformCrossover.Name = "rbUniformCrossover";
            this.rbUniformCrossover.Size = new System.Drawing.Size(146, 21);
            this.rbUniformCrossover.TabIndex = 31;
            this.rbUniformCrossover.Text = "Uniform Crossover";
            this.rbUniformCrossover.UseVisualStyleBackColor = true;
            this.rbUniformCrossover.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Elite";
            // 
            // tbElite
            // 
            this.tbElite.Location = new System.Drawing.Point(132, 199);
            this.tbElite.Name = "tbElite";
            this.tbElite.Size = new System.Drawing.Size(97, 22);
            this.tbElite.TabIndex = 33;
            this.tbElite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbElite.ValueChanged += new System.EventHandler(this.tbElite_ValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 543);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 24);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(123, 543);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 24);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close Form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbProblemSize
            // 
            this.tbProblemSize.Location = new System.Drawing.Point(132, 227);
            this.tbProblemSize.Name = "tbProblemSize";
            this.tbProblemSize.Size = new System.Drawing.Size(97, 22);
            this.tbProblemSize.TabIndex = 36;
            this.tbProblemSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbProblemSize.ValueChanged += new System.EventHandler(this.tbProblemSize_ValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 37;
            this.label4.Text = "# of Coordinates";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 851);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbProblemSize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbElite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbUniformCrossover);
            this.Controls.Add(this.rbTwoPointCrossover);
            this.Controls.Add(this.lblGenerationNum);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.tbGenerationCoordinates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPopulationSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonProduce);
            this.Controls.Add(this.lblPathLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNumGenerations);
            this.Controls.Add(this.tbMutation);
            this.Controls.Add(this.lblMutation);
            this.Controls.Add(this.lblCrossover);
            this.Controls.Add(this.tbCrossover);
            this.Controls.Add(this.btnPlotOriginal);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tbOriginalCoord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "Traveling Salesman Problem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbElite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProblemSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOriginalCoord;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnPlotOriginal;
        private System.Windows.Forms.TextBox tbCrossover;
        private System.Windows.Forms.Label lblCrossover;
        private System.Windows.Forms.Label lblMutation;
        private System.Windows.Forms.TextBox tbMutation;
        private System.Windows.Forms.TextBox tbNumGenerations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPathLength;
        private System.Windows.Forms.Button buttonProduce;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPopulationSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGenerationCoordinates;
        private System.Windows.Forms.Label lblGenerationNum;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.RadioButton rbTwoPointCrossover;
        private System.Windows.Forms.RadioButton rbUniformCrossover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tbElite;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown tbProblemSize;
        private System.Windows.Forms.Label label4;
    }
}

