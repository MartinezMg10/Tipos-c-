// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!"); */

//Ejercicio 1

Console.WriteLine("Por favor, introduce el nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Por favor, introduce el Apellido:");
string apellido = Console.ReadLine();
Console.WriteLine("Por favor, introduce la edad:");
string edad = Console.ReadLine();
Console.WriteLine("Sabes programar?");
string programar = Console.ReadLine();

string mensaje = $" Nombre: {nombre}\n Apellido: {apellido}\n Edad: {edad}\n Sabes programar: {programar} ";
Console.WriteLine(mensaje);

//Ejercicio 2

//Coche
int puertas = 4;
int ruedas = 4;
string marca = "Volswagen";
bool ItvVigente = true;

//Mesa

float peso = 45.5f;
float largo = 1.80f;
string material = "Madera";
string color = "Cafe";


//Ejercicio 3

//Un número es mayor o igual a 18:  el operador de comparación utilizado es el mayor o igual que (>=).
Console.WriteLine(19 >= 18);


//Un char es ‘a’:   el operador de comparación utilizado es el mayor o igual que (==).
char a = 'a';
Console.WriteLine(a == 'a');


//Se cumplen dos conciones a la vez (ambas verdaderas):   el operador de comparación utilizado es el mayor o igual que (&&).
Console.WriteLine(true && true);


//Se cumple una de dos condiciones a la vez (una true y otra false):  el operador de comparación utilizado es el mayor o igual que (||).
Console.WriteLine(true || false);







