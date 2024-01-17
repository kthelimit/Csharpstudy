using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreTest
{
    // VO(Value Object) 클래스 : 1건의 데이터와 데이터를 처리하는 메서드를 모아놓은 클래스이다.
    // VO클래스는 DTO(Data Transfer Object) 클래스라고도 부른다.
    internal class ScoreVo
    {
        string name;
        int kor;
        int eng;
        int math;
        int music;
        int total;
        double avg;
        int rank = 1;
        int idx;
        static int count;

        public ScoreVo() : this("기타",0,0,0,0) //아래의 생성자를 가져다 쓰는 것임
        {
            //idx = ++count;
            //name = "기타";
            //kor = 0;
            //eng = 0;
            //math = 0;
            //music = 0;
            //total = kor + eng + math + music;
            //avg = (double)total / 4;
            Console.WriteLine("기본 생성자가 실행됩니다.");
        }
        public ScoreVo(string _name, int _kor, int _eng, int _math, int _music)
        {
            idx = ++count;
            this.name = _name;
            this.kor = _kor;
            this.eng = _eng;
            this.math = _math;
            this.music = _music;
            //총점과 평균을 계산한다.
            total = kor + eng + math + music;
            avg = (double)total / 4;
        }
        public string GetName()
        {
            return name;
        }
        public int GetKor()
        {
            return kor;
        }
        public int GetEng()
        {
            return eng;
        }
        public int GetMath()
        {
            return math;
        }
        public int GetMusic()
        {
            return music;
        }
        public int GetRank()
        {
            return rank;
        }
        public int GetTotal()
        {
            return total;
        }
        public double GetAvg()
        {
            return avg;
        }
        public int GetIdx()
        {
            return idx;
        }
        public int GetCount()
        {
            return count;
        }


        public override string ToString()
        {
            return string.Format($"  {idx,-4:00}{name,4}{kor,5}  {eng,5}  {math,5}  {music,5}  {total,5}  {avg,6:0.00}    {rank,2}");
        }

        internal void SetRank(int rank)
        {
            this.rank = rank;
        }
    }
}
