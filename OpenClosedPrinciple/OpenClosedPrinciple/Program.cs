// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using OpenClosedPrinciple;

AreaCalculator cal = new AreaCalculator();
object[] arr = new object[2];
Rectangle rec = new Rectangle() 
{ 
    Height = 2, Width = 3
};
Circle cr = new Circle()
{
    Radius = 2
};
arr[0] = rec;
arr[1] = cr;
double area = cal.TotalArea(arr);
Console.WriteLine(area);

AreaCalculatorNew cal2 = new AreaCalculatorNew();
Shape[] shapes = new Shape[2];
RectangleNew recNew = new RectangleNew() 
{
    Height = 2,
    Width = 3
};
CircleNew cr2 = new CircleNew()
{
    Radius = 2
};
shapes[0] = recNew;
shapes[1] = cr2;
double area2 = cal2.TotalArea(shapes);
Console.WriteLine(area2);

