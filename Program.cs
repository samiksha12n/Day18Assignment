using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18Assignment
{
    internal class Program
    {
        public delegate void Winner();
           class TestPlayer
        {
            event Winner Result;
           public void Show()
            {
                Game game = new Game();
                if(game.EnergyLevel>4 || game.WiningProbability>60)
                {
                    Console.WriteLine("Congratulations!!! Your the Winner");
                }
                else if(game.EnergyLevel>1 || game.WiningProbability>50)
                {
                    Console.WriteLine("Congratulations!!! Your the Runner Up");
                }
                else
                {
                    Console.WriteLine("Better Luck Next Time!!!");
                }
            }
        }
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Enter Your Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Your Lucky Number from 1-10");
                int num = int.Parse(Console.ReadLine());
                Game game1 = new Game();
                TestPlayer test = new TestPlayer();
                if (num == 1)
                {
                    game1.FirstSpin();
                    test.Show();

                }
                else if (num == 2)
                {
                    game1.SecondSpin();
                    test.Show();
                }
                else if (num == 3)
                {
                    game1.ThirdSpin();
                    test.Show();
                }
                else if (num == 4)
                {
                    game1.FourtSpin();
                    test.Show();
                }
                else if (num == 5)
                {
                    game1.FifthSpin();
                    test.Show();
                }
                else if (num == 6)
                {
                    game1.SixthSpin();
                    test.Show();
                }
                else if (num == 7)
                {
                    game1.SeventhSpin();
                    test.Show();
                }
                else if (num == 8)
                {
                    game1.EigthSpin();
                    test.Show();
                }
                else if (num == 9)
                {
                    game1.NinthSpin();
                    test.Show();
                }
                else if (num == 10)
                {
                    game1.TenthSpin();
                    test.Show();
                }
                else
                {
                    Console.WriteLine("Please enter number betwwen 1-10");
                }
                Console.WriteLine("If you want to continue Then press y");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
            Console.ReadKey();
        }
    }
}
