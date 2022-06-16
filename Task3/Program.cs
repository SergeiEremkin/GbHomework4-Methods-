void ArrFeel(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine("Введите число");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void ArrShow(int[] arr)
{
    for(int i = 0; i < arr.Length; i++ )
    {
        System.Console.Write($"{arr[i]} ");
    }
}
int[] arr = new int[8];
ArrFeel(arr);
ArrShow(arr);