using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	internal class TemperatureArray
	{
		public double[] temperatures = new double[7];

		public double Monday { get; set; }
		public double Tuesday { get; set; }
		public double Wednesday { get; set; }
		public double Thursday { get; set; }
		public double Friday { get; set; }
		public double Saturday { get; set; }
		public double Sunday { get; set; }

		public double this[int index]
		{
			get
			{
				return index switch
				{
					0 => Monday,
					1 => Tuesday,
					2 => Wednesday,
					3 => Thursday,
					4 => Friday,
					5 => Saturday,
					6 => Sunday
				};
			}
			set
			{
				switch (index)
				{
					case 0:
						Monday = value;
						break;
					case 1:
						Tuesday = value;
						break;
					case 2:
						Wednesday = value;
						break;
					case 3:
						Thursday = value;
						break;
					case 4:
						Friday = value;
						break;
					case 5:
						Saturday = value;
						break;
					case 6:
						Sunday = value;
						break;
				}
			}

		}

		public double GetAverage()
		{
			return (Monday + Tuesday + Wednesday + Thursday + Friday + Saturday + Sunday) / 7.0;
		}
	}
}
