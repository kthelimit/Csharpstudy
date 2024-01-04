namespace FuzzyBuzzy
{
    internal class FuzzyBuzzy
    {
        static void Main(string[] args)
        {
            // 1 ~ 100까지 반복하면서 숫자를 출력할 때,
            // 3과 5의 공배수면 FuzzyBuzzy를 출력하고
            // 3의 배수이면 Fuzzy를 출력하고, 5의 배수이면 Buzzy를 출력하는 프로그램을 작성해보세요.


            //for (int i = 1; i <= 100; i++)
            //{
            //    string str = "";
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        str = "FuzzyBuzzy";
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        str = "Fuzzy";
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        str = "Buzzy";
            //    }
            //    Console.WriteLine($"{i,3} {str}");
            //}



            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("{0,5}, ","FuzzyBuzzy");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("{0,5}, ", "Fuzzy");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("{0,5}, ", "Buzzy");
                }
                else
                {
                    Console.Write("{0,5}, ", i);
                }
            }

        }
    }
}
