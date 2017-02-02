using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            do

            {
                Hissi hissi = new Hissi();

                Console.Write("Give a new floor number (1-5): ");
                luku = int.Parse(Console.ReadLine());
                hissi.Floor = luku;

            }

            while (luku != 0);


        }
    }
}