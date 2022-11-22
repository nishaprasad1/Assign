namespace MetTours;

[AttributeUsage(AttributeTargets.Method)]
public class MaxDurationAttribute : Attribute
{
    public double Tax { get; set; }

    public MaxDurationAttribute(double value = 0.08)
    {
         Tax = value;
    }
}