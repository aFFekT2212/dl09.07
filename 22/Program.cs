static int Sum(string a)
{
    int sum = 0;

    for (int i = 0; i < a.Length; i++)
    {
        int x = Int32.Parse(a[i].ToString());
        sum += x;
    }

    return sum;
}


    string a = Console.ReadLine();


Console.WriteLine(Sum (a));
