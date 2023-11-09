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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------");
            Console.WriteLine("Text Based Map!");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            
            Console.WriteLine("map legend:\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("^ = mountain\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("` = grass\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("~ = water\n");
            Console.ResetColor();

            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine("* = trees\n");
            Console.ResetColor();

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
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Larger Custom Map (scaled x6)");
            DisplayMap(6);
            // must enlarge window to see true result!!!
            
            Console.ReadKey(true);
            


        }
        

        // DisplayMap() Method

        static void DisplayMap()
        {
            // for loop for x and y coordinate to generate map
            
            Console.WriteLine("+" + new string('-', map.GetLength(1)) + "+");
            for (int y = 0; y < map.GetLength(0); y++)
            {
                Console.Write("|");
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    // setting color and writing map

                    SetColor(map[y, x]);
                    Console.Write(map[y, x]);
                    Console.ResetColor();
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("+" + new string('-', map.GetLength(1)) + "+");
            
        }
        
        // Scaled DisplayMap Method
        
        static void DisplayMap(int scale)
        {
            // Nested for loops to generate scaled map

            Console.WriteLine("+" + new string('-', map.GetLength(1) * scale) + "+");
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int rowSize = 0; rowSize < scale; rowSize++)
                {
                    Console.Write('|');
                    for (int x = 0; x < map.GetLength(1); x++) 
                    {
                        for (int columnSize = 0; columnSize < scale; columnSize++)
                        {
                            // setting color and writing map
                            
                            SetColor(map[y, x]);
                            Console.Write(map[y, x]);
                            Console.ResetColor();
                        }
                    }
                    Console.WriteLine("|");
                }

            }
            Console.WriteLine("+" + new string('-', map.GetLength(1) * scale) + "+");
        }

        static void SetColor(char terrain)
        {
            // switch statement to setup colors
            // in the case of 'character' it will set the color then break before the next character is added
            
            switch (terrain)
            {
                case '^':
                    Console.ForegroundColor = ConsoleColor.DarkGray; // mountain color
                    break;
                case '`':
                    Console.ForegroundColor = ConsoleColor.Green; // grass color
                    break;
                case '~':
                    Console.ForegroundColor = ConsoleColor.Blue; // water color
                    break;
                case '*':
                    Console.ForegroundColor = ConsoleColor.DarkGreen; // tree color
                    break;
                default:
                    Console.ResetColor();
                    break;
            }
        }



    }
}






       





