using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpaceTrader
{
    public class Story
    {
       
        public void Intro()
        {
          
            string load = "Systems: Green\nServers: Green\nConnection: Green\nBCI: Green\nNeural Net: Green\nConsole UI: Green\nControls: Green\nPower: Green\nNAT Type: Open\nLive: Green\nInitiation: Complete\nTRINITY Connection: Green\nBringer: Hollick";
            TypeEffect(load);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            string intro1 = "Hello Hollick.  It's a pleasure to finally meet you.  You are probably confused, but don't worry, we are here to help.  The year is 2042.  We here at TRINITY are very excited about working with you.  You had recieved a life threatening injury that resulted in full memory loss.  This injury has directly interfered with your cortex and nervous system.  Thanks to modern Brain Computer Interfaces here at TRINITY, we managed to save you, but your body subconsciously operates on its own, while you are given decisions to direct its main course of action.  This is in the form of percieving a console application interface.";
            TypeEffect(intro1);
            Console.WriteLine("");
            Console.WriteLine("");
            string intro2 = "You have been hired by us here at TRINITY in order to pay back your debt for saving your life.  Your official title is now Bringer.  You will be selling the products that are in highest demand, which are Element 115, batteries, memory, nootropics, and Transcenders.  You will travel back and forth to Earth, A Proxima 1, and here, Olympus.  You will meet with traders at Hubs and offer goods and services, or if the prices are cheaper there, buy products and sell it elsewhere.";
            TypeEffect(intro2);
            Console.WriteLine("");
            Console.WriteLine("");
            string intro3 = "In order for you to fully repay your debt, you must generate 50,000,000 ren in total profit.  We will then be happy to acquire your earnings and to give you your own Transcender.  Don't try to use one before you've completed your tasks, because you will be terminated immediately via the BCI inside your brain.  This Transcender device was created by us here at TRINITY in order to allow humans to expand consciousness into higher dimensions, free of the limits of a three dimensional body.  This is the ultimate reward for your hard work.";
            TypeEffect(intro3);
            Console.WriteLine("");
            Console.WriteLine("");
            string intro4 = "Today is your 18th birthday.  You will have until the age of 60 in order to pay back your debt to us.  If you fail to acquire the revenue in time, you will unfortunately be terminated for security reasons.  I will now be giving you a base stock of inventory, ren, and a starship.  We look forward to working with you, Hollick.";
            TypeEffect(intro4);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Acquired: Starship");
            Console.WriteLine("Acquired: 500000 Ren");
            Console.WriteLine("Acquired: 15 Batteries");
            Console.WriteLine("Acquired: 0 Memories");
            Console.WriteLine("Acquired: 5 Element 115");
            Console.WriteLine("Acquired: 5 Transcenders");
            Console.WriteLine("Acquired: 20 Nootropics");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter 3 to begin your new life, the clock is ticking.");   // need to create function to make entering black space will pull up menu for planet directory.

            string result = Console.ReadLine();
            if (result == "3")
            {
                Planet.PlanetsMenuControl();
            }
            else
            {
                Planet.PlanetsMenuControl();
            }

        }

        public static void TypeEffect(string dialogueChar)
        {
            foreach (char x in dialogueChar)
            {
                Thread.Sleep(0);
                Console.Write(x);
            }
        }


    }
}