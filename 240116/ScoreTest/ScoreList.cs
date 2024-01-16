
namespace ScoreTest
{
    // 여러학생들의 정보(ScoreVo 클래스)를 기억하는 클래스
    internal class ScoreList
    {
        // 여러 명의 학생 정보를 기억할 배열을 선언만 한다.
        // null로 초기화 된다.
        ScoreVo[] scoreList;
        int size; //배열의 크기
        int index; // 배열의 인덱스, 배열에 저장된 데이터의 개수

        public ScoreList()
        {
            size = 10;
            scoreList = new ScoreVo[size];
        }

        public ScoreList(int size)
        {
            this.size = size;
            scoreList = new ScoreVo[size];
        }
        public ScoreVo[] GetScoreList()
        {
            return scoreList;
        }

        public int GetSize()
        {
            return size;
        }

        public int GetIndex()
        {
            return index;
        }

        public override string ToString()
        {
            string str = "";
            str += "===============================================================\n";
            str += " 번호 | 이름 | 국어 | 영어 | 수학 | 음악 | 총점 | 평균 | 순위 \n";
            str += "===============================================================\n";

            for (int i = 0; i < index; i++)
            {
                for (int j = i + 1; j < index; j++)
                {
                    //i번째 학생의 총점이 크면 j번째 학생의 순위를 증가시키고,
                    //j번째 학생의 총점이 크면 i번째 학생의 순위를 증가시킨다.
                    if (scoreList[i].GetTotal() > scoreList[j].GetTotal())
                    {
                        scoreList[j].SetRank(scoreList[j].GetRank() + 1);
                    }
                    else if (scoreList[i].GetTotal() < scoreList[j].GetTotal())
                    {
                        scoreList[i].SetRank(scoreList[i].GetRank() + 1);
                    }
                }
                //str += scoreList[i].ToString();
                //str += "\n";
            }
            foreach (ScoreVo vo in scoreList)
            {
                str += vo + "\n";
            }
            str += "===============================================================\n";

            return str;
        }


        internal void addScore(ScoreVo vo)
        {
            scoreList[index++] = vo;
        }
    }
}
