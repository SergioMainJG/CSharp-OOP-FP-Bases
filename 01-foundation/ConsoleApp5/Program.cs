Sale sale = new Sale(10m);
Console.WriteLine( sale.Total );
Sale inmutableSale = sale.AddAmountInmutable(1m);
Sale mutableSale = sale.AddAmountMutable(10m);

Console.WriteLine( inmutableSale.Total );
Console.WriteLine( mutableSale.Total );
Console.WriteLine( sale.Total );

//! Formas de declarar instancias
Sale myObject1 = new Sale(10m);
var myObject2 = new Sale(20m);
Sale myObject3 = new(30m);

Console.WriteLine($"Valores objetos: {myObject1.Total};\n {myObject2.Total}:\n {myObject3.Total};\n");

myObject1.Some1();
class Sale
{
    public decimal Total { get; set; }

    public Sale( decimal total )
    {
        Total = total;
    }

    public Sale AddAmountInmutable( decimal amount)
    {
        Sale newSale = new Sale( this.Total);
        newSale.Total += amount;
        return newSale;
    }
    public Sale AddAmountMutable( decimal amount) {
        Total += amount;
        return this;
    }

    public void Some1() => Console.WriteLine("Algo pasa");

 
}