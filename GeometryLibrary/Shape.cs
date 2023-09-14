using System;

namespace GeometryLibrary
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        // Метод для вычисления площади круга по радиусу
        public double CalculateArea()
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус круга должен быть положительным числом.");
            }

            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Triangle : IShape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        // Метод для вычисления площади треугольника по трём сторонам
        public double CalculateArea()
        {
            if (!IsTriangleValid(sideA, sideB, sideC))
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует.");
            }

            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }
        //Метод для проверки на то, является ли треугольник прямоугольным
        public bool IsRightTriangle()
        {
            // Сортируем стороны по возрастани
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);
            // Проверяем теорему Пифагора
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
        // Метод для проверки правильности треугольника по трём сторонам
        private bool IsTriangleValid(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }
    }
}
