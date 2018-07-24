
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;


namespace koder
{

	public partial class MainForm : Form
	{
		Random losuj = new Random();
		MsgCrypt start = new MsgCrypt();

		public MainForm()
		{
			Thread t = new Thread(new ThreadStart(ekran));
			t.Start();
			Thread.Sleep(5000);
			InitializeComponent();
			t.Abort();
			
		}
		
		public void ekran()
		{
			Application.Run(new splachScreen());
		}
//   #############################################################################################################################
//   -----------------------------------------------------------------------------------------------------------------------------
        void SzyfrujClick(object sender, EventArgs e)
        {
            int nrTab = losuj.Next(0, 31);
            
            if (richTextBox1.Text != "")
            {
                richTextBox2.Text = start.koduj(nrTab.ToString(), MsgCrypt.zworcKod(nrTab), richTextBox1.Text);
                szyfruj.Enabled = false;
            }
            else
            {
                MessageBox.Show("Brak danych do zakodowania!", "Coding Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
//--------------------------------------------------------------------------------------------------------------------------------	

        void GenerujClick(object sender, EventArgs e)
        {
            szyfruj.Enabled = true;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }
		
		void WyczyscClick(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			richTextBox2.Clear();
		}
		
		void WytnijClick(object sender, EventArgs e)
		{
			richTextBox1.SelectAll();
			richTextBox1.Cut();
		}
		
		void WklejToolStripMenuItemClick(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.SelectAll();
            richTextBox2.Copy();
            richTextBox2.DeselectAll();
        }


//################################################################################################################################
//--------------------------------------------------------------------------------------------------------------------------------
	
	 //zrobic warunek sprawdzajacy czy jest znak poczatku klucza... jeśli nie ma niech pokaze wiadomość: zły format textu czy coś :)
      
		void ButDeszyfrujClick(object sender, EventArgs e)
		{
			if (richTextBox3.Text != "")
            {
				richTextBox4.Text = Dekoder.dekoduj('í', richTextBox3.Text);  
            }
            else
            {
                 MessageBox.Show("Brak danych do odkodowania!", "Decoding Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
		 
//--------------------------------------------------------------------------------------------------------------------------------

		void ButWklejClick(object sender, EventArgs e) //zdarzenie dla guzika wklej
		{
			richTextBox3.Paste(); //wklejenie textu do richboxa3.
		}

		void Wytnij2Click(object sender, EventArgs e)
		{
			richTextBox3.SelectAll();
			richTextBox3.Cut();
		}
		
		void Wklej2Click(object sender, EventArgs e)
		{
			richTextBox3.Paste();
		}

        private void wyszysc2_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = "";
            richTextBox4.Text = "";
        }


        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); //zamykanie programu z menu opcją zamknij.
        }

		
		void OProgramieToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Form1 oProgramie = new Form1();
			oProgramie.Show();
		}

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
        	Help pomoc = new Help();
        	pomoc.Show();
        }
	}
}