
namespace koder
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.etKlodka = new System.Windows.Forms.PictureBox();
			this.etSzyfrator = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.etKlodka)).BeginInit();
			this.SuspendLayout();
			// 
			// etKlodka
			// 
			this.etKlodka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("etKlodka.BackgroundImage")));
			this.etKlodka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.etKlodka.Location = new System.Drawing.Point(23, 12);
			this.etKlodka.Name = "etKlodka";
			this.etKlodka.Size = new System.Drawing.Size(45, 40);
			this.etKlodka.TabIndex = 9;
			this.etKlodka.TabStop = false;
			// 
			// etSzyfrator
			// 
			this.etSzyfrator.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.etSzyfrator.ForeColor = System.Drawing.Color.Goldenrod;
			this.etSzyfrator.Location = new System.Drawing.Point(59, 19);
			this.etSzyfrator.Name = "etSzyfrator";
			this.etSzyfrator.Size = new System.Drawing.Size(162, 32);
			this.etSzyfrator.TabIndex = 8;
			this.etSzyfrator.Text = "[msg]Crypt";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "Szyfrator wiadomości tekstowych";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(82, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "ver 1.0 RTM";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(12, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Copyright © Michał Dudek 2014";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(157, 130);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(75, 16);
			this.linkLabel1.TabIndex = 13;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "csr@interia.eu";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(244, 155);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.etKlodka);
			this.Controls.Add(this.etSzyfrator);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "O programie";
			((System.ComponentModel.ISupportInitialize)(this.etKlodka)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label etSzyfrator;
		private System.Windows.Forms.PictureBox etKlodka;
		private System.Windows.Forms.Label label1;
	}
}
