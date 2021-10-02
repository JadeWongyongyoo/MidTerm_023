using System;
using System.Collections.Generic;
namespace Test_3
{

    class Program
    {
        static void Main(string[] args)
        {
            ChoosMenu();
            ListFlower();
            Choice();
        }
        static void ChoosMenu()
        {
            Console.Clear();
            string decide = "y";
            string selectFlower;
            FlowerStore flowerStore = new FlowerStore();
            do
            {
                Console.WriteLine("Select number for buy flower : ");
                Console.WriteLine("----------------------------------------------------");
                foreach (string i in flowerStore.flowerList)
                {
                    Console.Write((flowerStore.flowerList.IndexOf(i) + 1) + " ");
                    Console.WriteLine(i);
                }
                selectFlower = Console.ReadLine();

                

                Console.WriteLine("You can stop this progress ? exit for >> exit << progress and press any key for continue");

                decide = Console.ReadLine();
                if (decide == "exit")
                {
                    Console.Write("Current my cart");
                    flowerStore.showCart();
                }
            }
            while (decide != "exit");

        }

        static FlowerStore flowerStore;
        static void ListFlower ()
        {
            Program.flowerStore = new FlowerStore();
        }

        static void Choice(string selectFlower)
        {
            switch (selectFlower)
            {
                case "1":
                    flowerStore.addToCart(flowerStore.flowerList[0]);
                    Console.WriteLine("Added " + flowerStore.flowerList[0]);
                    break;
                case "2":
                    flowerStore.addToCart(flowerStore.flowerList[1]);
                    Console.WriteLine("Added " + flowerStore.flowerList[1]);
                    break;
                default:
                    Console.WriteLine("Not Added to cart. found select number of flower");
                    break;
            }
        }
    }
        
    class FlowerStore
    {
            public List<string> flowerList = new List<string>();
        List<string> cart = new List<string>();
        public FlowerStore()
        {
            flowerList.Add("Rose");
            flowerList.Add("Lotus");
        }
        public void addToCart(string name)
        {
            cart.Add(name);
        }

        public void showCart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
                Console.WriteLine("----------------------------------------------------");
            }
            else
            {
                Console.WriteLine("My Cart :");
                foreach (string i in cart)
                {
                    Console.WriteLine(i);
                }
            }
        } 
    }

}
