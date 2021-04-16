using System;
using System.Linq;
using System.Collections.Generic;


namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {

        List<string> gameList = new List<string>();
            gameList.Add("WarCraft");
            gameList.Add("Minecraft");
            gameList.Add("Halo");
            gameList.Add("Zelda");

        Console.WriteLine("Game List:");
            foreach (var gameName in gameList)
            {
                Console.WriteLine($"{gameName}");
            }
          Console.WriteLine("-------------");

        Console.WriteLine("Game alpha list:");

        var gameOrderA = gameList.OrderBy(gamea => gamea);

            foreach (var gamea in gameOrderA)
            {
                Console.WriteLine($"{gamea}");
            }
          Console.WriteLine("-------------");

        Console.WriteLine("Game name length list:");

            var gameNameLength = gameList.OrderBy(gamea => gamea.Length);

            foreach (var gamea in gameNameLength)
            {
                Console.WriteLine($"{gamea}");
            }


        }
    }
}
