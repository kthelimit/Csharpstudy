namespace SwitchTest4
{
    internal class SwitchTest4
    {
        static void Main(string[] args)
        {
            // switch 식 : switch 문과 다르게 식이므로 결과가 나온다.
            // Math.Truncate() : 소수점 이하 버림 => 정수 부분만 남음.

            Console.Write("점수 입력 >> ");
            int input = Convert.ToInt32(Console.ReadLine());
            int score = (int)Math.Truncate(input / 10.0);

            string grade = score switch
            {
                9 => "A",
                8 => "B",
                7 => "C",
                6 => "D",
                _=> "F" //무시 패턴, switch 문의 default. 언더스코어가 들어가는 것이다.
            };     
            Console.WriteLine(grade);

            Console.WriteLine("재수강인가요?(y / n)");
            string str = Console.ReadLine();
            bool result = str =="y" ? true : false;
            grade = score switch
            {
                9 when result == true => "B+",
                9 => "A",
                8 => "B",
                7 => "C",
                6 => "D",
                _ => "F"
            } ;
            Console.WriteLine(grade);
        }
    }
}
