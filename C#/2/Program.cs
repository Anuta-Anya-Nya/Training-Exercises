// Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
int circleR = 6;
int square = 10;
double circleS = 3.141 * circleR * circleR;
double squareS = square * square;

if (circleS > squareS)
{
    Console.WriteLine("Площадь круга больше");
}
else if (circleS < squareS)
{
    Console.WriteLine("Площадь квадрата больше");
}
else 
{
    Console.WriteLine("Площади фигур равны");
}
