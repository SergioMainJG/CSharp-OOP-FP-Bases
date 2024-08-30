using System.Text.Json;

try
{
    var numbers = new int[5]
    {
        1,2,3, 4,5,
    };
    Console.WriteLine(numbers[2]);

    string text = File.ReadAllText("extra.md");
}
catch ( FileNotFoundException ex )
{
    if( ex is FileNotFoundException)
    {
        File.CreateText("extras.md");
    }
}
catch( Exception ex )
{
    Console.WriteLine("Algo ocurrió mal :C");

}
finally
{
    Console.WriteLine("Finally");
}

try
{
    //var beer = new Beer();
}
catch ( BeerNotFoundException ex )
{
    Console.WriteLine(ex.Message);
}
catch ( Exception ex )
{
    Console.WriteLine("Algo paso, ayuda");
}

var beer = new Beer()
{
    Price = 40
};

string jsonBeer = JsonSerializer.Serialize(beer);
Console.WriteLine(jsonBeer);
class BeerNotFoundException : Exception
{
    public BeerNotFoundException( string message ): base(message) { }
}

class Beer
{
    private int _quantity;

    public decimal Price { get; set; }
    private int Quantity
    {
        get { return _quantity; }
        set {
            if( value <= 0)
            {
                throw new BeerNotFoundException("No hay cerveza :c");
            }
            _quantity = value;
        }
    }

}