using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            string[] array = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z","1","2","3","4","5","6","7","8","9","0","!","&","$","?",".","," };
            Console.Title = "The Matrix";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            while (true)
            {
                
                Thread.Sleep(25);
                for (int i = 0; i < 3000; i++)
                {
                    int a;
                    

                    var bytes = new byte[36];
                    rand.NextBytes(bytes);


                    a = rand.Next(36);
                    Console.Write(" "); Console.Write(array[a]); Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    } }
