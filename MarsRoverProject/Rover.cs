using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProject
{
    public class Rover
    {
        public enum Directions
        {
            N = 1,
            S = 2,
            E = 3,
            W = 4
        }
 
        public Rover(Plateau Plateau, string Position, string Commands)
        {
            this.StartPosition(Position);
            if(!(this.XCoordinate >= 0) && (this.XCoordinate < Plateau.Width) && (this.YCoordinate >= 0) && (this.YCoordinate < Plateau.Height))
            {
                throw new Exception($"Lütfen aracının başlangıç noktasını (0 , 0) ve  ({Plateau.Width} , {Plateau.Height}) kordinatları arasında belirle...");
            }
            this.StartMoving(Commands);
        }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Directions Direction { get; set; }
   
        private void StartPosition(string roverPosition)
        {
            string[] roverPositionMsgSplit = roverPosition.Split(' ');
            this.XCoordinate = Convert.ToInt32(roverPositionMsgSplit[0]);
            this.YCoordinate = Convert.ToInt32(roverPositionMsgSplit[1]);
            this.Direction = (Directions)Enum.Parse(typeof(Directions),roverPositionMsgSplit[2]);
        }

        private void StartMoving(string roverCommands)
        {
            char[] commands = roverCommands.ToCharArray();

            foreach (char command in commands)
            {
                switch (command.ToString())
                {
                    case "M":
                        this.MoveRoverNext();
                        break;

                    default:
                        this.RotateRover(command.ToString());
                        break;
                }
            }
        }

        public void MoveRoverNext()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.YCoordinate += 1;
                    break;

                case Directions.E:
                    this.XCoordinate += 1;
                    break;

                case Directions.S:
                    this.YCoordinate -= 1;
                    break;

                case Directions.W:
                    this.XCoordinate -= 1;
                    break;
            }
        }
        public void RotateRover(string direction)
        {
            switch (direction.ToUpper())
            {
                case "L":
                    this.TurnLeft();
                    break;

                case "R":
                    this.TurnRight();
                    break;

                default:
                    throw new ArgumentException();
            }
        }
    
        private void TurnLeft()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.W;
                    break;

                case Directions.W:
                    this.Direction = Directions.S;
                    break;

                case Directions.S:
                    this.Direction = Directions.E;
                    break;

                case Directions.E:
                    this.Direction = Directions.N;
                    break;
            }
        }

        private void TurnRight()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.E;
                    break;

                case Directions.E:
                    this.Direction = Directions.S;
                    break;

                case Directions.S:
                    this.Direction = Directions.W;
                    break;

                case Directions.W:
                    this.Direction = Directions.N;
                    break;
            }
        }
    }
}



