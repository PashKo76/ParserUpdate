namespace ParserUpdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greetings();
            string? Input;
            ParserOutput output;
            while (true)
            {
                Input = Console.ReadLine();
                try
                {
                    output = Parser.LetsParse(Input);
                    break;
                }
                catch
                {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Ёще Раз Без Ошибок");
                Greetings();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Ваша команда");
            Console.WriteLine($"Команда - <{output.Command}>; X - {output.X}; Y - {output.Y}");
            Console.ReadKey();
        }
        static void Greetings()
        {
            Console.WriteLine("Введите Кординаты");
            Console.WriteLine("Образец: <Открыть или Флаг> X Y");
            Console.Write(":");
        }
    }
}