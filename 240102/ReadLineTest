namespace ReadLineTest
{
    internal class ReadLineTest
    {
        static void Main(string[] args)
        {
            // 콘솔 창에서 데이터 입력 받기 => ReadLine / Read / ReadKey
            // Console.ReadLine() : 한 줄 입력 받기 => 문자열로 입력받는다.
            // Console.Read() : 콘솔에서 입력받은 한 문자를 정수로 입력받는다. => ASCII / 유니코드 값
            // Console.ReadKey() : 한 문자 입력을 받는다 => 입력 즉시 값 반환. => ConsoleKeyInfo 사용

            //Console.Write("문자열 입력: ");
            //string str = Console.ReadLine();
            //Console.WriteLine(str);

            // Console.Read() : 입력 대기 상태 => 입력 후 엔터 => 문자를 정수값으로 반환

            //Console.Write("입력>> ");
            //int num = Console.Read();
            //Console.WriteLine(num);
            //Console.WriteLine((char)num);
            //여러줄 입력해서 맨앞 한글자만 인식함

            Console.Write("입력>>> ");
            ConsoleKeyInfo info = Console.ReadKey();
            Console.WriteLine(); ;
            Console.WriteLine(info);
            Console.WriteLine(info.KeyChar); //문자값으로 출력
            Console.WriteLine(info.Key);  //열거형식으로 출력. F1 누르면 F1이 나온다. 누른 키값.
            info = Console.ReadKey(true); //누른키를 표시하지않음
            info = Console.ReadKey(false); // 누른키를 표시


        }
    }
}
