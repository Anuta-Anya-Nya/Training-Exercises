//Известны два расстояния: одно в километрах, другое — в футах (1 фут 0,305 м). Какое из расстояний меньше?
int distanceKM = 1;
int distanceF = 20000;
int min = 0;
double distanceM1 = distanceKM * 1000;
double distanceM2 = distanceF * 0.305;

if (distanceM1 < distanceM2)
{ 
    min = distanceKM;
}
else 
{
    min = distanceF;
}

Console.WriteLine(min);