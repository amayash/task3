import arrays.*;

public class Array {

    public static void main(String[] args) {

        Array_first a1=new Array_first(10);
		Array_second a2=new Array_second(4,4);
        System.out.println(a1.Print());
        System.out.println(a1.nom1());
		System.out.println(a2.Print());
		System.out.println(a2.nom2());
		System.out.println(a2.nom3(a2.stroka()));
    }
}