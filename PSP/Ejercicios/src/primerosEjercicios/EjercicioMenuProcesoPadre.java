package primerosEjercicios;

import java.util.Scanner;

public class EjercicioMenuProcesoPadre {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String texto = "";

        while (!texto.equalsIgnoreCase("salir")) {
            System.out.println("* Eco: para recibir un eco del otro proceso");
            System.out.println("* Saludo: para recibir Hola del otro proceso");
            System.out.println("* Vivo: para comprobar si el otro proceso esta vivo");
            System.out.println("* Matar: para finalizar el otro proceso");
            System.out.println("* Resucitar: para activar otro proceso hijo");
            System.out.println("* Salir: para salir del programa");
            System.out.print("* Indica tu opción: ");
            texto = sc.nextLine();
        }

    }
}
