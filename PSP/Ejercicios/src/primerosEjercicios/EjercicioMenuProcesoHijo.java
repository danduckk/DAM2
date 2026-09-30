package primerosEjercicios;

import java.util.Scanner;

public class EjercicioMenuProcesoHijo {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        while (sc.hasNextLine()) { 
            String texto = sc.nextLine();
            if (texto.equalsIgnoreCase("SALUDO")) {
                System.out.println("HOLA SOY TU HIJO");
            } else {
                System.out.println("Devuelto: " + texto);
            }
        }
    }
}
