namespace ArrayTest
{
    internal class ArrayTest
    {
        static void Main(string[] args)
        {
            // 배열 : 형식이 동일한 변수를 여러개 저장할 수 있다.
            // => 같은 이름으로 여러개의 기억장소를 만드는 것.
            // => 기억장소 구분은 인덱스(첨자)를 이용한다.
            // => 생성된 배열의 각 저장공간을 '배열의 요소'라고 한다.
            // 배열 선언 => 데이터타입[] 배열명 = new 데이터타입[배열길이];
            // => 배열이름[인덱스]로 각 배열 요소에 접근할 수 있다.
            // 인덱스 : 배열 요소마다 붙여진 일련번호 => 인덱스는 0부터 시작
            // 인덱스의 범위 : 0 ~ 배열길이 -1
            // 배열은 선언만 하면 기본초기화가 실행돈다.
            // => int : 0 / double : 0 / char : 공백 / bool : false
            // => 참조형식(string, object)의 배열은 null로 초기화된다.

            int num1, num2, num3, num4, num5;
            int[] numbers = new int[5];
            // Console.WriteLine(num1); => 초기화가 되어있지 않아 에러.
            Console.WriteLine(numbers); // System.Int32[] 라고 뜸
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);

            // 배열 초기화
            // => 데이터타입[] 배열이름 = new 자료형[] {값1, 값2, ...};
            // => 데이터타입[] 배열이름 = {값1, 값2, .....};
            int[] numbers2 = new int[] { 1, 2, 3 };
            int[] numbers3 = { 4, 5, 6 };
            int[] numbers4;            
            numbers4 = new int[] { 7, 8, 9 };
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(numbers2[1]);
            Console.WriteLine(numbers2[2]);
            // Console.WriteLine(numbers2[3]); //  System.IndexOutOfRangeException: 인덱스 범위를 벗어나 예외가 발생함
            // Console.WriteLine(numbers2[-1]);인덱스에는 마이너스 정수를 넣을 수 없음

            for (int i=0; i<3; i++)
            {
                Console.WriteLine("numbers2["+ i+"] = " + numbers2[i]);
            }


            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            //Length : 배열길이 => 배열이름.Length

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            string[] name = { "고길동", "둘리", "마이콜", "도우너", "또치" };
            for(int i=0; i<name.Length; i++)
            {
                Console.WriteLine("name["+i+"] = "+name[i]);
            }

            string[] str = new string[5];
            for(int i=0; i<str.Length; i++)
            {
                Console.WriteLine($"str[{i}] = {str[i]}");
            }

            // foreach : 배열 또는 컬렉션처럼 여러개의 값을 담고 있는 데이터 구조에서 데이터가 들어있는만큼 반복한다.
            // foreach(데이터 형식 변수명 in 배열)
            // {
            //   반복할 내용; 
            // }

            // name 배열의 0번 요소부터 마지막 요소까지 반복 진행
            foreach ( string s in name )  
            {
                Console.WriteLine(s);
            }








        }
    }
}
