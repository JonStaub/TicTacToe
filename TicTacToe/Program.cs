using System;

namespace TicTacToe
{ 
  class Program
  {
    static string[,] board = new string[3, 3]
        {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7","8","9"}
        };
    static bool gameStatus = false;
    static int turnCount = 0;
    static void Main(string[] args)
    {
        DisplayBoard();
        PlayerTurn();

    }
    static void DisplayBoard()
    {
        Console.WriteLine(" {0} | {1} | {2} ", board[0, 0], board[0, 1], board[0, 2]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", board[1, 0], board[1, 1], board[1, 2]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", board[2, 0], board[2, 1], board[2, 2]);
    }
    static void PlayerTurn()
    {
        string currentPlayer = "Player 1";

        do
        {
            Console.WriteLine($"{currentPlayer}, please type the number of which square you would like to place your symbol:");
            string input = Console.ReadLine();
            
            try
            {

                if (int.Parse(input) > 0 && int.Parse(input) < 10 && currentPlayer == "Player 1")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (board[i, j] == input)
                            {
                                board[i, j] = "O";
                                Console.Clear();
                                DisplayBoard();
                                CheckForWinner();
                                currentPlayer = "Player 2";
                            }
                        }
                    }
                }
                else if (int.Parse(input) > 0 && int.Parse(input) < 10 && currentPlayer == "Player 2")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (board[i, j] == input)
                            {
                                board[i, j] = "X";
                                Console.Clear();
                                DisplayBoard();
                                CheckForWinner();
                                currentPlayer = "Player 1";
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That square is already taken");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid input");
            }
            
        }
        while (!gameStatus);
    }
    static void CheckForWinner()
    {
            turnCount++;
            if (turnCount <9)
            {   //Added Readkey so players could see results before the board resets
                //Player One Check
                if (board[0, 0] == "O" && board[0, 1] == "O" && board[0, 2] == "O")
                {
                    Console.WriteLine("Congratulations! Player One is the winner!");
                    Console.ReadKey();
                    gameStatus = true;
                    ResetBoard();

                }
                if (board[1, 0] == "O" && board[1, 1] == "O" && board[1, 2] == "O")
                {
                    Console.WriteLine("Congratulations! Player One is the winner!");
                    Console.ReadKey();
                    gameStatus = true;
                    ResetBoard();
                }
                if (board[2, 0] == "O" && board[2, 1] == "O" && board[2, 2] == "O")
                {
                    Console.WriteLine("Congratulations! Player One is the winner!");
                    Console.ReadKey(); 
                    gameStatus = true;
                    ResetBoard();
                }
                if (board[0, 0] == "O" && board[1, 0] == "O" && board[2, 0] == "O")
                {
                    Console.WriteLine("Congratulations! Player One is the winner!");
                    Console.ReadKey();
                    gameStatus = true;
                    ResetBoard();
                }
                if (board[0, 1] == "O" && board[1, 1] == "O" && board[2, 1] == "O")
                {
                    Console.WriteLine("Congratulations! Player One is the winner!");
                    Console.ReadKey(); 
                    gameStatus = true;
                    ResetBoard();
                }
                if (board[0, 2] == "O" && board[1, 2] == "O" && board[2, 2] == "O")
                {
                    Console.WriteLine("Congratulations! Player One is the winner!");
                    Console.ReadKey();
                    gameStatus = true;
                    ResetBoard();
                }
                if (board[0, 0] == "O" && board[1, 1] == "O" && board[2, 2] == "O")
                {
                    Console.WriteLine("Congratulations! Player One is the winner!");
                    Console.ReadKey(); 
                    gameStatus = true;
                    ResetBoard();
                }
                if (board[2, 0] == "O" && board[1, 1] == "O" && board[0, 2] == "O")
                {
                    Console.WriteLine("Congratulations! Player One is the winner!");
                    Console.ReadKey(); 
                    gameStatus = true;
                    ResetBoard();
                }
                // Player Two check
                if (board[0, 0] == "X" && board[0, 1] == "X" && board[0, 2] == "X")
                {
                    Console.WriteLine("Congratulations! Player Two is the winner!");
                    Console.ReadKey();
                    gameStatus = true;
                    ResetBoard();

                }
                if (board[1, 0] == "X" && board[1, 1] == "X" && board[1, 2] == "X")
                {
                    Console.WriteLine("Congratulations! Player Two is the winner!");
                    Console.ReadKey(); 
                    gameStatus = true;
                    ResetBoard();
                }
                if (board[2, 0] == "X" && board[2, 1] == "X" && board[2, 2] == "X")
                {
                    Console.WriteLine("Congratulations! Player Two is the winner!");
                    Console.ReadKey();
                    gameStatus = true;
                    ResetBoard();
                }
                if (board[0, 0] == "X" && board[1, 0] == "X" && board[2, 0] == "X")
                {
                    Console.WriteLine("Congratulations! Player Two is the winner!");
                    Console.ReadKey(); 
                    gameStatus = true;
                    ResetBoard();
                }
                if (board[0, 1] == "X" && board[1, 1] == "X" && board[2, 1] == "X")
                {
                    Console.WriteLine("Congratulations! Player Two is the winner!");
                    Console.ReadKey(); 
                    gameStatus = true;
                    ResetBoard();
                }
                if (board[0, 2] == "X" && board[1, 2] == "X" && board[2, 2] == "X")
                {
                    Console.WriteLine("Congratulations! Player Two is the winner!");
                    Console.ReadKey();
                    gameStatus = true;
                    ResetBoard();
                }
                if (board[0, 0] == "X" && board[1, 1] == "X" && board[2, 2] == "X")
                {
                    Console.WriteLine("Congratulations! Player Two is the winner!");
                    Console.ReadKey();
                    gameStatus = true;
                    ResetBoard();
                }
                if (board[2, 0] == "X" && board[1, 1] == "X" && board[0, 2] == "X")
                {
                    Console.WriteLine("Congratulations! Player Two is the winner!");
                    Console.ReadKey();
                    gameStatus = true;
                    ResetBoard();
                }
            }
            else if (turnCount == 9)
            {
                Console.WriteLine("The game has ended in a draw");
                Console.ReadKey();
                gameStatus = true;
                ResetBoard();
            }        
    }
    static void ResetBoard()
    {
        Console.Clear();
        board = new string[3, 3]
        {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7","8","9"}
        };
        gameStatus = false;
        turnCount = 0;
        DisplayBoard();
        PlayerTurn();           
    }
  }
}
