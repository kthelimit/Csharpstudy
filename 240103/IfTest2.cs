namespace IfTest2
{
    internal class IfTest2
    {
        static void Main(string[] args)
        {
            int input;
            Console.Write("숫자 하나를 입력하세요: ");
            string tmp = Console.ReadLine();
            input = Convert.ToInt32(tmp);  // input = int.Parse(tmp);
            if (input == 0) 
            {
                Console.WriteLine("입력하신 숫자는 0입니다.");
            } //else 값이 없으면 입력하지 않아도 된다.

            if(input != 0)             
                Console.WriteLine("입력하신 숫자는 0이 아닙니다."); //if 포함
            //if는 실행문장이 한 문장일 때 {} 블록을 생략해도 된다.
            Console.WriteLine($"입력하신 숫자는 {input}입니다."); //if 밖의 문장



        }
    }
}
