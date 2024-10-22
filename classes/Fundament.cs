public class Fundament : IFundament
{
    public void CheckOddOrEven(double a)
    {
        if(a%2 == 0) Console.WriteLine($"{a} is even!");
        else Console.WriteLine($"{a} is odd!");
    }

    public string GetAInterestingFact(string fact)
    {
        return fact;
    }

    public void SumTwoNumbers()
    {
        int a = 2; int b = 2; int c = 0;
        c=a+b;
        Console.WriteLine($"2 + 2 = " + c);
    }

    public double SumTwoNumbersOfGivenType(double a, double b)
    {
        double c=a+b;
        return c;
    }


    // Extra challenges

    public void PrintFibonnaciSeries()
    {
        // TODO: Implement the Fibonacci sequence
        int a = 0;
        int b = 1;
        int c;

        /* 
        c = a + b
        a = b
        b = c
        */
    }

    public string ReverseString(string str)
    {
        // TODO: reverse the given string
        return "";
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 0)
        {
            return 1;
        }
        return n;
    }


}
