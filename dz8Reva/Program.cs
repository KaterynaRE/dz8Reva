using str1;
using str2;
using str3;
using System;
using System.Drawing;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz8Reva
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Завдання 1
			//Створіть структуру «Тривимірний вектор». Визначте в ній необхідні поля і методи.Реалізуйте наступну
			//функціональність:
			//+ ■ Помножити вектор на число;
			//+ ■ Додавання векторів;
			//■ Віднімання векторів

			ThreeDimensionalVector obj1;
			double x = 1;
			double y = -2;
			double z = 3;
			obj1 = new ThreeDimensionalVector(x, y, z);
			//Console.WriteLine($"Vector 1 -  {obj1}");

			ThreeDimensionalVector obj2;
			double x2 = 4;
			double y2 = -2;
			double z2 = 6;
			obj2 = new ThreeDimensionalVector(x2, y2, z2);
			//Console.WriteLine($"Vector 2 -  {obj2}");

			double num = 2.2;

			Console.WriteLine("Multiplication check:");
			Console.WriteLine($"Vector before multiplication: {obj1}");
			ThreeDimensionalVector mult = ThreeDimensionalVector.MyltNum(obj1, num);
			Console.WriteLine($"Vector after Multiplication with {num}:  {mult}");


			Console.WriteLine("\nAddition check:");
			Console.WriteLine($"Vector 1: {obj1}");
			Console.WriteLine($"Vector 2: {obj2}");
			ThreeDimensionalVector addV = ThreeDimensionalVector.AddVector(obj1, obj2);
			Console.WriteLine($"Add vectors result: {addV}");

			Console.WriteLine("\nSubtraction check:");
			Console.WriteLine($"Vector 1: {obj1}");
			Console.WriteLine($"Vector 2: {obj2}");
			ThreeDimensionalVector minV = ThreeDimensionalVector.MinusVector(obj1, obj2);
			Console.WriteLine($"Subtraction vectors result: {minV}");


			//Завдання 2
			//Створіть структуру «Десяткове число». Визначте в
			//ній необхідні поля і методи.Реалізуйте наступну функціональність:
			//■ Перевести число у двійкову систему;
			//■ Перевести число у вісімкову систему;
			//■ Перевести число у шістнадцяткову систему.


			DecimalNumber decimalNumber2 = new DecimalNumber(55);
			Console.WriteLine($"\n{decimalNumber2} translate to 2-system:");
			decimalNumber2.TranslateNumber(55, 2);

			DecimalNumber decimalNumber8 = new DecimalNumber(55);
			Console.WriteLine($"\n{decimalNumber8} translate to 8-system:");
			decimalNumber8.TranslateNumber(55, 8);

			DecimalNumber decimalNumber16 = new DecimalNumber(55);
			Console.WriteLine($"\n{decimalNumber16} translate to 16-system:");
			decimalNumber16.TranslateNumber(55, 16);


			//Завдання 3
			//Створіть структуру «RGB колір». Визначте в ній необхідні поля і методи.
			//Реалізуйте наступну функціональність:
			//+ ■ Перевести у HEX формат;
			//- ■ Перевести у HSL;
			//- ■ Перевести у CMYK.

			RGBColor rGBColorR = new RGBColor(255, 0, 0);
			Console.WriteLine($"\nRed color {rGBColorR}");

			RGBColor rGBColorB = new RGBColor(0, 0, 255);
			Console.WriteLine($"\nBlue color {rGBColorB}");

			RGBColor rGBColorG = new RGBColor(0, 255, 0);
			Console.WriteLine($"\nGreen color {rGBColorG}");

			Console.WriteLine(rGBColorR.ToHex());

		}
	}
}
