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
        Dictionary<int, char> alphabetLayer = new Dictionary<int, char>
{
    { 81, 'a' },
    { 82, 'b' },
    { 83, 'c' },
    { 84, 'd' },
    { 85, 'e' },
    { 86, 'f' },
    { 87, 'g' },
    { 88, 'h' },
                { 80, ' ' }
};

        Dictionary<int, int> digitLayer = new Dictionary<int, int>
{
    { 00, 1 },
    { 10, 2 },
    { 20, 3 },
    { 30, 4 },
    { 40, 5 },
    { 50, 6 },
    { 60, 7 },
    { 70, 8 }
 };


        Dictionary<int, char> playerWhite = new Dictionary<int, char>
{

    { 61, 'p' },
    { 62, 'p' },
    { 63, 'p' },
    { 64, 'p' },
    { 65, 'p' },
    { 66, 'p' },
    { 67, 'p' },
    { 68, 'p' },
    { 71, 'B' },
    { 72, 'H' },
    { 73, 'E' },
    { 74, 'Q' },
    { 75, 'K' },
    { 76, 'E' },
    { 77, 'H' },
    { 78, 'B' },
 };

        Dictionary<int, char> playerBlack = new Dictionary<int, char>
{

    { 1, 'p' },
    { 2, 'p' },
    { 3, 'p' },
    { 4, 'p' },
    { 5, 'p' },
    { 6, 'p' },
    { 7, 'p' },
    { 8, 'p' },
    { 11, 'B' },
    { 12, 'H' },
    { 13, 'E' },
    { 14, 'Q' },
    { 15, 'K' },
    { 16, 'E' },
    { 17, 'H' },
    { 18, 'B' },
 };
        public Board()
        {

            Array.Clear(surface, 0, surface.Length);


        }

        public void boardPrinter()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int key = i * 10 + j;
                    //Console.Write(surface[i, j] + " ");
                    if (alphabetLayer.ContainsKey(key))
                    {
                        Console.Write(alphabetLayer[key]);
                        Console.Write("  ");
                    }
                    else if (digitLayer.ContainsKey(key))
                    {
                        Console.Write(digitLayer[key]);
                        Console.Write("  ");
                    }
                    else if (playerWhite.ContainsKey(key))
                    {
                        Console.Write(playerWhite[key]);
                        Console.Write("  ");
                    }
                    else if (playerBlack.ContainsKey(key))
                    {
                        Console.Write(playerBlack[key]);
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(i);
                        Console.Write(j);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }


        public void updatePosition()
        {


        }


    }



}
