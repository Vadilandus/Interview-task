namespace Interview_task
{
    // Класс Circle, в конструкторе реализация Поля radius
    // и метод CalculateArea, вычисляющий площадь
    public class Circle : ICalculateArea
    {
        private readonly double radius;
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new Exception("Радиус не может быть отрицателен");
            }
            else
            {
                this.radius = radius;
            }
            
        }
        /// <summary>
        /// Метод, выполняющий вычисление по нахождению площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    // Класс Rectangle, Поля с длиной сторон треугольника
    // Имеет метод, вычилсющий площадь,
    // Имеет метод, проверяющий треугольник на то, является ли он прямоугольным.
    public class Rectangle : ICalculateArea
    {
        // поля - стороны треугольника.
        private readonly double side1, side2, side3;
        public Rectangle(double side1, double side2, double side3)
        {
            // Проверяем на существование такого треугольника
            if (side1 + side2 > side3 && side1 + side3 > side2 && side3 + side2 > side1)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
            else
            {
                throw new Exception("Такого треугольника быть не может.");
            }
            
        }
        /// <summary>
        /// Метод, выполняющий вычисление по нахождению площади треугольника
        /// </summary>
        /// <param>perimetr - периметр треугольника</param>
        /// <returns>Площадь треугольника</returns>
        public double CalculateArea()
        {
            double perimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
        }

        ///<summary>
        /// Метод, проверяющий треугольник на прямоугольность.
        ///</summary>
        ///<param>Массив, который хранит стороны треугольника</param>
        ///<returns>Возвращает True, если прямоугольный, False, если нет</returns>
        public bool IsTriangleRectangular()
        {
            double[] Triangle = new double[3] {side1,side2,side3};
            Triangle = Triangle.OrderByDescending(x => x).ToArray();
            return Triangle[0] * Triangle[0] == Triangle[1] * Triangle[1] + Triangle[2] * Triangle[2];
        }
    }



}
