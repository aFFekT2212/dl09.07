static int sum(int a)
{
    int sum = 0;

    while (a != 0)
    {
        sum += a % 10;
        a /= 10;
    }

    return sum;
}

int a = Int32.Parse(Console.ReadLine());

Console.WriteLine(sum(a));