using System;

class Program
{

    public static void Main(String[] args)
    {

      Console.WriteLine("Voce quer ver a tabuada de qual numero?");
			int i = int.Parse(Console.ReadLine());
			for (int j = 1; j <= 10; j++){
				int resultado = i * j;
				Console.WriteLine("{0} x {1} = {2}", i, j, resultado);
			}
			
    }
}
