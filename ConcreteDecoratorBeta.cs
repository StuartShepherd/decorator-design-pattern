namespace DecoratorDesignPattern;

public class ConcreteDecoratorBeta : Decorator
{
    public ConcreteDecoratorBeta(Component comp) : base(comp)
    {
    }

    public override string Operation() =>
        $"ConcreteDecoratorBeta ({base.Operation()})";
}
