static int Stepen(int a, int b)

{ int result = 1;
    for (int i = 0; i < b; i++)
        result = result * a;
    return result;
}
int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
int result = 1;



Console.WriteLine(Stepen(a,b));