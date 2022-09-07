// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Write("Введи количество чисел: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];

void FillArray (int num)
{
for (int i = 0; i < num; i++)
  {
    Console.Write($"Еще: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Result(int[] array1)
{
  int count = 0;
  for (int i = 0; i < array1.Length; i++)
  {
    if(array1[i] > 0 ) count ++; 
  }
  return count;
}

FillArray(x);
Console.WriteLine($"Введено чисел больше 0: {Result(array)} ");