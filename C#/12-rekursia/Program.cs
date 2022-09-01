//Задача. Рассчитать значение квадрата целого положительного числа n, если известна зависимость
//n2 = (n-1)2 + 2·(n-1) + 1
int Squaring(int n)
{
    if (n == 1) return 1;
    return Squaring(n - 1) + 2 * (n - 1) + 1; //3: Sq(2)+2*(3-1)+1; Sq(1)+2*(2-1)+ 4+1+1; 1+2+4+2=9
}
Console.WriteLine("Задача 1: " + Squaring(3));

//Комбинаторная задача
//Задача. Вычислить количество комбинаций из n разных элементов по m. Количество комбинаций определяется формулой 

int Combin(int n, int m)
{
    if ((m == 0 && n > 0) || (m == n && m >= 0)) return 1;
    if (m > n && n >= 0) return 0;
    return Combin(n - 1, m - 1) + Combin(n - 1, m);
}
Console.WriteLine("Задача 2: " + Combin(6, 4));

//Задача. Разработать рекурсивную функцию, которая реализует синтаксический анализатор для понятия идентификатор. 
//Как известно, в языке программирования C# идентификатор подчиняется следующим правилам:
//первым символом идентификатора обязательно есть буква латинского алфавита;
//второй, третий и т.д. символ идентификатора может быть буквой или цифрой.
bool IsIdentifier(string id, int position)
{
    if (position == 0) // проверка первого символа
    {
        char c = id[position];
        if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
        {
            return IsIdentifier(id, position + 1); //проверка следующего символа
        }
        else
        {
            return false;
        }
    }
    else if (position < id.Length)
    {
        char c = id[position];
        if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
        {
            return IsIdentifier(id, position + 1);
        }
        else
        {
            return false;
        }
    }
    else
    {
        return true;
    }
}
Console.WriteLine("Задача 3: " + IsIdentifier("12a", 0));

// Задача. 
//Составить программу, которая реализует синтаксический анализатор для понятия «expression»  -простое выражение
// содержит буквы и только один знак операции ПОДРЯД + - *. Первый и последний символ - буква

// Для решения данной задачи нужно реализовать три функции:
// функцию IsIdentifier(), которая определяет есть ли простой идентификатор буквой;
// функцию IsOperation(), которая определяет ли есть операция синтаксически верной в соответствии с условием задачи;
// рекурсивную функцию IsExpression(), которая определяет есть ли простое выражение синтаксически правильным 
// в соответствии с условием задачи.
bool ItIdentifier(char c)
{
    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) return true;
    else return false;
}

bool ItOperation(char c)
{
    if (c == '+' || c == '-' || c == '*') return true;
    else return false;
}

bool ItExpression(string expr, int position, bool isOp)
{
    if (position == 0)
    {
        char c = expr[position];
        if (ItIdentifier(c))
        {
            return ItExpression(expr, position + 1, false);
        }
        else
        {
            return false;
        }
    }
    else
    {
        char c = expr[position];
        if (position < expr.Length - 1)
        {
            if (ItIdentifier(c))
            {
                return ItExpression(expr, position + 1, false); // false показывает следующей проверке что стояла буква. ЕВЛИ хотим в проверке только один знак +-* то прописать вместо false - ItOp
            }
            else if (ItOperation(c) && !isOp)
            {
                return ItExpression(expr, position + 1, true);
            }
            else
            {
                return false;
            }
        }
        else //проверяем последний элемент
        {
            return ItIdentifier(c); // оптимизация кода, выведет true или false
        }
    }
}
Console.WriteLine("Задача 4: " + ItExpression("a+b*vb", 0, false));