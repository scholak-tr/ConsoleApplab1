
    public class DecoyDuck : Duck
    {
        public DecoyDuck() : base(new FlyNoWay(), new SwimNoWay(), new QuackNoWay(), new Deadbehaviour()) { }
    }


