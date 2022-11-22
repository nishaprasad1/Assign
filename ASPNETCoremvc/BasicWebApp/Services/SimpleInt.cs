namespace Services;

public class SimpleInt : IInterest
{
   
    public double Interest(double p , double r, double n)
    {
        return (p * r * n)/100;
    }
     
}