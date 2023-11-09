using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedMap
{
    internal class Program
    {
        static char[,] map = new char[,] // dimensions defined by following data:
    {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
    };

        // usage: map[y, x]

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees
        


        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Text Based Map!");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Map (unscaled)");
            DisplayMap();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Map (scaled x2)");
            DisplayMap(2);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Map (scaled x3)");
            DisplayMap(3);
            Console.ReadKey(true);
            


        }
        
        static void DisplayMap()
        {
            Console.WriteLine("+" + new string('-', map.GetLength(1)) + "+");
            for (int y = 0; y < map.GetLength(0); y++)
            {
                Console.Write("|");
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    Console.Write(map[y, x]);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("+" + new string('-', map.GetLength(1)) + "+");
            
        }
        static void DisplayMap(int scale)
        {
            Console.WriteLine("+" + new string('-', map.GetLength(1) * scale) + "+");
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int rowSize = 0; rowSize < scale; rowSize++);
                {
                    Console.Write('|');
                    for (int x = 0; x < map.GetLength(1); x++) 
                    {
                        for (int columnSize = 0; columnSize < scale; columnSize++)
                        {
                            Console.Write(map[y, x]);
                        }
                    }
                    Console.WriteLine("|");
                }

            }
            Console.WriteLine("+" + new string('-', map.GetLength(1) * scale) + "+");
        } 
    }
}






       





