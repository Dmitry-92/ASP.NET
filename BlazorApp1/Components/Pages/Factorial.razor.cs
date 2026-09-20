using System.Numerics;

namespace BlazorApp1.Components.Pages;

public partial class Factorial
{
    int number = 0;
    BigInteger factorial = 1;

    void Calculate()
    {
        factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
    }
}