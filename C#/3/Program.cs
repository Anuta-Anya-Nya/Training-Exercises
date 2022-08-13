// разработать программу, которая по заданному числу определяет количество светодиодов, которые должны загореться, 
//чтобы правильно отобразить заданное число.
// Входные данные: Заданное число N (0 <= N <= 109) 123
// Выходные данные: Искомое количество светодиодов.12

string Nstr = Console.ReadLine();
int lightsNumber = 0;
for( int i=0; i < Nstr.Length; i++)
{
    switch (int.Parse(Nstr[i].ToString()))
    {
        case 0: lightsNumber +=6;
                break;
        case 1: lightsNumber +=2;
        break;
        case 2: lightsNumber +=5;
        break;
        case 3: lightsNumber +=5;
        break;
        case 4: lightsNumber +=4;
        break;
        case 5: lightsNumber +=5;
        break;
        case 6: lightsNumber +=6;
        break;
        case 7: lightsNumber +=3;
        break;
        case 8: lightsNumber +=7;
        break;
        case 9: lightsNumber +=6;
        break;
        default: Console.WriteLine("Такого не может быть!");
        break;
    }
}
Console.WriteLine(lightsNumber);