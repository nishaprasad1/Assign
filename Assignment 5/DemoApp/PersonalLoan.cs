namespace finance;

public class PersonalLoan : Loan,ITaxable
{
    public PersonalLoan(double principle , double period) : base (principle, period){}
    
    public override float Rate() {

		if(principle<=500000) {
			return 15;
		}
		return 16;
	}
    public  double getTax() 
    {
		return 5*Emi()/100;
	}
}