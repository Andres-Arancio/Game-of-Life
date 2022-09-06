using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PII_Game_Of_Life
{
    public class DocReader
    {
        /*
        <summary>
        Metodo dedicado a leer el documento entregardo y convertirlo en un tablero
        </summary>
        */
        public static Cell[,] readDocument(String url)
        {
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');

            Cell[,] board = new Cell[contentLines.Length, contentLines[0].Length];
            for (int  y=0; y<contentLines.Length; y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    board[x,y] = new Cell();
                    if(contentLines[y][x]=='1')
                    {
                        board[x,y].alive = true;
                    }
                    else
                    {
                        board[x,y].alive = false;
                    }
                }
            }
            return board;
        }
    }
}