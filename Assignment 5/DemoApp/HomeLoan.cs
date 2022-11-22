namespace finance;

public class HomeLoan : Loan,IDiscountable
{
    private int limit;
    
    public HomeLoan(double principle, double period) : base (principle, period)
    {
        limit  = 2500000;
    }

    public override float Rate()
    {

		if(principle<=2000000) {
			return 10;
		}
		else if(principle<=limit)
			return 11;
		return 12;
     

	}
       public double getDiscount() {
		return Emi()*0.5;
	}
}

