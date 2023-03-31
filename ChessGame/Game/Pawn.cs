using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChessGame.Game
{
    public class Pawn
    {
        public int moveCount {  get; set; }
        int[] directionalArray = { };
        int[] forbiddenCells = { };


        public void moveValidator()
        {

        }
        public static int[] possibleMoves( Dictionary<int,string> boardMap, int position, bool isWhite)
        {
            int[] possibleMoves = new int[3];

            int[] movesForWhite = { -9, -10, -11 };
            int[] movesForBlack = { 9, 10, 11 };

            Array.Clear(possibleMoves,0, possibleMoves.Length);


            /*            if (isWhite)
                        {
                            for(int i = 0; i < 3; i++)
                            {
                                possibleMoves[i] = position +   movesForWhite[i];
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                possibleMoves[i] = position + movesForBlack[i];
                            }
                        }*/

            for (int i = 0; i < 3; i++)
            {
                possibleMoves[i] = position + (isWhite ? movesForWhite[i] : movesForBlack[i]);
            }

            return possibleMoves;

        }





        public bool isforbiddenArea(int position)
        {

            if(position%10==0 || position>79) return true;
            else return false;

        }

    }
}
