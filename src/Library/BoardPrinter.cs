using System.IO;
using System.Text;
using System.Threading;

namespace Library;

public class BoardPrinter
{
    public bool[,] board; //variable que representa el tablero
    public int width; //variabe que representa el ancho del tablero
    public int height; //variabe que representa altura del tablero

    public BoardPrinter(bool[,] initialBoard, int boardWidth, int boardHeight)
    {
        board = initialBoard;
        width = boardWidth;
        height = boardHeight;
    }

    public void PrintBoard()
    {
        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(board[x, y])
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
        //=================================================
        //Invocar método para calcular siguiente generación
        //=================================================
        Thread.Sleep(300);
        }
    }
}