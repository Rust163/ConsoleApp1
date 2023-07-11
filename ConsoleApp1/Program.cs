using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int generalChoise = 0;
            Console.WriteLine("Список задач: \n" +
                " Задача № 1 \n " +
                " Задача № 2 \n " +
                " Задача № 3 \n " +
                " Задача № 4 \n " +
                " Задача № 5 \n " +
                " Задача № 6 \n " +
                " Задача № 7 \n " +
                " Задача № 8 \n " +
                " Задача № 9 \n " +
                " Задача № 10 ");
            Console.Write("Введите номер задачи: ");
            generalChoise = Convert.ToInt32(Console.ReadLine());
            switch (generalChoise)
            {
                case 1:
                    Console.WriteLine("Задача № 1");
                    string name;
                    int age1;
                    Console.WriteLine("Hello, send your data piease!");
                    Console.Write("Input your name: ");
                    name = Console.ReadLine();
                    Console.WriteLine($"Your name: {name}");
                    Console.Write("Input your age: ");
                    age1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Your age is: {age1}");
                    break;

                case 2:
                    int num = 0;
                    for (int i = 0; i < 50; i++)
                    {
                        num++;
                        Console.WriteLine(num++);
                    }
                    break;

                case 3:
                    int health;
                    int armor;
                    int damage;
                    int precentConvert = 100;
                    Console.Write("Input health: ");
                    health = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input armor: ");
                    armor = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input damage: ");
                    damage = Convert.ToInt32(Console.ReadLine());
                    health -= damage * armor / precentConvert;
                    Console.WriteLine($"You've been dealt {damage} damage, you have left {health} health");
                    break;

                case 4:
                    int money1;
                    int food;
                    int foodUnitPrice = 10;
                    bool isAbleToPay;

                    Console.WriteLine($"Welcom to the market! Today sell, our food price {foodUnitPrice} $");

                    Console.Write("How much money do you have?: ");
                    money1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("How much do you want to buy food?: ");
                    food = Convert.ToInt32(Console.ReadLine());

                    isAbleToPay = money1 >= food * foodUnitPrice;
                    food *= Convert.ToInt32(isAbleToPay);
                    money1 -= food * foodUnitPrice;
                    Console.WriteLine($"You have {food} food in your bag and {money1} money in your wallet");
                    break;

                case 5:
                    int age;
                    Console.Write("Input age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age >= 18)
                    {
                        Console.WriteLine("Welcom");
                    }
                    else
                    {
                        Console.WriteLine("Fuck you!!!");
                    }
                    break;

                case 6:
                    string dayOfWeek;
                    Console.Write("Input day of the week: ");
                    dayOfWeek = Console.ReadLine();
                    if (dayOfWeek == "monday")
                    {
                        Console.WriteLine("Go to lesson!");
                    }
                    else if (dayOfWeek == "tuesday")
                    {
                        Console.WriteLine("Write lesson!");
                    }
                    break;

                case 7:
                    int money = 300;
                    int lvl = 8;
                    if (money >= 500 || lvl > 9)
                    {
                        Console.WriteLine("Welcom to clan!");
                    }
                    else
                    {
                        Console.WriteLine("Fock of dog!");
                    }
                    break;
                case 8:
                    string dayOfWeek1;
                    Console.Write("Input day of the week: ");
                    dayOfWeek1 = Console.ReadLine();
                    switch (dayOfWeek1)
                    {
                        case "monday":
                            Console.WriteLine("Go to lesson!");
                            break;
                        case "tuesday":
                            Console.WriteLine("Write lesson!");
                            break;
                        case "saturday":
                        case "sunday":
                            Console.WriteLine("i am sleep!");
                            break;
                        default:
                            Console.WriteLine("No this day!!!");
                            break;
                    }
                    break;

                //if (dayOfWeek == "monday")
                //{
                //    Console.WriteLine("Go to lesson!");
                //}
                //else if (dayOfWeek == "tuesday")
                //{
                //    Console.WriteLine("Write lesson!");
                //}
                case 9:
                    string password = "123qwe";
                    string userInput;

                    Console.Write("Input password!");
                    userInput = Console.ReadLine();
                    if (userInput == password)
                    {
                        Console.WriteLine("Correct passord. Welcom to online bank!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect passord. Fack off!");
                    }
                    break;
                case 10:
                    float rubInWallet;
                    float dollarInWallet;
                    int rubToUsd = 64, usdToRub = 66;
                    float exchangeCurrentCount;
                    string desiretOperation;
                    Console.WriteLine("Welcom to currency exchanger!!!");

                    Console.Write("Input balans rub: ");
                    rubInWallet = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Input balans dollars: ");
                    dollarInWallet = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Select the required operation!");
                    Console.WriteLine("1) Exchange rubles for dollars?");
                    Console.WriteLine("2) Exchange rubles dollars for rubles?");
                    Console.Write("Your choise: ");
                    desiretOperation = Console.ReadLine();
                    switch (desiretOperation)
                    {
                        case "1":
                            Console.WriteLine("Exchange rub / dol");
                            Console.Write("How many exchanget?: ");
                            exchangeCurrentCount = Convert.ToSingle(Console.ReadLine());
                            if (rubInWallet >= exchangeCurrentCount)
                            {
                                rubInWallet -= exchangeCurrentCount;
                                dollarInWallet += exchangeCurrentCount / rubToUsd;
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                            }
                            break;
                        case "2":
                            Console.WriteLine("Exchange dol / rub");
                            Console.Write("How many exchanget?: ");
                            exchangeCurrentCount = Convert.ToSingle(Console.ReadLine());
                            if (rubInWallet >= exchangeCurrentCount)
                            {
                                dollarInWallet -= exchangeCurrentCount;
                                rubInWallet += exchangeCurrentCount * usdToRub;
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                            }
                            break;
                        default:
                            Console.WriteLine("Operation fail!");
                            break;
                    }
                    Console.WriteLine($"Youe balans {rubInWallet} rub and {dollarInWallet}  dollars!");
                    break;
            }
        }
    }
}
