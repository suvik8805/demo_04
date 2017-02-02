using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02_Vahvistin
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            do
            {
                Volume volume = new Volume();
                Console.WriteLine("Give a new volume value (0-100): ");
                luku = int.Parse(Console.ReadLine());
                volume.Volumevalue = luku;

            }
            while (luku != 0);

        }
    }
}
