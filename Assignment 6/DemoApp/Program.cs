
using System.Reflection;
using MetTours;

using Amount = System.Func<double,double,double>;


class Program
{
        private static double Tour(double rate , double total)
    {
        return rate * total;
        
    }
    static void Main(string[] args)
    {
        int d = int.Parse(args[0]);
        int p = int.Parse(args[1]);
        Type t = Type.GetType(args[2]);
        MethodInfo scheme = t.GetMethod(args[3]);
        object policy = Activator.CreateInstance(t);
        Tour amt = scheme.CreateDelegate<Tour>(policy);
        MaxDurationAttribute md;
        if( policy is EconomyTours)
        {
            md = t.GetCustomAttribute<MaxDurationAttribute>();
            
        }
        else
        {
            md = scheme.GetCustomAttribute<MaxDurationAttribute>();  
        }
        double TaxRate = md ?. Tax ?? 8 ;
       
         
        Console.WriteLine("Expenses on tour {0}",total);
        double tax = total*TaxRate/100;
        Console.WriteLine("Tax on tour {0}",tax);
        //Console.WriteLine("Tax on tour {0}",TaxRate);
        Console.WriteLine("Total amount to be paid on tour {0}",total + tax);
    }
    }
}