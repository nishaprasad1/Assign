public class Curvedbanner : Banner 
{
    	private float radius;

	public Curvedbanner( float w, float h, float r) : base (w,h)
    {
		radius = r;
	}
	public double Radius { get; set; }

	public override  double area()
    {
		return base.area() - 0.86  * radius * radius;
	}
}
