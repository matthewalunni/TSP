using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class Processor
    {
        //public List<Coordinate> Coordinates = new List<Coordinate>();
        //private static Random random = new Random();



        public bool stringIsCoordinate(string str)
        {
            bool isLetter = !String.IsNullOrEmpty(str) && Char.IsLetter(str[0]);


            if (isLetter)
            {
                return false;
            }
            else return true;

        }

        private Coordinate process(string[] columns)
        {
            try
            {
                double x = Convert.ToDouble(columns[1]);
                double y = Convert.ToDouble(columns[2]);
                Coordinate result = new Coordinate(x, y);
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Coordinate> ProcessFile(string fileName)
        {

            var coordinates = new List<Coordinate>();
            string[] Lines = File.ReadAllLines(fileName);

            foreach (var line in Lines)
            {

                bool isCoordinate = stringIsCoordinate(line);

                if (isCoordinate)
                {
                    var columns = line.Split(null);

                    if (!columns.Contains("EOF"))
                    {
                        var coordinate = process(columns);
                        if (coordinate != null)
                        {
                            coordinates.Add(coordinate);
                        }
                    }



                }

            }

            return coordinates;


        }

    }
}
