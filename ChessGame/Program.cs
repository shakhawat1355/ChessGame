
using ChessGame.Board;

Board board = new Board();

board.surface[1, 1] = 1;

board.boardPrinter();

Console.WriteLine( "Select A position: ");
string source = Console.ReadLine();

Console.WriteLine("select target position: ");
string target = Console.ReadLine();


board.updatePosition(source,target);
board.boardPrinter();