using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string nombre = PedirNombre(); //como devuelve un string podemos usarla como una variable
        int numero = PedirNumero(); // como es un int entonces podemos usarla como una variable
        int numero_al_cuadrado = ToSquere(numero);
        DisplayResult(nombre, numero_al_cuadrado);
        
    }

    
    //DisplayWelcome - Displays the message, Welcome to the Program!
    static void WelcomeMessage() // no se declara ningún tipo (int, string) porque solo vamos a imprimir un mensaje, OJO solo aca
    { 
    Console.WriteLine("Welcome to the program!");
    }

    //"PromptUserName - Asks for and returns the user's name (as a string)"
    static string PedirNombre() // Se usa string porque vamos a devolver una variable
    {
        Console.WriteLine("Please enter your name: ");
        string entered_name = Console.ReadLine();

        return entered_name;

    }

    //Asks for and returns the user's favorite number (as an integer)"
    static int PedirNumero() // de nuevo se usa int porque estamos devolviendo una variable

    {
        Console.WriteLine("Please enter your favorite number:");
        string answer1 = Console.ReadLine();
        int entered_number = int.Parse(answer1);
        return entered_number;
    }

    //Accepts an integer as a parameter and returns that number squared (as an integer)"
    static int ToSquere(int number) // de nuevo, como vamos a devolver una variable, necesitamos declarar el tipo
    {
        int squere_number = number * number;
        return squere_number;
    }


    //Accepts the user's name and the squared number and displays them."
    static void DisplayResult(string name, int squered_number)
    {
        Console.WriteLine($"{name}, the squere of your number is {squered_number}");
    }

}
