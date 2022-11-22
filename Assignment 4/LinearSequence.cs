namespace Mysequence;

public class LinearSequence : Sequence
{
	private  double current;
	private float step;

	public LinearSequence(double current,float step) {
		this.current=current;
        this.step=step;
	}
	public override double next() {
		double term=current;
		current +=step;
		return term;
	}

}
