public class Banner {
	
	private float width;
	private float height;

	public Banner( float w, float h) {
		width = w;
		height = h;
	}
    public double Width { get; set; }
    public double Height { get; set; }
	public virtual double area() {
		return width * height;
	}
}
