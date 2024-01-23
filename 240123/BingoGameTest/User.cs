using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BingoGameTest
{
    internal class User : Bingo
    {
        public User(int row) : base(row) { }
        public override void PrintBingoBoard()
        {
            Console.WriteLine("=====YOU=====");
            base.PrintBingoBoard();
        }
        public override void SelectNum()
        {
            while (true)
            {
                Console.Write("빙고 숫자 입력>> ");
                Num = int.Parse(Console.ReadLine());
                if (IsExistNum(Num))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("빙고 판 위에 존재하지 않는 숫자입니다. 다시 입력하세요.");
                }

            }
            RemoveNum(Num);
        }

    }
}
