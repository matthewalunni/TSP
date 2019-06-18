using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TSP
{
    public partial class MainForm : Form
    {
        private Processor processor;
        private Path path;
        public static double MutationRate;
        public static double CrossoverRate;
        public static int PopulationSize;
        private int current = -1; //which solution is being displayed
        private List<Path> solutions = new List<Path>();
        public static bool TwoPointCrossover;
        public static int ProblemSize;
        internal static bool UniformCrossover;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //the following changes chart colours to make points more visible
            chart1.ChartAreas[0].AxisX.LineWidth = 3;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.LineWidth = 3;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
            chart1.ChartAreas[0].AxisX.Interval = 0.25;
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.Series["original"].BorderWidth = 2;

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open a File";

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {

                tbFile.Text = ofd.FileName;
                processor = new Processor();
                
                //Population population = new Population();
                path = new Path(processor.ProcessFile(tbFile.Text));


                foreach (var coordinate in path.Coordinates)
                {
                    if (coordinate != null)
                    {
                        tbOriginalCoord.Text += "(" + coordinate.x + ", " + coordinate.y + ")" + Environment.NewLine;
                    }
                }


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbOriginalCoord_TextChanged(object sender, EventArgs e)
        {

        }



        private void chart1_Click(object sender, EventArgs e)
        {
            
               
        }

        private void btnPlotOriginal_Click(object sender, EventArgs e)
        {
            path.Display(chart1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonProduce_Click(object sender, EventArgs e)
        {
            CheckIfTextBoxesAreNull();
            TwoPointCrossover = rbTwoPointCrossover.Checked;
            PopulationSize = Convert.ToInt32(tbPopulationSize.Text);
            
            var population = path.CreatePopulation(PopulationSize); 
            int generation = 0;
            bool betterFitness = true;

            while (generation < Convert.ToInt32(tbNumGenerations.Text))
            {
                if (betterFitness)
                {
                    solutions.Add(population.BestPath());   
                }


                betterFitness = false;
                double currentFitness = population.BestFitness;


                population = population.Evolve((int)tbElite.Value);
                if (population.BestFitness > currentFitness)
                    betterFitness = true;

                generation++;
            }
            solutions = solutions.OrderBy(o => o.Distance).Reverse().ToList();
            current = 0;
            PrintSolution();
        }
        
        private void CheckIfTextBoxesAreNull()
        {
            if (tbPopulationSize.Text == null)
            {
                MessageBox.Show("Please enter a population size.");
            }

            if (tbNumGenerations.Text == null)
            {
                MessageBox.Show("Please enter a number of generations.");
            }

            if (tbMutation.Text == null)
            {
                MessageBox.Show("Please enter a mutation rate between 0 and 1.");
            }
            else
            {
                MutationRate = Convert.ToDouble(tbMutation.Text);
            }
            if (tbCrossover == null)
            {
                MessageBox.Show("Please enter a crossover rate between 0 and 1.");
            }
            else
            {
                CrossoverRate = Convert.ToDouble(tbCrossover.Text);
            }
            if (tbProblemSize == null)
            {
                MessageBox.Show("Please enter a valid problem size.");
            }
            else
            {
                ProblemSize = (int)tbProblemSize.Value;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            current++;
            PrintSolution();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            current--;
            PrintSolution();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            current = solutions.Count - 1;
            PrintSolution();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            current = 0;
            PrintSolution();
        }

        /** this method is used for the bottom scroller to print solutions**/
        public void PrintSolution()
        {
            if (current == 0)
            {
                buttonFirst.Enabled = false;
                buttonPrevious.Enabled = false;
            }
            else
            {
                buttonFirst.Enabled = true;
                buttonPrevious.Enabled = true;
            }

            if (current == solutions.Count - 1)
            {
                buttonNext.Enabled = false;
                buttonLast.Enabled = false;
            }
            else
            {
                buttonNext.Enabled = true;
                buttonLast.Enabled = true;
            }


            lblPathLength.Text = "Path Length: " + solutions[current].Distance;
            lblGenerationNum.Text = string.Format("Path {0} of {1}", current + 1, solutions.Count);

            solutions[current].Display(chart1);
            tbGenerationCoordinates.Clear();
            foreach (var coordinate in solutions[current].Coordinates)
            {
                if (coordinate != null)
                {
                    tbGenerationCoordinates.Text += "(" + coordinate.x + ", " + coordinate.y + ")" + Environment.NewLine;
                }
            }

        }

        private void rbTwoPointCrossover_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MainForm NewForm = new MainForm();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbProblemSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbElite_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

