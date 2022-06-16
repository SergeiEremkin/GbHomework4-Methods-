void Degree(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;

    }
    System.Console.WriteLine(result);
}
Degree(2, 3);
Degree(4, 6);
Degree(3, 3);