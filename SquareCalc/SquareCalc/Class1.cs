namespace SquareCalc;

//Абстрактный класс, описывающий геометрическую фигуру, какие методы и свойства она должна содержать
public abstract class Figure
{
    //Свойство, позволяющее задать (только через конструктор) и получить название фигуры
    public string Name { get; private set; }

    public Figure(string Name)
    {
        this.Name = Name;
    }
    //Сигнатура метода, вычисляющего площадь данной фигуры
    public abstract double Square();
}

//Класс, описывающий круг
public class Circle : Figure
{
    //Радиус круга
    public double r { get; private set; }

    public Circle(string Name, double r) : base(Name)
    {
       if (r<=0)
        throw new ArgumentException("Circle radius value cannot be less than or equal to 0");
       else
        this.r = r;
    }
    //Метод, вычисляющий площадь круга по радиусу
    public override double Square()
    {
        return Math.PI * Math.Pow(r, 2);
    }
}
//Класс, описывающий треугольник
public class Triangle : Figure
{
    //Стороны треугольника
    public double a { get; private set; }
    public double b { get; private set; }
    public double c { get; private set; }

    public Triangle(string Name, double a, double b, double c) : base(Name)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Side length value cannot be less than or equal to 0");
        else if (a > (b + c) || b > (a + c) || c > (a + b))
            throw new ArgumentException("Each side of the triangle must be less than the sum of the other two sides");
        else
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
    //Метод, вычисляющий площадь треугольника по трем сторонам a,b,c (формула Герона)
    public override double Square()
    {
        double p = (a + b + c) / 2; //Полупериметр
        return Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
    }
    //Метод, определяющий, является ли треугольник прямоугольным по теореме Пифагора
    public bool IsRightTriangle()
    {
        bool answer = (a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2))
                     || b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))
                     || c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
        return answer;
    }
}




