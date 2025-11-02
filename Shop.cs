using database.Product;
//using practiceproject.Customer;
//using practiceproject.Order;
using practiceproject.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproject
{
    internal class Shop
    {
        public void Start()
        {
            while (true)
            {
                Console.Clear();
                string option = MainMenu();
                if (option == "1")
                {

                    ProductUI productui = new ProductUI();
                    productui.ProductDriver();
                }
                else if (option == "2")
                {
                    //CustomerUI customerUI = new CustomerUI();
                    //customerUI.CustomerDriver();
                }
                else if (option == "3")
                {
                    //OrderUI orderUI = new OrderUI();
                    //orderUI.CreateOrderDriver();
                }
                else if (option == "4")
                {
                    //OrderUI orderUI = new OrderUI();
                    //orderUI.OrderDriver();
                }
                else if (option == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }
            }

        }

        public string MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("      Shop Management System    ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1 PRODUCT MANAGEMENT SYSTEM");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("2 CUSTOMER MANAGEMENT SYSTEM");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("3 ORDER MANAGEMENT SYSTEM");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("4 VIEW ORDER HISTORY");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string option = Console.ReadLine();
            return option;
        }
    }
}