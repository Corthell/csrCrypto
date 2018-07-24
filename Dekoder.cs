using System;
using System.Windows.Forms;

namespace koder
{

	public class Dekoder : MsgCrypt
	{
		
//-------------------------------------------------------------------------------------------------------	
		
		public static string dekoduj(char znak, string wejTextRaw) // główna funkcja dekodująca!!!
		{
            string matrycaTemp = "";
            string textWyj = "";
            string wejText;
			int klucz = 0;

            wejText = znajdzKlucz(ref klucz, znak, wejTextRaw);

            matrycaTemp = MsgCrypt.zworcKod(klucz);

            for (int i = 0; i < wejText.Length; i++)
            {
                for (int j = 0; j < matrycaTemp.Length; j++)
                {
                    if (wejText[i] == matrycaTemp[j])
                    {
                        textWyj += matryca[j];
                        continue;
                    }
                }
            }
			
            return textWyj;
		}
		
//-------------------------------------------------------------------------------------------------------
		
		static string znajdzKlucz(ref int klucz, char znak, string textWej)
		{
			string []tabPartKlucz = new string[3]; //miejsce na podzielony text wej (w celu uzyskania klucza).
			string textWyj;
			string tempKlucz;
			
			if(textWej.Contains("í")){
			   	
				tabPartKlucz = textWej.Split(znak);	//dzielenie textWej na 3 tab(środkowa z kluczem!).
				
			 }
			 else{
			 	
				MessageBox.Show("Błedny format danych wejściowych!", "Decoding Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
			 	return "";
			 }
			
			tempKlucz= tabPartKlucz[1];// odeseparowany klucz(np: 
			tabPartKlucz[1] = "";
			
			klucz = Convert.ToInt32(tempKlucz);
			return textWyj = String.Concat(tabPartKlucz);
		}
		
//-------------------------------------------------------------------------------------------------------	

	}
}
