using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace solucion
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		void Button1Click(object sender, System.EventArgs e)
		{
			
			if(textBox1.Text=="juan" && textBox2.Text =="hola")
			{
				MessageBox.Show("Bienvenido juan");
			}
			else {
				MessageBox.Show("No es valido");
			}
		}
	}
}
