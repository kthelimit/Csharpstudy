namespace StringtTest3
{
    internal class StringTest3
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            // DateTime dateTime = DateTime.Now;  =>현재날짜

            Console.WriteLine(dateTime);
            // 날짜서식(사용자 지정 서식)
            // => d / dd : 일, ddd / dddd : 요일
            Console.WriteLine(dateTime.ToString("d / dd / ddd / dddd"));
            // => M / MM : 월, MMM / MMMM : 월약어 (한국어에서는 월약어의 의미가 없다)
            Console.WriteLine(dateTime.ToString("M / MM / MMM / MMMM"));
            // => y / yy / yyyy : 년도
            // => h / hh : 12시간 형식의 시, H / HH : 24시간 형식의 시
            // => m / mm : 분
            // => s / ss : 초
            // => t : AM / PM 표시를 A, P로 표시
            // => tt : AM / PM 표시 두자리            
            Console.WriteLine(dateTime.ToString());
            Console.WriteLine(dateTime.ToString("yyyy.M.d h:m:s"));
            Console.WriteLine(dateTime.ToString("yyyy.MMMM.dddd tt h:m:s"));
            Console.WriteLine(dateTime.ToString("yyyy년 MMM dd일 (ddd) tt HH:mm:ss"));

            // 날짜 서식(표준서식) 이미 지정되어 있는 서식
            // => d : 간단한 날짜 => 2024-01-02
            // => D : 자세한 날짜 => 2024년 1월 2일 화요일
            // => F : 전체날짜 / 시간 패턴(자세한 시간) => 2024년 1월 2일 화요일  오후 3:20:20
            // => f : 전체날짜 / 시간 패턴(단순한 시간) => 2024년 1월 2일 화요일 오후 3:21
            Console.WriteLine(dateTime.ToString("d"));
            Console.WriteLine(dateTime.ToString("D"));
            Console.WriteLine(dateTime.ToString("F"));
            Console.WriteLine(dateTime.ToString("f"));
            // => g : 일반날짜 / 시간패턴(간단한 시간) => 2024-1-2 오후 3:24
            // => G : 일반날짜 / 시간패턴(자세한 시간) => 2024-1-2 오후 3:24:30
            // => t : 간단한 시간 패턴
            // => T : 자세한 시간 패턴
            Console.WriteLine(dateTime.ToString("g"));
            Console.WriteLine(dateTime.ToString("G"));
            Console.WriteLine(dateTime.ToString("t"));
            Console.WriteLine(dateTime.ToString("T"));
            // => Y/y : 연도 / 월
            // => M/m : 월 / 일
            // => u : 정렬가능 범용 날짜 / 시간 패턴
            // => U : 범용 전체 날짜 / 시간 패턴
            // => s : 정렬가능한 날짜 / 시간
            Console.WriteLine(dateTime.ToString("y"));
            Console.WriteLine(dateTime.ToString("m"));
            Console.WriteLine(dateTime.ToString("u"));
            Console.WriteLine(dateTime.ToString("U"));
            Console.WriteLine(dateTime.ToString("s"));


        }
    }
}
