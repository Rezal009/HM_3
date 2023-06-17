
// Задача 21: Напишите программу, которая принимает вход в координаты двух точек и нахождение расстояния между ними в 3D-пространствах.
// А (3,6,8); В (2,1,-7), -> 15,84
// А (7,-5, 0); В (1,-1,9) -> 11,53
        
                
        Console.WriteLine("Нахождение расстояния");
        int x1 = GetCoordinate("x", "A");
        int y1 = GetCoordinate("y", "A");
        int z1 = GetCoordinate("z", "A");
        int x2 = GetCoordinate("x", "B");
        int y2 = GetCoordinate("y", "B");
        int z2 = GetCoordinate("z", "B");

        double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);
        Console.WriteLine($"Расстояние между точками A и B: {distance:F2}");
    

    static int GetCoordinate(string coordinateName, string pointName)
    {
        Console.Write($"Введите координату {coordinateName} точки {pointName}: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static double CalculateDistance(int x1, int y1, int z1, int x2, int y2, int z2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;
        double deltaZ = z2 - z1;

        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        return Math.Round(distance, 2);
    }
