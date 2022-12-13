using System;
partial class Program

{


    static void Main(string[] args)
    {
        Duck duck = new DecoyDuck();
        duck.Fly();
        duck.Quack();
        duck.Swim();
        duck.Dead(); 

        Console.ReadLine();

    }

}

