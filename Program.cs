using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static double Sine(out double angle)
    {
        Console.WriteLine("Введите угол в градусах:");
        angle = Convert.ToDouble(Console.ReadLine());
        return Math.Sin(DegreeToRadian(angle));
    }
}