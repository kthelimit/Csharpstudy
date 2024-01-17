using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace MemoTest
{
    internal class MemoMain
    {
        private static MemoList memoList = new MemoList();
        static void Main(string[] args)
        {
            //MemoVo memo1 = new MemoVo("고길동", "1111", "1등!!!");
            //MemoVo memo2 = new MemoVo("둘리", "22222", "2등!!");
            //MemoVo memo3 = new MemoVo("도우너", "3333", "메롱!!");
            //Console.WriteLine(memo1.ToString());

            //1. 입력 / 목록보기 / 수정 / 삭제 / 종료를 선택할 수 있는 메뉴를 나타내고
            //해당 번호 입력시 해당 작업을 할 수 있게 한다.
            
            int menu = 0;
            while (menu != 5)
            {
                while (true)
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine("1. 입력 | 2. 목록 보기 | 3. 수정 | 4. 삭제 | 5. 종료");
                    Console.WriteLine("=======================================================");
                    Console.Write("메뉴 선택 >> ");
                    menu = Convert.ToInt32(Console.ReadLine());
                    if (menu >= 1 && menu <= 5)
                    {
                        break;
                    }
                    Console.WriteLine("메뉴는 1 ~ 5 사이 숫자로 입력하세요.");
                }
                //여기까지 왔다면 1~5사이의 정수가 입력 되었다는 의미이다.
                switch (menu)
                {
                    case 1: Insert(); break;
                    case 2: ShowList(); break;
                    case 3: Update(); break;
                    case 4: Delete(); break;
                }
            }
            Console.WriteLine("프로그램을 종료합니다.");
        }

        // 삭제할 글 번호를 입력받아 삭제할 글 1건을 가지고 와서 화면에 표시하고
        // 비밀번호를 입력받아서 memoList라는 List에 저장된 글 1건을 삭제한다.
        private static void Delete()
        {
            Console.Write("삭제할 글 번호 >>");
            int idx = Convert.ToInt32(Console.ReadLine());

            //memoList라는 List에 저장된 1건을 가지고 오는 메서드를 실행하고
            //가지고 온 결과를 MemoVo클래스 객체에 저장한다.

            MemoVo origin = memoList.SelectMemo(idx);
            //삭제할 글 번호에 해당되는 글을 삭제한다.
            Console.WriteLine("삭제할 글 확인");
            Console.WriteLine(origin.ToString());

            //삭제할 글의 비밀번호를 입력받는다.
            Console.Write("비밀번호 입력>>");
           string password = Console.ReadLine();
            
            //삭제하기 위해 입력한 비밀번호와 삭제할 글의 비밀번호를 비교한다.
            if(password == origin.GetPassword())
            {
                memoList.DeleteMemo(idx);
                Console.WriteLine(idx+"번 글 삭제 완료!!");
            }
            else
            {
                //비밀번호가 일치하지 않기 때문에 비밀번호가 일치하지 않는다는 메시지를 출력한다.
                Console.WriteLine("비밀번호가 일치하지 않습니다.");
            }


        }

        private static void Update()
        {
            throw new NotImplementedException();
        }

        private static void ShowList()
        {
            Console.WriteLine(memoList.ToString());
        }

        //이름, 비밀번호, 메모를 입력받아 MemoVo 클래스 객체에 저장하고 List에 저장하는 메소드를 호출하는 메소드
        private static void Insert()
        {
            Console.WriteLine("메모장에 저장할 글 입력");
            Console.Write("이름: ");
            string name = Console.ReadLine().Trim();
            Console.Write("비밀번호: ");
            string password = Console.ReadLine();
            Console.Write("메모: ");
            string memo = Console.ReadLine();
            MemoVo vo = new MemoVo(name, password, memo);
            // Console.WriteLine(vo.ToString());
            // MemoVo  클래스 객체를 MemoList 클래스의 List에 저장하는 메소드를 실행한다.        
            //insert() 메서드가 종료되면 메모리에서 해제된다.
            //MemoList list = new MemoList();
            memoList.AddMemo(vo);
            Console.WriteLine("저장 완료~!!!");
        }
    }
}
