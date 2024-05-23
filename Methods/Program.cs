
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