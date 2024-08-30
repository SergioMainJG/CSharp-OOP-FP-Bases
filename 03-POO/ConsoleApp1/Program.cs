int[] numbers = new int[5]
{
    1,2, 3, 4, 5
};

string[] name = new string[5]
{
    "Sergio", "Diego", "José", "Adrian", "Jorge",
};

void Show2<T>(T[] data)
{
    for (global::System.Int32 i = 0; i < data.Length; i++)
    {
        Console.WriteLine(data[i]);
    }
}

var numbers2 = new List<int>() { 1,2,3 };
foreach (var n in numbers2)
{
    Console.WriteLine(n);
}


Show2(numbers);
Show2(name);

//A myObjectA = new A();
//B myObjectB = new B();
//C myObjectC = new C();

//Console.WriteLine(myObjectA.GetClassName);
//Console.WriteLine(myObjectB.GetClassName);
//Console.WriteLine(myObjectC.GetClassName);

var beer = new Beer()
{
    HasAlchol = true,
    Name = "Erdinger",
    Price = 20.5m,
    Quantity = 10,
};

void Show(IProduct product)
{
    Console.WriteLine(product.GetInfo());
}
Show(beer);

var myList1 = new MyList<int>(5);
myList1.Add(1);
myList1.Add(5);
myList1.Add(10);
myList1.Add(15);
myList1.Add(25);
var myList2 = new MyList<string>(5);
myList2.Add("México");
myList2.Add("Colombia");
myList2.Add("Venezuela");
myList2.Add("España");
myList2.Add("Brazil");
var myList3 = new MyList<char>(5);
myList3.Add('a');
myList3.Add('b');
myList3.Add('c');
myList3.Add('d');
myList3.Add('f');

myList1.Show();
myList2.Show();
myList3.Show();
interface IProduct
{
    public decimal Price { get; set; }
    public string Name { get; set; }
    public string GetInfo();
}

interface IDrinkable
{
    public decimal Quantity { get; set; }
    public bool HasAlchol{ get; set; }
}

public interface IEnumerable
{
    IEnumerable GetEnumerator();
}

abstract class Liquid
{
    public string LiquidName { get; set; }
    public string LiquidQuantity { get; set; }
    public string ShowInfo() => $"Liquido {LiquidName}";
    public abstract string GetCompleteInfo();
}



class Beer : Liquid, IProduct, IDrinkable
{
    public decimal Price { get; set; }
    public string Name { get; set; }
    public decimal Quantity { get; set; }
    public bool HasAlchol { get; set; }
    public double Alcohol { get; set; }
    public string Style { get; set; }

    public override string GetCompleteInfo() => $"Una cerveza {LiquidName} {Alcohol} de alcohol";
    

    public string GetInfo()
    {
        return $"La información es {Name} ${Price}";
    }
}

abstract class A
{
    public virtual string GetClassName => "Soy A!";
    protected string some = "info";

};
class B: A
{
    public override string GetClassName => "Soy B!";
};
class C : A
{
    public override string GetClassName => "Soy B!";
};

class MyList<T>
{
    private T[] data;
    private int index = 0;

    public MyList(int length) => data = new T[length];

    public void Add(T item)
    {
        data[index++] = item;
    }
    public void Show()
    {
        for (int i = 0; i < data.Length; i++)
        {
            Console.WriteLine(data[i]);
        }
    }
}