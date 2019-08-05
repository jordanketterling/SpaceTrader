using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTrader
{
    public class Player
    {
        Planet planet = new Planet();

        public int transenders;
        public void Hollick()
        {
            Console.Write("HUD | ");
            Console.WriteLine("Bringer: Hollick ");
            Console.Write("Age: " + HollickAge() + " |");
            Console.Write(" Ren: " + HollickMoney() + " |");
            Console.Write(" Location: " + HollickLocation() + " |");
            Console.Write(" INVENTORY( Batteries: " + Batteries() + ",");
            Console.Write(" Element 115: " + Element115() + ",");
            Console.Write(" Memory: " + Memory() + ",");
            Console.Write(" Transcenders: " + Transcenders());
            Console.Write(" Nootropics: " + Nootropics() + " )");
            Console.WriteLine(" ");
            Console.WriteLine("______________________________________________________________________________________________________________________");

        }

        public int HollickAge()
        {
            int age = 18;



            return age;
        }


        public int HollickMoney()
        {
            int money = 500000;



            return money;
        }


        public int HollickLocation()
        {
            //string Earth;
            int location = 1;



            return location;
        }
        
        //INVENTORY
        public void Transcenders(int x, int y)
        {

            x += y;

            transenders = x;

            
        }


        public int Memory()
        {
            int memory = 10;

            

            return memory;
        }


        public int Element115()
        {
            int element = 5;



            return element;
        }


        public int Batteries()
        {
            int batteries = 15;



            return batteries;
        }

        public int Nootropics()
        {
            int nootropics = 20;



            return nootropics;
        }
    }
}

