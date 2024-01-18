namespace UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 업캐스팅 : 자식 클래스 타입의 객체를 부모 클래스 타입의 객체로
            // 형변환 하는 것을 말한다.


            Dog dog = new Dog();
            Animal animal;
            animal = dog; //부모 클래스로 업캐스팅됨.
            Console.WriteLine("#"+dog.name); //강아지로 나옴

            Animal animal2 = new Dog();
            
            dog.Bark();
            animal.Bark(); // 멍멍이 override 되어있어서 나옴
            Console.WriteLine($"#{animal.name}"); // 동물로 나옴
            Console.WriteLine($"#{animal2.name}"); // 동물로 나옴

            Animal animal1 = new Animal();
            animal1.Bark();
            Console.WriteLine("#"+animal1.name);
        }
    }
}
