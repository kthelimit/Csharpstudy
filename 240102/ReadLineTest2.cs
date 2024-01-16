namespace ReadLineTest2
{
    internal class ReadLineTest2
    {
        static void Main(string[] args)
        {
            //// 숫자 입력 받기
            //Console.Write("숫자를 입력하세요.: ");
            //string input = Console.ReadLine();
            //Console.WriteLine(Convert.ToInt32(input));
            //Console.WriteLine(Convert.ToInt32(input) + 15); // 숫자로 변환되어서 15가 더해진다.
            //Console.WriteLine(input + 15); // string이라서 숫자가 더해지는게 아니라 바로 뒤에 붙여진다.
            //// Console.WriteLine((int)input+15); 에러 : (int)로 강제 형변환은 안 된다.

            //// Convert.ToInt32() : 정수로 변환
            //// Convert.ToSingle() : 실수로 변환
            //// Convert.ToChar() : 문자로 변환
            //// ToString() : 문자열로 변환

            //// int.Parse() : 정수로 변환
            //// int.TryParse() : 정수변환. 문자열에 정수가 없으면 false 반환
            //Console.Write("숫자를 입력하세요.: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("입력한 숫자는 : {0}입니다.",num);

            //int i;
            //Console.Write("입력>>> ");
            //string input2 = Console.ReadLine();
            //Console.WriteLine(int.TryParse(input2, out i));

            //Console.Write("숫자 입력>> ");
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num+10);

            Console.Write("문자열 입력: ");
            string str = Console.ReadLine();
            string str2 = str.Substring(2, 1); //3번째 글자부터 1개 가져오게 된다.
            Console.WriteLine(str2);
            Console.Write("문자열 입력: ");
            str = Console.ReadLine().Substring(3,1); //4번째 글자가 없으면 오류 메세지가 출력된다.
            Console.WriteLine(str);
            Console.Write("문자열 입력: ");
            char ch = Convert.ToChar(Console.ReadLine().Substring(0, 1));
            Console.WriteLine(ch);

        }
    }
}
