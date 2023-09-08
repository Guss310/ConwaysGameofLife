using System.IO;
using System.Text;
using System.Threading;

namespace Library;

public class BoardPrinter
{
    private Board board;

    public BoardPrinter(Board board)
    {
        this.board = board;
    }

    public void PrintBoard()
    {
       
    
        Console.Clear();
        StringBuilder s = new StringBuilder();
        for (int y = 0; y < this.board.boardHeight;y++)
        {
            for (int x = 0; x < this.board.boardWidth; x++)
            {
                if(this.board.gameBoard[x, y])
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }
            s.Append("\n");
        }
        Console.WriteLine(s.ToString());
    
    }
}