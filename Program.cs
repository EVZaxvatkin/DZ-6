// See https://aka.ms/new-console-template for more information

//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Zadacha41()
{

Console.WriteLine("Введено М чисел: ");

int size = 8;
int[] array = new int[size];
Fillarray(array, -10, 11);
Printarray(array);

Console.WriteLine();

Plusnumber(array);



void Plusnumber(int[] array)
{
int count = 0;
for (int i =0; i < array.Length; i++)
{
    if (array[i] > 0) count++; 
}
Console.WriteLine("Массив содержит " + count + " числа больше 0");
}



void Fillarray(int[] array, int startNumber, int finishNumber)
{
    Random random = new Random();

    for (int i =0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void Printarray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    Console.Write(array[i] + "\t");
} 

}
//Zadacha41();


// Задача 43. Напишите программу, которая найдёт точку 
//пересечения двух прямых, заданных уравнениями y = k1 * 
//x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
//пользователем.

void Zadacha43()
{

Console.WriteLine("Найти точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 "); 


Console.WriteLine("Введите показатель - b1");
string s1 = Console.ReadLine();
double b1 = Convert.ToDouble(s1);

Console.WriteLine("Введите показатель - k1");
string s2 = Console.ReadLine();
double k1 = Convert.ToDouble(s2);

Console.WriteLine("Введите показатель - b2");
string s3 = Console.ReadLine();
double b2 = Convert.ToDouble(s3);

Console.WriteLine("Введите показатель - k2");
string s4 = Console.ReadLine();
double k2 = Convert.ToDouble(s4);

Equation();


void Equation()
{
    double x = (b1 - b2) / (k2 - k1);

    Console.WriteLine("Точка пересечения двух прямых имеет координаты: " + x + ";" + (k1*x + b1));
}
}
Zadacha43();
