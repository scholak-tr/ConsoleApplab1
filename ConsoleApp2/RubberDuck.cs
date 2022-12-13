
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new FlyNoWay(), new SwimNoWay(), new QuackNoWay(), new Deadbehaviour()) { }
    }



