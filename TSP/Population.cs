using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSP
{
    class Population
    {
        public List<Path> Paths { get; set; }
        private Path bestPath { get; set; }

        public double BestFitness
        {
            get; set;
        }


        public Population(List<Path> paths)
        {
            Paths = paths;
            BestFitness = GetBestFitness();
        }

        private double GetBestFitness()
        {
            return Paths.Max(t => t.Fitness);
        }

        public Path FindBestPath()
        {
            foreach (Path path in Paths)
            {
                if (bestPath == null)
                {
                    bestPath = path;
                }
                
                if (path.Fitness > bestPath.Fitness)
                {
                    bestPath = path;
                }
            }

            return bestPath;
        }
        public Population Evolve(int fittest)
        {
            var bestPopulation = Elite(fittest);
            var newPopulation = CreateNewPopulation(Paths.Count - fittest);
            return new Population(bestPopulation.Paths.Concat(newPopulation.Paths).ToList());
        }

        public Path BestPath()
        {
            return Elite(1).Paths[0];
        }

        public Population Elite(int fittest)
         {
            if (fittest <= 0.1 * Paths.Count)
            {
                var best = new List<Path>();
                var next = new Population(Paths);

                for (int i = 0; i < fittest; i++)
                {
                    best.Add(next.FindBestPath());
                    next = new Population(next.Paths.Except(best).ToList());
                }

                return new Population(best);
            }
            else
            {
                MessageBox.Show("Fittest > 10% of the population.  Restart the program and try again.");
                return null;
            }
        }



        public Population CreateNewPopulation(int populationSize)
        {
            var paths = new List<Path>();

            for (int i = 0; i < populationSize; ++i)
            {
                Path path = Select().Crossover(Select());

                foreach (Coordinate coordinate in path.Coordinates)
                {
                    path = path.Mutate();
                }

                paths.Add(path);
            }

            return new Population(paths);
        }

        public Path Select()
        {
            while (true)
            {
                int i = Program.Randomizer.Next(0, Paths.Count);

                if (Paths[i].Fitness / BestFitness >= Program.Randomizer.NextDouble() )
                {
                    return new Path(Paths[i].Coordinates);
                }
            }
        }

    }
}
