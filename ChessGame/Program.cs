
using ChessGame.Board;



Console.OutputEncoding = System.Text.Encoding.Unicode;

Board board = new Board();

board.surface[1, 1] = 1;

board.boardPrinter();

Console.WriteLine( "Select A position: ");
string source = Console.ReadLine();

Console.WriteLine("select target position: ");
string target = Console.ReadLine();


board.updatePosition(source,target);
board.boardPrinter();