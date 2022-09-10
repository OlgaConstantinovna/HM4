// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write ("Введите первое число A: ");
int A =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число B: ");
int B =Convert.ToInt32(Console.ReadLine());
   int result = A;
  for(int i=1; i < B; i++)
  {
    result = result * A;
  }
     Console.WriteLine("A в степени В = " + result);
