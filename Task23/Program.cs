﻿// Задача 23 Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
 
Console.Write("Введите число: "); 
int N = int.Parse(Console.ReadLine()!); 
int[] GetSqrtTable(int N) 
{   
    int[] SqrtArray = new int[N]; 
    for (int i = 0; i < N; i++) 
    {  
        SqrtArray[i] = (i + 1) * (i + 1) * (i + 1);    
    }      
    return SqrtArray; 
}  
void PrintTable(int[] Array) 
{
    int number = 1;     
    for (int i = 0; i < Array.Length; i++)
    { 
     Console.WriteLine(Array[i]); 
     number++; 
    }
}  
int[] SqrtTable = GetSqrtTable(N);
PrintTable(SqrtTable);
