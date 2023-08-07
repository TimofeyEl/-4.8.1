using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Линьков_Тимофей_4._8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            string row = Console.ReadLine();
            if (int.TryParse(row, out int x))
                Console.WriteLine(x);
            else
                Console.WriteLine("Вы ввели не число, попробуйте еще раз.");

            Console.Write("Введите количество столбцов: ");
            string col = Console.ReadLine();
            if (int.TryParse(col, out int y))
                Console.WriteLine(y);
            else
                Console.WriteLine("Вы ввели не число, попробуйте еще раз.");

            int[,] matrix = new int[x, y];
            int sum = 0;
            Random random = new Random();

            for(int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    matrix[i, j] = random.Next(10);
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i,j],3}");
                    
                }
                Console.WriteLine($" Сумма: {sum}",3);
                Console.ReadKey();
            }
            
        }
      
    }
   
}
