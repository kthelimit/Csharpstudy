namespace BingoGameTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 빙고게임 규칙
            // 1 ~ 25의 숫자를 무작위로 섞은 2차원 배열의 빙고판을 만든다.
            // 1 ~ 25까지의 숫자중 하나를 입력 받아서 그 숫자를 지우거나
            // 다른 문자로 바꾼다. => 0으로 바꾼다.
            // 가로 세로 대각선이 전부 지워지거나 다른 문자가 된다면
            // bingo 개수를 늘려주고 bingo개수가 5이면 게임을 종료한다.

            Console.Write("빙고판 사이즈를 입력하세요>> ");
            int size = int.Parse(Console.ReadLine());
            // 빙고판 만들기
            User user = new User(size);
            Com com = new Com(size);

            user.PrintBingoBoard();
            com.PrintBingoBoard();

            //빙고 숫자 입력받기
            while (true)
            {
                int num;

                user.SelectNum();
                com.RemoveNum(user.Num);

                //빙고판 출력하기
                user.PrintBingoBoard();
                com.PrintBingoBoard();

                //빙고확인
                Console.WriteLine("빙고의 수 : " + user.CheckCount());
                Console.WriteLine("컴퓨터의 빙고의 수 : " + com.CheckCount());
                if (user.CheckCount() >= 5 || com.CheckCount() >= 5)
                {
                    break;
                }
                //컴퓨터가 고를 차례
                com.SelectNum();
                user.RemoveNum(com.Num);
                Console.WriteLine("COM이 고른 수 : " + com.Num);
                Console.WriteLine();

                //빙고판 출력하기
                user.PrintBingoBoard();
                com.PrintBingoBoard();

                //빙고확인
                Console.WriteLine("빙고의 수 : " + user.CheckCount());
                Console.WriteLine("컴퓨터의 빙고의 수 : " + com.CheckCount());
                if (user.CheckCount() >= 5 || com.CheckCount() >= 5)
                {
                    break;
                }

            }

            Console.WriteLine("빙고 끝~!");
        }

    }
}

