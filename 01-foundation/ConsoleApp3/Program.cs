//! OOP

decimal total = 100;
string customer = "Pablo";
Sale sale = new Sale( total, customer);

Console.WriteLine(sale.GetInfo());

string name  = "Stout";
string style = "Cerveza Fuerte";
Beer myBeer = new Beer( style, name );
Beer myBeer2 = new Beer( style, name );
Beer myBeer3 = new Beer( style, name );

Console.WriteLine( myBeer.Name + " " + myBeer.Style );
Console.WriteLine( Beer.Quantity );
Beer.Show();

Tax tax = new Tax(10m, 1.16m);
Console.WriteLine(tax.Amount);
Console.WriteLine(tax.GetTotal());
Console.WriteLine(tax);

Engineer hector = new Engineer("Héctor", "Programación");
Console.WriteLine(hector.GetInfo());

SaleTwo saleTwo = new SaleTwo();
saleTwo.Total = -1;
saleTwo.Total = 1192;

Console.WriteLine( saleTwo.Total );

class Sale
{
    public decimal total;
    public string  customer;

    public Sale( decimal total, string customer )
    {
        this.total = total;
        this.customer = customer;
    }

    public string GetInfo()
    {
        string info = "El total es $ " + total;
        info += " y el cliente es: " + customer;
        return info;
    }
};


//class Program
//{
    //static void Main(string[] args) {

    //}
//};

class Water
{
    public string Name;
    public Water( string name)
    {
        Name = name;
    }
}

class Beer : Water
{
    public static int Quantity = 0;
    public string Style;

    public Beer( string style, string name):
        base( name )
    {
        Style = style;
        Quantity++;
    }

    public static void Show()
    {
        Console.WriteLine(Quantity);
    }
}

class Tax
{
    public decimal Amount;
    private decimal _rate;
    
    public Tax( decimal amount, decimal rate )
    {
        Amount = amount;
        _rate = rate;
    }

    public decimal GetTotal()
    {
        return Amount * _rate;
    }
};

class People
{
    protected string name;

    public People( string name )
    {
        this.name = name;
    }

    protected string GetDescription()
    {
        return "El nombre es:" + name;
    }
};

class Engineer : People
{
    private string _profession;
    public Engineer(string name, string profession)
        : base(name)
    {
        _profession = profession;
    }

    public string GetInfo()
    {
        return "La profesión es: " + _profession + " " + GetDescription();
    }

    public string GetName()
    {
        return name;
    }

}

class SaleTwo
{
    //CAMPO
    private decimal total;
    
    //PROPIEDAD
    public decimal Total
    {
        get { return total; }
        set
        {
            total = value;

            if (total < 0)
            {
                total = 0;
            }
        }
    }
}