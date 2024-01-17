using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ScoreTest
{
    internal class ScoreList2
    {
        List<ScoreVo> scoreList = new List<ScoreVo>();

        public List<ScoreVo> GetScoreList()
        {
            return scoreList;
        }

        //override 재정의. 부모클래스에 있는걸 자식클래스에서 바꿔쓰는거.
        public override string ToString()
        {
            string str = "";
            str += "===============================================================\n";
            str += " 번호 | 이름 | 국어 | 영어 | 수학 | 음악 | 총점 | 평균 | 순위 \n";
            str += "===============================================================\n";

            for (int i = 0; i < scoreList.Count; i++)
            {
                for (int j = i + 1; j < scoreList.Count; j++)
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
            }
            for (int i = 0; i < scoreList.Count; i++)
            {
                str += scoreList[i].ToString() + "\n";
            }

            str += "===============================================================\n";

            return str;
        }


        internal void addScore(ScoreVo vo)
        {
            scoreList.Add(vo);
        }
    }
}
