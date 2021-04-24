using System;

namespace jaba2_task1
{
    class Program
    {
        delegate void oprration(int x); //сигнатура делегата
        static oprration[] arr = new oprration[3]; //массив делегата
        static void Main(string[] args)
        {
            arr[0] = (x) => Console.WriteLine(Math.Sqrt(Math.Abs(x)));
            arr[1] = (x) => Console.WriteLine(Math.Pow(x, 3));
            arr[2] = (x) => Console.WriteLine(x + 3.5);


            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');

                try
                {
                    int oprID = int.Parse(str[0]);
                    int x = int.Parse(str[1]);

                    arr[oprID](x);

                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка! \nВведите валидные данные.");
                    break;
                }
            }
        }
    }
}
