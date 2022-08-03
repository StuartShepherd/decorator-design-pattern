using DecoratorDesignPattern;

Console.WriteLine("Decorator Design Pattern");
Console.WriteLine("Decorator is a structural pattern that allows adding new behaviors to objects dynamically by placing them inside special wrapper objects, called decorators.");
Console.WriteLine();

Client client = new Client();

var simple = new ConcreteComponent();
Console.WriteLine("Client: Simple component:");
client.ClientCode(simple);
Console.WriteLine();

var decoratorAlpha = new ConcreteDecoratorAlpha(simple);
var decoratorBeta = new ConcreteDecoratorBeta(decoratorAlpha);
Console.WriteLine("Client: Decorated component:");
client.ClientCode(decoratorBeta);