
Add();

var result = Add2(20, 12);
Console.WriteLine(result);

var ress = Add3(20, 20);
Console.WriteLine(ress);
static void Add()
{
    Console.WriteLine("Added!");
}



static int Add2(int n1, int n2)
{

    return n1 + n2;
}

static int Add3(int n11, int n12 = 30) // default değerler metodun en sonunda olur. 2 tane de olurdu, ama en sonlarda veya hepsinde.
{                                       // KDV hesaplamada kullanılabilir.
    var res = n11 + n12;
    return res;
}

//-- Ref Keyword --
int number1 = 20;
int number2 = 100;

var result2 = Add4(number1, number2);
Console.WriteLine(result2);
Console.WriteLine(number1);

static int Add4(int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}

int number3 = 20;//bu değerin metot içerisinde değişebileceği düşünülüyorsa ref olarak gönderilir.mesela kredi oranı sabit, bir müşteriye özel indirim olabilir.
int number4 = 100;

var result3 = Add5(ref number3, number4);
Console.WriteLine(result3);
Console.WriteLine(number3);

static int Add5(ref int number3, int number4)
{
    number3 = 30;
    return number3 + number4;
}
//--

//-- Out Keyword --

//mantık olarak ref ile aynı değer tipi referans tip gibi göndermek

int number5;// ref içerisinde number set edilmiş olmalı, burada ona gerek yok int number; yeterlidir..
int number6 = 100;
var result4 = Add6(out number5, number6);

static int Add6(out int number5, int number6)
{
    number5 = 30; // out kullanmadan önce metot içerisinde set edilmesi lazım!
    return number5 + number6;
}