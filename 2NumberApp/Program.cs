using System;
					
public class Program
{
	public static void Main()
	{   Console.Write("Первая задача: ");
        Console.Write("Введите число А = ");
	    int a= int.Parse(Console.ReadLine());
		Console.Write("Введите число B = ");
		int b= int.Parse(Console.ReadLine());
		int sum=0;
        for (int i = a + 1; i < b; i++)
            {
                sum += i;
            }
        for (int i = b + 1; i < a; i++)
            {
                sum += i;
            }
        Console.WriteLine($"Сумма всех чисел, расположенных между данными числами = {sum}");
        Console.Write("Вторая задача: ");
        Console.Write("Введите число А = ");
	    int c = int.Parse(Console.ReadLine());
		Console.Write("Введите число B = ");
		int d = int.Parse(Console.ReadLine());
        /*for (int i = c + 1 % 2 == 1 ? c + 1 : c + 2; i < d; i = i + 2)
        Console.WriteLine("{0} ",i);*/
        for (int i = c + 1; i < d; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine($"{i}");
            }
        }
        for (int i = d + 1; i < c; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine($"{i}");
            }
        }
	}
}