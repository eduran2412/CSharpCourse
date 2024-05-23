// Value Types

double n5 = 10.4; // 64 bit , den sonra 15-16 karakter
decimal n6 = 10.4m; // integer daki long mantığı , den sonra 28-29 karakter  değer sonuna m harfi koymak gerekiyor
char character = 'A';
bool condition = false;
byte n1 = 255; //0-255 - 8 bit
short n2 = 32767; // 16 bit
int n3 = 10; // 32 bit
long n4 = 9223372036854775807; // 64 bit
var n7 = 10;
n7 = 'A';
//n7="A" int değere string değer atanamaz, hata verir.

Console.WriteLine("Number1 is : {0}",n1); //{0} virgülden sonraki ilk değerdir.
Console.WriteLine("Number2 is : {0}", n2);
Console.WriteLine("Number3 is : {0}", n3);
Console.WriteLine("Number4 is : {0}", n4);
Console.WriteLine("Character is : {0}", (int)character);
Console.WriteLine("Character is : {0}", character);
Console.WriteLine("Number5 is : {0}", n5);
Console.WriteLine("Number6 is :{0}", n6);
Console.WriteLine("Number7 is : {0}",n7);
Console.WriteLine(Days.Friday);
Console.WriteLine((int)Days.Friday);


// enum olmadan yani Days.Friday yapmayıp,"Friday" yazmak magic string oluyor, enum içinde 1 kere değiştir, her yerde değişir..
enum Days
{
    //Monday=2, Tuesday=20, .... index değiştirme. Sonrakileri değiştirmezsen en sonun üzerine saymaya devam eder.
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday  
}