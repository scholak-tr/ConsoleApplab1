
public abstract class Duck
{
    public string Name { get; set; }
    private IFly fly;
    private ISwim swim;
    private IQuack quack;
    private IDead dead;
    public Duck(IFly fly, ISwim swim, IQuack quack, IDead dead)
    {
        this.fly = fly;
        this.swim = swim;
        this.quack = quack;
        this.dead = dead;
    }
    public void Swim()
    {
        this.swim.Swim();
    }
    public void Fly()
    {
        this.fly.Fly();
    }
    public void Quack()
    {
        this.quack.Quack();
    }
    public void Dead()

    {
        this.dead.Dead();
    }
}


