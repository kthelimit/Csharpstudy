namespace Inheritance
{
    internal class Star
    {
        static void Main(string[] args)
        {
            // 상속 : 다른 클래스에 정의된 동작을 재사용, 확장 및 수정하는 새 클래스를 만들 수 있다.
            // => 멤버가 상속되는 클래스를 기본클래스(부모 클래스)이고,
            // 해당 멤버를 상속하는 클래스를 파생클래스(자식 클래스)라고 한다.
            // => 다중 상속은 지원하지 않고 단일 상속만 가능
            // => 자식 인스턴스를 통해서 부모 클래스 멤버를 사용할 수 있다.
            // => 코드를 재사용하고 구현시간을 단축 / 기존 클래스의 필드와 메서드를 재사용
            // => 파생클래스 객체를 생성하면 기본 클래스의 생성도 호출된다.
            
            // class 자식이름 :  부모이름
            //{
            //}

            Marine marineA = new Marine();
            marineA.Init("마린A",10);
            marineA.damage = 2;

            Marine marineB = new Marine();
            marineB.Init("마린B", 10);
            marineB.damage = 2;

            Medic medicA = new Medic();
            medicA.healValue = 3;

            marineB.Attack(marineA);
            Console.WriteLine("{0}의 체력 : {1}", marineA.name, marineA.GetHp());
            Console.WriteLine("{0}의 체력 : {1}", marineB.name, marineB.GetHp());

            medicA.Heal(marineA);
            Console.WriteLine("{0}의 체력 : {1}", marineA.name, marineA.GetHp());
            Console.WriteLine("{0}의 체력 : {1}", marineB.name, marineB.GetHp());

        }
    }
}
