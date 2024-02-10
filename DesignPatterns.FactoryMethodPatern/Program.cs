// See https://aka.ms/new-console-template for more information

PizzaStore ankaraPizza = new AnkaraPizzaStore();

IPizza cheese = ankaraPizza.OrderPizza("cheese");
Console.WriteLine("Cheese pizza ordered in Ankara Store");

PizzaStore istanbulPizza = new IstanbulPizzaStore();

IPizza veggiePizza = istanbulPizza.OrderPizza("veggi");
Console.WriteLine("Veggie pizza ordered in İstanbul Store");


interface IPizza
{
    void Prepare();
    void Bake();
    void Cut();
}

class CheesePizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Cheese Pizza Bake");
    }

    public void Cut()
    {
        Console.WriteLine("Cheese Pizza Cut");
    }

    public void Prepare()
    {
        Console.WriteLine("Cheese Pizza Prepare");
    }
}
class VegiPizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Vegi Pizza Bake");
    }

    public void Cut()
    {
        Console.WriteLine("Vegi Pizza Cut");
    }

    public void Prepare()
    {
        Console.WriteLine("Vegi Pizza Prepare");
    }
}
abstract class PizzaStore
{
    protected abstract IPizza CreatePizza(string type);
    public IPizza OrderPizza(string type)
    {
        IPizza pizza = CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        return pizza;
    }
}
class AnkaraPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new CheesePizza(),
            "veggi" => new VegiPizza(),
            _ => throw new ArgumentException("Invalid pizza type", nameof(type))
        };
    }
}
class IstanbulPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new CheesePizza(),
            "veggi" => new VegiPizza(),
            _ => throw new ArgumentException("Invalid pizza type", nameof(type))
        };
    }
}

