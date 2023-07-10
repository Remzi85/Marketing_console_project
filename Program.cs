using System;
namespace Marketing_Console
{
    public class Program
    {
        public static void Main(string[] args) { 
        
                int option;

                do
                {
                    Console.WriteLine("1.Products ");
                    Console.WriteLine("2. Add Product");
                    Console.WriteLine("3. Delete Product ");
                    Console.WriteLine("4. Sales");
                    Console.WriteLine("5. Add Sale ");
                    Console.WriteLine("6. Delete Sale");
                    Console.WriteLine("7. Sale Items");
                    Console.WriteLine("8. Add Sale Item");
                    Console.WriteLine("9. Delete Sale Item ");
                    Console.WriteLine("10. Report");
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("-----------");

                    Console.WriteLine("Enter option:");

                    while (!int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.WriteLine("Invalid number!");
                        Console.WriteLine("-----------");
                        Console.WriteLine("Enter option:");
                    }

                    switch (option)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 8:
                            break;
                        case 9:
                            break;
                        case 10:
                            break;
                        case 0:
                            Console.WriteLine("Bye!");
                            break;
                        default:
                            Console.WriteLine("No such option!");
                            break;
                    }

                } while (option != 0);
            }
        }
    }
