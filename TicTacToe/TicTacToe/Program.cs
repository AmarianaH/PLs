using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        public sign s;

        static void Main(string[] args)
        {

            TicTacToeGame t = new TicTacToeGame();
            t.ResetBoad();
            bool flg = true;
            sign player;
            char c;
            int row,colomn;

            do
            {
                if (flg == true) { Console.WriteLine("it's X's turn"); player = sign.X; flg = false; }
                else { Console.WriteLine("it's O's turn"); player = sign.O; flg = true; }


                do
                {
                    Console.WriteLine("please enter 2 parameters,");
                    Console.WriteLine("the row number; enter; then the colomn number;");
                    row = int.Parse(Console.ReadLine());
                    colomn = int.Parse(Console.ReadLine());
                    while (row < 0 || row >= 3 || colomn < 0 || colomn >= 3)
                    {
                        Console.WriteLine("you entered wrong coordinates, please try again:");
                        Console.WriteLine("please enter 2 parameters,");
                        Console.WriteLine("the row number; enter; then the colomn number;");
                        row = int.Parse(Console.ReadLine());
                        colomn = int.Parse(Console.ReadLine());
                    }

                    c = t.Move(row, colomn, player);
                    if (c == 'm') { Console.WriteLine("the cell is not empty, please try again."); }
                } while (c == 'm');
                    t.mat[row, colomn] = c;
                t.DisplayBoard();
                if (t.ifDraw() == true) { Console.WriteLine("No one wins. Draw!!! try to win the next time."); return; }
                else { Console.WriteLine($"Someone wins? : {t.ifWins()}"); }
            } while (!t.ifWins());
           
        }
    }
}
