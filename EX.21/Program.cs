// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] A = new int[3];
int[] B = new int[3];

A[0] = ReadInt("Введите координату X точки A: ");
A[1] = ReadInt("Введите координату Y точки A: ");
A[2] = ReadInt("Введите координату Z точки A: ");

B[0] = ReadInt("Введите координату X точки B: ");
B[1] = ReadInt("Введите координату Y точки B: ");
B[2] = ReadInt("Введите координату Z точки B: ");

double res = Math.Round(Math.Sqrt(Math.Pow(A[0]-B[0],2) + Math.Pow(A[1]-B[1],2) + Math.Pow(A[2]-B[2],2)),2);
System.Console.WriteLine("Расстояние между точками = " + res);

