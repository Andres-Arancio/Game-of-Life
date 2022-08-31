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

        public Board(string newsource)
        {
            bool[,] gameboard = DocReader.readDocument(source);
            int boardwidth = gameboard.GetLength(0);
            int boardheight = gameboard.GetLength(1);
        }

        Cell[,] boardrunner = new Cell[boardwidth, boardheight];        
    }
}
