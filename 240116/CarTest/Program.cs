namespace CarTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Car(); // Car 클래스의 인스턴스가 생성된 후 생성자가 호출된다.

            // 매개변수가 있는 생성자일 경우 인수를 전달해야한다.
            new Car("넥쏘");

            new Car("아이오닉6", "흰색");

            Car car = new Car("티코");

            //car 변수으 name 속성 출력
            Console.WriteLine(car.name);

            Car car2 = new Car(300);
            Console.WriteLine(car2.maxSpeed);
        }
    }
}
