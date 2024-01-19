namespace PropertyTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PropertyVo vo = new PropertyVo();
            vo.d = 13;
            Console.WriteLine("a의 값은 " + vo.d);

            Console.WriteLine(vo.name_);
            vo.name_ = "얌얌";
            Console.WriteLine(vo.name_);
        }
    }
}
