using ChessGame.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChessGame.Board
{
    public class Board
    {
        public int[,] surface = new int[8, 8];
        string[] blackPieces = new string[] { "♜", "♞", "♝", "♚", "♛", "♝", "♞", "♜" };
        string[] whitePieces = new string[] { "♖", "♘", "♗", "♔", "♕", "♗", "♘", "♖" };
        int[] possibleMovesForPiece = { };


        Dictionary<int, string> mappedChars = new Dictionary<int, string>
{
    { 10, "1" },
    { 20, "2" },
    { 30, "3" },
    { 40, "4" },
    { 50, "5" },
    { 60, "6" },
    { 70, "7" },
    { 80, null },
    { 00, "0" },
    { 81, "   a " },
    { 82, " b " },
    { 83, " c " },
    { 84, " d " },
    { 85, " e " },
    { 86, " f " },
    { 87, " g " },
    { 88, " h " },
    { 11, "♟" },
    { 12, "♟" },
    { 13, "♟" },
    { 14, "♟" },
    { 15, "♟" },
    { 16, "♟" },
    { 17, "♟" },
    { 18, "♟" },
    { 61, "♙" },
    { 62, "♙" },
    { 63, "♙" },
    { 64, "♙" },
    { 65, "♙" },
    { 66, "♙" },
    { 67, "♙" },
    { 68, "♙" }
};

        Dictionary<char, int> mappedAlphabets = new Dictionary<char, int>
{
    { 'a', 1 },
    { 'b', 2 },
    { 'c', 3 },
    { 'd', 4 },
    { 'e', 5 },
    { 'f', 6 },
    { 'g', 7 },
    { 'h', 8 }
};





        public Board()
        {

            Array.Clear(surface, 0, surface.Length);
            // Create the mappedCharsping using KeyValuePair<int, string>



/*﻿♔ ♕ ♖ ♗ ♘ ♙
♚ ♛ ♜ ♝ ♞ ♟︎*/
            for (int i = 1; i <= 8; i++)
            {
                mappedChars.Add(i, blackPieces[i - 1]);
            }

            for (int i = 71; i <= 78; i++)
            {
                mappedChars.Add(i, whitePieces[i - 71]);
            }

            for (int i = 0; i <= 88; i++)
            {
                if (!mappedChars.ContainsKey(i))
                {
                    mappedChars.Add(i, " ");
                }
            }

        }

        public void boardPrinter()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int key = i * 10 + j;
                    //Console.Write(surface[i, j] + " ");

                    //Map color here

                    if (key%10!=0 && key<80)
                    {
                        if(possibleMovesForPiece.Any(item => item == key)){
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.Write("  ");
                        }
                        else
                        {
                            if ((i + j) % 2 == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.Write("  ");
                            }
                            // Otherwise, print a white square
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.Write("  ");
                            }
                        }

                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    //Map Character here

                    if (mappedChars.ContainsKey(key))
                    {
                        Console.Write(mappedChars[key]);
                        Console.Write("  ");
                    }
                    else if (mappedChars.ContainsKey(key))
                    {
                        Console.Write(mappedChars[key]);
                        Console.Write("  ");
                    }
                    else if (mappedChars.ContainsKey(key))
                    {
                        Console.Write(mappedChars[key]);
                        Console.Write("  ");
                    }
                    else if (mappedChars.ContainsKey(key))
                    {
                        Console.Write(mappedChars[key]);
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(i);
                        Console.Write(j);
                        Console.Write(" ");
                    }

/*                    Console.Write(i);
                    Console.Write(j);
                    Console.Write(" ");*/
                }
                Console.WriteLine();
            }
            Array.Clear(possibleMovesForPiece, 0, possibleMovesForPiece.Length);

        }


        public void updatePosition(string source, string target)
        {
            var s = inputFormatter(source);
            var t = inputFormatter(target);
            //Console.Write(s.Item1);
            //Console.WriteLine(mappedAlphabets[s.Item2]);

            //Console.Write(t.Item1);
            //Console.WriteLine(mappedAlphabets[t.Item2]);

            /*            mappedChars[t.Item1 * 10 + mappedAlphabets[t.Item2]] = mappedChars[s.Item1 * 10 + mappedAlphabets[s.Item2]];
                        mappedChars[s.Item1*10+ mappedAlphabets[s.Item2]] = " ";*/
            bool isWhite = whitePieces.Any(piece => piece == mappedChars[s.Item1 * 10 + mappedAlphabets[s.Item2]]);

            int Spos = s.Item1 * 10 + mappedAlphabets[s.Item2];
            Console.WriteLine(isWhite);

            int[] possibleMoves = Pawn.possibleMoves(mappedChars, Spos, isWhite);

            for (int i = 0; i < possibleMoves.Length; i++)
            {
                Console.WriteLine(possibleMoves[i]);
            }

            possibleMovesForPiece = possibleMoves;





        }

        public static (int, char) inputFormatter(string input)
            {
                if (input.Length != 2)
                {
                    throw new ArgumentException("Input string must be exactly two characters long");
                }
                char firstChar = input[0];
                char secondChar = input[1];
                if (Char.IsDigit(firstChar) && Char.IsLetter(secondChar))
                {
                    int number = int.Parse(firstChar.ToString());
                    char character = char.Parse(secondChar.ToString());
                    return (number, character);
                }
                else if (Char.IsLetter(firstChar) && Char.IsDigit(secondChar))
                {
                    int number = int.Parse(secondChar.ToString());
                    char character = char.Parse(firstChar.ToString());
                    return (number, character);
                }
                else
                {
                    throw new ArgumentException("Input string must contain one digit and one letter");
                }
            

        }

        //static void PrintChessBoard()
        //{
        //    for (int row = 0; row < 8; row++)
        //    {
        //        for (int col = 0; col < 8; col++)
        //        {
        //            // If the sum of the row and column is even, print a black square
        //            if ((row + col) % 2 == 0)
        //            {
        //                Console.BackgroundColor = ConsoleColor.Black;
        //                Console.Write("  ");
        //            }
        //            // Otherwise, print a white square
        //            else
        //            {
        //                Console.BackgroundColor = ConsoleColor.White;
        //                Console.Write("  ");
        //            }
        //        }
        //        Console.WriteLine(); // Move to the next row
        //    }
        //    Console.ResetColor(); // Reset the console color to the default
        //}


    }



}
