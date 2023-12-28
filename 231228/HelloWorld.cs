
namespace HelloWorld
{
    internal class Program
    {
        //Main 메소드 : 프로그램의 진입점 => 프로그램 실행시 가장 먼저 실행. Main이 종료되면 프로그램도 종료된다.
        //=> 모든 프로그램에 반드시 하나 가지고 있어야 하는 메소드
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            OperatorExamples();

            // 비주얼 스튜디오 단축키
            // ctrl + space : 자동완성
            // ctrl + f5 : 디버깅 없이 실행
            // f5 : 디버깅
            // ctrl + k, d : 전체 정렬(들여쓰기 정렬)
            // ctrl + k, f : 선택 영역 정렬
            // ctrl + l : 한줄 잘라내기
            // ctrl + k, c : 한줄 주석설정 / ctrl + k, u 주석 해제
            // ctrl + shift + / : 여러줄 주석 = /* ~ */
            // ctrl + shift + n : 파일 / 새프로젝트
            // ctrl + shift + l : 솔루션 탐색기 열기(보기 메뉴에서 열어도 됨)
            // ctrl + k, s : 코드 감싸기(#if, #region 등)
            // alt + 위 / 아래 방향키 : 코드 이동
            // ctrl + s : 저장

        }

        private static void OperatorExamples()
        {

            int width = 3;
            width++;
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);

            bool truthValue = true;
            Console.WriteLine(truthValue);

        }
    }
}
