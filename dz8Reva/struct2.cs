using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str2
{
	struct DecimalNumber
	{
		public decimal Value;

		public DecimalNumber(decimal ValueP)
		{
			Value = ValueP;
		}

		public void TranslateNumber(int num, int systemFortranslate)
		{
			int res = 0;
			int temp = 0;
			int remeber;
			int reverse = 0;
			while (num > 0)
			{
				res = num % systemFortranslate;
				temp = temp * 10 + res;
				num = num / systemFortranslate;
			}
			while (temp > 0)
			{
				remeber = temp % 10;
				reverse = reverse * 10 + remeber;
				temp /= 10;
			}

			switch (systemFortranslate)
			{
				case 2:
					Console.WriteLine(reverse);
					break;
				case 8:
					Console.WriteLine(reverse + "_8$");
					break;
				case 16:
					Console.WriteLine(reverse + "_16$");
					break;
				default:
					break;
			}
			
		}
		public override string ToString()
		{
			return $"Translate Number {Value}";
		}
	}
}
