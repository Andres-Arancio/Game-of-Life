using System;
using System.Text;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string url = "C:\\Users\\aaran\\OneDrive\\Documentos\\Programacion II\\Programas\\Repositorios\\Game-of-Life\\assets\\board.txt";
            Board board = new Board(url);
            Printer.PrintConsole(board);
            Board.RunBoard(board);
            Printer.PrintConsole(board);
        }
    }
}
