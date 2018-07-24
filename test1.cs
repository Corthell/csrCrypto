
using System;

namespace konsola
{

	public class test1
	{
		Random count = new Random();
		string wynik = "";
		string matryca = "123456789";
		//----------------------------------------------------------------------------------------------
		public string generuj()
		{
			string matrycaKopia = matryca;

			Console.WriteLine("matryca: " + matryca);
			Console.WriteLine("matrycakopia_lengh: " + matrycaKopia.Length);
			Console.WriteLine("\n----------------------------\n");
			
			for(int i = matrycaKopia.Length; i > 0; i--)
			{
				Console.WriteLine("matrycakopia_lengh_poczatek przeb: " + matrycaKopia.Length);
				int licznik = count.Next(0, matrycaKopia.Length);
				Console.WriteLine("licznik: " + licznik);
				
				wynik += matrycaKopia[licznik];
				Console.WriteLine("wynik: " + wynik);
				
				matrycaKopia = matrycaKopia.Remove(licznik, 1);
				
				Console.WriteLine("matrycakopia: " + matrycaKopia);
				Console.WriteLine("matrycakopia_lengh: " + matrycaKopia.Length);
				Console.WriteLine("\n----------------------------\n");
			}
			
			Console.WriteLine(wynik);
			
			return wynik;
		}
	}
}
