Console.WriteLine("Введите координаты первой точки");
Console.WriteLine(" ");
Console.WriteLine("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.WriteLine(" ");
Console.WriteLine("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double res = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
Console.WriteLine(res);
//формула (double res) из интернета, 
//которая была на семинаре(double res = Math.Sqrt(((x2| - x1) ^ 2 + (y2 - y1) ^ 2 + (z2 - z1) ^ 2)); не сработала! 