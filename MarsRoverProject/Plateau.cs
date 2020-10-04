using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProject
{
    public class Plateau
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Plateau(int xMax, int yMax)
        {
            this.Width = xMax;
            this.Height = yMax;
        }
        public Plateau(string Coordinates)
        {
            if (string.IsNullOrEmpty(Coordinates))
                throw new ArgumentException();
            string[] coordinateMessage = Coordinates.Trim().Split(' ');

            if (coordinateMessage.Length != 2)
                throw new ArgumentOutOfRangeException();

            this.Width = Convert.ToInt32(coordinateMessage[0]);
            this.Height = Convert.ToInt32(coordinateMessage[1]);
        }
   
    }

}
