using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{

    class Coordinate
    {
        public double x;
        public double y;


        public Coordinate(double x, double y) {
            this.x = x;
            this.y = y;
        }

        //this method returns the distance between the current coordinate and the next
        public double GetDistance(Coordinate next)
        {
            return Math.Sqrt(Math.Pow((next.x - x), 2) + 
                Math.Pow((next.y - y), 2));
        }
        
    }
}
