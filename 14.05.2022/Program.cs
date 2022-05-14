using _14._05._2022.Models;
using System;

namespace _14._05._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity;
            int currentgun;
            bool isSingle;
            //Weapon weapon = new Weapon(30, 22, false);

            do
            {
                Console.WriteLine("Daraq tutumunu yazin ");
                capacity = Convert.ToInt32(Console.ReadLine());

            } while (capacity < 0);
            do
            {
                Console.WriteLine("Currentgun yazin ");
                currentgun = Convert.ToInt32(Console.ReadLine());
            } while (currentgun < 0 || currentgun > capacity);

            Console.WriteLine("ates modunu yazin ");
            isSingle = Convert.ToBoolean(Console.ReadLine());

            Weapon weapon2 = new Weapon(capacity, currentgun, isSingle);

            bool check = true;
            do
            {
                Console.WriteLine("Enter The Case:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("0. Informasiya al");
                        Console.WriteLine("1. Shot");
                        Console.WriteLine("2. Fire");
                        Console.WriteLine("3. GetREmainBulletCount");
                        Console.WriteLine("4. Reload");
                        Console.WriteLine("5. Change Fire Mode");
                        Console.WriteLine("6. Quit");
                        break;
                    case 1:
                        weapon2.Shot();
                        break;
                    case 2:
                        weapon2.Fire();
                        break;

                    case 3:
                        Console.WriteLine(weapon2.GetRemainBulletCount());
                        break;

                    case 4:
                        Console.WriteLine(weapon2.Reload());
                        break;

                    case 5:
                        Console.WriteLine(weapon2.ChangeFireMode());
                        break;

                    case 6:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Qaqam Yorma Ozunu Basqa Kod Yoxdu");
                        break;
                }
            } while (check);
        }
    }
}
