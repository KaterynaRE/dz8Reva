using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str1
{
	struct ThreeDimensionalVector
	{
		public double x;
		public double y;
		public double z;

		public ThreeDimensionalVector(double xP, double yP, double zP)
		{
			x = xP;
			y = yP;
			z = zP;
		}

		public override string ToString()
		{
			return $"x {x}: y {y}: z {z}";
		}

		public static ThreeDimensionalVector MyltNum(ThreeDimensionalVector obj1, double num)
		{
			double mX = obj1.x * num;
			double mY = obj1.y * num;
			double mZ = obj1.z * num;
			ThreeDimensionalVector multNum = new ThreeDimensionalVector(mX, mY, mZ);
			return multNum;
		}

		public static ThreeDimensionalVector AddVector(ThreeDimensionalVector obj1, ThreeDimensionalVector obj2)
		{
			double mX = obj1.x + obj2.x;
			double mY = obj1.y + obj2.y;
			double mZ = obj1.z + obj2.z;
			ThreeDimensionalVector addVec = new ThreeDimensionalVector(mX, mY, mZ);
			return addVec;
		}

		public static ThreeDimensionalVector MinusVector(ThreeDimensionalVector obj1, ThreeDimensionalVector obj2)
		{
			double mX = obj1.x - obj2.x;
			double mY = obj1.y - obj2.y;
			double mZ = obj1.z - obj2.z;
			ThreeDimensionalVector minV = new ThreeDimensionalVector(mX, mY, mZ);
			return minV;
		}



	}
}
