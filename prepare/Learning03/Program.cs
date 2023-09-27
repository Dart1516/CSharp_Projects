using System;

class Program
{
    static void Main(string[] args)
    {
Console.WriteLine("");
Console.WriteLine("EXERCISE 1");
Console.WriteLine("");
//In your Program.cs file, verify that you can create fractions using all three of these constructors. For example, create an instance for 1/1 (using the first constructor), for 6/1 (using the second constructor), for 6/7 (using the third constructor).

Fraction f1 = new Fraction();
Fraction f2 = new Fraction(1);
Fraction f3 = new Fraction(1,2);


//In your Program.cs file, verify that you can call all of these methods and get the correct values, using setters to change the values and then getters to retrieve these new values and then display them to the console.
f1.setTop(10);
f1.GetTop();

Console.WriteLine(f1.GetTop());


Console.WriteLine("verifying first");
//Verify that you can call each constructor and that you can retrieve and display the different representations for a few different fractions. For example, you could try:
// 
//1
//5
//3/4
//1/3
Console.WriteLine("");
Console.WriteLine("the answer to my exercise");

Fraction f4 = new Fraction();
Fraction f5 = new Fraction(5);
Fraction f6 = new Fraction(3,4);
Fraction f7 = new Fraction(1,3);
Console.WriteLine(f4.getFractionString());
Console.WriteLine(f5.getFractionString());
Console.WriteLine(f6.getDecimalValue());// here I change wrongly to double
Console.WriteLine(f7.getDecimalValue()); // I used the incorrect method.
Fraction f8 = new Fraction(3,4);
Fraction f9 = new Fraction(1,3);
Console.WriteLine(f8.getDecimalValueButGood());// Lo tuve que hacer de nuevo 
Console.WriteLine(f9.getDecimalValueButGood()); //  pero esta vez si funcionó. 

Console.WriteLine("");
    }
}