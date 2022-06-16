void Summ(int Number)
{
    int result = Number % 10;
    while (Number != 0)
    {
        Number = Number / 10;
        result = result + (Number % 10);
    }
    Console.WriteLine(result);
}
Summ(234);
Summ(23);
Summ(2);
Summ(10101010);
