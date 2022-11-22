namespace Mysequence;

public class PowerSequence : Sequence, IResetable
{
    private double current;
    private float factor;

    public PowerSequence(float factor)
   {
    this.current = 1;
    this.factor = factor;
   }

   public override double next()
   {
    double term = current;
    current *= factor;
    return term;
   }
   public void reset() 
   {
		this.current=1;
   }
}

