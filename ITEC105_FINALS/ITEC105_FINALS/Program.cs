using System;
using System.Collections.Generic;

namespace ITEC105_FINALS
{
    class Program
    {
        static void Main(string[] args)
        {
            //eto yung queue para sa drinks
            Queue<int> black_coffee = new Queue<int>();
            Queue<int> cappucino = new Queue<int>();
            Queue<int> expresso = new Queue<int>();

            //eto naman yung queue para sa cake
            Queue<int> cheesecake = new Queue<int>();
            Queue<int> tiramisu = new Queue<int>();
            Queue<int> strawberry_cake = new Queue<int>();

            //eto naman yung sa pastries
            Queue<int> donut = new Queue<int>();
            Queue<int> pie = new Queue<int>();
            Queue<int> cinnamon_roll = new Queue<int>();




            string choice, drinks, cake, pastries, remove;
            Console.WriteLine(" Welcome to D & N 's Restaurant!! ");
            Console.WriteLine(" Please choose what you want!!  ");
            Console.WriteLine("[A] Drinks");
            Console.WriteLine("[B] Cakes");
            Console.WriteLine("[C] Pastries");
            Console.WriteLine("[D] Remove");
            Console.WriteLine("[E] Show Order List");
            Console.WriteLine("[F] Exit Menu");

            while (true)
            {
                Console.Write("\nSELECT Your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "A":
                        Console.WriteLine("Drink's List");
                        Console.WriteLine("[A] Black Coffee");
                        Console.WriteLine("[B] Cappuccino");
                        Console.WriteLine("[C] Espresso");
                        Console.Write("\nSELECT Your choice: ");
                        drinks = Console.ReadLine();

                        switch (drinks)
                        {
                            case "A" :
                                Console.Write("how many black coffee do you want? ");
                                black_coffee.Enqueue(Convert.ToInt32(Console.ReadLine()));
                                Console.WriteLine("order confirmed!!");

                                break;

                            case "B":

                                Console.Write("how many Cappucino do you want? ");
                                cappucino.Enqueue(Convert.ToInt32(Console.ReadLine()));
                                Console.WriteLine("order confirmed!!");

                                break;

                            case "C":

                                Console.Write("how many Expresso do you want? ");
                                expresso.Enqueue(Convert.ToInt32(Console.ReadLine()));
                                Console.WriteLine("order confirmed!!");

                                break;
                        }
                        break;

                    case "B":
                        Console.WriteLine("Cake's List");
                        Console.WriteLine("[A] Cheesecake");
                        Console.WriteLine("[B] Tiramisu");
                        Console.WriteLine("[C] Strawberry Cake");
                        cake = Console.ReadLine();

                        switch (cake)
                        {
                            case "A":
                                Console.Write("how many cheesecake do you want? ");
                                cheesecake.Enqueue(Convert.ToInt32(Console.ReadLine()));
                                Console.WriteLine("order confirmed!!");

                                break;

                            case "B":

                                Console.Write("how many cheesecake do you want? ");
                                tiramisu.Enqueue(Convert.ToInt32(Console.ReadLine()));
                                Console.WriteLine("order confirmed!!");

                                break;

                            case "C":
                                Console.Write("how many strawberry cake do you want? ");
                                strawberry_cake.Enqueue(Convert.ToInt32(Console.ReadLine()));
                                Console.WriteLine("order confirmed!!");
                                break;
                        }
                        break;

                    case "C":
                        Console.WriteLine("Pastries List");
                        Console.WriteLine("[A] Donuts");
                        Console.WriteLine("[B] Pie");
                        Console.WriteLine("[C] Cinnamon roll");
                        pastries = Console.ReadLine();

                        switch (pastries)
                        {
                            case "A":
                                Console.Write("how many Donuts do you want? ");
                                donut.Enqueue(Convert.ToInt32(Console.ReadLine()));
                                Console.WriteLine("order confirmed!!");

                                break;

                            case "B":

                                Console.Write("how many Pie do you want? ");
                                pie.Enqueue(Convert.ToInt32(Console.ReadLine()));
                                Console.WriteLine("order confirmed!!");

                                break;

                            case "C":
                                Console.Write("how many Cinnamon roll do you want? ");
                                cinnamon_roll.Enqueue(Convert.ToInt32(Console.ReadLine()));
                                Console.WriteLine("order confirmed!!");
                                break;
                        }
                        break;

                    case "D":

                        Console.Write("Remove");
                        Console.WriteLine("[A] Black Coffee");
                        Console.WriteLine("[B] Cappuccino");
                        Console.WriteLine("[C] Espresso");
                        Console.WriteLine("[D] Cheesecake");
                        Console.WriteLine("[E] Tiramisu");
                        Console.WriteLine("[F] Strawberry Cake");
                        Console.WriteLine("[G] Donuts");
                        Console.WriteLine("[H] Pie");
                        Console.WriteLine("[I] Cinnamon Roll");
                        Console.Write("\nSELECT Your choice: ");
                        remove = Console.ReadLine();

                        switch (remove)
                        {
                            case "A":
                                black_coffee.Dequeue();

                                Console.WriteLine("black coffee removed!");
                                break;

                            case "B":
                                cappucino.Dequeue();
                                Console.WriteLine("Cappucino removed!");

                                break;

                            case "C":
                                expresso.Dequeue();
                                Console.WriteLine("Espresso removed!");
                                break;

                            case "D":
                                cheesecake.Dequeue();
                                Console.WriteLine("Tiramisu removed!");
                                break;

                            case "E":
                                strawberry_cake.Dequeue();
                                Console.WriteLine("strawberry cake removed!");
                                break;

                            case "F":
                                donut.Dequeue();
                                Console.WriteLine("donut removed!");
                                break;

                            case "G":
                                pie.Dequeue();
                                Console.WriteLine("pie removed!");
                                break;

                            case "H":
                                cinnamon_roll.Dequeue();
                                Console.WriteLine("cinnamon roll removed!");
                                break;


                        }
                        break;

                    case "E":
                        Console.WriteLine("========================================================");
                        foreach (int black_coffees in black_coffee)
                        {
                            Console.Write("black coffee: ");
                            Console.WriteLine(black_coffees);

                        }
                        

                        foreach (int cappucinos in cappucino)
                        {
                            Console.WriteLine("cappucino: " + cappucinos);

                        }

                        foreach (int expressos in expresso)
                        {
                            Console.Write("expresso: " + expressos);

                        }
                        Console.WriteLine("========================================================");
                        foreach (int cheesecakes in cheesecake)
                        {
                            Console.WriteLine("cheesecake: " + cheesecakes);

                        }

                        foreach (int strawberry_cakes in strawberry_cake)
                        {
                            Console.WriteLine("strawberry_cake: " + strawberry_cakes);

                        }

                        Console.WriteLine("========================================================");

                        foreach (int donuts in donut)
                        {
                            Console.Write("donut: " + donuts);

                        }

                        foreach (int pies in pie)
                        {
                            Console.WriteLine("pie: " + pies);

                        }

                        foreach (int cinnamon_rolls in cinnamon_roll)
                        {
                            Console.WriteLine("cinnamon roll: " + cinnamon_rolls);

                        }
                        Console.WriteLine("========================================================");

                        break;






                }
                //end of switch
                if (choice == "F")
                {
                    break;

                }
            }
        }
    }
}
