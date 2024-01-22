namespace PropertyTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PropertyTest1 pro = new PropertyTest1();
            ////pro.name = "Test"; // =>에러. name 필드가 private
            //pro.Name = "홍길동";
            //Console.WriteLine(pro.Name);


            PropertyTest1 pro = new PropertyTest1("홍길동") { Age=20 };
            //아마 오른쪽의 중괄호가 이니셜라이저, 괄호 안이 생성자임
            Console.WriteLine("name: {0}, age: {1}", pro.Name, pro.Age);
        }
    }
}
