using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] ducks = new Duck[] { new DecoyDuck(), new RubberDuck(), new ReadheadDuck(), new MallardDuck() };
            foreach (Duck duck in ducks)
            {
                duck.Fly();
                duck.Quack();
                duck.Swim();
                duck.Dead();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
