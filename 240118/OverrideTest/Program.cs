namespace OverrideTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // virtual 키워드는 기본 클래스에서 정의된 메서드를 파생클래스에서
            // 재정의하도록 허용한다.
            // => static, abstract, private 한정자와 함께 사용할 수 없다.
            // override 한정자는 상속된 메서드의 구현을 확장하거나 수정하는데
            // 필요하다.

            Marine marine = new Marine();
            marine.name = "마린";
            Firebat firebat = new Firebat();
            firebat.name = "파이어뱃";
            marine.Attack();
            firebat.Attack();


        }
    }
}
