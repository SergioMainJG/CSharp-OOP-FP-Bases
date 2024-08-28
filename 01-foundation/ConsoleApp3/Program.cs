//! OOP

decimal total = 100;
string customer = "Pablo";
Sale sale = new Sale( total, customer);

Console.WriteLine(sale.GetInfo());

string name  = "Stout";
string style = "Cerveza Fuerte";
Beer myBeer = new Beer( style, name );
Console.WriteLine( myBeer.Name + " " + myBeer.Style );

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
    public string Style;
    public Beer( string style, string name):
        base( name )
    {
        Style = style;
    }
}
