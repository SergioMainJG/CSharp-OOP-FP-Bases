
Console.WriteLine(Math.Add(35, 45));
Console.WriteLine(Math.Add(23, 82 ));
Console.WriteLine(Math.Add("5", "15"));

SaleWithTax sale = new SaleWithTax(1.16m);
sale.Add(10m);
sale.Add(20m);
Console.WriteLine(sale.Total);
class Math
{
    public static int Add( int x, int y)
    {
        return x + y;
    }
    public static int Add(int x, int y, int z)
    {
        return x + y + z;
    }
    public static int Add(string x, string y)
    {
        return int.Parse( x ) + int.Parse( y );
    }
}

class Sale
{
    protected decimal _total;

    public virtual void Add( decimal amount )
    {
        _total += amount;
    }
}

class SaleWithTax : Sale
{
    private decimal _tax;
    public decimal Total
    {
        get
        {
            return _total;
        }
    }

    public SaleWithTax( decimal tax )
    {
        _tax = tax;
    }

    public override void Add(decimal amount)
    {
        base.Add(amount * _tax);
    }
} 