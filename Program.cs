// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void Palindrom(string number)
{
    if(number[0] == number[4] && number[1] == number[3]) 
    {
        Console.Write("УРА - данное число палиндром");
    }
    else
    {
        Console.Write("Данное число не палиндром");
    }
}

Console.WriteLine("Hello, what you name ?");
string name = Console.ReadLine();
Console.Clear();

Console.WriteLine(name + " напиши пятизначное число");
string numbers = Console.ReadLine();
int checknumbers = numbers.Length; // проверяет по длине текста
// int checknumbers = Convert.ToInt32(numbers); // второй вариант проверки 5 числа. перевод его в числовое
// if(checknumbers < 9999 || checknumbers > 99999) 

if(checknumbers < 5 || checknumbers > 5)
   {
   Console.WriteLine("Число не пятизначное");
   return;
   }

Palindrom(numbers);


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*double Rastoynie(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    result = Math.Round(result, 2);
    return result;
    
}
Console.Write("напишите координаты X первой точки ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("напишите координаты Y первой точки ");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("напишите координаты Z первой точки ");
double Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("напишите координаты X второй точки ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("напишите координаты Y второй точки ");
double Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("напишите координаты Z второй точки ");
double Z2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.Write("расстояние между двумя точками в 3D пространстве" + " = " + Rastoynie(X1, Y1, Z1, X2, Y2, Z2));
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*Console.WriteLine("Hello, what you name ?");
string name = Console.ReadLine();
Console.Clear();

Console.WriteLine(name + " напиши любое целое число");
int N = Convert.ToInt32(Console.ReadLine());

void CubNumber(int N)
{
    for(int i = 1; i <= N; i++)
    {
    Console.Write(Math.Pow(i, 3) + " ");
    }
}    
CubNumber(N);*/

