package primerosEjercicios;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.util.Scanner;

public class EjercicioNumeroAleatorioPadre {
	public static void main(String[] args) throws Exception {
        // 1. Arrancar el hijo
        ProcessBuilder pb = new ProcessBuilder("java", "primerosEjercicios.EjercicioNumeroAleatorioHijo");
        pb.directory(new File("./bin"));
        pb.redirectError(ProcessBuilder.Redirect.INHERIT);
        Process hijo = pb.start();

        // 2. Preparar el canal para hablarle y el canal para escucharle
        BufferedWriter alHijo = new BufferedWriter(new OutputStreamWriter(hijo.getOutputStream()));
        BufferedReader delHijo = new BufferedReader(new InputStreamReader(hijo.getInputStream()));

        // 3. Para ller lo que escribe el usuario
        Scanner sc = new Scanner(System.in);
        String texto = "";

        // 4. Bucle principal
        while (!texto.equalsIgnoreCase("fin")) {
            System.out.print("Escribe algo: ");
            texto = sc.nextLine();

            if (!texto.equalsIgnoreCase("fin")) {
                alHijo.write(texto);
                alHijo.newLine();
                alHijo.flush(); // se manda el texto al hijo
                String numero = delHijo.readLine(); // se lee la respuesta del hijo
                System.out.println("Número: " + numero);
            }
        }

        // 5. Cerrar el canal del hijo: el hijo se entera de que ya no hay mas y termina
        alHijo.close();
    }
}
