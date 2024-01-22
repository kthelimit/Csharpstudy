using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    internal class BaseballGame
    {

        public static int[] MakeGameArr(int gamelevel)
        {
            int[] arr = new int[gamelevel];
            //3자리 랜덤수 뽑아내기
            int[] baseball = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                int r = rand.Next(1, 10);
                int temp = baseball[0];
                baseball[0] = baseball[r];
                baseball[r] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = baseball[i];
            }
            return arr;
        }

        public static int[] InputPlayerArr(int gamelevel)
        {
            Console.Write($"숫자 {gamelevel}개를 입력하시오(공백으로 구분) : ");
            string[] str = Console.ReadLine().Split();
            Console.WriteLine(string.Join(" ", str));
            int[] arr = new int[gamelevel];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(str[i]);
            }
            return arr;
        }

        public static int CheckSCount(int[] gameArr, int[] player)
        {
            int sCount = 0;
            for (int i = 0; i < gameArr.Length; i++)
            {
                if (gameArr[i] == player[i])
                {
                    sCount++;
                }
            }
            return sCount;
        }

        public static int CheckBCount(int[] gameArr, int[] player)
        {
            int bCount = 0;
            for (int i = 0; i < gameArr.Length; i++)
            {
                for (int j = 0; j < gameArr.Length; j++)
                {
                    if (i != j && gameArr[i] == player[j])
                    {
                        bCount++;
                    }
                }
            }
            return bCount;
        }
    }
}
