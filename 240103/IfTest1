namespace IfTest1
{
    internal class IfTest1
    {
        static void Main(string[] args)
        {
            // if(조건식) {
            //  조건식이 참일 경우에 실행할 문장;
            //  ....;
            // } else {
            //  조건식이 거짓일 경우에 실행할 문장;
            //  .....;
            // }


            // if(조건식1) {
            //       조건식1이 참일 경우에 실행할 문장;
            //       ....;
            // } else if(조건식2){
            //       조건식2가 참일 경우에 실행할 문장;
            //       .....;
            // } else{
            //       조건식2가 거짓일 경우에 실행할 문장;
            //       ....;
            // }

            Console.Write("나이를 입력하세요. : ");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);

            if (age >= 20) 
            {
                Console.WriteLine("성인입니다.");
            }
            else 
            {
                Console.WriteLine("미성년자입니다.");
            }


            // 둘리 주민번호 : 830422-1184600
            // 주민번호를 입력받아 성별 나타내기.


            Console.Write("주민번호를 입력하세요. : ");
            char gender = Convert.ToChar(Console.ReadLine().Substring(7, 1));
            if(gender=='1' ||  gender=='3') 
            {
                Console.WriteLine("성별은 남성입니다.");
            }
            else // if(gender=='2' || gender=='4')
            {
                Console.WriteLine("성별은 여성입니다.");
            }

            // char대신 string을 썼다면 gender == "1"로 쓰면 된다. 따옴표가 다를 뿐이다.

            //string input2 = Console.ReadLine();
            //int num = Convert.ToInt32(input2.Substring(7,1));
            //if (num ==1 || num ==3)
            //{
            //    Console.WriteLine("남성입니다.");
            //}
            //else if(num ==2 || num ==4) 
            //{
            //    Console.WriteLine("여성입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("잘못된 입력입니다.");
            //}
        }
    }
}
