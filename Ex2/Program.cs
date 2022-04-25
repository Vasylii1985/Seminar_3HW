// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите кор X точки A ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кор Y точки A ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кор Z точки A ");
double az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кор X точки B ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кор Y точки B ");
double by = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кор Z точки B ");
double bz = Convert.ToDouble(Console.ReadLine());


double firstAction = Math.Pow(bx-ax, 2)+Math.Pow(by-ay, 2)+Math.Pow(bz-az, 2);
double secondAction = Math.Sqrt(firstAction);

Console.WriteLine($"Расстояние между точками равно {secondAction}");