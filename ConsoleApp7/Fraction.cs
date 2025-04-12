using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	internal class Fraction
	{
		public int Nominator {  get; set; }

		private int _denominator; 
		
		public int Denominator
		{
			get {  return _denominator; }

			set
			{
				if (Denominator == 0)
					throw new ArgumentException("NULL DENOMINATOR"); 
				_denominator = value;
			}
		}

		private int GCD(int a, int b) //ця штучка шукає найбільший спільний дільник за алгоритмом якогось дуже розумного дядька я вже не пам'ятаю як його звуть
		{
			a = a < 0 ? -a : a; //цю штучку я з інтернету взяв каюсь тут воно перетворює числа на додатні 
			b = b < 0 ? -b : b;	

			while(b != 0)
			{
				int temp = b;
				b = a % b; 
				a = temp;
			}

			return a;
		}

		public void Simplify()
		{
			int gcd = GCD(Nominator, Denominator);

			Nominator /= gcd;
			Denominator /= gcd;

			if (Denominator < 0)
			{
				Nominator *= -1; 
				Denominator *= -1;
			}
		}

		public Fraction(int nominator, int denominator)
		{
			Nominator = nominator;
			Denominator = denominator;
			Simplify();
		}

		public static Fraction operator+(Fraction a, Fraction b)
		{
			return new Fraction(a.Nominator * b.Denominator + b.Nominator * a.Denominator,
			a.Denominator * b.Denominator);
		}

		public static Fraction operator-(Fraction a, Fraction b)
		{
			return new Fraction(a.Nominator * b.Denominator - b.Nominator * a.Denominator, a.Denominator * b.Denominator);
		}

		public static Fraction operator*(Fraction a, Fraction b)
		{
			return new Fraction(a.Nominator * b.Nominator, a.Denominator * b.Denominator);
		}

		public static Fraction operator/(Fraction a, Fraction b)
		{
			if (b.Denominator == 0)
				throw new DivideByZeroException("NULL DENOMINATOR DIVISION");
			return new Fraction(a.Nominator * b.Denominator, a.Denominator * b.Nominator); 
		}

		public static bool operator==(Fraction a, Fraction b)
		{
			if(a is null || b is null)
				return false;
			return a.Nominator == b.Nominator && a.Denominator == b.Denominator;
		}

		public static bool operator!=(Fraction a, Fraction b)
		{
			return !(a == b);
		}


	}
}
