//Program(Main)
namespace finance;
public class Program
{
    public static void Main(string[] args)
    {
        double principle1=double.Parse(args[0]);
        double period1=double.Parse(args[1]);
        var p1 = new PersonalLoan(principle1,period1);
        var p2 = new HomeLoan(principle1,period1);
        Console.WriteLine($"PersonalLoan is = Rs.{p1.Emi():0.00}");
        
        Console.WriteLine($"HomeLoan is = Rs.{p2.Emi():0.00}");
    }
}