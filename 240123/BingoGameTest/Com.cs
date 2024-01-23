using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BingoGameTest
{
    internal class Com : Bingo
    {
        public Com(int row) : base(row) { }
        public override void PrintBingoBoard()
        {
            Console.WriteLine("=====COM=====");
            base.PrintBingoBoard();
        }

        public override void SelectNum()
        {
            while (true)
            {
                Random random = new Random();
                int temp = random.Next(1, Row * Column + 1);
                bool isExist = IsExistNum(temp);
                if (isExist)
                {
                    Num = temp;
                    break;
                }
            }
            RemoveNum(Num);
        }
    }
}
