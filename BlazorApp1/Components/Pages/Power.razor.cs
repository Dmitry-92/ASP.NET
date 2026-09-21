using System.ComponentModel;

namespace BlazorApp1.Components.Pages;

public partial class Power
{
    double baseNumber = 0;
    double exponent = 0;
    double result = 0;


    void Calculate()
    {
        result = Math.Pow(baseNumber, exponent);
    }
}
    