class MathUtil
{
public static bool IsEven(double n)
    {
        if(n % 2 == 0)
        {
            return true;
        }
        return false;
    }
public static bool IsOdd(double n)
    {
        if(n % 2 != 0)
        {
            return true;
        }
        return false;
    }
public static bool IsPrime(double n)
    {
       double num = n;      
       for (int i = 2; i <= num / 2; ++i)
        {
		if (num % i == 0) 
        {
		     return  false;		          
		}
	    }
		return true;
    }
public static double IsCountPrime(double n,double m)
    {
        double term, count = 0;
		for(term = n; term <= m; ++term)
		{
		if (IsPrime(term) == true)
        {
			count += 1;
		}
	}
		return count;
    }
public static int IsReverse(int o)
    {
        int number;
        int  reverse = 0;  
    	for( number=o; number != 0; number=number/10)   
		{  
		int remainder = number % 10;  
		reverse = reverse * 10 + remainder ;
		}  
		return reverse;
    }
public static int IsDigitCount(int o)
    {
	    int count=0, num=o;

	   	while (num != 0)
        {
  	       	num /= 10;
             ++count;
    	}
	return count;
	}

}