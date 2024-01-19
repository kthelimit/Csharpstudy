namespace UpcastingDowncastingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Marine marine = new Marine();
            //marine.Attack();
            //marine.StimPack();

            //업캐스팅 => 암시적
            //TerranUnit unit = marine;
            //TerranUnit unit;
            //unit = new Marine();
            //unit.Attack();
            //unit.StimPack(); // 호출불가.
            //자식 클래스에 있던 메서드를 실행할 수 없음....

            // GetType() : 현재 인스턴스의 자료형 => New 키워드를 통해서 생성된 인스턴스의 자료형

            //Console.WriteLine(unit.GetType().Name);
            // new Marine()으로 생성된 인스턴스라서 Marine으로 나온다.
            //Console.WriteLine(typeof(TerranUnit).Name);
            // typeof는 자료형을 직접 써야함...

            //업캐스팅 => 명시적

            //TerranUnit unit = new Marine(); //암시적 업캐스팅
            //TerranUnit unit = (TerranUnit)new Marine();
            //unit.Attack();
            //unit.StimPack(); // 호출불가.

            //다운캐스팅
            //TerranUnit unit = new Marine(); //암시적 업캐스팅
            //Marine marine = (Marine)unit; //명시적 다운캐스팅
            //marine.Attack();
            //marine.StimPack(); //호출가능



            //부모클래스 인스턴스 생성 후, 자식 클래스 타입으로 (다운캐스팅) 할 수 없다.
            // => 예외발생
            //Marine marine = (Marine)new TerranUnit(); //명시적 다운캐스팅
            //marine.Attack();
            //marine.StimPack();
            //컴파일 오류는 안 나오는데.... 실행하면 불가능한캐스트예외가 발생함.

            // is 연산자 : 런타임(프로그램이 동작되어지는 때) 형식이 지정된 형식과 호환되는지
            // 확인 => true / false 값으로 반환
            // as 연산자 : 런타임 형식이 지정된 형식과 호환된 경우, 해당 형식으로 명시적 변환.
            // => 변환할 수 없는 경우, as 연산자가 null을 반환
            // => 예외를 나타내지 않고 null로 만든다.

            // is 연산자를 사용해서 형식변환이 가능한지 확인 가능
            //TerranUnit unit = new TerranUnit();
            //bool canDownCast = unit is Marine;
            //Console.WriteLine(canDownCast);

            //Marine marine = new Marine();
            //bool canUpcast = marine is TerranUnit;
            //Console.WriteLine(canUpcast);
            //TerranUnit unit = marine;

            //TerranUnit unit = new Marine(); //암시적 업캐스팅
            //Console.WriteLine(unit is Marine);
            //Marine marine = (Marine)unit; //명시적 다운캐스팅


            // as 연산자를 사용해 명시적으로 캐스팅하기
            //Marine marine= new Marine();
            //TerranUnit unit = marine as TerranUnit; //명시적 업캐스팅
            //Console.WriteLine(unit); //성공

            TerranUnit unit = new TerranUnit();
            Marine marine = unit as Marine;//변환이 실패하면 예외없이 null반환
            Console.WriteLine("marine : {0}", marine); 


        }
    }
}
