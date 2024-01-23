using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGameTest
{
    internal abstract class Bingo
    {
        int row;
        int column;
        int num;
        public int Row { get { return row; } set { row = value; } }
        public int Column { get { return column; } set { column = value; } }
        public int Num { get { return num; } set { num = value; } }

        int[,] board;

        public Bingo(int row)
        {
            Row = row;
            Column = row;
            MakeBingo(row);
        }

        private void MakeBingo(int size)
        {
            board = new int[size, size]; //배열의 행열을 입력받을 수도 있다.
            int n = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = ++n;
                }
            }
            Random random = new Random();
            for (int i = 0; i < 100000; i++)
            {
                int row = random.Next(0, 5);
                int col = random.Next(0, 5);
                int temp = board[0, 0];
                board[0, 0] = board[row, col];
                board[row, col] = temp;
            }

        }

        public virtual void PrintBingoBoard()
        {
            int icount = 0;
            foreach (int i in board)
            {
                Console.Write($"{i,2:00} ");
                icount++;
                if (icount % row == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        //입력받은 숫자를 지움
        public void RemoveNum(int num)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (num == board[i, j])
                    {
                        board[i, j] = 0;
                        break;
                    }
                }
            }
        }

        //카운트 수 세기
        public int CheckCount()
        {
            int count = 0; //전체 빙고 개수
            int lcCount = 0; //왼쪽 대각선 빙고 개수
            int rcCount = 0; //오른쪽 대각선 빙고 개수
            for (int i = 0; i < row; i++)
            {
                int rCount = 0; //행 빙고 개수
                int cCount = 0; //열 빙고 개수
                for (int j = 0; j < column; j++)
                {
                    if (board[i, j] == 0)  // 행 빙고
                    {
                        rCount++;
                    }
                    if (board[j, i] == 0) // 열 빙고
                    {
                        cCount++;
                    }
                    if (i == j && board[i, j] == 0)
                    {
                        lcCount++;
                    }
                    if (i + j == row - 1 && board[i, j] == 0)
                    {
                        rcCount++;
                    }
                }
                if (rCount == row)
                {
                    count++;
                }
                if (cCount == row)
                {
                    count++;
                }
                // Console.WriteLine($"row = {rCount}, col = {cCount}");
            }
            //  Console.WriteLine($"왼쪽 대각선 = {lcCount}, 오른쪽 대각선 = {rcCount}");
            if (lcCount == row)
            {
                count++;
            }
            if (rcCount == row)
            {
                count++;
            }

            return count;
        }
        //숫자가 존재하는지 체크하기
        protected bool IsExistNum(int num)
        {
            if (num == 0)
            {
                return false;
            }
            bool isExist = false;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (board[i, j] == num)
                    {
                        isExist = true;
                        break;
                    }
                }
            }

            return isExist;
        }


        public abstract void SelectNum();
    }
}
