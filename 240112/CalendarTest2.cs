namespace CalendarTest2
{
    internal class CalendarTest2
    {
        static void Main(string[] args)
        {
            int month;
            int year;
            Console.Write("이번달(1) / 특정달(2) >> ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                DateTime dateTime = DateTime.Now;
                year = dateTime.Year;
                month = dateTime.Month;
                Console.WriteLine("{0}년 {1}월", year, month);
            }
            else
            {
                Console.WriteLine("년/월을 입력하시오 >> ");
                year = Convert.ToInt32(Console.ReadLine());
                month = Convert.ToInt32(Console.ReadLine());
                //Console.Write("원하는 년도 입력>> ");
                //year = Convert.ToInt32(Console.ReadLine());
                //Console.Write("원하는 달 입력>> ");
                //month = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("==================================");
            Console.WriteLine("           {0,-4}년 {1, -2:00}월", year, month);
            Console.WriteLine("==================================");
            Console.WriteLine(" 일   월   화   수   목   금   토");
            Console.WriteLine("==================================");

            //for (int i = 1; i <= WeekDay(year, month, 1); i++)
            //{
            //    Console.Write("     ");
            //}

            // 1일이 출력될 위치를 맞추기 위해 1일의 요일만큼 반복하며 전달 날짜를 출력한다.
            int week = WeekDay(year, month, 1);
            int start = 0;

            if (month == 1)
            {
                start = 31 - week; //1월일대
            }
            else
            {
                start = DateTime.DaysInMonth(year, month - 1) - week; // 2 ~ 12월
            }
            for (int i = 1; i <= week; i++)
            {
                Console.Write($" {++start,-4:00}");
            }
            // 1일부터 달력을 출력할 달의 마지막 날짜까지 반복하며 날짜를 출력.
            for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
            {
                Console.Write($" {i,-4:00}");
                if ((WeekDay(year, month, i) == 6) && i != DateTime.DaysInMonth(year, month))
                {
                    Console.WriteLine();
                }
            }

            //날짜를 출력하고 남은 빈칸에 다음달 1일의 요일부터 토요일까지 반복하며 날짜를 출력한다.

            if (month == 12)
            {
                week = WeekDay(year + 1, 1, 1);
            }
            else
            {
                week = WeekDay(year, month + 1, 1);
            }
            if (week != 0)
            {
                int d = 1;
                for (int i = week; i <= 6; i++)
                {
                    Console.Write($" {d++,-4:00}");
                }
            }

            Console.WriteLine("\n==================================");


        }

        //모든 날짜를 더해서 7로 나눠서 나머지를 구해야함.
        static int WeekDay(int year, int month, int day)
        {
            // 2024년 전년도인 2023년까지의 전체 일수.
            int sum = (year - 1) * 365 + (year - 1) / 4 - (year - 1) / 100 + (year - 1) / 400;

            // 2024년도 1월부터 선택한 월의 전달까지의 마지막 날짜를 더해준다.
            for (int i = 1; i < month; i++)
            {
                sum += DateTime.DaysInMonth(year, i);
            }
            return (sum + day) % 7;

        }
    }
}
