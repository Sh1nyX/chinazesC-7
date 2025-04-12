namespace ConsoleApp7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*TemperatureArray temps = new TemperatureArray();

			temps[0] = 12.3;
			temps[1] = 14.0;
			temps[2] = 13.7;
			temps[3] = 15.2;
			temps[4] = 16.5;
			temps[5] = 18.1;
			temps[6] = 17.6;

			for (int i = 0; i < 7; i++)
			{
				Console.WriteLine($"Day {i + 1}: {temps[i]}°C");
			}

			Console.WriteLine($"\nСередня температура: {temps.GetAverage():F2}°C");*/

			Fraction f = new Fraction(12, -16); 

			Console.WriteLine(f); 
			f.Nominator = 18;
			f.Denominator = 24;

			Console.WriteLine($"До Скорочення: {f}"); 
			f.Simplify();
			Console.WriteLine($"Після Скорочення: {f}"); 
		}
	}
}
