public class Program
{
    public static void Main(string[] args)
    {
    double n = double.Parse(args[0]);
    double m = double.Parse(args[1]);
    int p = int.Parse(args[2]);

    Console.WriteLine($"The Number {args[0]} is Even :{MathUtil.IsEven(n)}");
    Console.WriteLine($"The Number {args[0]} is Odd :{MathUtil.IsOdd(n)}");
    Console.WriteLine($"The Number {args[0]} is Prime :{MathUtil.IsPrime(n)}");
    Console.WriteLine($"The Number of Prime Number present between are {args[0]} and {args[1]}:{MathUtil.IsCountPrime(n,m)}");
    Console.WriteLine($"The Reverse of Number {args[2]} is :{MathUtil.IsReverse(p)}");
    Console.WriteLine($"The Digit Count of number {args[2]} is :{MathUtil.IsDigitCount(p)}");
    }
}
