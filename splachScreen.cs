
using System;
using System.Drawing;
using System.Windows.Forms;

namespace koder
{
	/// <summary>
	/// Description of splachScreen.
	/// </summary>
	public partial class splachScreen : Form
	{
		public splachScreen()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			progressBar1.Increment(1);
			if(progressBar1.Value == 120) {timer1.Stop(); Close();}
			
		}
	}
}
