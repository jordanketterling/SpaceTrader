using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTrader
{
    class Program
    {

        static void Main(string[] args)
        {
            Player hollick = new Player();
            hollick.Hollick();

            Console.Clear();

            Story intro = new Story(hollick);
            intro.Intro();
        }
    }
}
