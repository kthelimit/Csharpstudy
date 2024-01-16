namespace ScoreTest
{
    internal class ScoreMain
    {
        static void Main(string[] args)
        {
            // ScoreVo vo = new ScoreVo("고길동", 80,70,60,90);
            // Console.WriteLine(vo.name); // =>name 멤버변수는 private
            //Console.WriteLine(vo.GetIdx());
            //Console.WriteLine(vo.GetName());
            //Console.WriteLine(vo.GetKor());
            //Console.WriteLine(vo.GetEng());
            //Console.WriteLine(vo.GetMath());
            //Console.WriteLine(vo.GetMusic());
            //Console.WriteLine(vo.GetTotal());
            //Console.WriteLine(vo.GetAvg());

            // 학생들의 점수를 입력받아서 객체를 생성하기
            // 원하는 수만큼 객체를 생성하기

            //ScoreVo vo1 = new ScoreVo("둘리", 60, 80, 70, 100);
            //ScoreVo vo2 = new ScoreVo("도우너", 60, 80, 40, 70);
            //ScoreVo vo3 = new ScoreVo("마이콜", 40, 60, 90, 70);

            //ScoreVo[] vo = new ScoreVo[10];
            //while (true)
            //{
            //    int idx = 0;
            //    Console.Write("학생이름 국어 영어 수학 음악 입력>> ");
            //    string[] voarr = Console.ReadLine().Split(" ");
            //    vo[idx++] = new ScoreVo(voarr[0], int.Parse(voarr[1]), int.Parse(voarr[2]), int.Parse(voarr[3]), int.Parse(voarr[4]));
            //    Console.WriteLine("더 입력합니까? y/n");

            //}
            ScoreList scoreList = new ScoreList();
            while (true)
            {
                Console.Write("학생 이름 입력(q:입력종료) >>");
                string name = Console.ReadLine().ToUpper();
                if (name == "Q")
                {
                    break;
                }
                else
                {
                    Console.Write("국어 점수 >>");
                    int kor = int.Parse(Console.ReadLine());
                    Console.Write("영어 점수 >>");
                    int.TryParse(Console.ReadLine(), out int eng);
                    Console.Write("수학 점수 >>");
                    int math = Convert.ToInt32(Console.ReadLine());
                    Console.Write("음악 점수 >>");
                    int music = Convert.ToInt32(Console.ReadLine());
                    ScoreVo vo = new ScoreVo(name, kor, eng, math, music);
                    scoreList.addScore(vo);
                }


            }
                Console.WriteLine(scoreList.ToString());
        }
    }
}
