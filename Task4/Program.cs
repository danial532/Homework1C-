internal class Program
{
    private static void Main(string[] args)
    {
        //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. (не включая N)
        Console.Clear();
        Console.WriteLine("Введите число: N");
        int N = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        {
        while (i < N)
            {
            if (i % 2 == 0)
            {
             Console.Write($"{i}, ");
             i = i+1;
            }
            else { i=i+1; }
            }
        Console.WriteLine("- это все чётные числа от 1 до N");        
        }
    }
    
}
