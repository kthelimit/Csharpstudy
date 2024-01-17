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
            //ScoreVo vo1 = new ScoreVo();
            //Console.WriteLine(vo1.GetName());

            ScoreList scoreList = new ScoreList();
            ScoreList2 scoreList2 = new ScoreList2();



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
                    scoreList2.addScore(vo);
                }


            }
            Console.WriteLine(scoreList2.ToString());
        }
    }
}
