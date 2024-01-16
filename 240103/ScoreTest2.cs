namespace ScoreTest2
{
    internal class ScoreTest2
    {
        static void Main(string[] args)
        {
            // 중첩 if : if 문 {} 블럭 안에 또 다른 if 문
            // if(조건식1){
            //      조건식1이 참일때 실행할 문장;
            //      if(조건식2) {
            //          조건식 1이 참이고 조건식 2가 참일 때 실행할 문장;
            //          ...;
            //      }else {
            //          조건식 1이 참이고 조건식 2가 거짓일 때 실행할 문장;
            //          ...;
            //      }
            // } else {
            //      조건식1이 거짓일 때 실행할 문장;
            //      ...;
            // }

            // 평균 점수를 입력받고, 90점 이상이고 98점 이상이면 A+
            // 94점 미만이면 A- 그외에는 A0

            int score = 0;
            char grade = ' ', opt = '0'; //70점 이상까지만 C를 주자.

            Console.Write("평균을 입력하세요.: ");
            score = int.Parse(Console.ReadLine());
            if (score >= 90)
            {
                grade = 'A';
                if (score >= 98)
                {
                    opt = '+';
                }
                else if (score < 94)
                {
                    opt = '-';
                }
            }
            else if (score >= 80)
            {
                grade = 'B';
                if (score >= 88)
                {
                    opt = '+';
                }
                else if (score < 84)
                {
                    opt = '-';
                }
            }
            else if (score >= 70)
            {
                grade = 'C';
                if (score >= 78)
                {
                    opt = '+';
                }
                else if (score < 74)
                {
                    opt = '-';
                }
            }
            else
            {
                grade = 'F';
            }


            Console.WriteLine($"당신의 학점은 {grade}{opt}입니다.");

            //if(score>=98)
            //{
            //    grade = 'A';
            //    opt = '+';
            //}
            //else if(score>=94)
            //{
            //    grade = 'A';
            //}
            //else if(score>=90)
            //{
            //    grade= 'A';
            //    opt = '-';
            //}
            // 이렇게 해도 되긴 하지만... 중첩if가 더 간결하면 중첩if를 쓰자


        }
    }
}
