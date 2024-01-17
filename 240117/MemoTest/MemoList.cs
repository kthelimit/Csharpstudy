

namespace MemoTest
{
    // 메모(memoVo) 목록을 기억하는 클래스
    internal class MemoList
    {
        List<MemoVo> memoList= new List<MemoVo>();
        public List<MemoVo> GetMemoList()
        {
            return memoList;
        }
        public void SetMemoList(List<MemoVo> memoList)
        {
            this.memoList = memoList;
        }
        public override string ToString()
        {
            string str = "";
            if(memoList.Count==0)
            {
                // 저장된 메모가 없다는 메시지를 출력한다.
                Console.WriteLine("저장된 메모가 없습니다.\n");
            }
            else
            {
                // 저장된 메모가 있으면 마지막에 입력한 글(최신글)부터 출력한다.
                //for(int i=0; i<memoList.Count; i++){}
                // => 처음부터 마지막
                for(int i = memoList.Count-1; i >= 0; i--)
                {
                    str += memoList[i].ToString()+"\n";
                }
            }
            return str;
        }

        public void AddMemo(MemoVo vo)
        {
            memoList.Add(vo);
        }

        // MemoMain에서 호출되는 수정 또는 삭제할 글 번호를 넘겨받고 memoList라는 Lsit에 저장된 메모 중에서
        //수정 또는 삭제할 글번호에 해당되는 글 1건을 얻어와서 리턴하는 메서드
        internal MemoVo SelectMemo(int idx)
        {
            return memoList[idx - 1];
        }

        internal void DeleteMemo(int idx)
        {
            memoList.RemoveAt(idx - 1);
            // 메모 삭제 후 인덱스가 변경되므로 인덱스에 맞춰서 글번호를 다시 붙여준다.
            // 이 현상은 데이터베이스를 사용하지 않고 List를 사용하기 때문에 발생되는 현상이다.
            // List는 앞의 데이터가 지워지면 뒤의 데이터가 앞으로 인덱스가 당겨지는 특징이 있다.

            for(int i=0; i<memoList.Count; i++)
            {
                memoList[i].SetIdx(i + 1);
            }            
        }
    }
}
