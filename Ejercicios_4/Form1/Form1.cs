using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Saludo_Click(object sender, EventArgs e)
        {
            Form2 boton = new Form2();
            this.Hide();
            boton.saludo_nya.Text += (this.box_Nombre.Text + " " +  this.box_Apellido.Text);  
            boton.ShowDialog();  
        }
        
    }
}
