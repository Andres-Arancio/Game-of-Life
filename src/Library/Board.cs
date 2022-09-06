using System;

namespace PII_Game_Of_Life
{
    public class Board
    {
        /*
        <summary>
        Atributos del tablero que se consiguen del documento a leer. Source contiene la url del documento
        </summary>
        */
        string source {get ; set ;}
        public int boardheight {get ; set ;}
        public int boardwidth {get ; set ;}
        public Cell[,] gameboard {get ; set ;}

        public Board(string newsource)
        {
            Cell[,] gameboard = DocReader.readDocument(newsource);
            int boardwidth = gameboard.GetLength(0);
            int boardheight = gameboard.GetLength(1);
        }

        public static void RunBoard(Board board)
        {
            Cell[,] cloneboard = new Cell[board.boardwidth, board.boardheight];
            for (int x = 0; x < board.boardwidth; x++)
            {
                for (int y = 0; y < board.boardheight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<board.boardwidth && j>=0 && j < board.boardheight && board.gameboard[i,j].alive)
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(board.gameboard[x,y].alive)
                    {
                        aliveNeighbors--;
                    }
                    if (board.gameboard[x,y].alive && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población
                        cloneboard[x,y].alive = false;
                    }
                    else if (board.gameboard[x,y].alive && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación
                        cloneboard[x,y].alive = false;
                    }
                    else if (!board.gameboard[x,y].alive && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción
                        cloneboard[x,y].alive = true;
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        cloneboard[x,y].alive = board.gameboard[x,y].alive;
                    }
                }
            }
            board.gameboard = cloneboard;
        }
    }
}
