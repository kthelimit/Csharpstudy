namespace CardPickerTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CardPicker cards = new CardPicker();
            Console.Write("카드 개수>> ");
            string line = Console.ReadLine();

            if(int.TryParse(line, out int numberOfCards)) 
            {
                foreach (string card in cards.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("잘못된 값을 입력하셨습니다!!");
            }

        }
    }
}
