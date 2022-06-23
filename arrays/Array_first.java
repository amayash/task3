package arrays;

import java.util.Random;

public class Array_first
{
	protected int[] massiv;
	
	public Array_first(int length)
	{
		Random r=new Random();
		massiv = new int[length];
		for (int i=0;i<length;i++)
			massiv[i]=r.nextInt(100);
	}
	
	public String Print()
	{
		String str="";
		for (int i=0;i<massiv.length;i++)
			str+=massiv[i]+" ";
	return str;
	}
	
	public String nom1()
	{
		int sum=0;
		for (int i=0;i<massiv.length;i++)
			sum+=massiv[i];
		int sr=sum/massiv.length;
		int k=0;
		sum=0;
		for (int i=0;i<massiv.length;i++)
			if (massiv[i]>sr) {
				k++;
				sum+=massiv[i];
			}
		String str="Кол-во эл-тов больших ср. арифметического"+"("+sr+") - "+k+"\nИх сумма - "+sum+"\n";
		return str;
	}
	
}
