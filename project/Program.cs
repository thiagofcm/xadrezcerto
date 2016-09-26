using System;


namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro");

            int x= int.Parse(Console.ReadLine());
            int y = 3*x;
            Console.WriteLine("TRIPLO = " + y);
            Console.ReadLine();
        }
    }
}
