public class T2RatonesThr extends Thread {

	public static void main (String [] args)
	{
		T2RatonesThr miTh1 = new T2RatonesThr();
		miTh1.start();
		T2RatonesThr miTh2 = new T2RatonesThr();
		miTh2.start();
	}
	@Override
	public void run ()
	{
		System.out.println("HOLA");
	}
}