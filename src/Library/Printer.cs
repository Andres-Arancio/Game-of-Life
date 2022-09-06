using System;
using System.Text;
using System.Collections;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class Printer
    {
        public static void PrintConsole(Board board)
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<board.boardheight;y++)
                {
                    for (int x = 0; x<board.boardwidth; x++)
                    {
                        if(board.gameboard[x,y].alive)
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
}