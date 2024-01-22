namespace InterfaceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hydralisk hydralisk = new Hydralisk();
            //hydralisk.Burrow();
            //hydralisk.RecoveryHp();

            // 인터페이스는 형식 => 인스턴스를 생성할 수 없다.
            //new IZerg(); // =>에러. 
            //업캐스팅 => izerg 변수의 값은 Hydralisk 인스턴스
            //IZerg izerg = new Hydralisk();
            //izerg.Burrow();
            //izerg.RecoveryHp();

            //IMetamorph metamorph = new Hydralisk();
            //metamorph.Morph("러커");
            //metamorph.Burrow(); // 접근불가
            //metamorph.RecoveryHp(); // 접근 불가
            //metamorph.damage=4; // 접근불가: 해당 타입에 정의되어 있지 않음
            // 업캐스팅 되면 자식개체에 있는필드나 메서드를 쓸 수 없음...

            //다운캐스팅
            //var h = (Hydralisk)metamorph;
            //h.damage = 4;
            // int hydralistDamage = ((Hydralisk)metamorph).damage;
            // => 소괄호 이용해서 직접 필드에 접근 가능
            //int hydraliskDamage = (metamorph as Hydralisk).damage;
            // => as 연산자 이용한 다운캐스팅
            //Console.WriteLine(hydraliskDamage);

            //IZerg zerg = new Hydralisk();
            //zerg.Morph("저글링"); // 접근불가. => IZerg 인터페이스에 정의되어있지 않음

            Hydralisk hydralisk = new Hydralisk();
            hydralisk.Morph("러커");
            hydralisk.Burrow();
            hydralisk.RecoveryHp();
            Console.WriteLine(hydralisk.damage);
        }
    }
}
