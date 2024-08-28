// See https://aka.ms/new-console-template for more information

//Array

//struct List
//{
//    string name;
//    List* list;
//}
string[] beers = new string[5];

beers[0] = "Erdinger";
beers[1] = "Delirium";
beers[2] = "Minerva";
beers[3] = "Corona";
beers[4] = "Paulaner";

for (int i = 0; i < beers.Length; i++)
{
    Console.WriteLine("La cerveza número " + (i + 1) + " es: " + beers[i]);
}

int[] Generate( int length )
{
    int[] numbers = new int[ length ];

    for (int i = 0; i < length; i++)
    {
        numbers[i] = 1 + i;   
    }
    return numbers;
};

int[] numbers = Generate(10);

Console.WriteLine( numbers );

for (int i = 0; i <  numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}