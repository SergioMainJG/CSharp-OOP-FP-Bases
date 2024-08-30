int[] numbers =
[
    1,2,3, 4,5,6,7,8,9,10
];

// Programación imperativa

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0) Console.WriteLine("Como es par");
}

// Programación declarativa

numbers.Where(x => x % 2 ==0 ).ToList().ForEach(x => Console.WriteLine("Que es par"));

void Hi()
{
    Console.WriteLine("Hola Mundo");
}

var hello = Hi;

hello();

string Message() => "Un mensaje externo";

void DoSomething( Func<string> fn )
{
    Console.WriteLine("Algo que pasa antes");
    Console.WriteLine(fn());
    Console.WriteLine("Algo que pasa después");
}

DoSomething(Message);

// Función impura

DateTime AddSeconds(int seconds) => DateTime.Now.AddSeconds(seconds);
Console.WriteLine(AddSeconds(1).TimeOfDay);
Console.WriteLine(AddSeconds(1).TimeOfDay);

// Función pura
var now =  DateTime.Now;
DateTime DateAddSeconds( DateTime date, int seconds) => date.AddSeconds(seconds);
Console.WriteLine(DateAddSeconds(now, 1).TimeOfDay);
Console.WriteLine(DateAddSeconds(now, 1).TimeOfDay);

var beer = new Beer(){Name = "Colimita"};

// Función impura por realizar operaciones por referencia
Beer ToUpperName ( Beer beer) 
{
    beer.Name = beer.Name.ToUpper();
    return beer;
}

Beer BeerToUpperName(Beer beer)
{

    var newBeer = new Beer()
    {
        Name = beer.Name.ToUpper()
    };
    return newBeer;
}

Console.WriteLine( ToUpperName(beer).Name );
Console.WriteLine( beer.Name );

var beer2 = new Beer() { Name = "Heineken" };

Console.WriteLine( BeerToUpperName(beer2).Name );
Console.WriteLine( beer2.Name );

var some = () => Console.WriteLine("Hola Mundo!");
some();
var add = (int a, int b) => a + b;
int res = add(1, 2);
Console.WriteLine(res);

var mul = (int a, int b) => a * b;

Func<string> message = () => "Es un mensaje";
Func< int ,string> hi = ( int number ) => $"El número es: { number }";
var hi2= ( int number ) => $"El número es: { number }";

var messages = (Func<string> fn) =>
{
    Console.WriteLine("Algo que pasa antes");
    Console.WriteLine(fn());
    Console.WriteLine("Algo que pasa después");
};

messages(() => "Mensaje central");

//Action<string> print = ( string msg ) => Console.WriteLine(msg); 
//print("Un mensaje");

Predicate<int> isPair = (int number) => number % 2 == 0;
if (isPair(12)) Console.WriteLine("Es par");

void printNumbers(int[] numbers, int index = 0)
{
    if( index >= numbers.Length )
    {
        return;
    }

    Console.WriteLine($"{numbers.Length} numbers {numbers[index]}");
    printNumbers(numbers, index+1);
}

printNumbers( numbers, 0 );

Action<string> print()
{
    int counter = 0;
    return (string message) =>
    {
        counter++;
        Console.WriteLine($"Ejecución {counter} {message}");
    };
}

var show1 = print();
var show2 = print();
show1("Un mensaje");
show1("Otro mensaje");
show2("Un mensaje con show2");

//Func<float, Func<float, float>> Mul()
//{
//    return (float a) =>
//    {
//        return (float b) => a * b;
//    };
//}

Func<float, Func<float, float>> mul2 = a => b => a * b;

//var m = mul();

//var mx10 = mul(10f);
float res1 = mul2(10f)(9f);

Console.WriteLine(res1);

//Func<string, Func<string, string>> Word()
//{
//    return (string word) =>
//    {
//        return (string word2) => string.Concat(word, word2);
//    };
//}
//var concat          = Word();

Func< string, Func<string, string>> Word = greeting => name => string.Concat(greeting, name);

var greetingBase    = Word("Hola, ");
var greetingSergio  = greetingBase("Sergio!");
var greetingRafa    = greetingBase("Rafa!");
var greetingAdrian  = greetingBase("Adrian!");
var greetingNapoles = greetingBase("Napoles!");

Console.WriteLine($"{greetingSergio}");
Console.WriteLine($"{greetingRafa}");
Console.WriteLine($"{greetingAdrian}");
Console.WriteLine($"{greetingNapoles}");

class Beer
{
    public string Name { get; set; }
}