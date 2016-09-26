using System;


namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro");

            int x= int.Parse(Console.ReadLine());
            int y = 2*x;
            Console.WriteLine("DOBRO = " + y);
            Console.ReadLine();
        }
    }
}
