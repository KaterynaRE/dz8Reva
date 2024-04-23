using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace str3
{
	struct RGBColor
	{
		public int red;
		public int green;
		public int blue;

		public RGBColor(int rP, int gP, int bP)
		{
			red = rP;
			green = gP;
			blue = bP;
		}

		public override string ToString()
		{
			return $" {red}: {green} : {blue} ";
		}

		public string ToHex()
		{
			return $"#{red:X2}{green:X2}{blue:X2}";
		}

		
	}
}
