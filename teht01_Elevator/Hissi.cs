using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01_Elevator
{
    class Hissi
    {
        private readonly int maxFloor = 5;
        private readonly int minFloor = 1;

        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (minFloor <= value && value <= maxFloor) { 
                    floor = value;
                Console.WriteLine("Elevator is now in floor: " + floor); }
                
               else 
                Console.WriteLine("Floor is not accepted!");
            
                

            }
        }

        }
    }