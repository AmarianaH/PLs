using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    enum sign { X, O }

    class TicTacToeGame
    {
        public sign s;
        public char[,] mat = new char[3, 3];

        public void DisplayBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(string.Format("{0,5}", mat[i, j]));
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        public void ResetBoad()
        {
            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                    mat[i, j] = '-';
        }

        public char Move(int row, int colomn , sign player)
        {
            if(row >= 0 && row < 3 && colomn >= 0 && colomn < 3)
            {
                if(mat[row,colomn].Equals('-'))
                {
                    if(player.Equals(sign.X))
                        return 'X';
                    if (player.Equals(sign.O))
                        return 'O';
                }
                else
                {
                    return 'm';
                }
            }
            return '-';
        }

        public bool ifWins()
        {
            if (mat[0, 0] == mat[0, 1] && (mat[0, 0] == mat[0, 2] && mat[0, 0] != '-'))
                return true;
            
            if (mat[1, 0] == mat[1, 1] && (mat[1, 0] == mat[1, 2] && mat[1, 0] != '-'))
                return true;
            
            if (mat[2, 0] == mat[2, 1] && (mat[2, 0] == mat[2, 2] && mat[2, 0] != '-'))
                return true;
            
            if (mat[0, 0] == mat[1, 0] && (mat[0, 0] == mat[2, 0] && mat[0, 0] != '-'))
                return true;
            
            if (mat[0, 1] == mat[1, 1] && (mat[0, 0] == mat[2, 1] && mat[0, 1] != '-'))
                return true;
            
            if (mat[0, 2] == mat[1, 2] && (mat[0, 2] == mat[2, 2] && mat[0, 2] != '-'))
                return true;

            if (mat[0, 0] == mat[1, 1] && (mat[0, 0] == mat[2, 2] && mat[0, 0] != '-'))
               return true;

            if (mat[0, 2] == mat[1, 1] && (mat[0, 2] == mat[2, 0] && mat[0, 2] != '-'))
               return true;

            return false;
        }

        public bool ifDraw()
        {
            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == '-')
                    {
                        return false;
                    }
                }
            return true;
        }
    }
}