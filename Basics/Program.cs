int A, B;
Console.Write("Enter a number A: ");
A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number B: ");
B = Convert.ToInt32(Console.ReadLine());

if (A > B)
{
    Console.WriteLine("Error\nA can't be bigger than B");
}

for (int i = 0; i <= B; i++)
{
    if (A >= B)
    {
        break;
    }
    for (int j = 0; j < A; j++)
    {
        Console.Write(A);
        Console.Write(" ");
    }

    Console.WriteLine();
    A++;
}