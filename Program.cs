using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ships
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool IsON = true;
            bool IsONGlobal = true;
            Menu menu = new Menu();
            DuelGameManager gm;
            int player1 = 0;
            int player2 = 0;

            

            
            while(IsONGlobal)
            {
                menu.ShowMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (choice == 1)
                {
                    Console.Clear();
                    bool IsON2 = true;


                    while (IsON2)
                    {
                        gm = new DuelGameManager();
                        gm.SetPoints(player1, player2);
                        gm.ShowBoard();
                        gm.PlaceShip();
                        Console.Clear();
                        gm.ShowBoard();

                        while (IsON)
                        {
                            Console.WriteLine("Podaj pole do strzalu: ");
                            string move = Console.ReadLine().ToUpper();

                            gm.MakeMove(move);
                            if (gm.p2hp == 0)
                            {
                                Console.WriteLine("Wygrał gracz 1");
                                player1++;
                                gm.SetPoints(player1, player2);
                                Console.ReadKey();
                                IsON = false;

                            }
                            if (gm.p1hp == 0)
                            {
                                Console.WriteLine("Wygrał gracz 2");
                                player2++;
                                gm.SetPoints(player1, player2);
                                Console.ReadKey();
                                IsON = false;
                            }
                            Console.Clear();
                            gm.ShowBoard();
                        }

                        Console.WriteLine("Chcesz kontynuowac gre? y/n");
                        string playAgain = Console.ReadLine().ToUpper();

                        if (playAgain == "N")
                            IsON2 = false;
                        if (playAgain == "Y")
                            IsON2 = true;
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (choice == 2)
                {

                }
                else if (choice == 3)
                {
                    gm = new DuelGameManager();
                    player1 = 0;
                    player2 = 0;
                    gm.SetPoints(player1, player2);
                    Console.Clear();
                    Console.WriteLine("Zresetowano punkty!");
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    IsONGlobal = false;
                    Console.WriteLine("Do zobaczenia!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Podales zla opcje!");
                }
            }
            
        }
    }
}
