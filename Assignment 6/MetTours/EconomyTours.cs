namespace MetTours;
public class EconomyTours
{

 public double GetDaysRent(int days , int noPersons) 
 {
    return ((500* days * noPersons)-(discount(days,noPersons)* days * noPersons) )  ;
 }
 

 public int discount(int days, int noPersons)
    
    {
        int a=0;
        if(noPersons>= 4 && days>6)
        {
            a = 200;
        }
        else if( days > 6 || noPersons >= 4)
        {
            a = 100;

        }
        
        return a;
    }
}
