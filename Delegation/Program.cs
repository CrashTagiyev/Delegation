




using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

class Program
{
    delegate bool PredicatWithTwoArgument<T1, T2>(T1 arg1, T2 arg2);
    static void Main(string[] args)
    {
        PredicatWithTwoArgument<int, int> customPred = (num1, num2) => num1 > num2;
        Func<int, int, int> summ = (num1, num2) => num1 + num2;
        Func<int, int, int> minus = (num1, num2) => num1 - num2;
        Func<int, int, int> multiply = (num1, num2) => num1 * num2;
        Func<int, int, int> divide = (num1, num2) => num1 / num2;
        Func<int, int> kvadrati = num1 => num1 * num1;
        Action<bool> BoolAction = boolValue => Console.WriteLine(boolValue);
        Action<int> intAction = intValue => Console.WriteLine(intValue);
        int num1 = 10;
        int num2 = 2;

        BoolAction(customPred(num1, num2));
        intAction(summ(num1, num2));
        intAction(minus(num1, num2));
        intAction(multiply(num1, num2));
        intAction(divide(num1, num2));
        intAction(kvadrati(num1));

    }
}