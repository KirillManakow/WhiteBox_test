using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_white_box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = 1;
            do
            {
                try
                {
                    double max = 0;
                    int tmp = 0;
                    int tmpp = 0;
                    int N;
                    do
                    {
                        Console.WriteLine("Введите колчество чисел содержащихся в массиве");
                        Int32.TryParse(Console.ReadLine(), out N);
                        if (N > 0)
                        {

                            Console.WriteLine("Введите 1 если хотите, чтобы массив заполнился самостоятельно или 2 если хотите заполнить вручную");
                            double vibor = Double.Parse(Console.ReadLine());
                            if (vibor == 1)
                            {
                                Console.WriteLine("Введите начало промежутка цифр в массиве");
                                int x = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите конец промежутка цифр в массиве");
                                int y = int.Parse(Console.ReadLine());
                                double[] arr = new double[N];
                                Random rand = new Random();
                                for (int i = 0; i < arr.Length; i++)
                                {
                                    arr[i] = rand.Next(x,y);
                                }
                                double min = arr[0];

                                Console.WriteLine("Исходный массив: ");
                                for (int i = 0; i < arr.Length; i++)
                                {

                                    if (arr[i] > max)
                                    {
                                        max = arr[i];
                                        tmp = i;

                                    }
                                    if (min > arr[i])
                                    {
                                        min = arr[i];
                                        tmpp = i;

                                    }
                                    Console.Write(arr[i] + " ");
                                }
                                Console.WriteLine();
                                Console.WriteLine("Максимальное число: {0}", max);
                                Console.WriteLine("Максимальное число: {0}", min);
                                Console.WriteLine();
                                Console.WriteLine("Меняем местами элементы: ");
                                for (int i = 0; i < arr.Length; i++)
                                {
                                    arr[tmpp] = max;
                                    arr[tmp] = min;

                                    Console.Write(arr[i] + " ");
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                int i = 0;
                                double[] arr = new double[N];
                                for (i = 0; i < N; i++)
                                {
                                    Console.WriteLine("Введите {0}-й элемент", i + 1);
                                    arr[i] = int.Parse(Console.ReadLine());
                                }
                                int k = 0;
                                for (i = 0; i < arr.Length; i++)
                                    if (arr[i] % 2 == 0)
                                        k++;

                                Console.WriteLine("Исходный массив: ");
                                double min = arr[0];
                                for (i = 0; i < arr.Length; i++)
                                {

                                    if (arr[i] > max)
                                    {
                                        max = arr[i];
                                        tmp = i;

                                    }
                                    if (min > arr[i])
                                    {
                                        min = arr[i];
                                        tmpp = i;

                                    }
                                    Console.Write(arr[i] + " ");
                                }
                                Console.WriteLine();
                                Console.WriteLine("Максимальное число: {0}", max);
                                Console.WriteLine("Максимальное число: {0}", min);
                                Console.WriteLine();
                                Console.WriteLine("Меняем местами элементы: ");
                                for (i = 0; i < arr.Length; i++)
                                {
                                    arr[tmpp] = max;
                                    arr[tmp] = min;

                                    Console.Write(arr[i] + " ");
                                }
                                 end = 0;
                                Console.ReadKey();

                            }


                        }
                        else
                        {
                            Console.WriteLine("Данные введене неверно. Размер массива должен быть больше нуля ( >0 )");
                        }

                    }
                    while (N <= 0);
                }
                catch (Exception)
                {
                    Console.WriteLine("ОШИБКА! ОШИБКА! ОШИБКА!");
                }
            } while (end == 1);
        }
    }
}

