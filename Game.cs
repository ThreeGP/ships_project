using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ships
{
    public class DuelGameManager
    {
        static public int currentPlayerMove = 1;
        Dictionary<string, string> playerOneBoard = new Dictionary<string, string>();
        Dictionary<string, string> playerTwoBoard = new Dictionary<string, string>();
        Dictionary<string, string> playerOneShots = new Dictionary<string, string>();
        Dictionary<string, string> playerTwoShots = new Dictionary<string, string>();

        public DuelGameManager()
        {
            const string ALPHABET = "ABCDEFGHIJ";
            for (int i = 0; i < ALPHABET.Length; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    playerOneBoard.Add($"{ALPHABET[i]}{j}", " ");
                    playerTwoBoard.Add($"{ALPHABET[i]}{j}", " ");
                    playerOneShots.Add($"{ALPHABET[i]}{j}", " ");
                    playerTwoShots.Add($"{ALPHABET[i]}{j}", " ");
                }
            }
        }
        Menu menu = new Menu();
        int player_1;
        int player_2;
        
        public void SetPoints(int player1, int player2)
        {
            player_1 = player1;
            player_2 = player2;
        }


        public void ShowBoard()
        {
            Dictionary<string, string> board = currentPlayerMove == 1 ? playerOneBoard : playerTwoBoard;
            Dictionary<string, string> board2 = currentPlayerMove == 1 ? playerOneShots : playerTwoShots;
            Console.WriteLine($"                 Gracz1: {player_1}      \t\t\t\t\t\t   Gracz2: {player_2}");
            Console.WriteLine($"               TWOJE STATKI         o - statek / * - trafiony / x - pudlo \t TWOJE STRZALY");
            Console.WriteLine();
            Console.WriteLine("    A | B | C | D | E | F | G | H | I | J  \t\t\t     A | B | C | D | E | F | G | H | I | J  ");
            Console.WriteLine("  -----------------------------------------\t\t\t   -----------------------------------------");
            Console.WriteLine($" 1| {board["A1"]} | {board["B1"]} | {board["C1"]} | {board["D1"]} | {board["E1"]} | {board["F1"]} | {board["G1"]} | {board["H1"]} | {board["I1"]} | {board["J1"]}\t\t\t  1| {board2["A1"]} | {board2["B1"]} | {board2["C1"]} | {board2["D1"]} | {board2["E1"]} | {board2["F1"]} | {board2["G1"]} | {board2["H1"]} | {board2["I1"]} | {board2["J1"]}");
            Console.WriteLine("  -----------------------------------------\t\t\t   -----------------------------------------");
            Console.WriteLine($" 2| {board["A2"]} | {board["B2"]} | {board["C2"]} | {board["D2"]} | {board["E2"]} | {board["F2"]} | {board["G2"]} | {board["H2"]} | {board["I2"]} | {board["J2"]}\t\t\t  2| {board2["A2"]} | {board2["B2"]} | {board2["C2"]} | {board2["D2"]} | {board2["E2"]} | {board2["F2"]} | {board2["G2"]} | {board2["H2"]} | {board2["I2"]} | {board2["J2"]}");
            Console.WriteLine("  -----------------------------------------\t\t\t   -----------------------------------------");
            Console.WriteLine($" 3| {board["A3"]} | {board["B3"]} | {board["C3"]} | {board["D3"]} | {board["E3"]} | {board["F3"]} | {board["G3"]} | {board["H3"]} | {board["I3"]} | {board["J3"]}\t\t\t  3| {board2["A3"]} | {board2["B3"]} | {board2["C3"]} | {board2["D3"]} | {board2["E3"]} | {board2["F3"]} | {board2["G3"]} | {board2["H3"]} | {board2["I3"]} | {board2["J3"]}");
            Console.WriteLine("  -----------------------------------------\t\t\t   -----------------------------------------");
            Console.WriteLine($" 4| {board["A4"]} | {board["B4"]} | {board["C4"]} | {board["D4"]} | {board["E4"]} | {board["F4"]} | {board["G4"]} | {board["H4"]} | {board["I4"]} | {board["J4"]}\t\t\t  4| {board2["A4"]} | {board2["B4"]} | {board2["C4"]} | {board2["D4"]} | {board2["E4"]} | {board2["F4"]} | {board2["G4"]} | {board2["H4"]} | {board2["I4"]} | {board2["J4"]}");
            Console.WriteLine("  -----------------------------------------\t\t\t   -----------------------------------------");
            Console.WriteLine($" 5| {board["A5"]} | {board["B5"]} | {board["C5"]} | {board["D5"]} | {board["E5"]} | {board["F5"]} | {board["G5"]} | {board["H5"]} | {board["I5"]} | {board["J5"]}\t\t\t  5| {board2["A5"]} | {board2["B5"]} | {board2["C5"]} | {board2["D5"]} | {board2["E5"]} | {board2["F5"]} | {board2["G5"]} | {board2["H5"]} | {board2["I5"]} | {board2["J5"]}");
            Console.WriteLine("  -----------------------------------------\t\t\t   -----------------------------------------");
            Console.WriteLine($" 6| {board["A6"]} | {board["B6"]} | {board["C6"]} | {board["D6"]} | {board["E6"]} | {board["F6"]} | {board["G6"]} | {board["H6"]} | {board["I6"]} | {board["J6"]}\t\t\t  6| {board2["A6"]} | {board2["B6"]} | {board2["C6"]} | {board2["D6"]} | {board2["E6"]} | {board2["F6"]} | {board2["G6"]} | {board2["H6"]} | {board2["I6"]} | {board2["J6"]}");
            Console.WriteLine("  -----------------------------------------\t\t\t   -----------------------------------------");
            Console.WriteLine($" 7| {board["A7"]} | {board["B7"]} | {board["C7"]} | {board["D7"]} | {board["E7"]} | {board["F7"]} | {board["G7"]} | {board["H7"]} | {board["I7"]} | {board["J7"]}\t\t\t  7| {board2["A7"]} | {board2["B7"]} | {board2["C7"]} | {board2["D7"]} | {board2["E7"]} | {board2["F7"]} | {board2["G7"]} | {board2["H7"]} | {board2["I7"]} | {board2["J7"]}");
            Console.WriteLine("  -----------------------------------------\t\t\t   -----------------------------------------");
            Console.WriteLine($" 8| {board["A8"]} | {board["B8"]} | {board["C8"]} | {board["D8"]} | {board["E8"]} | {board["F8"]} | {board["G8"]} | {board["H8"]} | {board["I8"]} | {board["J8"]}\t\t\t  8| {board2["A8"]} | {board2["B8"]} | {board2["C8"]} | {board2["D8"]} | {board2["E8"]} | {board2["F8"]} | {board2["G8"]} | {board2["H8"]} | {board2["I8"]} | {board2["J8"]}");
            Console.WriteLine("  -----------------------------------------\t\t\t   -----------------------------------------");
            Console.WriteLine($" 9| {board["A9"]} | {board["B9"]} | {board["C9"]} | {board["D9"]} | {board["E9"]} | {board["F9"]} | {board["G9"]} | {board["H9"]} | {board["I9"]} | {board["J9"]}\t\t\t  9| {board2["A9"]} | {board2["B9"]} | {board2["C9"]} | {board2["D9"]} | {board2["E9"]} | {board2["F9"]} | {board2["G9"]} | {board2["H9"]} | {board2["I9"]} | {board2["J9"]}");
            Console.WriteLine("  -----------------------------------------\t\t\t   -----------------------------------------");
            Console.WriteLine($"10| {board["A10"]} | {board["B10"]} | {board["C10"]} | {board["D10"]} | {board["E10"]} | {board["F10"]} | {board["G10"]} | {board["H10"]} | {board["I10"]} | {board["J10"]}\t\t\t 10| {board2["A10"]} | {board2["B10"]} | {board2["C10"]} | {board2["D10"]} | {board2["E10"]} | {board2["F10"]} | {board2["G10"]} | {board2["H10"]} | {board2["I10"]} | {board2["J10"]}");
            Console.WriteLine("  -----------------------------------------\t\t\t   -----------------------------------------");
            Console.WriteLine($"Ruch gracza: {currentPlayerMove} ");
        }
        public int p2hp = 3;
        public int p1hp = 3;

        public bool MakeMove(string move)
        {
            if (currentPlayerMove == 1)
            {
                if (playerTwoBoard[move] == "o")
                {
                    playerTwoBoard[move] = "*";
                    playerOneShots[move] = "*";
                    SinkShip(playerTwoBoard, move);
                    p2hp--;
                    Console.WriteLine("Trafiles w statek!");
                    Console.ReadKey();

                }
                else if (playerTwoBoard[move] == "x" || playerTwoShots[move] == "*")
                {
                    Console.WriteLine("Strzelałeś już w to miejsce");
                }
                else if (playerTwoBoard[move] == " ")
                {
                    Console.WriteLine("Pudło!");
                    playerTwoBoard[move] = "x";
                    playerOneShots[move] = "x";
                    currentPlayerMove = 2;
                    Console.ReadKey();
                }
            }
            else if (currentPlayerMove == 2)
            {
                if (playerOneBoard[move] == "o")
                {
                    playerOneBoard[move] = "*";
                    playerTwoShots[move] = "*";
                    SinkShip(playerOneBoard, move);
                    p1hp--;
                    Console.WriteLine("Trafiles w statek!");
                    Console.ReadKey();
                }
                else if (playerOneBoard[move] == "x" || playerTwoShots[move] == "*")
                {
                    Console.WriteLine("Strzelałeś już w to miejsce");
                    Console.ReadKey();
                }
                else if (playerOneBoard[move] == " ")
                {
                    Console.WriteLine("Pudło!");
                    playerOneBoard[move] = "x";
                    playerTwoShots[move] = "x";
                    currentPlayerMove = 1;
                }
            }
            return true;
        }
        public void TestPlaceShip()
        {
            playerOneBoard["A1"] = "o";
            playerOneBoard["A3"] = "o";
            playerOneBoard["A5"] = "o";
            playerOneBoard["A7"] = "o";

            playerOneBoard["B1"] = "o";
            playerOneBoard["C1"] = "o";

            playerOneBoard["D5"] = "o";
            playerOneBoard["E5"] = "o";
            playerOneBoard["F5"] = "o";

            playerOneBoard["C6"] = "o";
            playerOneBoard["C7"] = "o";
            playerOneBoard["C8"] = "o";
            playerOneBoard["C9"] = "o";

            // player 2
            playerTwoBoard["A1"] = "o";
            playerTwoBoard["A3"] = "o";
            playerTwoBoard["A5"] = "o";
            playerTwoBoard["A7"] = "o";

            playerTwoBoard["B1"] = "o";
            playerTwoBoard["C1"] = "o";

            playerTwoBoard["D5"] = "o";
            playerTwoBoard["E5"] = "o";
            playerTwoBoard["F5"] = "o";

            playerTwoBoard["C6"] = "o";
            playerTwoBoard["C7"] = "o";
            playerTwoBoard["C8"] = "o";
            playerTwoBoard["C9"] = "o";

        }
        bool IsPositionValid(Dictionary<string, string> board, string position)
        {
            const string ALPHABET = "ABCDEFGHIJ";
            Console.ReadKey();

            if (board[position] == "o")
                return false;

            int row = ALPHABET.IndexOf(position[0]);

            int col = int.Parse(position.Substring(1)) - 1;

            for (int r = row - 1; r <= row + 1; r++)
            {
                for (int c = col - 1; c <= col + 1; c++)
                {
                    if (r >= 0 && r < 10 && c >= 0 && c < 10)
                    {
                        if (r == row && c == col)
                            continue;

                        if (board[ALPHABET[r] + "" + (c + 1)] == "o")
                            return false;
                    }
                }
            }
            return true;
        }
        public void PlaceShip()
        {

            string ALPHABET = "ABCDEFGHIJ";
            {

                for (int i = 1; i <= 4;) // 1 masztowiec
                {
                    Console.WriteLine($"GRACZ [{currentPlayerMove}] ({i}/4)Wybierz miejsce w którym chcesz postawic 1 masztowca: ");
                    string placeShip = Console.ReadLine().ToUpper();


                    if (playerOneBoard[placeShip] != "o" && IsPositionValid(playerOneBoard,placeShip))
                    {
                        playerOneBoard[placeShip] = "o";

                        i++;
                        Console.Clear();
                        ShowBoard();
                    }
                    else
                    {
                        Console.WriteLine("Podales zle miejsce!");
                    }
                }


                for (int i = 1; i <= 3;) // 2 masztowiec ==== poziomo
                {
                    Console.WriteLine($"GRACZ [{currentPlayerMove}] ({i}/3) Wybierz kierunek w którym chcesz postawic 2 masztowca: ");
                    Console.WriteLine("[1] poziomo [2] pionowo");
                    int shipDirection = Convert.ToInt32(Console.ReadLine());

                    if (shipDirection == 1)
                    {

                        Console.WriteLine($"({i}/3)Wybierz miejsce w którym chcesz postawic 2 masztowca: ");
                        string placeShip = Console.ReadLine().ToUpper();


                        if (playerOneBoard[placeShip] != "o")
                        {
                            if (ALPHABET.IndexOf(placeShip[0]) == 9)
                            {
                                Console.WriteLine("Statek wykracza poza plansze [poziomo A-I]");
                            }
                            else
                            {
                                int columnIndex = ALPHABET.IndexOf(placeShip[0]);
                                char nextColumn = ALPHABET[columnIndex + 1];
                                string key = nextColumn + "" + placeShip[1];
                                key = placeShip.Length < 3 ? key : key + placeShip[2];

                                if (IsPositionValid(playerOneBoard, placeShip) && IsPositionValid(playerOneBoard, ALPHABET[ALPHABET.IndexOf(placeShip[0]) + 1] + "" + placeShip[1]))
                                {
                                    playerOneBoard[placeShip] = "o";
                                    playerOneBoard[key] = "o";
                                    i++;
                                    Console.Clear();
                                    ShowBoard();
                                }
                                else
                                {
                                    Console.WriteLine("W poblizu znajduje sie inny statek!");
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Podales zle miejsce!");
                        }
                    }
                    if (shipDirection == 2) // 2 masztowiec ==== pioniowo
                    {
                        Console.WriteLine($"({i}/3)Wybierz miejsce w którym chcesz postawic 2 masztowca: ");
                        string placeShip = Console.ReadLine().ToUpper(); ;


                        if (playerOneBoard[placeShip] != "o")
                        {
                            if (Convert.ToInt32(placeShip[1].ToString()) > 9)
                            {
                                Console.WriteLine("Statek wykracza poza plansze [poziomo 1-9]");
                            }
                            else
                            {
                                int columnIndex = Convert.ToInt32(placeShip[1]) - 48;
                                string nextColumn = Convert.ToString(columnIndex + 1);
                                string key = placeShip[0] + "" + nextColumn;

                                

                                if (IsPositionValid(playerOneBoard, placeShip) && IsPositionValid(playerOneBoard,placeShip[0] + "" + (int.Parse(placeShip.Substring(1)) + 1)))
                                {
                                    playerOneBoard[placeShip] = "o";
                                    playerOneBoard[key] = "o";
                                    i++;
                                    Console.Clear();
                                    ShowBoard();
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Podales zle miejsce!");
                        }
                    }

                }


                for (int i = 1; i <= 2;) // 3 masztowiec ==== poziomo
                {
                    Console.WriteLine($"GRACZ [{currentPlayerMove}] ({i}/2) Wybierz kierunek w którym chcesz postawic 3 masztowca: ");
                    Console.WriteLine("[1] poziomo [2] pionowo");
                    int shipDirection = Convert.ToInt32(Console.ReadLine());

                    if (shipDirection == 1)
                    {

                        Console.WriteLine($"({i}/2)Wybierz miejsce w którym chcesz postawic 3 masztowca: ");
                        string placeShip = Console.ReadLine().ToUpper(); ;
                        if (playerOneBoard[placeShip] != "o")
                        {
                            if (ALPHABET.IndexOf(placeShip[0]) > 8)
                            {
                                Console.WriteLine("Statek wykracza poza plansze [poziomo A-H]");
                            }
                            else
                            {
                                int columnIndex = ALPHABET.IndexOf(placeShip[0]);

                                char nextColumn = ALPHABET[columnIndex + 1];
                                string key = nextColumn + "" + placeShip[1];
                                key = placeShip.Length < 3 ? key : key + placeShip[2];

                                char nextColumn2 = ALPHABET[columnIndex + 2];
                                string key2 = nextColumn2 + "" + placeShip[1];
                                key2 = placeShip.Length < 3 ? key2 : key2 + placeShip[2];

                                if (IsPositionValid(playerOneBoard, placeShip) && IsPositionValid(playerOneBoard, ALPHABET[ALPHABET.IndexOf(placeShip[0]) + 1] + "" + placeShip[1]) && IsPositionValid(playerOneBoard, ALPHABET[ALPHABET.IndexOf(placeShip[0]) + 2] + "" + placeShip[1]))
                                {
                                    playerOneBoard[placeShip] = "o";
                                    playerOneBoard[key] = "o";
                                    playerOneBoard[key2] = "o";
                                    i++;
                                    Console.Clear();
                                    ShowBoard();
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Podales zle miejsce!");
                        }
                    }
                    if (shipDirection == 2) // 3 masztowiec ==== pinowo
                    {
                        Console.WriteLine($"({i}/2)Wybierz miejsce w którym chcesz postawic 3 masztowca: ");
                        string placeShip = Console.ReadLine().ToUpper(); ;

                        if (playerOneBoard[placeShip] != "o")
                        {
                            if (Convert.ToInt32(placeShip[1].ToString()) > 8)
                            {
                                Console.WriteLine("Statek wykracza poza plansze [poziomo 1-8]");
                            }
                            else
                            {
                                int columnIndex = Convert.ToInt32(placeShip[1]) - 48;
                                string nextColumn = Convert.ToString(columnIndex + 1);
                                string key = placeShip[0] + "" + nextColumn;

                                string nextColumn2 = Convert.ToString(columnIndex + 2);
                                string key2 = placeShip[0] + "" + nextColumn2;

                                if (IsPositionValid(playerOneBoard, placeShip) && IsPositionValid(playerOneBoard, placeShip[0] + "" + (int.Parse(placeShip.Substring(1)) + 1)) && IsPositionValid(playerOneBoard, placeShip[0] + "" + (int.Parse(placeShip.Substring(1)) + 2)))
                                {
                                    playerOneBoard[placeShip] = "o";
                                    playerOneBoard[key] = "o";
                                    playerOneBoard[key2] = "o";
                                    i++;
                                    Console.Clear();
                                    ShowBoard();
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Podales zle miejsce!");
                        }
                    }
                }


                for (int i = 1; i <= 1;) // 4 masztowiec ==== poziomo
                {
                    Console.WriteLine($"GRACZ [{currentPlayerMove}] ({i}/1) Wybierz kierunek w którym chcesz postawic 4 masztowca: ");
                    Console.WriteLine("[1] poziomo [2] pionowo");
                    int shipDirection = Convert.ToInt32(Console.ReadLine());
                    if (shipDirection == 1)
                    {
                        Console.WriteLine($"({i}/1)Wybierz miejsce w którym chcesz postawic 4 masztowca: ");
                        string placeShip = Console.ReadLine().ToUpper(); ;

                        if (ALPHABET.IndexOf(placeShip[0]) > 7)
                        {
                            Console.WriteLine("Statek wykracza poza plansze [poziomo A-G]");
                        }
                        else
                        {
                            int columnIndex = ALPHABET.IndexOf(placeShip[0]);

                            char nextColumn = ALPHABET[columnIndex + 1];
                            string key = nextColumn + "" + placeShip[1];
                            key = placeShip.Length < 3 ? key : key + placeShip[2];

                            char nextColumn2 = ALPHABET[columnIndex + 2];
                            string key2 = nextColumn2 + "" + placeShip[1];
                            key2 = placeShip.Length < 3 ? key2 : key2 + placeShip[2];

                            char nextColumn3 = ALPHABET[columnIndex + 3];
                            string key3 = nextColumn3 + "" + placeShip[1];
                            key3 = placeShip.Length < 3 ? key3 : key3 + placeShip[2];

                            if (IsPositionValid(playerOneBoard, placeShip) && IsPositionValid(playerOneBoard,ALPHABET[ALPHABET.IndexOf(placeShip[0]) + 1] + "" + placeShip[1]) && IsPositionValid(playerOneBoard, ALPHABET[ALPHABET.IndexOf(placeShip[0]) + 2] + "" + placeShip[1]) && IsPositionValid(playerOneBoard, ALPHABET[ALPHABET.IndexOf(placeShip[0]) + 3] + "" + placeShip[1]))
                            {
                                playerOneBoard[placeShip] = "o";
                                playerOneBoard[key] = "o";
                                playerOneBoard[key2] = "o";
                                playerOneBoard[key3] = "o";
                                i++;
                                Console.Clear();
                                ShowBoard();
                                currentPlayerMove = 2;
                            }

                        }
                    }
                    if (shipDirection == 2) // 4 masztowiec ===== pionowo
                    {
                        Console.WriteLine($"({i}/1)Wybierz miejsce w którym chcesz postawic 4 masztowca: ");
                        string placeShip = Console.ReadLine();

                        if (playerOneBoard[placeShip] != "o")
                        {
                            if (Convert.ToInt32(placeShip[1].ToString()) > 7)
                            {
                                Console.WriteLine("Statek wykracza poza plansze [poziomo 1-7]");
                            }
                            else
                            {

                                int columnIndex = Convert.ToInt32(placeShip[1]) - 48;
                                string nextColumn = Convert.ToString(columnIndex + 1);
                                string key = placeShip[0] + "" + nextColumn;

                                string nextColumn2 = Convert.ToString(columnIndex + 2);
                                string key2 = placeShip[0] + "" + nextColumn2;

                                string nextColumn3 = Convert.ToString(columnIndex + 3);
                                string key3 = placeShip[0] + "" + nextColumn3;

                                if (IsPositionValid(playerOneBoard, placeShip) && IsPositionValid(playerOneBoard, placeShip[0] + "" + (int.Parse(placeShip.Substring(1)) + 1)) && IsPositionValid(playerOneBoard, placeShip[0] + "" + (int.Parse(placeShip.Substring(1)) + 2)) && IsPositionValid(playerOneBoard,placeShip[0] + "" + (int.Parse(placeShip.Substring(1)) + 3)))
                                {
                                    playerOneBoard[placeShip] = "o";
                                    playerOneBoard[key] = "o";
                                    playerOneBoard[key2] = "o";
                                    playerOneBoard[key3] = "o";
                                    i++;
                                    Console.Clear();
                                    ShowBoard();
                                    currentPlayerMove = 2;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Podales zle miejsce!");
                        }
                    }
                }

            }
            Console.ReadKey();
            Console.Clear();
            ShowBoard();
            // GRACZ 2 ==============================
            for (int i = 1; i <= 4;) // 1 masztowiec
            {
                Console.WriteLine($"GRACZ [{currentPlayerMove}] ({i}/4)Wybierz miejsce w którym chcesz postawić 1 masztowiec: ");
                string placeShip = Console.ReadLine().ToUpper();


                if (playerTwoBoard[placeShip] != "o" && IsPositionValid(playerTwoBoard, placeShip))
                {
                    playerTwoBoard[placeShip] = "o";

                    i++;
                    Console.Clear();
                    ShowBoard();
                }
                else
                {
                    Console.WriteLine("Podales zle miejsce!");
                }
            }


            for (int i = 1; i <= 3;) // 2 masztowiec ==== poziomo
            {
                Console.WriteLine($"GRACZ [{currentPlayerMove}] ({i}/3) Wybierz kierunek w którym chcesz postawić 2 masztowiec: ");
                Console.WriteLine("[1] poziomo [2] pionowo");
                int shipDirection = Convert.ToInt32(Console.ReadLine());

                if (shipDirection == 1)
                {

                    Console.WriteLine($"({i}/3)Wybierz miejsce w którym chcesz postawić 2 masztowiec: ");
                    string placeShip = Console.ReadLine().ToUpper();


                    if (playerTwoBoard[placeShip] != "o")
                    {
                        if (ALPHABET.IndexOf(placeShip[0]) == 9)
                        {
                            Console.WriteLine("Statek wykracza poza plansze [poziomo A-I]");
                        }
                        else
                        {
                            int columnIndex = ALPHABET.IndexOf(placeShip[0]);
                            char nextColumn = ALPHABET[columnIndex + 1];
                            string key = nextColumn + "" + placeShip[1];
                            key = placeShip.Length < 3 ? key : key + placeShip[2];

                            if (IsPositionValid(playerTwoBoard,placeShip) && IsPositionValid(playerTwoBoard,ALPHABET[ALPHABET.IndexOf(placeShip[0]) + 1] + "" + placeShip[1]))
                            {
                                playerTwoBoard[placeShip] = "o";
                                playerTwoBoard[key] = "o";
                                i++;
                                Console.Clear();
                                ShowBoard();
                            }
                            else
                            {
                                Console.WriteLine("W poblizu znajduje sie inny statek!");
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Podales zle miejsce!");
                    }
                }
                if (shipDirection == 2) // 2 masztowiec ==== pioniowo
                {
                    Console.WriteLine($"({i}/3)Wybierz miejsce w którym chcesz postawić 2 masztowiec: ");
                    string placeShip = Console.ReadLine().ToUpper();


                    if (playerTwoBoard[placeShip] != "o")
                    {
                        if (placeShip.Length > 2)
                        {
                            Console.WriteLine("Statek wykracza poza plansze [poziomo 1-9]");
                        }
                        else
                        {
                            int columnIndex = Convert.ToInt32(placeShip[1]) - 48;
                            string nextColumn = Convert.ToString(columnIndex + 1);
                            string key = placeShip[0] + "" + nextColumn;

                            if (IsPositionValid(playerTwoBoard,placeShip) && IsPositionValid(playerTwoBoard,placeShip[0] + "" + (int.Parse(placeShip.Substring(1)) + 1)))
                            {
                                playerTwoBoard[placeShip] = "o";
                                playerTwoBoard[key] = "o";
                                i++;
                                Console.Clear();
                                ShowBoard();
                                Console.WriteLine(columnIndex + "  " + key);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Podales zle miejsce!");
                    }
                }

            }


            for (int i = 1; i <= 2;) // 3 masztowiec ==== poziomo
            {
                Console.WriteLine($"GRACZ [{currentPlayerMove}] ({i}/2) Wybierz kierunek w którym chcesz postawić 3 masztowiec: ");
                Console.WriteLine("[1] poziomo [2] pionowo");
                int shipDirection = Convert.ToInt32(Console.ReadLine());

                if (shipDirection == 1)
                {

                    Console.WriteLine($"({i}/2)Wybierz miejsce w którym chcesz postawić 3 masztowiec: ");
                    string placeShip = Console.ReadLine().ToUpper();
                    if (playerTwoBoard[placeShip] != "o")
                    {
                        if (ALPHABET.IndexOf(placeShip[0]) > 8)
                        {
                            Console.WriteLine("Statek wykracza poza plansze [poziomo A-H]");
                        }
                        else
                        {
                            int columnIndex = ALPHABET.IndexOf(placeShip[0]);

                            char nextColumn = ALPHABET[columnIndex + 1];
                            string key = nextColumn + "" + placeShip[1];
                            key = placeShip.Length < 3 ? key : key + placeShip[2];

                            char nextColumn2 = ALPHABET[columnIndex + 2];
                            string key2 = nextColumn2 + "" + placeShip[1];
                            key2 = placeShip.Length < 3 ? key2 : key2 + placeShip[2];

                            if (IsPositionValid(playerTwoBoard,placeShip) && IsPositionValid(playerTwoBoard,ALPHABET[ALPHABET.IndexOf(placeShip[0]) + 1] + "" + placeShip[1]) && IsPositionValid(playerTwoBoard, ALPHABET[ALPHABET.IndexOf(placeShip[0]) + 2] + "" + placeShip[1]))
                            {
                                playerTwoBoard[placeShip] = "o";
                                playerTwoBoard[key] = "o";
                                playerTwoBoard[key2] = "o";
                                i++;
                                Console.Clear();
                                ShowBoard();
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Podales zle miejsce!");
                    }
                }
                if (shipDirection == 2) // 3 masztowiec ==== pinowo
                {
                    Console.WriteLine($"({i}/2)Wybierz miejsce w którym chcesz postawić 3 masztowiec: ");
                    string placeShip = Console.ReadLine().ToUpper();

                    if (playerTwoBoard[placeShip] != "o")
                    {
                        if (Convert.ToInt32(placeShip[1].ToString()) > 8)
                        {
                            Console.WriteLine("Statek wykracza poza plansze [poziomo 1-8]");
                        }
                        else
                        {
                            int columnIndex = Convert.ToInt32(placeShip[1]) - 48;
                            string nextColumn = Convert.ToString(columnIndex + 1);
                            string key = placeShip[0] + "" + nextColumn;

                            string nextColumn2 = Convert.ToString(columnIndex + 2);
                            string key2 = placeShip[0] + "" + nextColumn2; 



                            if (IsPositionValid(playerTwoBoard,placeShip) && IsPositionValid(playerTwoBoard,placeShip[0] + "" + (int.Parse(placeShip.Substring(1)) + 1)) && IsPositionValid(playerTwoBoard,placeShip[0] + "" + (int.Parse(placeShip.Substring(1)) + 2)))
                            {
                                playerTwoBoard[placeShip] = "o";
                                playerTwoBoard[key] = "o";
                                playerTwoBoard[key2] = "o";
                                i++;
                                Console.Clear();
                                ShowBoard();
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Podales zle miejsce!");
                    }
                }
            }


            for (int i = 1; i <= 1;)
            // 4 masztowiec ==== poziomo
            {
                Console.WriteLine($"GRACZ [{currentPlayerMove}] ({i}/1) Wybierz kierunek w którym chcesz postawić 4 masztowiec: ");
                Console.WriteLine("[1] poziomo [2] pionowo");
                int shipDirection = Convert.ToInt32(Console.ReadLine());
                if (shipDirection == 1)
                {
                    Console.WriteLine($"({i}/1)Wybierz miejsce w którym chcesz postawić 4 masztowiec: ");
                    string placeShip = Console.ReadLine().ToUpper();

                    if (ALPHABET.IndexOf(placeShip[0]) > 7)
                    {
                        Console.WriteLine("Statek wykracza poza plansze [poziomo A-G]");
                    }
                    else
                    {
                        int columnIndex = Convert.ToInt32(placeShip[1]) - 48;
                        string nextColumn = Convert.ToString(columnIndex + 1);
                        string key = placeShip[0] + "" + nextColumn;

                        string nextColumn2 = Convert.ToString(columnIndex + 2);
                        string key2 = placeShip[0] + "" + nextColumn2;

                        char nextColumn3 = Convert.ToChar(columnIndex + 3);
                        string key3 = placeShip[0] + "" + nextColumn3;

                        if (IsPositionValid(playerTwoBoard,placeShip) && IsPositionValid(playerTwoBoard, ALPHABET[ALPHABET.IndexOf(placeShip[0]) + 1] + "" + placeShip[1]) && IsPositionValid(playerTwoBoard, ALPHABET[ALPHABET.IndexOf(placeShip[0]) + 2] + "" + placeShip[1]) && IsPositionValid(playerTwoBoard, ALPHABET[ALPHABET.IndexOf(placeShip[0]) + 3] + "" + placeShip[1]))
                        {
                            playerTwoBoard[placeShip] = "o";
                            playerTwoBoard[key] = "o";
                            playerTwoBoard[key2] = "o";
                            playerTwoBoard[key3] = "o";
                            i++;
                            Console.Clear();
                            ShowBoard();
                            currentPlayerMove = 2;
                        }

                    }
                }
                if (shipDirection == 2) // 4 masztowiec ===== pionowo
                {
                    Console.WriteLine($"({i}/1)Wybierz miejsce w którym chcesz postawić 4 masztowiec: ");
                    string placeShip = Console.ReadLine().ToUpper();

                    if (playerTwoBoard[placeShip] != "o")
                    {
                        if (Convert.ToInt32(placeShip[1].ToString()) > 7)
                        {
                            Console.WriteLine("Statek wykracza poza plansze [poziomo 1-7]");
                        }
                        else
                        {
                            int columnIndex = Convert.ToInt32(placeShip[1]) - 48;
                            string nextColumn = Convert.ToString(columnIndex + 1);
                            string key = placeShip[0] + "" + nextColumn;

                            string nextColumn2 = Convert.ToString(columnIndex + 2);
                            string key2 = placeShip[0] + "" + nextColumn2;

                            string nextColumn3 = Convert.ToString(columnIndex + 3);
                            string key3 = placeShip[0] + "" + nextColumn3;

                            if (IsPositionValid(playerTwoBoard, placeShip) && IsPositionValid(playerTwoBoard, placeShip[0] + "" + (Convert.ToInt32(placeShip.Substring(1)) + 1)) && IsPositionValid(playerTwoBoard, placeShip[0] + "" + (Convert.ToInt32(placeShip.Substring(1)) + 2)) && IsPositionValid(playerTwoBoard, placeShip[0] + "" + (Convert.ToInt32(placeShip.Substring(1)) + 3)))
                            {
                                playerTwoBoard[placeShip] = "o";
                                playerTwoBoard[key] = "o";
                                playerTwoBoard[key2] = "o";
                                playerTwoBoard[key3] = "o";
                                i++;
                                Console.Clear();
                                ShowBoard();
                                currentPlayerMove = 2;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Podales zle miejsce!");
                    }
                }
                currentPlayerMove = 1;
            }
        }

        public void SinkShip(Dictionary<string, string> board, string position)
        {
            const string ALPHABET = "ABCDEFGHIJ";
            int row = ALPHABET.IndexOf(position[0]);
            int column = Convert.ToInt32(position.Substring(1)) - 1;

            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = column - 1; j <= column + 1; j++)
                {
                    if (i >= 0 && i < ALPHABET.Length && j >= 0 && j < 10)
                    {
                        string pos = $"{ALPHABET[i]}{j + 1}";
                        if (board.ContainsKey(pos) && board[pos] == " ")
                        {
                            if(currentPlayerMove == 1)
                                playerOneShots[pos] = "x";
                            if(currentPlayerMove == 2)
                                playerTwoShots[pos] = "x";
                        }
                    }
                }
            }
        }



    }
}

