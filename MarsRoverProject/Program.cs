using System;

namespace MarsRoverProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Platonun uzunluk değerlerini giriniz. Boşluk  bırakarak giriniz.");
            var plateauCoordinates = Console.ReadLine();
            Plateau plateau = new Plateau(plateauCoordinates);

            Console.WriteLine("Mars rover aracının başlangıç noktasını giriniz. Boşluk  bırakarak giriniz.");
            var startPositions = Console.ReadLine().ToUpper();

            Console.WriteLine("Mars rover aracının hareket komutlarını giriniz.");
            var moves = Console.ReadLine().ToUpper();

            Rover currentRover = new Rover(plateau, startPositions, moves);
            Console.WriteLine(currentRover.XCoordinate.ToString()+" "+ currentRover.YCoordinate.ToString()+" "+ currentRover.Direction);
            Console.ReadLine();
        }
    }
}
