namespace Mysequence;

public class Program
{

public static double Compute(Sequence seq,int count)
{   

   	if(seq is IResetable)
			((IResetable) seq).reset();
		
    return seq.sum(count)/ count;
}
public static void Main(string[] args)
{
double n = double.Parse(args[0]);
float m = float.Parse(args[1]);
int i = int.Parse(args[2]);
float j = float.Parse(args[3]);
Sequence s1 = new LinearSequence(n,m);
Sequence s2 = new PowerSequence(j);

Console.WriteLine($"compute for s1 {Program.Compute(s1,i)}");
Console.WriteLine($"compute for s2 {Program.Compute(s2,i)}");
}
}


