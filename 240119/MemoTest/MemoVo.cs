using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoTest
{
    // 메모 1건을 기억하는 클래스
    internal class MemoVo
    {
        public static int count;    // 자동 증가에 사용할 정적 필드
        int idx;                    // 글 번호 => 자동 증가
        string name;                // 작성자
        string password;            // 비밀번호
        string memo;                // 메모 내용
        DateTime writeDate;         // 작성일

        public MemoVo() : this("기타", "1", "test")
        {

        }
        public MemoVo(string name, string password, string memo)
        {
            idx = ++count;
            this.name = name;
            this.password = password;
            this.memo = memo;
            writeDate = DateTime.Now;
        }

        public int GetIdx()
        {
            return idx;
        }
        public string GetName()
        {
            return name;
        }

        public string GetPassword()
        {
            return password;
        }

        public string GetMemo()
        {
            return memo;
        }
        public DateTime GetWriteDate()
        {
            return writeDate;
        }
        public override string ToString()
        {
            return string.Format($"{idx}. {name}({password})  {writeDate}에 작성한 글 {memo}\n");
        }

        public void SetIdx(int idx)
        {
            this.idx = idx;
        }

        public void SetMemo(string memo)
        {
            this.memo = memo;
        }
    }
}
