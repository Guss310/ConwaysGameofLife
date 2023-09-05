using System.IO;
using System.Text;

namespace Library;


public class Archivo
{
    public Archivo(string link)
    {
        this.url = link;
        this.content = File.ReadAllText(url);
        this.contentLines = content.Split('\n');
        this.board = new bool[contentLines.Length, contentLines[0].Length];
        for (int y = 0; y < contentLines.Length; y++)
        {
            for (int x = 0; x < contentLines[y].Length; x++)
            {
                if (contentLines[y][x] == '1')
                {
                    board[x, y] = true;
                }
            }
        }
    }
    public string url;
    public string content;
    public string[] contentLines;
    public bool[,] board;
}
