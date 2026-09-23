using System.Numerics;

namespace BlazorApp1.Components.Pages;

public partial class Fibonacci
{
    private int limit = 100;
    string result = "";

    void Calculate()
    {
        var numbers = new List<BigInteger>();
        BigInteger a = 0;
        BigInteger b = 1;

        while (a <= limit)
        {
            numbers.Add(a);
            BigInteger next = a + b;
            a = b;
            b = next;
        }
        
        result = string.Join(", ", numbers);
    }
}

