namespace AbstractTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parent parent = new Parent(); //추상 클래스는 new 사용 못함
                                          //=> 직접 인스턴스를 만들 수 없다.
        
            AbstractTest1 test = new AbstractTest1();
            test.printName(); //파생클래스에서 재정의한 추상메서드 호출
            test.nomalMethod(); //기본클래스에서 선언한 일반 메서드 호출

        }
    }
}
