namespace DecoratorDesignPattern
{
    public class ConcreteDecoratorAlpha : Decorator
    {
        public ConcreteDecoratorAlpha(Component comp) : base(comp)
        {
        }

        public override string Operation() =>
            $"ConcreteDecoratorAlpha ({base.Operation()})";
    }
}
