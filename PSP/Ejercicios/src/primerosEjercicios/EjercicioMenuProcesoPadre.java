package primerosEjercicios;

<<<<<<< HEAD
import java.util.Scanner;

public class EjercicioMenuProcesoPadre {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String texto = "";

        while (!texto.equalsIgnoreCase("salir")) {
=======
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.Scanner;

public class EjercicioMenuProcesoPadre {
    public static void main(String[] args) throws Exception{
        Scanner sc = new Scanner(System.in);
        String opcion = "";
        String textoDevuelto = "";

        ProcessBuilder pb = new ProcessBuilder("java", "primerosEjercicios.EjercicioMenuProcesoHijo");
        pb.directory(new File("./bin"));
        Process hijo =  pb.start();

        BufferedWriter alHijo = new BufferedWriter(new OutputStreamWriter(hijo.getOutputStream()));
        BufferedReader delHijo = new BufferedReader(new InputStreamReader(hijo.getInputStream()));

        while (!opcion.equalsIgnoreCase("salir")) {
            System.out.println("\nMenú de Opciones. Pulsa:");
>>>>>>> origin/ejercicios-psp-clase
            System.out.println("* Eco: para recibir un eco del otro proceso");
            System.out.println("* Saludo: para recibir Hola del otro proceso");
            System.out.println("* Vivo: para comprobar si el otro proceso esta vivo");
            System.out.println("* Matar: para finalizar el otro proceso");
            System.out.println("* Resucitar: para activar otro proceso hijo");
            System.out.println("* Salir: para salir del programa");
            System.out.print("* Indica tu opción: ");
<<<<<<< HEAD
            texto = sc.nextLine();
        }

=======
            opcion = sc.nextLine();

            opcion = opcion.toLowerCase();
            switch (opcion) {
            case "eco":
                String textoEco = "";
                System.out.print("Escribe un texto: ");
                textoEco = sc.nextLine();
                alHijo.write(textoEco);
                alHijo.newLine();
                alHijo.flush();

                textoDevuelto = delHijo.readLine();
                System.out.println(textoDevuelto);
                break;
            case "saludo":
                alHijo.write("SALUDO");
                alHijo.newLine();
                alHijo.flush();

                textoDevuelto = delHijo.readLine();
                System.out.println(textoDevuelto);                
                break;
            case "vivo":
                if (hijo.isAlive()) {
                    System.out.println("Está vivo, pid: " + hijo.pid());
                } else {
                    System.out.println("Está muerto.");
                }
                break;
            case "matar":
                if (hijo.isAlive()) {
                    System.out.println("Matando...: ");
                    alHijo.close();
                } else {
                    System.out.println("Está muerto.");
                }
                break;
            case "resucitar":
                if (!hijo.isAlive()) {
                    System.out.println("Resucitando...");
                    hijo = pb.start();
                    alHijo = new BufferedWriter(new OutputStreamWriter(hijo.getOutputStream()));
                    delHijo = new BufferedReader(new InputStreamReader(hijo.getInputStream()));
                } else {
                    System.out.println("El proceso ya está vivo.");
                }
                break;
            case "salir":
                System.out.println("Saliendo...");
                break;
            default:
                System.out.println("Escribe una opción válida.");
                break;
        }
        }        
>>>>>>> origin/ejercicios-psp-clase
    }
}
