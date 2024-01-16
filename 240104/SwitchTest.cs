namespace SwitchTest
{
    internal class SwitchTest
    {
        static void Main(string[] args)
        {
            // Switch 문 : 지정된 일치 표현식을 기반으로 여러 패턴 중 해당하는 하나의 코드를 실행한다.
            // 일치식 => char, 문자열, 조건식, 정수 및 숫자형식, 열거형식 중 하나여야 함.
            // break : 현재 실행중인 제어문(반복문 / switch 문)을 빠져나갈때(강제종료) 사용.

            // switch(일치식) {
            //          case 패턴1 :
            //              패턴1일 때 실행할 문장;
            //              break;
            //          case 패턴2 :
            //              패턴2일 때 실행할 문장;
            //              break;
            //          default : 
            //              모든 패턴에 해당하지 않을 때 실행할 문장;
            //              break;
            //}

            //Console.Write("국어 점수를 입력하세요: ");
            //int kor = int.Parse(Console.ReadLine());
            //Console.Write("수학 점수를 입력하세요: ");
            //int math = int.Parse(Console.ReadLine());
            //Console.Write("영어 점수를 입력하세요: ");
            //int eng = int.Parse(Console.ReadLine());

            //int total = kor + math + eng;
            //double avg = (double)total / 3;

            //Console.WriteLine("총점 : " + total);
            //Console.WriteLine("평균 : {0:0.00}", avg);
            //switch ((int)avg / 10)
            //{
            //    case 10://실행할 문장이 하나라도 들어가면 반드시 break가 들어가야함                   
            //    case 9:
            //        Console.WriteLine("학점 : A");
            //        break;
            //    case 8:
            //        Console.WriteLine("학점 : B");
            //        break;
            //    case 7:
            //        Console.WriteLine("학점 : C");
            //        break;
            //    case 6:
            //        Console.WriteLine("학점 : D");
            //        break;
            //    //default:
            //    //    Console.WriteLine("학점 : F");
            //    //    break;
            //    //아래처럼 써도 되긴 함

            //    case 5:
            //    case 4:
            //    case 3:
            //    case 2:
            //    case 1:
            //    case 0:
            //        Console.WriteLine("학점 : F");
            //        break;
            //}

            // 계절 출력하기 => 월을 입력받아 계절 출력하기.
            // 12~2 3~5 6^8 9~11

            Console.Write("월을 입력하세요>> ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다~~");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다!!");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.~");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;
                default:
                    Console.WriteLine("입력한 값이 잘못되었습니다.");
                    break;
            }






        }
    }
}
