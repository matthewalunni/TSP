using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class Path
    {
        public List<Coordinate> Coordinates { get; set; }
        public double Fitness { get; set; }
        public double Distance { get; set; }

        private double GetDistance()
        {
            double total = 0;
            for (int i = 0; i < Coordinates.Count; ++i)
                total += Coordinates[i].GetDistance(Coordinates[(i + 1) % Coordinates.Count]);

            return total;

        }

        public Path Mutate()
        {
            List<Coordinate> result = new List<Coordinate>(Coordinates);


            if (Program.Randomizer.NextDouble() < MainForm.MutationRate)
            {
                int random = Program.Randomizer.Next(0, Coordinates.Count);
                int nextRandom = Program.Randomizer.Next(0, Coordinates.Count);
                Coordinate coordinate = result[random];
                result[random] = result[nextRandom];
                result[nextRandom] = coordinate;
            }

            return new Path(result);
        }

        public Path(List<Coordinate> coordinates)
        {
            Coordinates = coordinates;
            Distance = GetDistance();
            Fitness = 1 / Distance;

        }

        public Path TwoPointCrossover(Path otherParent)
        {
            int firstPoint = Program.Randomizer.Next(0, otherParent.Coordinates.Count);
            int secondPoint = Program.Randomizer.Next(firstPoint, otherParent.Coordinates.Count);
            List<Coordinate> coordinatesInRange = Coordinates.GetRange(firstPoint, secondPoint - firstPoint + 1);
            List<Coordinate> coordinatesOutOfRange = otherParent.Coordinates.Except(coordinatesInRange).ToList();
            List<Coordinate> crossedOverCoordinates = coordinatesOutOfRange.Take(firstPoint)
                .Concat(coordinatesInRange).Concat(coordinatesOutOfRange.Skip(firstPoint)).ToList();
            return new Path(new List<Coordinate>(crossedOverCoordinates));
        }

        public Path UniformCrossover(Path otherParent)
        {
            List<Coordinate> result = this.Coordinates;
            int count = MainForm.ProblemSize;
            
            List<Coordinate> result1 = otherParent.Coordinates;
            
            for (int i = 0; i < count; i++)
            {
               
                if (Program.Randomizer.NextDouble() > 0.5)
                {

                }
                else
                {
                    //var temp = result[i];
                    //result.Remove(otherParent.Coordinates[i]);
                    //result.Insert(i, otherParent.Coordinates[i]);

                    //otherParent.Coordinates.Remove(temp);
                    //otherParent.Coordinates.Insert(i, temp);
                    var temp = result[i];
                    result.Remove(otherParent.Coordinates[i]);
                    result.Insert(i, otherParent.Coordinates[i]);
                    //remove nulls
                    result = result.Where(x => x != null).ToList();




                }

            }
            return new Path(result);
        }


        public Path Crossover(Path otherParent)
        {
            List<Coordinate> result = new List<Coordinate>(Coordinates);
            if (Program.Randomizer.NextDouble() < MainForm.CrossoverRate)
            {

                if (MainForm.TwoPointCrossover)
                {
                    result = TwoPointCrossover(otherParent).Coordinates;
                }
                else
                {
                    result = UniformCrossover(otherParent).Coordinates;
                }
            }
            return new Path(result);

        }

        //this function will randomly sort the coordinates to create the initial population
        //it also populates the next part of the coordinate class
        public List<Coordinate> Randomize()
        {
            List<Coordinate> result = Coordinates.OrderBy(a => Guid.NewGuid()).ToList();
            removeNull(result); //removes null coordinates

            return result;
        }

        public Population CreatePopulation(int populationSize)
        {
            List<Path> paths = new List<Path>();
            for (int i = 0; i < populationSize; i++)
            {
                paths.Add(new Path(Randomize()));
            }

            return new Population(paths);
        }

        public void Display(System.Windows.Forms.DataVisualization.Charting.Chart chart1)
        {
            try
            {
                chart1.Series["original"].Points.Clear();

                foreach (var coordinate in Coordinates)
                {
                    chart1.Series["original"].Points.AddXY(coordinate.x, coordinate.y);
                }

                chart1.Series["original"].Points.AddXY(Coordinates.First().x, Coordinates.First().y);
                chart1.Series["original"].Color = Color.Red;
            }
            catch (Exception)
            {
                // MessageBox.Show(exception.Message);
                // do nothing
            }
        }

        private void removeNull(List<Coordinate> result)
        {
            //this removes the null coordinate, dont know why there is a null coordinate
            foreach (var coordinate in result.ToList())
            {
                if (coordinate == null)
                {
                    result.Remove(coordinate);
                }

            }



        }

    }
}
