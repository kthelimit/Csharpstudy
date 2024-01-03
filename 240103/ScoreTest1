namespace ScoreTest1
{
    internal class ScoreTest1
    {
        static void Main(string[] args)
        {
            // 세 과목 점수를 입력받아서 평균 / 총점 / 등급을 구하는 프로그램
            Console.Write("국어 점수 입력>> ");
            int kor = Convert.ToInt32(Console.ReadLine());
            Console.Write("영어 점수 입력>> ");
            int eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("수학 점수 입력>> ");
            int math = Convert.ToInt32(Console.ReadLine());

            int total = kor + eng + math;
            double avg = (double)total / 3;

            Console.WriteLine($"총점 : {total}");
            Console.WriteLine("평균 : {0:0.00}", avg);

            // 90점 이상이면 A / 80 점 이상이면 B / 70점 이상이면 C / 60점 이상이면 D / 그외에는 F

            if (avg >= 90)
            {
                Console.WriteLine("학점 : A");
            }
            else if (avg >= 80)
            {
                Console.WriteLine("학점 : B");
            }
            else if (avg >= 70)
            {
                Console.WriteLine("학점 : C");
            }
            else if (avg >= 60)
            {
                Console.WriteLine("학점 : D");
            }
            else
            {
                Console.WriteLine("학점 : F");
            }


            // if(avg >= 80 && avg < 90) 처럼 구간을 지정해서 전부 if문으로 작성해도 ㅇㅋ
        }
    }
}
