using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            Console.WriteLine("Выберите номер операции:");
            Console.WriteLine("Номер 1 - определяет длину окружности по заданному радиусу");
            Console.WriteLine("Номер 2 - определяет площадь круга по заданному радиусу");
            Console.WriteLine("Номер 3 - проверяет принадлежность точки с координатами (x, y) кругу с радиусом r и координатами центра x0, y0");
            t = Convert.ToInt32(Console.ReadLine());
            if (t == 1)
            {
                Circle.Enter(); Circle.Dlin();
            }
            else
            {
                if (t == 2)
                {
                    Circle.Enter(); Circle.Sqr();
                }
                else
                {
                    if (t == 3) { Circle.Enter(); Circle.Point(); }
                    else { Console.WriteLine("Вы вели не допустимое действие!!!"); }
                }
            }
            Console.ReadKey();

        }
    }
}
static class Circle
{
    static double R;
    public static void Enter()
    {
        Console.WriteLine("Введите радиус R = ");
        R = Convert.ToDouble(Console.ReadLine());
    }
    public static void Dlin()
    {
        Console.WriteLine("Длина окружности = " + (2 * (Math.PI) * R));
    }
    public static void Sqr()
    {
        Console.WriteLine("Длина окружности = " + ((Math.PI) * R * R));
    }
    public static void Point()
    {
        Console.WriteLine("Введите x");
        double mx = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите y");
        double my = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите x(0)");
        double ox = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите y(Y)");
        double oy = int.Parse(Console.ReadLine());
        double d = Math.Sqrt(Math.Pow(ox - mx, 2) + Math.Pow(oy - my, 2));
        if (d <= R)
            Console.WriteLine("Точка с координатами x,y пренадлежит кругу.");
        else
            Console.WriteLine("Точка с координатами x,y не принадлежит кругу.");
    }
}