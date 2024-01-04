namespace SwitchTest3
{
    internal class SwitchTest3
    {
        static void Main(string[] args)
        {
            // 패턴 일치(매칭) : 식에 특정 특징이 있는지 확인하기 위해 테스트하는 기법.
            // => 형식 패턴 : 변수가 지정된 형식과 일치하는지 테스트.

            object obj = -123;
            switch (obj)
            {
                case int:
                    Console.WriteLine("정수입니다.");
                    break;
                case float:
                    Console.WriteLine("실수입니다.");
                    break;
                case string:
                    Console.WriteLine("문자열입니다.");
                    break;
                default:
                    Console.WriteLine("기타 데이터 타입입니다.");
                    break;

            }

            // case when을 이용하면 조건식을 이용할 수 있다.
            // when을 케이스 가드라고 한다. => case 문의 패턴을 더 구체적으로 만들어 줄 수 있다.

            switch (obj)
            {
                case int i when i > 0: // obj의 값이 0보다 컸을 때 실행.
                    Console.WriteLine("0보다 큰 정수입니다.");
                    break;
                case int:
                    Console.WriteLine("0보다 작은 정수입니다.");
                    break;
                default:
                    Console.WriteLine("정수가 아닌 데이터 입니다.");
                    break;
            }

        }
    }
}
