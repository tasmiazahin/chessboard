using static System.Net.Mime.MediaTypeNames;
using System;
using System.Text;

namespace chessboard
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            string text = Console.ReadLine();
            int userInput = Convert.ToInt32(text);


            for (int i = 0; i < userInput; i++)
            {
                for (int j = 0; j < userInput; j++)
                {
                    //Console.Write("◼︎");
                    Console.Write('\u2B1B');

                }
                Console.WriteLine();
            }
        }
    }
}


