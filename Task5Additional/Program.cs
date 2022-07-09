internal class Program
{
    private static void Main(string[] args)

        //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
        {
         Console.Clear();
         Console.WriteLine("Введите трехзначное число: N");
         string str = Console.ReadLine();
         int strLen = str.Length;
         if (strLen != 3)
         {
         Console.WriteLine("Перезапустите программу и введите корректное (трехзначное) число");
         }
         else
            {
            int N = Int32.Parse(str);
            int lastNuber = N % 10;
            Console.WriteLine($"{lastNuber} - это последняя цифра числа N");        
            }
        }
}
