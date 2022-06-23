using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Array_second:Array_first
    {
		private int[,] massiv2;
		private int n;
		private int m;

		public Array_second(int Length, int l) : base(Length)
		{
			Random r = new Random();
			n = Length;
			m = l;
			massiv2 = new int[Length,l];
			for (int i = 0; i < Length; i++)
				for (int j = 0; j < l; j++)
					massiv2[i,j] = r.Next(15);
		}
		
		public int[] GetLine(int ind)
        {
            int[] line = new int[m];

			for (int i = 0; i < m; i++)
            {
				line[i] = massiv2[ind, i];
            }
			return line;
        }
		public String Print()
		{
			String str = "";
			for (int i = 0; i < n; i++)
			{
				massiv = GetLine(i);
				str += base.Print() + "\n";
			}
			return str;
		}

		public String nom2()
		{
			String strin = "";
			int imp = -1;
			int sum = 0;
			if (m != 1)
				sum = massiv2[0,0] + massiv2[0,1] + massiv2[n - 1,m - 1];
			else return "Массив слишком мал";

			for (int i = 0; i < n; i++)
				for (int j = 0; j < m; j++)
					if (massiv2[i,j] % sum == 0)
						imp = i;
			int[,] array = new int[n + 1,m];
			if (imp == -1) return "Такой строки нет";

			for (int i = 0; i <= imp; i++)
				for (int j = 0; j < m; j++)
					array[i,j] = massiv2[i,j];
			for (int i = imp + 1; i <= imp + 1; i++)
				for (int j = 0; j < m; j++)
					array[i,j] = 0;
			for (int i = imp + 2; i < n + 1; i++)
				for (int j = 0; j < m; j++)
					array[i,j] = massiv2[i - 1,j];
			Console.WriteLine(imp + "\n");
			for (int i = 0; i < n + 1; i++)
			{
				for (int j = 0; j < m; j++)
					strin += array[i,j] + " ";
				strin += "\n";
			}
			return strin;
		}

		public int stroka()
		{
			int dlina = 0;
			int needi = -1;
			for (int i = 0; i < n; i++)
			{
				String str = "";
				for (int j = 0; j < n; j++)
					str += Convert.ToString(massiv2[i,j]);
				if (str.Length > dlina)
				{
					dlina = str.Length;
					needi = i;
				}
			}
			Console.WriteLine(needi + "\n");
			return needi;
		}

		public String nom3(int num)
		{
			massiv = GetLine(num);
			return base.nom1();
		}
	}
}
