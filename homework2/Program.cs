/* 
Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 
*/

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

double rast = Math.Round(R(x1,y1,z1,x2,y2,z2), 2);
System.Console.WriteLine($"-> {rast}");

int Coordinate(string coor, string tochka)
{
    System.Console.Write($"Введите координату{coor} точки {tochka}: ");
    int vvod = Convert.ToInt32(Console.ReadLine());
    return vvod;
}

double R (double arg1, double arg2,
         double arg3, double arg4,
         double arg5, double arg6)
{
double answer =  Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
return answer;
}
