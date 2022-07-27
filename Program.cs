// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.WriteLine("введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// int x = a;

// for (int i = 1; i < b; i++)
// {
// x = x * a;
// }
// Console.WriteLine(a + " в степени " + b + " равно: " + x);

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.WriteLine("введите число");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// // while (i > 0)
// // {
// // int num = i % 10;
// // i = i / 10;
// // sum = sum + num;
// // }
// // Console.WriteLine("сумма всех цифр в числе равна: " + sum);


// //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int GenerateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int [N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end+1);
//     }
//     return RandomArray;
// }
// void ShowArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i ++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine(" ");

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] numbers = new int[10];

// void FillArray(int[] array, int min, int max){
//   for (int i = 0; i<array.Length; i++ ){
//     array[i] = new Random().Next(min, max);
//   }
// }

// void WriteArray(int[] array){
//     for (int i = 0; i<array.Length; i++ ){
//     Console.Write(array[i] + " ");
//   }
//   Console.WriteLine();
// }

// int QuantityPositive(int[] array){
//     int quantity = 0;
//     for (int i = 0; i<array.Length; i++ ){
//     if (array[i] % 2 == 1)
//     {
//       quantity++;
//     }
//   }
//   return quantity;
// }

// FillArray(numbers, 100, 999);
// WriteArray(numbers);
// Console.WriteLine();

// int quantity = QuantityPositive(numbers);
// Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");



//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Console.Write($"Введите количество элементов массива: ");
// int numberElements = Convert.ToInt32(Console.ReadLine()); 

// int RandomNumbers(int numberElements, int min, int max)
//   {
//   int[] randomNumbers = new int[numberElements];
//   int sumElements = 0;
//   Console.Write("ваш массив : ");

//     for (int i = 0; i <randomNumbers.Length; i++ ){
//       randomNumbers[i] = new Random().Next(min, max);

//       Console.Write(randomNumbers[i] + " ");

//       if (i % 2 != 1)
//       {
//         sumElements = sumElements + randomNumbers[i];
//       }
//     }
//   return sumElements;
//   }

// int randomNumbers =  RandomNumbers(numberElements, 50, 99);

// Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// int[] arrayNumbers = new int [15];
//   for (int i = 0; i < arrayNumbers.Length; i++ )
//   {
//     arrayNumbers[i] = new Random().Next(1, 15);
//     Console.Write(arrayNumbers[i] + " ");
//   }

// int maxNumber = arrayNumbers[0];
// int minNumber = arrayNumbers[0];

//   for (int i = 1; i < arrayNumbers.Length; i++)
//   {
//     if (maxNumber < arrayNumbers[i])
//     {
//       maxNumber = arrayNumbers[i];
//     }
//         if (minNumber > arrayNumbers[i])
//     {
//       minNumber = arrayNumbers[i];
//     }
//   }

//   int nambers = maxNumber - minNumber;

//   Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {nambers}");





//Задача Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

// int[] CreateRandomArray(int size, int min, int max)
// {
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
// array[i] = new Random().Next(min, max + 1);
// }
// return array;
// }

// void ShowArray(int[] array)
// {

// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_pos = 0;
// int sum_neg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
// if (myArray[i] > 0)
// sum_pos += myArray[i];
// else
// sum_neg += myArray[i];
// }

// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");

//Задача 39. напишите программу,которая перевернет одномерный массив(последний элемент будет на 1ом месте, и наоборот)

// int[] GetArray(int size, int minValue, int maxValue)
// {
// int[] res = new int[size];

// for (int i = 0; i < size; i++)
// {
// res[i] = new Random().Next(minValue, maxValue + 1);
// }
// return res;
// }

// void ReversArray1(int[] inArray)
// {
// for (int i = 0; i < inArray.Length / 2; i++)
// {
// int k = inArray[i];
// inArray[i] = inArray[inArray.Length - i - 1];
// inArray[inArray.Length - i - 1] = k;
// }
// }

// int[] ReversArray2(int[] inArray)
// {
// int[] result = new int[inArray.Length];
// for (int i = 0; i < inArray.Length; i++)
// {
// result[i] = inArray[inArray.Length - 1 - i];
// }
// return result;
// }



//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Console.WriteLine("Введите первое число");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int C = Convert.ToInt32(Console.ReadLine());

// if (A <= (B+C) && B <= (C+A) && C <= (A+B))
// {
//   Console.WriteLine("Такой треугольник может существовать");
// }
// else{
//     Console.WriteLine("Такой треугольник не может существовать");
// }


//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.


//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
 
// Console.Write($"Введите число М(количество чисел): ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] Numbers1 = new int[m];   

// void InputNumbers(int m){
// for (int i = 0; i < m; i++)
//   {
//     Console.Write($"Введите {i+1} число: ");    //выводит попорядку числа с клавиатуры 
//     Numbers1[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }
// int quantity(int[] Numbers1)
// {
//   int count = 0;
//   for (int i = 0; i < Numbers1.Length; i++)
//   {
//     if(Numbers1[i] > 0 ) count += 1; 
//   }
//   return count;
// }

// InputNumbers(m);

// Console.WriteLine($"Введено чисел больше 0: {quantity(Numbers1)} ");


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.WriteLine("Введите зечание b1");   // запрашиваем у пользователя 
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// if (k1 == k2 && b1 == b2){
//     Console.WriteLine("Прямые совподают - точек пересечения бесконечное множество");
// }
// else {
//     Console.WriteLine("Координаты точки пересечения прямых при заданных значениях: ");
//     double x = (b1 -b2)/(k2 - k1);
//     double y = k1 *  x +b1;
//     Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ({x}; {y})");
// }



//Задача 46. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
// int[,] result = new int[m, n];
// for (int i = 0; i < m; i++)
// {
// for (int j = 0; j < n; j++)
// {
// result[i, j] = new Random().Next(minValue, maxValue + 1);
// }
// }
// return result;
// }

// void PrintArray(int[,] inArray)
// {
// for (int row = 0; row < inArray.GetLength(0); row++)
// {
// for (int column = 0; column < inArray.GetLength(1); column++)
// {
// Console.Write($"{inArray[row,column]} ");
// }
// Console.WriteLine();
// }
// }

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);


//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// Console.Clear();

// int[,] GetArray(int m, int n)
// {
// int[,] result = new int[m, n];
// for (int i = 0; i < m; i++)
// {
// for (int j = 0; j < n; j++)
// {
// result[i, j] = i+j;
// }
// }
// return result;
// }

// void PrintArray(int[,] inArray)
// {
// for (int row = 0; row < inArray.GetLength(0); row++)
// {
// for (int column = 0; column < inArray.GetLength(1); column++)
// {
// Console.Write($"{inArray[row,column]} ");
// }
// Console.WriteLine();
// }
// }

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns);
// PrintArray(array);


//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// int[,] GetArray(int m, int n, int minValue, int maxValue) // создает двумерный массив
// {
// int[,] result = new int[m, n];
// for (int i = 0; i < m; i++)
// {
// for (int j = 0; j < n; j++)
// {
// result[i, j] = new Random().Next(minValue, maxValue + 1);
// }
// }
// return result;

// }
// int GetSum (int [,] array)
// { int sum=0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// if(i==j) sum=sum+array[i,j];
// }
// }
// return sum;
// }
// void PrintArray(int[,] inArray) // вывводит двумерный массив
// {
// for (int row = 0; row < inArray.GetLength(0); row++)
// {
// for (int column = 0; column < inArray.GetLength(1); column++)
// {
// Console.Write($"{inArray[row,column]} ");
// }
// Console.WriteLine();
// }
// }

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");



//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
// int[,] result = new int[m, n];
// for (int i = 0; i < m; i++)
// {
// for (int j = 0; j < n; j++)
// {
// result[i, j] = new Random().NextDouble()*(maxValue-minValue)+minValue;
// }
// }
// return result;
// }

// void PrintArray(double[,] inArray)
// {
// for (double row = 0; row < inArray.GetLength(0); row++)
// {
// for (double column = 0; column < inArray.GetLength(1); column++)
// {
// Console.Write($"{inArray[row, column]} ");
// }
// Console.WriteLine();
// }
// }

// Console.Write("Введите количество строк массива: ");
// double rows=Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// double columns=Convert.ToDouble(Console.ReadLine());

// double[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine("введите количество строк");
// int linesVol  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columnsVol = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[linesVol, columnsVol];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// void FillArrayRandomNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.WriteLine("введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [10,10];
// FillArrayRandomNumbers(numbers);

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
// }

// PrintArray(numbers);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(10, 100);
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }   
//         Console.Write("]");
//         Console.WriteLine(""); 
//     }
// }




//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника




