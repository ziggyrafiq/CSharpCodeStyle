﻿namespace ZiggyRafiq.CodeStyles.Helper;
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
          throw new ArgumentException("Divisor cannot be zero.", nameof(b));
        
        return a / b;
    }
}
