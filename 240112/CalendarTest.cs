namespace CalendarTest
{
    internal class CalendarTest
    {
        static void Main(string[] args)
        {
            int year = 2024;
            int month = 8;
            Console.WriteLine("==================================");
            Console.WriteLine("           {0,-4}년 {1, -2:00}월", year, month);
            Console.WriteLine("==================================");
            Console.WriteLine(" 일   월   화   수   목   금   토");
            Console.WriteLine("==================================");

            // 1일이 출력이 되는 위치를 맞추기 위해 1일의 요일만큼 반복하며 빈칸을 출력한다.
            //Console.WriteLine(WeekDay(year, month, 1));
            //Console.WriteLine(DateTime.DaysInMonth(year, month));

            for (int i = 1; i <= WeekDay(year, month, 1); i++)
            {
                Console.Write("     ");
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
