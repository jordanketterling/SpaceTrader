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

        public int transcenders;
        public int money;
        public int age;
        public int element;
        public int memory;
        public int nootropics;
        public int batteries;
        public void Hollick()
        {
            Console.Write("HUD | ");
            Console.WriteLine("Bringer: Hollick ");
            Console.Write("Age: " + age + " |");
            Console.Write(" Ren: " + money + " |");
            Console.Write(" Location: " + HollickLocation() + " |");
            Console.Write(" INVENTORY( Batteries: " + batteries + ",");
            Console.Write(" Element 115: " + element + ",");
            Console.Write(" Memory: " + memory + ",");
            Console.Write(" Transcenders: " + transcenders + ",");
            Console.Write(" Nootropics: " + nootropics + " )");
            Console.WriteLine(" ");
            Console.WriteLine("______________________________________________________________________________________________________________________");

        }

        public static int HollickAge(int x)
        {
            int age = 18;

            age += x;

            return age;
        }


        public static void HollickMoney(int x, int y)
        {
            int money = 500000;

            money += x;  //Sell

            money -= y;  //Buy

        }


        public int HollickLocation()
        {
            //string Earth;
            int location = 1;



            return location;
        }
        
        //INVENTORY
        public static int Transcenders(int x, int y)
        {

            int transcenders = 5;

            transcenders += x; //Buy

            transcenders -= y; //Sell

            return transcenders;
        }


        public static int Memory(int x, int y)
        {
            int memory = 0;

            memory += x;  //Buy

            memory -= y;  //Sell

            return memory;
        }


        public static int Element115(int x, int y)
        {
            int element = 5;

            element += x;  //Buy

            element -= y; //Sell

            return element;
        }


        public static int Batteries(int x, int y)
        {
            int batteries = 15;

            batteries += x;  //Buy

            batteries -= y;  //Sell

            return batteries;
        }

        public static int Nootropics(int x, int y)
        {
            int nootropics = 20;

            nootropics += x;  //Buy

            nootropics -= y;  //Sell

            return nootropics;
        }
    }
}

