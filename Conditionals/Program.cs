// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var n = 10;
if (n == 10)
{
    Console.WriteLine("n is 10");
}
else
{
    Console.WriteLine("n is not 10");
}

//ReSharper eklentisi ile
// Bir başka yol Single Line If
Console.WriteLine(n == 10 ? "n is 10" : "n is not 10");

if (n == 10)
{
    Console.WriteLine("n is 10");
}
else if (n == 20)
{
    Console.WriteLine("n is 20");
}
else
{
    Console.WriteLine("n is a different number");

}
// switch

var n2 = 11;

switch (n2)
{
    case 10:
        Console.WriteLine("number is 10");
        break;
    case 20:
        Console.WriteLine();
        break;
    default:
        Console.WriteLine("default value");
        break;
}

//Çoklu Şartlar

var n4 = 20;

if (n4 >= 0 && n4 <= 100)
{
    Console.WriteLine("Number is between 0-100");
}
else if ((n4 <= 200 && (n4 > 100)))
{
    Console.WriteLine("Number is between 101-200");
}
else if (n4 > 200 || n4 < 0)
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}

