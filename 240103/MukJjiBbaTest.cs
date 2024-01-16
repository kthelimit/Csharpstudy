using System.Net.WebSockets;

namespace MukJjiBbaTest
{
    internal class MukJjiBbaTest
    {
        static void Main(string[] args)
        {
            // 가위 = 1 / 바위 = 2 / 보 = 3
            Random random = new Random();

            int com = random.Next(3) + 1;
            Console.WriteLine("=========================");
            Console.WriteLine("1. 가위");
            Console.WriteLine("2. 바위");
            Console.WriteLine("3. 보");
            Console.WriteLine("=========================");
            Console.Write("커맨드 입력>> ");
            int user = int.Parse(Console.ReadLine());

            //string user = Console.ReadLine();
            //string com = random.Next(1,4).ToString();


            Console.Write("당신의 커맨드 : ");
            if (user == 1)
            { 
                Console.WriteLine("가위"); 
            }
            else if (user == 2)
            { 
                Console.WriteLine("바위"); 
            }
            else
            { 
                Console.WriteLine("보"); 
            }

            Console.Write("컴퓨터의 커맨드 : ");
            if (com == 1)
            {
                Console.WriteLine("가위");
            }
            else if (com == 2)
            {
                Console.WriteLine("바위");
            }
            else
            {
                Console.WriteLine("보");
            }

            // 이기는 경우  : user == 1 이고 com == 3인 경우,
            //              user == 2 이고 com == 1인 경우,
            //              user == 3 이고 com == 2인 경우,
            // 지는 경우    : user == 1 이고 com == 2인 경우,
            //              user == 2 이고 com == 3인 경우,
            //              user == 3 이고 com == 1인 경우,   
            // 비기는 경우 : user == com

            if (user == com)
            {
                Console.WriteLine("무승부입니다.");
            }
            else if (user - com == 1 || user - com == -2)
            {
                Console.WriteLine("승리했습니다.");
            }
            else
            {
                Console.WriteLine("패배했습니다.");
            }
        }
    }
}
