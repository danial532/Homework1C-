internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        Console.Clear();
         Console.WriteLine("Введите число А ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число B");
        int B = Convert.ToInt32(Console.ReadLine());
        
        {
        if (A < B) 
        Console.WriteLine ($" {B} > {A}");
        else
            if (A>B) Console.WriteLine ($" {A} > {B}");
            else 
            Console.WriteLine ($"числа равны, {A} = {B}");
        }
    }
}
