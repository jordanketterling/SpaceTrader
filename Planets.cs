using System;
using System.Collections.Generic;
using System.Text;


namespace SpaceTrader
{
    public class Planet
    {
      

        public static void Planets()
        {

        }

        public static void PlanetsMenu()
        {
            Console.WriteLine("STARSHIP PLANET DIRECTORY");
            Console.WriteLine("Type 1 to travel to Earth.");
            Console.WriteLine("Type 2 to travel to Alpha Proxima 1.");
            Console.WriteLine("Type 3 to travel to Olympus.");
            Console.WriteLine("_______________________________________________________________");
        }

        public static int PlanetsMenuInput()
        {
            string input = "";

            do
            {
                PlanetsMenu();
                input = Console.ReadLine();
            } while (string.IsNullOrEmpty(input));

            return int.Parse(input);
        }

        public static void PlanetsMenuControl()
        {
            bool addInput = false;

            do
            {
                int menuSelect = PlanetsMenuInput();
                switch (menuSelect)
                {
                    case 1:
                        Console.Clear();
                        Earth();
                        break;
                    case 2:
                        Console.Clear();
                        AlphaProxima1();
                        break;
                    case 3:
                        Console.Clear();
                        Olympus();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid destination.");
                        break;

                }
            } while (!addInput);
        }



        // Earth
        public static void Earth()
        {
            Console.WriteLine("Welcome to Hub 117 on the beautiful planet Earth. Please enjoy your stay.");
            EarthHubMenu();
        }

        public (double, double) EarthLocation()
        {
            int x = 1;
            int y = 1;
            var location = (x, y);
            return location;
        }

        public static int EarthHubMenu()
        {
            Console.WriteLine("Would you like to buy or sell?");
            Console.WriteLine("Press 1 to Buy.");
            Console.WriteLine("Press 2 to Sell.");
            Console.WriteLine("Press 3 to return to your starship.");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);
            return x;
        }

        public static void EarthBuySell()
        {
            bool addInput = false;

            do
            {
                int menuSelect = EarthHubMenu();
                switch (menuSelect)
                {
                    case 1:
                        Console.Clear();
                        EarthBuyMenu();
                        break;
                    case 2:
                        Console.Clear();
                        EarthSell();
                        break;
                    case 3:
                        Console.Clear();
                        PlanetsMenuControl();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid request.");
                        break;

                }
            } while (!addInput);

        }

        public static int EarthBuyMenu()
        {
            Player newPlayer = new Player();
            newPlayer.Hollick();

            double batteries = 75000;
            double element115 = 100000;
            double memory = 10000;
            double tran = 1000000;
            double nootropics = 50000;

            Console.WriteLine("Which item would you like to purchase?");
            Console.WriteLine("Press 1 to buy Batteries");
            Console.WriteLine("Press 2 to buy Element 115");
            Console.WriteLine("Press 3 to buy Memory");
            Console.WriteLine("Press 4 to buy Transcenders");
            Console.WriteLine("Press 5 to buy Nootropics");
            Console.WriteLine("Press 6 to return to Buy/Sell Menu");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);
            return x;
        }

        public static void EarthBuyMenuSelect()
        {
            bool addInput = false;

            do
            {
                int menuSelect = EarthBuyMenu();
                switch (menuSelect)
                {
                    case 1:
                        Console.Clear();
                        Batteries();
                        break;
                    case 2:
                        Console.Clear();
                        Element115();
                        break;
                    case 3:
                        Console.Clear();
                        Memory();
                        break;
                    case 4:
                        Console.Clear();
                        Tran();
                        break;
                    case 5:
                        Console.Clear();
                        Nootropics();
                        break;
                    case 6:
                        Console.Clear();
                        EarthHubMenu();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid item.");
                        break;

                }
            } while (!addInput);

        }

        public static int Batteries()
        {
            Player newPlayer = new Player();
            newPlayer.Hollick();

            int price = 75000;
            Console.WriteLine("Battery: 75,000 Ren");
            Console.WriteLine("Enter how many Batteries you would like to buy with the max being 15.");
            Console.WriteLine("Enter 0 to return to the item select menu.");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                EarthBuyMenuSelect();
            }

            if (x > 15)
            {
                Console.WriteLine("Outside of max purchase value");
                Tran();
            }

            int y = x * price;
            return y;
        }

        public static int Element115()
        {
            Player newPlayer = new Player();
            newPlayer.Hollick();

            int price = 100000;
            Console.WriteLine("Element 115: 100,000 Ren");
            Console.WriteLine("Enter how much Element 115 you would like to buy with the max being 10.");
            Console.WriteLine("Enter 0 to return to the item select menu.");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                EarthBuyMenuSelect();
            }

            if (x > 10)
            {
                Console.WriteLine("Outside of max purchase value");
                
            }

            int y = x * price;
            return y;
        }

        public static int Memory()
        {
            Player newPlayer = new Player();
            newPlayer.Hollick();

            int price = 10000;
            Console.WriteLine("Memory: 10,000 Ren");
            Console.WriteLine("Enter how much Memory you would like to buy with the max being 100.");
            Console.WriteLine("Enter 0 to return to the item select menu.");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                EarthBuyMenuSelect();
            }

            if (x > 100)
            {
                Console.WriteLine("Outside of max purchase value");
                Tran();
            }

            int y = x * price;
            return y;
        }

        public void Tran()
        {
            Player newPlayer = new Player();
            newPlayer.Hollick();

            int price = 1000000;
            Console.WriteLine("Transcender: 1,000,000 Ren");
            Console.WriteLine("Enter how many Nootropics you would like to buy with the max being 5.");
            Console.WriteLine("Enter 0 to return to the item select menu.");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);


            if (x < 1)
            {
                EarthBuyMenuSelect();
            }

            if (x > 5)
            {
                Console.WriteLine("Outside of max purchase value.");
                Tran();
            }

            int z = newPlayer.transenders;
            newPlayer.Transcenders(z, x);

            int y = x * price;

           
        
        }

        public static int Nootropics()
        {
            Player newPlayer = new Player();
            newPlayer.Hollick();

            int price = 50000;
            Console.WriteLine("Nootropics: 50,000 Ren");
            Console.WriteLine("Enter how many Nootropics you would like to buy with the max being 20.");
            Console.WriteLine("Enter 0 to return to the item select menu.");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                EarthBuyMenuSelect();
            }

            if (x > 20)
            {
                Console.WriteLine("Outside of max purchase value");
                Tran();
            }

            int y = x * price;
            return y;
        }


        public static void BatteryInventoryAdd()
        {
            Player newPlayer = new Player();
            newPlayer.Hollick();


        }

        public static void Element115InventoryAdd()
        {
            Player newPlayer = new Player();
            newPlayer.Hollick();


        }

        public static void MemoryInventoryAdd()
        {
            Player newPlayer = new Player();
            newPlayer.Hollick();


        }

        public static void TranscenderInventoryAdd()
        {
            Player newPlayer = new Player();
            newPlayer.Hollick();


        }

        public static void NootropicInventoryAdd()
        {
            Player newPlayer = new Player();
            newPlayer.Hollick();


        }


        // Earth Sell
        public static void EarthSell()
        {
            Player newPlayer = new Player();
            newPlayer.Hollick();


        }

        // Alpha Proxima 1
        public static void AlphaProxima1()
        {
            Console.WriteLine("Welcome to Hub Elon on the wonderous planet Alpha Proxima 1. Please enjoy your stay.");
        }

        public (double, double) AlphaProxima1Location()
        {
            double x = 9;
            double y = 2;
            var location = (x, y);
            return location;
        }


        // Olympus
        public static void Olympus()
        {
            Console.WriteLine("Welcome to Hub TRINITY on the megastructure planet Olympus. We hope you enjoy your stay.");
        }

        public (double, double) OlympusLocation()
        {
            double x = 4;
            double y = 5;
            var location = (x, y);
            return location;
        }
    }
}
