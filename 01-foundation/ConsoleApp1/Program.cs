// See https://aka.ms/new-console-template for more information
// Variable: Contenedor de información que almacena valores en memoria

//int number = 88;
//Console.WriteLine(number);
string text  = "Hola, soy Sergio Arce c:";
int age      = 21;
char initial = 'S';


Console.WriteLine(text);
Console.WriteLine(age);
Console.WriteLine(initial);
void Hi( string name, string lastName )
{
    Console.WriteLine( "¡Hola, " + name + " " + lastName +"!");
};

int Add(int num1, int num2) { return num1 + num2; }

Hi("Sergio", "Arce");
Console.WriteLine(Add(5, 43));
