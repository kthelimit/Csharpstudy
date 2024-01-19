namespace Starcraft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TerranUnit unit = new TerranUnit(); //추상클래스는 new 사용 못함
            Marine marine = new Marine();
            //marine.SetName("마린이");
            //marine.maxHp = 100;
            marine.Init("마린이", 100);
            marine.Attack();
            marine.Hit(25);

        }
    }
}
