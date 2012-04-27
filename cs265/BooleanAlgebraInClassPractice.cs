using System;

class BooleanAlgebraInClassPractice
{
    static void Main(string[] args)
    {
        Console.WriteLine("A\tB\tC\tD\tEQ1\tEQ2");
        Console.WriteLine(FirstSecond(false, false, false, false));
        Console.WriteLine(FirstSecond(false, false, false, true));
        Console.WriteLine(FirstSecond(false, false, true, false));
        Console.WriteLine(FirstSecond(false, false, true, true));
        Console.WriteLine(FirstSecond(false, true, false, false));
        Console.WriteLine(FirstSecond(false, true, false, true));
        Console.WriteLine(FirstSecond(false, true, true, false));
        Console.WriteLine(FirstSecond(false, true, true, true));
        Console.WriteLine(FirstSecond(true, false, false, false));
        Console.WriteLine(FirstSecond(true, false, false, true));
        Console.WriteLine(FirstSecond(true, false, true, false));
        Console.WriteLine(FirstSecond(true, false, true, true));
        Console.WriteLine(FirstSecond(true, true, false, false));
        Console.WriteLine(FirstSecond(true, true, false, true));
        Console.WriteLine(FirstSecond(true, true, true, false));
        Console.WriteLine(FirstSecond(true, true, true, true));

        Console.WriteLine();

        Console.WriteLine("B\tC\tD\tEQ3\tEQ4");
        Console.WriteLine(ThirdFourth(false, false, false));
        Console.WriteLine(ThirdFourth(false, false, true));
        Console.WriteLine(ThirdFourth(false, true, false));
        Console.WriteLine(ThirdFourth(false, true, true));
        Console.WriteLine(ThirdFourth(true, false, false));
        Console.WriteLine(ThirdFourth(true, false, true));
        Console.WriteLine(ThirdFourth(true, true, false));
        Console.WriteLine(ThirdFourth(true, true, true));
    }

    static string FirstSecond(bool a, bool b, bool c, bool d)
    {
        return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", a, b, c, d, First(a, b, c, d), Second(a, b, c, d));
    }

    static bool First(bool a, bool b, bool c, bool d)
    {
        return (!a && !b && c) || !(a || b || !c) || (!a && !b && !c && d);
    }

    static bool Second(bool a, bool b, bool c, bool d)
    {
        return (!a && !b && c) || (!a && !b && d);
    }

    static string ThirdFourth(bool b, bool c, bool d)
    {
        return string.Format("{0}\t{1}\t{2}\t{3}\t{4}", b, c, d, Third(b, c, d), Fourth(b, c, d));
    }

    static bool Third(bool b, bool c, bool d)
    {
        return (b || (b && c)) && (b || (b && c)) && (b || d);
    }

    static bool Fourth(bool b, bool c, bool d)
    {
        return b;
    }
}