using System;

namespace ConsoleApp1
{
    class Program
    {
        static public void Main(string[] args)
        {
			int[] matricula = new int[5];
			int[] nota1 = new int[5];
			int[] nota2 = new int[5];
			int[] nota3 = new int[5];
			int[] nota4 = new int[5];
			float soma, media;			

			matricula[0] = 1;
			matricula[1] = 2;
			matricula[2] = 3;
			matricula[3] = 4;
			matricula[4] = 5;

			


			for (int i = 0; i < 5; i++)
			{
			
				Console.Write("Informe nota do " + ( i ) + " aluno: ");
				nota1[i] = int.Parse(Console.ReadLine());
				Console.Write("Informe nota do aluno: ");
				nota2[i] = int.Parse(Console.ReadLine());
				Console.Write("Informe nota do aluno: ");
				nota3[i] = int.Parse(Console.ReadLine());
				Console.Write("Informe nota do aluno: ");
				nota4[i] = int.Parse(Console.ReadLine());
				
			}


			for (int i = 0; i < 5; i++)
			{

				soma = nota1[i] + nota2[i] + nota3[i] + nota4[i];
				media = soma / 4;
				Console.WriteLine("A media do " + (i) + " aluno: " + media);

			}


			Console.ReadKey();

		}
	}
}
