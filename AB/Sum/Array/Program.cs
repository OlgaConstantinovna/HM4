// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] FillArrayNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(-999,999);
    }
return array;
}
void WriteArrayPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i]+ " "); 
    }
}

int [] number = FillArrayNumber(new int[8]);
WriteArrayPrint(number);