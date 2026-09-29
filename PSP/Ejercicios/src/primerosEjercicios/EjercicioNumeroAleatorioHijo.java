package primerosEjercicios;

import java.util.Random;
import java.util.Scanner;

public class EjercicioNumeroAleatorioHijo {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		Random r = new Random();
		
		while (sc.hasNext()) { // Mientras el padre mande algo
			sc.nextLine();
			int numero = r.nextInt(10) + 1;
			System.out.println(numero); // Contesta el número
		}
	}
}
