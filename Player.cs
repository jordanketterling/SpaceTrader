using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTrader
{
    public class Player
    {

        public int transcenders = 5;
        public int money = 500000;
        public int age = 18;
        public int element = 5;
        public int memory = 0;
        public int nootropics = 20;
        public int batteries = 15;

        
        public void Hollick()
        {
            Console.Write("HUD | ");
            Console.WriteLine("Bringer: Hollick ");
            Console.Write("Age: " + age + " |");
            Console.Write(" Ren: " + money + " |");
            //Console.Write(" Location: " + HollickLocation() + " |");
            Console.Write(" INVENTORY( Batteries: " + batteries + ",");
            Console.Write(" Element 115: " + element + ",");
            Console.Write(" Memory: " + memory + ",");
            Console.Write(" Transcenders: " + transcenders + ",");
            Console.Write(" Nootropics: " + nootropics + " )");
            Console.WriteLine(" ");
            Console.WriteLine("______________________________________________________________________________________________________________________");
        }
    }
}

