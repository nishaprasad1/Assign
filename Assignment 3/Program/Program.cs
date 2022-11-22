
class Program {
	
	public static double bannerPrice( Banner info, int copies) {

		float rate = copies < 5 ? 0.8f : 0.75f;
		
		return copies * rate * info.area();
	}

	public static void Main(string[] args) {
		int n = int.Parse(args[0]);
		
		Banner a = new Banner(30,15);
		
		Curvedbanner b = new Curvedbanner (30,15,5);

		Console.WriteLine($"Total price of regular banner = Rs.{Program.bannerPrice(a,n)}");
		Console.WriteLine($"Total price of curved banner = Rs.{Program.bannerPrice(b,n)}");
	}
}


