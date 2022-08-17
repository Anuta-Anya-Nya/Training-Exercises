string Derive(double coefficient, double exponent)
  {
    double mult = coefficient * exponent;
    double numb2 = exponent - 1;
    string result = mult.ToString() + "x^" + numb2.ToString();
    return result;
    // return $"{coefficient * exponent}x^{exponent - 1}";
  }
Console.WriteLine(Derive(7, 8));