namespace MetTours;
 
 public class PeriumTours
 {
     [MaxDuration(0.10)]
    public double getDaysRentForCommon( int days , int noPersons)
    {
        double total;
        total=1200 * days * noPersons;
        return total;
    }
    public double getDaysRentForSeniors(int days , int noPersons)
    {
        double total;
        total= (1100-discount(days,noPersons))*days * noPersons;
        return total; 
    }
    public double getDaysRentForWoman(int days , int noPersons)
    {
        double total;
        total=(1000-discount(days,noPersons))*days * noPersons;
        return total; 
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