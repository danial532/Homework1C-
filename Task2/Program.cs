internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        Console.Clear();
        Console.WriteLine("Введите число А ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число B");   
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число C");
        int C = Convert.ToInt32(Console.ReadLine());

        {
            if (A > B && A > C)
            {
             Console.WriteLine($"Максимальное число = {A}");
            }
                if (B > A && B > C)
                {
                 Console.WriteLine($"Максимальное число = {B}");
                }
                    if (C > A && C > B)
                    {
                     Console.WriteLine($"Максимальное число = {C}");
                    }
            
        }
    }
}