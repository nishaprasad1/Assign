namespace finance;

public abstract class Loan 
{
    public double principle{ get;set;} 
    public double period { get;set;}

    public Loan(double principle,double period)
    {
		this.principle=principle;
		this.period=period;
	}

   public abstract float Rate();
   public double Emi()
   {
     	double emi=0;

		emi= principle*(1+ Rate() * period / 100) / (12 * period);
		return emi;
   }
   

}