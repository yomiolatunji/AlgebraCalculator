using System;

namespace AdvanCalculator
{
    internal class QuadraticEquation
    {
        public QuadraticResult GetResult(float a, float b, float c)
        {
            QuadraticResult quadraticResult = new QuadraticResult();
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            bool isComplex = discriminant < 0;
            double discriminantSqrt = Math.Sqrt(Math.Abs(discriminant));
            double firstPart = (-b) / (2 * a);
            double secondPart = discriminantSqrt / (2 * a);
            if (isComplex)
            {
                quadraticResult.FirstValue = $"{firstPart} + {secondPart}i";
                quadraticResult.SecondValue = $"{firstPart} - {secondPart}i";
            }
            else
            {
                quadraticResult.FirstValue = (firstPart + secondPart).ToString();
                quadraticResult.SecondValue = (firstPart - secondPart).ToString();
            }

            return quadraticResult;
        }
    }

    public class QuadraticResult
    {
        public string FirstValue { get; set; }
        public string SecondValue { get; set; }
    }
}