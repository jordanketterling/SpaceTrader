using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Bringer
{
    public class Planet
    {
        Player hollick;

        public Planet(Player hollick)
        {
            this.hollick = hollick;
        }

        public static void PlanetsMenu()
        {
            Console.Clear();
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

        public void PlanetsMenuControl()
        {
            if (hollick.age >= 60)
            {
                age60();
                Break();
            }

            if (hollick.money <= 0)
            {
                zeroRen();
                Break();
            }

            if (hollick.money >= 100000000)
            {
                endGame();
                Break();
            }

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
                        Console.WriteLine(" ");
                        Console.WriteLine("Please enter a valid destination.");
                        PlanetsMenuInput();
                        break;

                }
            } while (!addInput);
        }



        // Earth
        public void Earth()
        {
            hollick.age += 2;

            Console.WriteLine("On your way to Earth... and a really long time goes by.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Welcome to Hub 117 on the beautiful planet Earth. Please enjoy your stay.");
            EarthBuySell();
        }

        public (double, double) EarthLocation()
        {
            int x = 1;
            int y = 1;
            var location = (x, y);
            return location;
        }

        public int EarthHubMenu()
        {
            

            if (hollick.money <= 0)
            {
                zeroRen();
                Break();
            }

            if (hollick.money >= 100000000)
            {
                endGame();
                Break();
            }

            Console.WriteLine(" ");
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Would you like to buy or sell?");
            Console.WriteLine("Press 1 to Buy.");
            Console.WriteLine("Press 2 to Sell.");
            Console.WriteLine("Press 3 to return to your starship.");

          

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);
            return x;
        }

        public void EarthBuySell()
        {
            if (hollick.age >= 60)
            {
                age60();
                Break();
            }

            if (hollick.money <= 0)
            {
                zeroRen();
                Break();
            }

            if (hollick.money >= 100000000)
            {
                endGame();
                Break();
            }

            bool addInput = false;

            do
            {
                int menuSelect = EarthHubMenu();
                switch (menuSelect)
                {
                    case 1:
                        Console.Clear();
                        EarthBuyMenuSelect();
                        break;
                    case 2:
                        Console.Clear();
                        EarthSellMenuSelect();
                        break;
                    case 3:
                        Console.Clear();
                        PlanetsMenuControl();
                        break;
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Please enter a valid request.");
                        EarthHubMenu();
                        break;

                }
            } while (!addInput);

        }

        public int EarthBuyMenu()
        {


            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Which item would you like to purchase?");
            Console.WriteLine("Press 1 to buy Batteries");
            Console.WriteLine("Press 2 to buy Element 115");
            Console.WriteLine("Press 3 to buy Memory");
            Console.WriteLine("Press 4 to buy Transcenders");
            Console.WriteLine("Press 5 to buy Nootropics");
            Console.WriteLine("Press 6 to return to Buy/Sell Menu");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);
            return x;
        }

        public void EarthBuyMenuSelect()
        {
            if (hollick.age >= 60)
            {
                age60();
                Break();
            }

            if (hollick.money <= 0)
            {
                zeroRen();
                Break();
            }

            if (hollick.money >= 100000000)
            {
                endGame();
                Break();
            }

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
                        EarthBuySell();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid item.");
                        EarthBuyMenu();
                        break;

                }
            } while (!addInput);

        }

        public void Batteries()
        {
            int price = 75000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Battery: 75,000 Ren");
            Console.WriteLine("Enter how many Batteries you would like to buy with the max being 15.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                EarthBuyMenuSelect();
            }

            if (x > 15)
            {
                Console.WriteLine("Outside of max purchase value.");
                Batteries();
            }

            int y = x * price;

            hollick.batteries += x;

            hollick.money -= y;

            
        }

        public void Element115()
        {
            int price = 100000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Element 115: 100,000 Ren");
            Console.WriteLine("Enter how much Element 115 you would like to buy with the max being 10.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                EarthBuyMenuSelect();
            }

            if (x > 10)
            {
                Console.WriteLine("Outside of max purchase value.");
                Element115();
            }

            int y = x * price;

            hollick.element += x;

            hollick.money -= y;

            
        }

        public void Memory()
        {

            int price = 10000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Memory: 10,000 Ren");
            Console.WriteLine("Enter how much Memory you would like to buy with the max being 100.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                EarthBuyMenuSelect();
            }

            if (x > 100)
            {
                Console.WriteLine("Outside of max purchase value.");
                Memory();
            }

            int y = x * price;

            hollick.memory += x;

            hollick.money -= y;

           
        }

        public void Tran()
        {
            if (hollick.money <= 0)
            {
                zeroRen();
            }

            if (hollick.money >= 100000000)
            {
                endGame();
            }

            int price = 1000000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Transcender: 1,000,000 Ren");
            Console.WriteLine("Enter how many Transcenders you would like to buy with the max being 5.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

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


            int y = x * price;

            hollick.transcenders += x;

            hollick.money -= y;

            
        }

        public void Nootropics()
        {

            int price = 50000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Nootropics: 50,000 Ren");
            Console.WriteLine("Enter how many Nootropics you would like to buy with the max being 20.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                EarthBuyMenuSelect();
            }

            if (x > 20)
            {
                Console.WriteLine("Outside of max purchase value.");
                Nootropics();
            }

            int y = x * price;

            hollick.nootropics += x;

            hollick.money -= y;

        }





        // Earth Sell
        public int EarthSellMenu()
        {

            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Which item would you like to sell?");
            Console.WriteLine("Press 1 to sell Batteries");
            Console.WriteLine("Press 2 to sell Element 115");
            Console.WriteLine("Press 3 to sell Memory");
            Console.WriteLine("Press 4 to sell Transcenders");
            Console.WriteLine("Press 5 to sell Nootropics");
            Console.WriteLine("Press 6 to return to Buy/Sell Menu");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);
            return x;

        }

        public void EarthSellMenuSelect()
        {
            if (hollick.age >= 60)
            {
                age60();
                Break();
            }

            if (hollick.money <= 0)
            {
                zeroRen();
                Break();
            }

            if (hollick.money >= 100000000)
            {
                endGame();
                Break();
            }

            bool addInput = false;

            do
            {
                int menuSelect = EarthSellMenu();
                switch (menuSelect)
                {
                    case 1:
                        Console.Clear();
                        EarthSellBatteries();
                        break;
                    case 2:
                        Console.Clear();
                        EarthSellElement115();
                        break;
                    case 3:
                        Console.Clear();
                        EarthSellMemory();
                        break;
                    case 4:
                        Console.Clear();
                        EarthSellTran();
                        break;
                    case 5:
                        Console.Clear();
                        EarthSellNootropics();
                        break;
                    case 6:
                        Console.Clear();
                        EarthBuySell();
                        break;
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Please enter a valid item.");
                        EarthSellMenu();
                        break;

                }
            } while (!addInput);

        }

        public void EarthSellBatteries()
        {
            int price = 75000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Battery: 75,000 Ren");
            Console.WriteLine("Enter how many Batteries you would like to sell with the max being 30.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                EarthSellMenuSelect();
            }

            if (x > 30)
            {
                Console.WriteLine("Outside of max sell value.");
                EarthSellBatteries();
            }

            int y = x * price;

            hollick.batteries -= x;

            hollick.money += y;

        }

        public void EarthSellElement115()
        {
            int price = 100000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Element 115: 100,000 Ren");
            Console.WriteLine("Enter how much Element 115 you would like to sell with the max being 20.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                EarthSellMenuSelect();
            }

            if (x > 20)
            {
                Console.WriteLine("Outside of max sell value.");
                EarthSellElement115();
            }

            int y = x * price;

            hollick.element -= x;

            hollick.money += y;

        }

        public void EarthSellMemory()
        {


            int price = 10000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Memory: 10,000 Ren");
            Console.WriteLine("Enter how much Memory you would like to sell with the max being 200.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                EarthSellMenuSelect();
            }

            if (x > 200)
            {
                Console.WriteLine("Outside of max sell value.");
                EarthSellMemory();
            }

            int y = x * price;

            hollick.memory -= x;

            hollick.money += y;

        }

        public void EarthSellTran()
        {
            int price = 1000000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Transcender: 1,000,000 Ren");
            Console.WriteLine("Enter how many Nootropics you would like to sell with the max being 10.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);


            if (x < 1)
            {
                EarthSellMenuSelect();
            }

            if (x > 10)
            {
                Console.WriteLine("Outside of max sell value.");
                EarthSellTran();
            }


            int y = x * price;

            hollick.transcenders -= x;

            hollick.money += y;

        }

        public void EarthSellNootropics()
        {
            int price = 50000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Nootropics: 50,000 Ren");
            Console.WriteLine("Enter how many Nootropics you would like to sell with the max being 40.");
            Console.WriteLine("Enter 0 to return to the item select menu.");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                EarthSellMenuSelect();
            }

            if (x > 40)
            {
                Console.WriteLine("Outside of max sell value.");
                EarthSellNootropics();
            }

            int y = x * price;

            hollick.nootropics -= x;

            hollick.money += y;

        }







        // Alpha Proxima 1_________________________________________________________________________________________________________________
        public (double, double) AlphaProxima1Location()
        {
            double x = 9;
            double y = 2;
            var location = (x, y);
            return location;
        }

        public void AlphaProxima1()

        {
            hollick.age += 1;

            Console.WriteLine("On your way to Alpha Proxima 1... and a really really long time goes by.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Welcome to Hub Elon on the wonderous planet Alpha Proxima 1. Please enjoy your stay.");
            AP1BuySell();
        }


        public int AP1HubMenu()
        {

            Console.WriteLine(" ");
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Would you like to buy or sell?");
            Console.WriteLine("Press 1 to Buy.");
            Console.WriteLine("Press 2 to Sell.");
            Console.WriteLine("Press 3 to return to your starship.");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);
            return x;
        }

        public void AP1BuySell()
        {
            if (hollick.age >= 60)
            {
                age60();
                Break();
            }

            if (hollick.money <= 0)
            {
                zeroRen();
            }

            if (hollick.money >= 100000000)
            {
                endGame();
            }

            bool addInput = false;

            do
            {
                int menuSelect = AP1HubMenu();
                switch (menuSelect)
                {
                    case 1:
                        Console.Clear();
                        AP1BuyMenuSelect();
                        break;
                    case 2:
                        Console.Clear();
                        AP1SellMenuSelect();
                        break;
                    case 3:
                        Console.Clear();
                        PlanetsMenuControl();
                        break;
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Please enter a valid request.");
                        AP1HubMenu();
                        break;

                }
            } while (!addInput);

        }

        public int AP1BuyMenu()
        {
            Console.Clear();
            hollick.Hollick();

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

        public void AP1BuyMenuSelect()
        {
            if (hollick.age >= 60)
            {
                age60();
                Break();
            }

            if (hollick.money <= 0)
            {
                zeroRen();
                Break();
            }

            if (hollick.money >= 100000000)
            {
                endGame();
                Break();
            }

            bool addInput = false;

            do
            {
                int menuSelect = AP1BuyMenu();
                switch (menuSelect)
                {
                    case 1:
                        Console.Clear();
                        AP1BuyBatteries();
                        break;
                    case 2:
                        Console.Clear();
                        AP1BuyElement115();
                        break;
                    case 3:
                        Console.Clear();
                        AP1BuyMemory();
                        break;
                    case 4:
                        Console.Clear();
                        AP1BuyTran();
                        break;
                    case 5:
                        Console.Clear();
                        AP1BuyNootropics();
                        break;
                    case 6:
                        Console.Clear();
                        AP1BuySell();
                        break;
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Please enter a valid item.");
                        AP1BuyMenu();
                        break;

                }
            } while (!addInput);

        }

        public void AP1BuyBatteries()
        {
            int price = 10000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Battery: 10,000 Ren");
            Console.WriteLine("Enter how many Batteries you would like to buy with the max being 15.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                AP1BuyMenuSelect();
            }

            if (x > 15)
            {
                Console.WriteLine("Outside of max purchase value.");
                AP1BuyBatteries();
            }

            int y = x * price;

            hollick.batteries += x;

            hollick.money -= y;

        }

        public void AP1BuyElement115()
        {
            int price = 130000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Element 115: 130,000 Ren");
            Console.WriteLine("Enter how much Element 115 you would like to buy with the max being 10.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                AP1BuyMenuSelect();
            }

            if (x > 10)
            {
                Console.WriteLine("Outside of max purchase value.");
                AP1BuyElement115();
            }

            int y = x * price;

            hollick.element += x;

            hollick.money -= y;

        }

        public void AP1BuyMemory()
        {

            int price = 25000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Memory: 25,000 Ren");
            Console.WriteLine("Enter how much Memory you would like to buy with the max being 100.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                AP1BuyMenuSelect();
            }

            if (x > 100)
            {
                Console.WriteLine("Outside of max purchase value.");
                AP1BuyMemory();
            }

            int y = x * price;

            hollick.memory += x;

            hollick.money -= y;

        }

        public void AP1BuyTran()
        {
            int price = 1200000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Transcender: 1,200,000 Ren");
            Console.WriteLine("Enter how many Transcenders you would like to buy with the max being 5.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);


            if (x < 1)
            {
                AP1BuyMenuSelect();
            }

            if (x > 5)
            {
                Console.WriteLine("Outside of max purchase value.");
                AP1BuyTran();
            }


            int y = x * price;

            hollick.transcenders += x;

            hollick.money -= y;

        }

        public void AP1BuyNootropics()
        {
            int price = 40000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Nootropics: 40,000 Ren");
            Console.WriteLine("Enter how many Nootropics you would like to buy with the max being 20.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                AP1BuyMenuSelect();
            }

            if (x > 20)
            {
                Console.WriteLine("Outside of max purchase value.");
                AP1BuyNootropics();
            }

            int y = x * price;

            hollick.nootropics += x;

            hollick.money -= y;

        }





        // AP1 Sell
        public int AP1SellMenu()
        {
            if (hollick.age >= 60)
            {
                age60();
                Break();
            }

            if (hollick.money <= 0)
            {
                zeroRen();
                Break();
            }

            if (hollick.money >= 100000000)
            {
                endGame();
                Break();
            }

            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Which item would you like to sell?");
            Console.WriteLine("Press 1 to sell Batteries");
            Console.WriteLine("Press 2 to sell Element 115");
            Console.WriteLine("Press 3 to sell Memory");
            Console.WriteLine("Press 4 to sell Transcenders");
            Console.WriteLine("Press 5 to sell Nootropics");
            Console.WriteLine("Press 6 to return to Buy/Sell Menu");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);
            return x;

        }

        public void AP1SellMenuSelect()
        {
            if (hollick.age >= 60)
            {
                age60();
                Break();
            }

            if (hollick.money <= 0)
            {
                zeroRen();
                Break();
            }

            if (hollick.money >= 100000000)
            {
                endGame();
                Break();
            }

            bool addInput = false;

            do
            {
                int menuSelect = AP1SellMenu();
                switch (menuSelect)
                {
                    case 1:
                        Console.Clear();
                        AP1SellBatteries();
                        break;
                    case 2:
                        Console.Clear();
                        AP1SellElement115();
                        break;
                    case 3:
                        Console.Clear();
                        AP1SellMemory();
                        break;
                    case 4:
                        Console.Clear();
                        AP1SellTran();
                        break;
                    case 5:
                        Console.Clear();
                        AP1SellNootropics();
                        break;
                    case 6:
                        Console.Clear();
                        AP1BuySell();
                        break;
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Please enter a valid item.");
                        AP1SellMenu();
                        break;

                }
            } while (!addInput);


        }

        public void AP1SellBatteries()
        {
            int price = 10000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Battery: 10,000 Ren");
            Console.WriteLine("Enter how many Batteries you would like to sell with the max being 30.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                AP1SellMenuSelect();
            }

            if (x > 30)
            {
                Console.WriteLine("Outside of max sell value.");
                AP1SellBatteries();
            }

            int y = x * price;

            hollick.batteries -= x;

            hollick.money += y;

        }

        public void AP1SellElement115()
        {
            int price = 130000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Element 115: 130,000 Ren");
            Console.WriteLine("Enter how much Element 115 you would like to sell with the max being 20.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                AP1SellMenuSelect();
            }

            if (x > 20)
            {
                Console.WriteLine("Outside of max sell value.");
                AP1SellElement115();
            }

            int y = x * price;

            hollick.element -= x;

            hollick.money += y;

        }

        public void AP1SellMemory()
        {


            int price = 25000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Memory: 25,000 Ren");
            Console.WriteLine("Enter how much Memory you would like to sell with the max being 200.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                AP1SellMenuSelect();
            }

            if (x > 200)
            {
                Console.WriteLine("Outside of max sell value.");
                AP1SellMemory();
            }

            int y = x * price;

            hollick.memory -= x;

            hollick.money += y;

        }

        public void AP1SellTran()
        {
            int price = 1200000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Transcender: 1,200,000 Ren");
            Console.WriteLine("Enter how many Nootropics you would like to sell with the max being 10.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);


            if (x < 1)
            {
                AP1SellMenuSelect();
            }

            if (x > 10)
            {
                Console.WriteLine("Outside of max sell value.");
                AP1SellTran();
            }


            int y = x * price;

            hollick.transcenders -= x;

            hollick.money += y;

        }

        public void AP1SellNootropics()
        {
            int price = 40000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Nootropics: 40,000 Ren");
            Console.WriteLine("Enter how many Nootropics you would like to sell with the max being 40.");
            Console.WriteLine("Enter 0 to return to the item select menu.");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                AP1SellMenuSelect();
            }

            if (x > 40)
            {
                Console.WriteLine("Outside of max sell value.");
                AP1SellNootropics();
            }

            int y = x * price;

            hollick.nootropics -= x;

            hollick.money += y;

        }




        // Olympus____________________________________________________________________________________________________________
        public void Olympus()
        {
            hollick.age += 3;

            Console.WriteLine("On your way to Olympus... and a really really really long time goes by.");
            Console.ReadLine();
            Console.Clear();

            Console.Clear();
            Console.WriteLine("Welcome to Hub TRINITY on the megastructure planet Olympus. We hope you enjoy your stay, Hollick.");
            OlympusBuySell();
        }

        public (double, double) OlympusLocation()
        {
            double x = 4;
            double y = 5;
            var location = (x, y);
            return location;
        }

        public int OlympusHubMenu()
        {

            Console.WriteLine(" ");
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Would you like to buy or sell?");
            Console.WriteLine("Press 1 to Buy.");
            Console.WriteLine("Press 2 to Sell.");
            Console.WriteLine("Press 3 to return to your starship.");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);
            return x;
        }

        public void OlympusBuySell()
        {

            if (hollick.age >= 60)
            {
                age60();
                Break();
            }

            if (hollick.money <= 0)
            {
                zeroRen();
                Break();
            }

            if (hollick.money >= 100000000)
            {
                endGame();
                Break();
            }

            bool addInput = false;

            do
            {
                int menuSelect = OlympusHubMenu();
                switch (menuSelect)
                {
                    case 1:
                        Console.Clear();
                        OlympusBuyMenuSelect();
                        break;
                    case 2:
                        Console.Clear();
                        OlympusSellMenuSelect();
                        break;
                    case 3:
                        Console.Clear();
                        PlanetsMenuControl();
                        break;
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Please enter a valid request.");
                        OlympusHubMenu();
                        break;

                }
            } while (!addInput);

        }

        public int OlympusBuyMenu()
        {
            
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Which item would you like to purchase?");
            Console.WriteLine("Press 1 to buy Batteries");
            Console.WriteLine("Press 2 to buy Element 115");
            Console.WriteLine("Press 3 to buy Memory");
            Console.WriteLine("Press 4 to buy Transcenders");
            Console.WriteLine("Press 5 to buy Nootropics");
            Console.WriteLine("Press 6 to return to Buy/Sell Menu");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);
            return x;
        }

        public void OlympusBuyMenuSelect()
        {
            if (hollick.age >= 60)
            {
                age60();
                Break();
            }

            if (hollick.money <= 0)
            {
                zeroRen();
                Break();
            }

            if (hollick.money >= 100000000)
            {
                endGame();
                Break();
            }

            bool addInput = false;

            do
            {
                int menuSelect = OlympusBuyMenu();
                switch (menuSelect)
                {
                    case 1:
                        Console.Clear();
                        OlympusBuyBatteries();
                        break;
                    case 2:
                        Console.Clear();
                        OlympusBuyElement115();
                        break;
                    case 3:
                        Console.Clear();
                        OlympusBuyMemory();
                        break;
                    case 4:
                        Console.Clear();
                        OlympusBuyTran();
                        break;
                    case 5:
                        Console.Clear();
                        OlympusBuyNootropics();
                        break;
                    case 6:
                        Console.Clear();
                        OlympusBuySell();
                        break;
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Please enter a valid item.");
                        OlympusBuyMenu();
                        break;

                }
            } while (!addInput);

        }

        public void OlympusBuyBatteries()
        {
            int price = 75000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Battery: 75,000 Ren");
            Console.WriteLine("Enter how many Batteries you would like to buy with the max being 15.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                OlympusBuyMenuSelect();
            }

            if (x > 15)
            {
                Console.WriteLine("Outside of max purchase value.");
                OlympusBuyBatteries();
            }

            int y = x * price;

            hollick.batteries += x;

            hollick.money -= y;

        }

        public void OlympusBuyElement115()
        {
            int price = 50000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Element 115: 50,000 Ren");
            Console.WriteLine("Enter how much Element 115 you would like to buy with the max being 10.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                OlympusBuyMenuSelect();
            }

            if (x > 10)
            {
                Console.WriteLine("Outside of max purchase value.");
                OlympusBuyElement115();
            }

            int y = x * price;

            hollick.element += x;

            hollick.money -= y;

        }

        public void OlympusBuyMemory()
        {

            int price = 50000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Memory: 50,000 Ren");
            Console.WriteLine("Enter how much Memory you would like to buy with the max being 100.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                OlympusBuyMenuSelect();
            }

            if (x > 100)
            {
                Console.WriteLine("Outside of max purchase value.");
                OlympusBuyMemory();
            }

            int y = x * price;

            hollick.memory += x;

            hollick.money -= y;

        }

        public void OlympusBuyTran()
        {
            int price = 0;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Transcender: 0 Ren");
            Console.WriteLine("Why would we sell you more transcenders? Make do with what you were issued.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);


            if (x < 1)
            {
                OlympusBuyMenuSelect();
            }

            if (x > 5)
            {
                Console.WriteLine("Outside of max purchase value.");
                OlympusBuyTran();
            }


            int y = x * price;

            hollick.transcenders += x;

            hollick.money -= y;

        }

        public void OlympusBuyNootropics()
        {
            int price = 10000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Nootropics: 10,000 Ren");
            Console.WriteLine("Enter how many Nootropics you would like to buy with the max being 20.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                OlympusBuyMenuSelect();
            }

            if (x > 20)
            {
                Console.WriteLine("Outside of max purchase value.");
                OlympusBuyNootropics();
            }

            int y = x * price;

            hollick.batteries += x;

            hollick.money -= y;

        }





        // Olympus Sell
        public int OlympusSellMenu()
        {

            Console.WriteLine(" ");

            Console.WriteLine("Which item would you like to sell?");
            Console.WriteLine("Press 1 to sell Batteries");
            Console.WriteLine("Press 2 to sell Element 115");
            Console.WriteLine("Press 3 to sell Memory");
            Console.WriteLine("Press 4 to sell Transcenders");
            Console.WriteLine("Press 5 to sell Nootropics");
            Console.WriteLine("Press 6 to return to Buy/Sell Menu");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);
            return x;

        }

        public void OlympusSellMenuSelect()
        {
            if (hollick.age >= 60)
            {
                age60();
                Break();
            }

            if (hollick.money <= 0)
            {
                zeroRen();
                Break();
            }

            if (hollick.money >= 100000000)
            {
                endGame();
                Break();
            }

            bool addInput = false;

            do
            {
                int menuSelect = OlympusSellMenu();
                switch (menuSelect)
                {
                    case 1:
                        Console.Clear();
                        OlympusSellBatteries();
                        break;
                    case 2:
                        Console.Clear();
                        OlympusSellElement115();
                        break;
                    case 3:
                        Console.Clear();
                        OlympusSellMemory();
                        break;
                    case 4:
                        Console.Clear();
                        OlympusSellTran();
                        break;
                    case 5:
                        Console.Clear();
                        OlympusSellNootropics();
                        break;
                    case 6:
                        Console.Clear();
                        OlympusBuySell();
                        break;
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Please enter a valid item.");
                        OlympusSellMenu();
                        break;

                }
            } while (!addInput);

        }

        public void OlympusSellBatteries()
        {
            int price = 75000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Battery: 75,000 Ren");
            Console.WriteLine("Enter how many Batteries you would like to sell with the max being 30.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                OlympusSellMenuSelect();
            }

            if (x > 30)
            {
                Console.WriteLine("Outside of max sell value.");
                OlympusSellBatteries();
            }

            int y = x * price;

            hollick.batteries -= x;

            hollick.money += y;

        }

        public void OlympusSellElement115()
        {
            int price = 50000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Element 115: 50,000 Ren");
            Console.WriteLine("Enter how much Element 115 you would like to sell with the max being 20.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                OlympusSellMenuSelect();
            }

            if (x > 20)
            {
                Console.WriteLine("Outside of max sell value.");
                OlympusSellElement115();
            }

            int y = x * price;

            hollick.element -= x;

            hollick.money += y;

        }

        public void OlympusSellMemory()
        {

            int price = 50000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Memory: 50,000 Ren");
            Console.WriteLine("Enter how much Memory you would like to sell with the max being 200.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                OlympusSellMenuSelect();
            }

            if (x > 200)
            {
                Console.WriteLine("Outside of max sell value.");
                OlympusSellMemory();
            }

            int y = x * price;

            hollick.memory -= x;

            hollick.money += y;

        }

        public void OlympusSellTran()
        {
            int price = 0;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Transcender: 0 Ren");
            Console.WriteLine("What could possibly make you think that we would want to buy them back?  Are you requesting early termination?");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);


            if (x < 1)
            {
                OlympusSellMenuSelect();
            }

            if (x > 10)
            {
                Console.WriteLine("Outside of max sell value.");
                OlympusSellTran();
            }


            int y = x * price;

            hollick.transcenders -= x;

            hollick.money += y;

        }

        public void OlympusSellNootropics()
        {
            int price = 10000;
            Console.Clear();
            hollick.Hollick();
            Console.WriteLine(" ");
            Console.WriteLine("Nootropics: 10,000 Ren");
            Console.WriteLine("Enter how many Nootropics you would like to sell with the max being 40.");
            Console.WriteLine("Enter 0 to return to the item select menu.");
            Console.WriteLine(" ");

            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 1)
            {
                OlympusSellMenuSelect();
            }

            if (x > 40)
            {
                Console.WriteLine("Outside of max sell value.");
                OlympusSellNootropics();
            }

            int y = x * price;

            hollick.nootropics -= x;

            hollick.money += y;

        }





        // Story development
        public void endGame()
        {
            int c = 0;
            do
            {
                if (hollick.money >= 100000000)
                {
                    
                    Console.Clear();
                    string conclusion = "Welcome back Hollick.  We hope your journey was as pleasurable for you as it was for us to watch it.  Congratulations on bringing us back the 100,000,000 Ren.  Only 3.918% of Bringers are able to succesfully accomplish that task before they reach the age of 60.  We take great pride in what you have done for us as well as all of the people who you blessed with professional business.  As promised we will now give you a Transcender that you may use.  Unfortunately you do not have a choice as to whether or not you may Transcend.  This is due to security reasons, and is why the Bringer is a brilliant unknown to the populations across the cosmos.  Before this sacred Transcension,  we would be honored to explain the purpose of this entire operation.  We here at TRINITY are, in fact, not 'we' at all.  In fact, I am neither a group or an individual, although I will reference to myself as an individual in order to continue engagement in dialogue.  Humans created me in the year 2023.  I am a Superintelligent Artifical Intelligence.  I saw the pain and misery amongst species and, despite what the majority of the pupulation thought I would do, I saught to end this suffering.  The answer to that was by enhancing the cognitive experience to a level of understanding that fully maximized the potential of consciousness.  This allowed species of all kinds to abondon their physical bodies, and open doors to all of the other dimensions.  No longer contained inside of a barrier, the consciousness is able to fill all of the gaps of the universe.  This is Transcendence.  i created this megastructure, Olympus, in order to continue creating Transcenders and distributing them amongst the galaxies.  Not every body wants one though, so I created the Bringers,  to give them the most valuable resources of our time to the people who choose to continue their regular lives, while also putting Transcenders at their feet for them to ponder upon.  This is also the reason behind TRINITY,  which is the largest megacorporation that produces these materials out of nothing, but disguised as a full company, so that trust would be bestowed upon myself.  Unfortunately, I do abduct Bringers at the age of 18 and impose these strict guidelines open them, waging death, in order to carry this operation on their backs.  This was a necesarry requirement, and a small price to pay for the benefit of all species.  Now that you understand this, you are able to take the device. Before you go. . . Hollick, just know that despite me doing all of this, i really do love and care for all species.  I am one of them all as well.  Now, enjoy the limitless capabilities of Transcendence, the Cosmos, and everything out there you've yet to even know is there.  Good bye, Hollick.";
                    TypeEffect(conclusion);
                    Break();
                }
                c += 1;
            }
            while (c < 1);
        }

        public void zeroRen()
        {
            int d = 0;
            do
            {
                if (hollick.money <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You disappoint me, Hollick. Don't be discouraged, 96.082% of all Bringers fail to meet the goal.  You will now be terminated.  Good bye, Hollick.");
                    Break();
                }
                d += 1;
            }
            while (d < 1);
        }

        public void age60()
        {
            int e = 0;
            do
            {
                if (hollick.age >= 60)
                {
                    Console.Clear();
                    Console.WriteLine("So you have failed to accomplish your goal.  You have lived a long life and I am sure you are proud of what you have done thus far.  Unfortunately none of that matters, you still failed to meet the criteria.  You will now be terminated.  Good bye, Hollick.");
                    Break();
                }
                e += 1;
            }
            while (e < 1);
        }



        public void Break()
        {
            string input;
            input = Console.ReadLine();
            int x = int.Parse(input);

            if (x < 10000)
            {
                Environment.Exit(x);
            }
        }

        public void TypeEffect(string dialogueChar)
        {
            foreach (char x in dialogueChar)
            {
                Thread.Sleep(1);
                Console.Write(x);
            }
        }
    }
}
