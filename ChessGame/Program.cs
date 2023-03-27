
using ChessGame.Board;

Board board = new Board();

board.surface[1, 1] = 1;

board.boardPrinter();

Console.WriteLine( "Input a move:");
string input = Console.ReadLine();

board
