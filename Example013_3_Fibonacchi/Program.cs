// f(1) = 1
// f(2) = 1
// f(n) = f(n-1)+f(n-2)

double Fibonacchi(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacchi(n - 1) + Fibonacchi(n - 2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"(f{i}) = {Fibonacchi(i)}");
}