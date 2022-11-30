// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write ("Введите координату X1 = ");
string str1 = Console.ReadLine();
Console.Write ("Введите координату Y1 = ");
string str2 = Console.ReadLine();
Console.Write ("Введите координату Z1 = ");
string str3 = Console.ReadLine();
Console.Write ("Введите координату X2 = ");
string str4 = Console.ReadLine();
Console.Write ("Введите координату Y2 = ");
string str5 = Console.ReadLine();
Console.Write ("Введите координату Z2 = ");
string str6 = Console.ReadLine();
int X1 = int.Parse(str1);
int Y1 = int.Parse(str2);
int Z1 = int.Parse(str3);
int X2 = int.Parse(str4);
int Y2 = int.Parse(str5);
int Z2 = int.Parse(str6);
int X = X2-X1;
int Y = Y2-Y1;
int Z = Z2-Z1;
double result = Math.Sqrt(Math.Pow(X, 2)+Math.Pow(Y, 2)+Math.Pow(Z, 2));
Console.WriteLine();
Console.Write ("Расстояние между ними в 3D пространстве = "   + result);