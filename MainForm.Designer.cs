/*
 * Created by SharpDevelop.
 * User: mecalux1.1
 * Date: 2014-09-16
 * Time: 16:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace koder
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.kopiuj = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Wytnij = new System.Windows.Forms.ToolStripMenuItem();
			this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.szyfruj = new System.Windows.Forms.Button();
			this.generuj = new System.Windows.Forms.Button();
			this.wyczysc = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.butWklej = new System.Windows.Forms.Button();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Wytnij2 = new System.Windows.Forms.ToolStripMenuItem();
			this.Wklej2 = new System.Windows.Forms.ToolStripMenuItem();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.richTextBox4 = new System.Windows.Forms.RichTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.butDeszyfruj = new System.Windows.Forms.Button();
			this.wyszysc2 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oProgramieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.etSzyfrator = new System.Windows.Forms.Label();
			this.etKlodka = new System.Windows.Forms.PictureBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.contextMenuStrip2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.etKlodka)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tabControl1.Location = new System.Drawing.Point(12, 57);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(651, 476);
			this.tabControl1.TabIndex = 14;
			this.tabControl1.TabStop = false;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.kopiuj);
			this.tabPage1.Controls.Add(this.richTextBox1);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.richTextBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(643, 447);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Szyfrowanie";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(525, 276);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(17, 17);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// kopiuj
			// 
			this.kopiuj.Location = new System.Drawing.Point(543, 269);
			this.kopiuj.Name = "kopiuj";
			this.kopiuj.Size = new System.Drawing.Size(75, 23);
			this.kopiuj.TabIndex = 8;
			this.kopiuj.TabStop = false;
			this.kopiuj.Text = "Kopiuj";
			this.kopiuj.UseVisualStyleBackColor = true;
			this.kopiuj.Click += new System.EventHandler(this.button1_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.richTextBox1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.richTextBox1.Location = new System.Drawing.Point(18, 118);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(606, 128);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.Wytnij,
									this.wklejToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(109, 48);
			// 
			// Wytnij
			// 
			this.Wytnij.Name = "Wytnij";
			this.Wytnij.Size = new System.Drawing.Size(108, 22);
			this.Wytnij.Text = "Wytnij";
			this.Wytnij.Click += new System.EventHandler(this.WytnijClick);
			// 
			// wklejToolStripMenuItem
			// 
			this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
			this.wklejToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.wklejToolStripMenuItem.Text = "Wklej";
			this.wklejToolStripMenuItem.Click += new System.EventHandler(this.WklejToolStripMenuItemClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(18, 278);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Wynik";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(18, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tekst do zakodowania";
			// 
			// richTextBox2
			// 
			this.richTextBox2.ContextMenuStrip = this.contextMenuStrip1;
			this.richTextBox2.Enabled = false;
			this.richTextBox2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.richTextBox2.Location = new System.Drawing.Point(18, 298);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(606, 128);
			this.richTextBox2.TabIndex = 5;
			this.richTextBox2.TabStop = false;
			this.richTextBox2.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.szyfruj);
			this.groupBox1.Controls.Add(this.generuj);
			this.groupBox1.Controls.Add(this.wyczysc);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(618, 70);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Operacje";
			// 
			// szyfruj
			// 
			this.szyfruj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.szyfruj.Enabled = false;
			this.szyfruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.szyfruj.ForeColor = System.Drawing.Color.Red;
			this.szyfruj.Location = new System.Drawing.Point(6, 19);
			this.szyfruj.Name = "szyfruj";
			this.szyfruj.Size = new System.Drawing.Size(105, 45);
			this.szyfruj.TabIndex = 2;
			this.szyfruj.Text = "Szyfruj";
			this.szyfruj.UseVisualStyleBackColor = true;
			this.szyfruj.Click += new System.EventHandler(this.SzyfrujClick);
			// 
			// generuj
			// 
			this.generuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.generuj.Image = ((System.Drawing.Image)(resources.GetObject("generuj.Image")));
			this.generuj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.generuj.Location = new System.Drawing.Point(117, 33);
			this.generuj.Name = "generuj";
			this.generuj.Size = new System.Drawing.Size(81, 31);
			this.generuj.TabIndex = 1;
			this.generuj.Text = " Generuj ";
			this.generuj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.generuj.UseVisualStyleBackColor = true;
			this.generuj.Click += new System.EventHandler(this.GenerujClick);
			// 
			// wyczysc
			// 
			this.wyczysc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wyczysc.Location = new System.Drawing.Point(537, 33);
			this.wyczysc.Name = "wyczysc";
			this.wyczysc.Size = new System.Drawing.Size(75, 31);
			this.wyczysc.TabIndex = 12;
			this.wyczysc.TabStop = false;
			this.wyczysc.Text = "Wyczyść";
			this.wyczysc.UseVisualStyleBackColor = true;
			this.wyczysc.Click += new System.EventHandler(this.WyczyscClick);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.tabPage2.Controls.Add(this.pictureBox2);
			this.tabPage2.Controls.Add(this.butWklej);
			this.tabPage2.Controls.Add(this.richTextBox3);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.richTextBox4);
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(643, 447);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Deszyfrowanie";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox2.InitialImage = null;
			this.pictureBox2.Location = new System.Drawing.Point(525, 96);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(17, 17);
			this.pictureBox2.TabIndex = 16;
			this.pictureBox2.TabStop = false;
			// 
			// butWklej
			// 
			this.butWklej.Location = new System.Drawing.Point(543, 89);
			this.butWklej.Name = "butWklej";
			this.butWklej.Size = new System.Drawing.Size(75, 23);
			this.butWklej.TabIndex = 15;
			this.butWklej.Text = "Wklej";
			this.butWklej.UseVisualStyleBackColor = true;
			this.butWklej.Click += new System.EventHandler(this.ButWklejClick);
			// 
			// richTextBox3
			// 
			this.richTextBox3.ContextMenuStrip = this.contextMenuStrip2;
			this.richTextBox3.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.richTextBox3.Location = new System.Drawing.Point(18, 118);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(606, 128);
			this.richTextBox3.TabIndex = 10;
			this.richTextBox3.Text = "";
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.Wytnij2,
									this.Wklej2});
			this.contextMenuStrip2.Name = "contextMenuStrip1";
			this.contextMenuStrip2.Size = new System.Drawing.Size(109, 48);
			// 
			// Wytnij2
			// 
			this.Wytnij2.Name = "Wytnij2";
			this.Wytnij2.Size = new System.Drawing.Size(108, 22);
			this.Wytnij2.Text = "Wytnij";
			this.Wytnij2.Click += new System.EventHandler(this.Wytnij2Click);
			// 
			// Wklej2
			// 
			this.Wklej2.Name = "Wklej2";
			this.Wklej2.Size = new System.Drawing.Size(108, 22);
			this.Wklej2.Text = "Wklej";
			this.Wklej2.Click += new System.EventHandler(this.Wklej2Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(18, 278);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 17);
			this.label3.TabIndex = 14;
			this.label3.Text = "Wynik";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(18, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(163, 17);
			this.label4.TabIndex = 13;
			this.label4.Text = "Tekst do odkodowania";
			// 
			// richTextBox4
			// 
			this.richTextBox4.ContextMenuStrip = this.contextMenuStrip1;
			this.richTextBox4.Enabled = false;
			this.richTextBox4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.richTextBox4.Location = new System.Drawing.Point(18, 298);
			this.richTextBox4.Name = "richTextBox4";
			this.richTextBox4.Size = new System.Drawing.Size(606, 128);
			this.richTextBox4.TabIndex = 12;
			this.richTextBox4.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.butDeszyfruj);
			this.groupBox2.Controls.Add(this.wyszysc2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox2.Location = new System.Drawing.Point(6, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(618, 70);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Operacje";
			// 
			// butDeszyfruj
			// 
			this.butDeszyfruj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.butDeszyfruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.butDeszyfruj.ForeColor = System.Drawing.Color.Teal;
			this.butDeszyfruj.Location = new System.Drawing.Point(6, 19);
			this.butDeszyfruj.Name = "butDeszyfruj";
			this.butDeszyfruj.Size = new System.Drawing.Size(130, 45);
			this.butDeszyfruj.TabIndex = 6;
			this.butDeszyfruj.Text = "Deszyfruj";
			this.butDeszyfruj.UseVisualStyleBackColor = true;
			this.butDeszyfruj.Click += new System.EventHandler(this.ButDeszyfrujClick);
			// 
			// wyszysc2
			// 
			this.wyszysc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wyszysc2.Location = new System.Drawing.Point(537, 33);
			this.wyszysc2.Name = "wyszysc2";
			this.wyszysc2.Size = new System.Drawing.Size(75, 31);
			this.wyszysc2.TabIndex = 1;
			this.wyszysc2.Text = "Wyczyść";
			this.wyszysc2.UseVisualStyleBackColor = true;
			this.wyszysc2.Click += new System.EventHandler(this.wyszysc2_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.menuToolStripMenuItem,
									this.oProgramieToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(675, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.zakończToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// zakończToolStripMenuItem
			// 
			this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
			this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.zakończToolStripMenuItem.Text = "Zakończ";
			this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
			// 
			// oProgramieToolStripMenuItem
			// 
			this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.manualToolStripMenuItem,
									this.oProgramieToolStripMenuItem1});
			this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
			this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.oProgramieToolStripMenuItem.Text = "Pomoc";
			// 
			// manualToolStripMenuItem
			// 
			this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
			this.manualToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.manualToolStripMenuItem.Text = "Manual";
			this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
			// 
			// oProgramieToolStripMenuItem1
			// 
			this.oProgramieToolStripMenuItem1.Name = "oProgramieToolStripMenuItem1";
			this.oProgramieToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
			this.oProgramieToolStripMenuItem1.Text = "O programie";
			this.oProgramieToolStripMenuItem1.Click += new System.EventHandler(this.OProgramieToolStripMenuItem1Click);
			// 
			// etSzyfrator
			// 
			this.etSzyfrator.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.etSzyfrator.ForeColor = System.Drawing.Color.Goldenrod;
			this.etSzyfrator.Location = new System.Drawing.Point(507, 37);
			this.etSzyfrator.Name = "etSzyfrator";
			this.etSzyfrator.Size = new System.Drawing.Size(162, 32);
			this.etSzyfrator.TabIndex = 2;
			this.etSzyfrator.Text = "[msg]Crypt";
			// 
			// etKlodka
			// 
			this.etKlodka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("etKlodka.BackgroundImage")));
			this.etKlodka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.etKlodka.Location = new System.Drawing.Point(471, 30);
			this.etKlodka.Name = "etKlodka";
			this.etKlodka.Size = new System.Drawing.Size(45, 40);
			this.etKlodka.TabIndex = 7;
			this.etKlodka.TabStop = false;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 545);
			this.Controls.Add(this.etKlodka);
			this.Controls.Add(this.etSzyfrator);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "[msg]Crypt 1.0  RTM";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.contextMenuStrip2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.etKlodka)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem Wklej2;
		private System.Windows.Forms.ToolStripMenuItem Wytnij2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
		private System.Windows.Forms.Button wyszysc2;
		private System.Windows.Forms.Button butDeszyfruj;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RichTextBox richTextBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.Button butWklej;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ToolStripMenuItem Wytnij;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button szyfruj;
		private System.Windows.Forms.Label etSzyfrator;
		private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button generuj;
		private System.Windows.Forms.Button wyczysc;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem1;
        private System.Windows.Forms.Button kopiuj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox etKlodka;
        private System.Windows.Forms.NotifyIcon notifyIcon1;

	}
}
