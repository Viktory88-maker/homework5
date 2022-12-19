//Задача 36: создайте одномерный массив,
// заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.
int [] CreateArray()
{
    Console.Write("Введите количество элентов массив: ");
    int num = int.Parse(Console.ReadLine()!);
    Console.Write("Массив  {");
    int[] array = new int [num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(100,1000);
        Console.Write($"{array[i]}");
    }
    Console.WriteLine("}\n");
    return array;
}

void FindSum(int[] myArray)
{
    int sum = 0;
    for(int i = 0; i < 4; i++)
    {
        if(i % 2 !=0) sum += myArray[i];
    }
    Console.WriteLine($"Сумма элементов,стоящий на нечетных позициях = {sum}");
}
FindSum(CreateArray());


