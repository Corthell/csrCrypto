using System;
using System.Windows.Forms;

namespace koder
{

	public class MsgCrypt
	{
		
		Random count = new Random();
		protected static string []tabcode = new string[31];
		string wynik = "";
		string wynikKodowania = "";
		public static string matryca = @"abcdefghijklmnoprstuwxyzćżźńąśłęóŻŹĆŃĄŚŁĘÓABCDEFGHIJKLMNOPRSTUWXYZ /""1234567890?>!@#$%^&*()_+=][}{|<-:.,~'";
		string matrycaKopia;

//-----------------------------------------------------------------------------------------------------------------------------------------

        public string koduj(string klucz, string lokal_tab_code, string sourceText)
        {
            wynikKodowania = "";

            for (int i = 0; i < sourceText.Length; i++)
            {
                for (int j = 0; j < matryca.Length; j++)
                {
                    if (sourceText[i] == matryca[j])
                    {
                        wynikKodowania += lokal_tab_code[j];
                        continue;
                    }
                }
            }
		//generowanie gotowego textu zakodowanego. Count.next... losuje pozycje gdzie ma znależć się 'í'+klucz+'í'. 
        return wynikKodowania = wynikKodowania.Insert(count.Next(0, sourceText.Length), 'í' + klucz + 'í');
        }

//-----------------------------------------------------------------------------------------------------------------------------------------

        public static string zworcKod(int nr)
		{
			 	
			tabcode[0] = "Ć5.Ży'|&E=2l@7Ń~ds+ąoŁSÓ6[kóĄj 1hCIcNń(bPĘ>-RKAT:Dź08łf#FaY}ęBW{^$p4MX<?z3!U,w)OZ9ier]HgŚćxJu_śżG*tŹLn%m";
			tabcode[1] = "T[ńlN]bhpg'ZyM}zD+_śE0,kŹ~2@Ń.=x>-9#Gnźf3ŚćXKCWĆąJwóę$Y<?5:BStuOL Rżr8ms4{Óe&P|!ŁFUdHIcĘ167i(aĄj*ł)%oŻA^";
			tabcode[2] = "pd(ś&r}f1xgnRm~=a{Jy5YsjÓODŁŻ 8Ę4uę2[IX@K'ĄPLŚ.,WbĆB9>-t)i+HN$kUł^E*źńóG]#_oCż6TąeS30F<?h:MŃ%z7AZ|!Źlćcw";
			tabcode[3] = "ązgokJHN RĆńrF.ćA(8=!~Lź0Ób3śmd'óY[@U^9ŻSTC,MBc*y{GDu1Ł:WlItO&fŚ)ęĘwe5Z6ł7]%sxn>-hŹ}jiż_+K$XĄ2a<?4ŃP#p|E";
			tabcode[4] = "a79SĆ$nI2P3ń]Ł:LW|ydÓ'hĄŚś[K1ĘŻxjY.,egFp~H4łZóXu=(c5UO %G)J8+żązŃtŹ>-kźę6T_AECms}ćfDo<?0wB*i^!#lbNrM{R@&";
			tabcode[5] = "zźó&ćĘ8ąiuWż{tUJm$anŁęĆ6XEMSyÓ3|c*k#gŃł)KT~eP]Gx(1'R:_=r>-l2[+Lw9!pd F<?Yńhj0.,B7IoO5Ż4@sŹN}DŚZ%^fbHĄśAC";
			tabcode[6] = "Ć5Ży|&E2>-l@7Ńds+ąoŁS~Ó6[kó=Ąj 1hCIcNń(bPĘR'KAT:<?Dź08łf#FaY}ęBW{^$p4MXz3!Uw)OZ9ier]HgŚ.,ćxJu_śżG*tŹLn%m";
			tabcode[7] = "śLłcżym~!%rpĄgI=>-]4z8hUźą'<?BŚ0)Ć+[|(1kjŹu*ZK_e9iFćAYCńET2a@6fs:ęÓ^x#$óGw}o,W3MŻnODt&dJŃ{SPĘŁ HNlb7.XR5";
			tabcode[8] = "${uy9o3x'HPkD^źŚ.(t%<?@r|JŹIaY+>-S)U!dg,lZĄ[XśzÓWm&ć10c_Ż6hL:fęKOżnąjŃ82~iA Gb]EFN=4łŁBóń#*TC7RwepĘ}ĆMs5";
			tabcode[9] = "ęĄńnm.ŻjG<?_CŹM,|x9*lŚ]źĆÓ7a{Zł puWcĘ'YE^iŃs[4F!hL>-ćH%ąO2)P(U}Syo=DbBś50żrŁ@&68k:K$JT~AXgózRI3wt+fe#d1N";
			tabcode[10] = "ąkiługjeÓ4&5LĄ=7Ł}0.Dy<?,'NcYwm%3ĆŹU{WGfź@HŚę rCa]Z:_lżnŃd6KEśJ)zA~Ę!8#9xńOo>-[(RM$hsb2St+XćBF|*^P1óIpTŻ";
			tabcode[11] = "Ć5Ży|.,&E2l@7Ńds+ąoŁSÓ=6[kóĄj 1hC<?IcNń(bPĘRKAT:Dź08łf#~FaY}ęBW{'^$p4M>-Xz3!Uw)OZ9ier]HgŚćxJu_śżG*tŹLn%m";
			tabcode[12] = "Ę zrA5C{ąp4L+Ó.,yx3ĆiDYUBŚ$źw#=hRęEKFX>-Ł!Nf<?óG7^'~dTł:OŹ0ZmcM6&s(ńkH1_8)ubĄ%*Żlt9|}@ć2śnPżo[eŃ]SWaJgIj";
			tabcode[13] = "0#i<?xąó>-H4PźA+śJZ]&:*!3uDYX')dT}~KB|ć9nk lEh5[1eÓsfĄj^ł_żgoIŻĆFŃz72{UŁMŚńGpWĘ8b@ŹCrN$.,OLawR6m=%ę(tycS";
			tabcode[14] = "{s9'ąhR<?SkL=6N>-FEbźi*t}H x~5.Yu7ŹZ210fż+jPUom_ćBcł4ezśDK[ę3X,r#ĘnlĄĆ|Ó&:IóO)TŁ!dgŃyńJ]wWpŚA%8G@^ŻC$a(M";
			tabcode[15] = "źjrń=u0Sł%my~sWĘ{P]n[6k4ć<?hEpZ!OB>-^YęÓbga,ą8Ś}$ĄdLŁ5z'@2óDlcM.K)i#fx& GĆR+ŻC(T3AU*śFwNoIJe|żX7Ń:HŹ_19t";
			tabcode[16] = "no[.~,6:BG#)pI=bDuzkZH TU0!y@}Oę^RMńSŻXjŚŃFW(Lf3NŹge>-YłCĄ5hJźż8]c%<?r|xAtóiE'l4ą+d9a7s1Ę_K2Łwć$P*ś{ÓĆ&m";
			tabcode[17] = ".,2T@sŚh:LMZżCXł~ISwkJoź=DEmŻ !ąrć]0ĘxbŁ)_nę*{g9%3+yń1OP(Ć'HtjY$7śWŃó6FcAzi8Ź}p>-uÓG5Ą<?4#NaK^l[dU&feBR|";
			tabcode[18] = "sN8dŻWD[j}ćXYi.,z^EŃug9Z)SĘT:5F+Gy~Jżk3L=P]|tI*AŹUn_Ć%10!źoŁOhHRK2ślę{cł(Śr@ąm7p4ńf6ÓaóMw Ąeb'>-#xC<?B$&";
			tabcode[19] = "Ho7jÓM6{)T^ŃRBa5ź+@uOŻ![ J#.,śóĘ98m*će|x1rWdĆ]ńzZ2f4U~C=pcSlł$Ź%NĄ>-FŚ0gwYn}XbsIDG:&E<?ę3'iżAPyKhtą(k_LŁ";
			tabcode[20] = "śE{nżdbSkc'3ŃNLrtFy_eYm:2IApR}ńZoąućja.,8ÓG$>-KłWg[lXhiĄ]|*<?%ŻMŚ4#(H =@ĘTxCŁsź9^Póę&J6U~B15+)OwŹz!7Df0Ć";
			tabcode[21] = "Ź$ę'sA@Wx{&GjE ZąeRkFĆ)Y(XÓ9móBŚ>-Uźa%ńLuw43żMf<?HO1SN5Ih|cnĘpŁJ:bK_.,DĄ*!Ń+ć0#zś8gyTŻi]=o27}t6r[łdl~^CP";
			tabcode[22] = "'sÓeRU0r7x(21Kzg>-mLbŚt%{uPopESD<?źZil6WXó:#ŻYĘŹ^yNjf&śOk=Ąh)ąĆGIJ~Ł3ę|ń84+ C_MćcTB.,!ŃF5aA]w$9*d}łż[Hn@";
			tabcode[23] = "fmŹNK:ćBĄ<?Łb>-^żPCR)c(A+'9hęZ&L|w=i}d%lEąś6@M5]Ć7TYDĘŃ0~Ś!S#guja*UŻxtńF{_pnrłoyG [Hź2$Ó,kWIXsJezO138ó.4";
			tabcode[24] = "I<?=4hŚU7>-łŻżLó1źwi&$ń[yŹ @ZzO_k)]:s~(rgxŃ0e'td3ę#śEj8}ÓB|*^Y5!Łlb2pD.,ĘKmWfo9JaąTĆNF{G6HnćPMcA+CĄR%XuS";
			tabcode[25] = "%ą_ńmX=cYi@Ą7x4~>-wÓ[+ś<?J,2b&9H!5R$EGżpŻęzDUźlBĘh3n.ufys(ŁdFMW*Ck8Ź]Ś^Oł'gT)I|{ćSoeŃ}r A6PL:jN#Z1ó0tKaĆ";
			tabcode[26] = "kRJCgW.x~@ć]jŁź,Śę+ńEBMś*#Ą4>-p&=i_fL<?ŹU${ ĆZOYI7tcdnXąÓPS}DA:u9m6^5h(rŻ30óŃNGK%2|łH8s'ĘżFToy1)b[z!awle";
			tabcode[27] = "Ó^gUą.ęx&9baj3FCOc0pŹwB~N #_XJ24śTo,*I>-YLmfź<?ó5+łDHnZŚr[Ę$Ć7dńĄ)Ł16si8Ń|]{!e%S@hA'GyućW:lKR(PMkŻztż}=E";
			tabcode[28] = "TH0RkNz4Wnd }óxAguLY2JPń$Fo8,ŃĄ%MićĆ{9Sf3CżÓŚ~#r>-_Ł+eą:5|('c*D!.GŻBźsśĘO1[tZŹh&l<?ębpKX6@)wj^7ałymE]IU=";
			tabcode[29] = "Ł}ŹU{WG0.Dy<?,'NcYwm%3ĆąkiługjeÓ4&5LĄ=7fź@HŚę rCa]Z:_lżnŃd6KEś+XćBF|*^P1óIpTŻJ)zA~Ę!8#9xńOo>-[(RM$hsb2St";
			tabcode[30] = "ZF@>-gp19M!yUĆŻjo_$ćdw}xBDP'cut*ĘęmÓŚ8+Sa ^5O6ią)3{(&YGŁz%CfóElINXŃ|H:[ńsź<?4KnĄ=śAłk2żrŹ.]T7W,eLh#JR~0b";
			
		return tabcode[nr];
		}
        
//-------------------------------------------------------------------------------------------------------------------------------------------
		public string generuj() //nie używane!.
		{
			matrycaKopia = matryca;
			
			for(int i = matrycaKopia.Length; i > 0; i--)
			{
				int licznik = count.Next(0, matrycaKopia.Length);
			
				wynik += matrycaKopia[licznik];
				
				matrycaKopia = matrycaKopia.Remove(licznik, 1);
			}
			
		return wynik;
		}
		
//-----------------------------------------------------------------------------------------------------------------------------------------
	
		public void generujTab(string []tab, int rozmiarTab) //nie używane.
		{
			for(int i = 0; i < rozmiarTab; i++)
			{
				matrycaKopia = matryca;
				
				for(int j = matrycaKopia.Length; j > 0; j--)
				{
					int licznik = count.Next(0, matrycaKopia.Length);
				
					wynik += matrycaKopia[licznik];
					
					matrycaKopia = matrycaKopia.Remove(licznik, 1);
				}
			
			tab[i] = wynik;
			wynik = "";
			}
		}
	}	
}
