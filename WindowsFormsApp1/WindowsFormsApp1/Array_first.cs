using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Array_first
    {
        protected int[] massiv;

		public Array_first(int Length)
		{
			Random r = new Random();
			massiv = new int[Length];
			for (int i = 0; i < Length; i++)
				massiv[i] = r.Next(100);
		}

		public String Print()
		{
			String str = "";
			for (int i = 0; i < massiv.Length; i++)
				str += massiv[i] + " ";
			return str;
		}

		public String nom1()
		{
			int sum = 0;
			for (int i = 0; i < massiv.Length; i++)
				sum += massiv[i];
			int sr = sum / massiv.Length;
			int Length = 0;
			sum = 0;
			for (int i = 0; i < massiv.Length; i++)
				if (massiv[i] > sr)
				{
					Length++;
					sum += massiv[i];
				}
			String str = "Кол-во эл-тов больших ср. арифметического" + "(" + sr + ") - " + Length + "\nИх сумма - " + sum + "\n";
			return str;
		}
	}
}
