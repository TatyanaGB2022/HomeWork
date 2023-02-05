﻿// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InputInt(string message)
{
  System.Console.WriteLine($"{message}");
  return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int len)
{
  int[] array = new int[len];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(99, 999);
  }
  return array;
}

void PrintArray(int[] array)
{
  foreach (int item in array)
  {
    System.Console.Write($"{item}\t");
  }
  System.Console.WriteLine();
}

int EvenNumber(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
      count++;
  }
  return count;
}

int len = InputInt("Введите длину массива ");
int[] array = GenerateArray(len);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве: {EvenNumber(array)}");
