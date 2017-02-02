using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02_Vahvistin
{
    class Volume
    {
        private readonly int maxvolume = 100;
        private readonly int minvolume = 0;

        private int volume;

        public int Volumevalue

        {

            get
            {
                return volume;

            }
            set
            {
                if (minvolume <= value && value <= maxvolume)
                {
                    Console.WriteLine("Amplifier volume is set to:" + value);

                }
                if (value < minvolume)
                {
                    Console.WriteLine("Too low volume - Amplifier volume is set ot minimum: " + minvolume);
                }
                if (value > maxvolume)
                {
                    Console.WriteLine("Too much volume - Amplifier volume is set to maximum: " + maxvolume);
                }
            }

        }
    }
}

    

