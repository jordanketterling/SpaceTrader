﻿using System;
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
            Story intro = new Story();
            intro.Intro();

            Planet planet = new Planet();
            planet.Planets();

            Player hollick = new Player();
            hollick.Hollick();
        }
    }
}
