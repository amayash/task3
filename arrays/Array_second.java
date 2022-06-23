package arrays;

import java.util.Random;
import arrays.Array_first;

public class Array_second extends Array_first
{
	private int[][] massiv2;
	private int n;
	private int m;
	
	public Array_second(int k, int l)
	{
		super(k);
		Random r=new Random();
		n=k;
		m=l;
		massiv2 = new int[k][l];
		for (int i=0;i<k;i++)
			for (int j=0;j<l;j++)
				massiv2[i][j]=r.nextInt(15);
	}
	
	public String Print()
	{
		String str="";
		for (int i=0;i<massiv2.length;i++) {
			massiv=massiv2[i];
			str+=super.Print()+"\n";
		}
	return str;
	}

	public String nom2()
	{
		String strin="";
		int imp=-1;
		int sum=0;
		if (m!=1)
			sum=massiv2[0][0]+massiv2[0][1]+massiv2[n-1][m-1];
		else return "Массив слишком мал";

		for (int i = 0; i < n; i++)
			for (int j = 0; j < m; j++)
				if (massiv2[i][j]%sum==0)
					imp=i;
		int[][] array=new int[n+1][m];
		if (imp==-1) return "Такой строки нет";
		
		for (int i=0;i<=imp;i++)
			for (int j=0;j<m;j++)
				array[i][j]=massiv2[i][j];
		for (int i=imp+1;i<=imp+1;i++)
			for (int j=0;j<m;j++)
				array[i][j]=0;
		for (int i=imp+2;i<n+1;i++)
			for (int j=0;j<m;j++)
				array[i][j]=massiv2[i-1][j];
		System.out.println(imp+"\n");
		for (int i=0;i<n+1;i++) {
			for (int j=0;j<m;j++)
				strin+=array[i][j]+" ";
			strin+="\n";
		}
		return strin;
	}
	
	public int stroka(){
		int dlina=0;
		int needi=-1;
		for (int i=0;i<n;i++) {
			String str="";
			for (int j=0;j<n;j++) 
				str+=Integer.toString(massiv2[i][j]);
				if (str.length()>dlina) {
					dlina=str.length();
					needi=i;
				}
		}
		System.out.println(needi+"\n");
		return needi;
	}
	
	public String nom3(int num)
	{
		massiv=massiv2[num];
		return super.nom1();
	}
}
