using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBoxMateria.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMateria.Visible = true;
        }

        private void boton_Saludo_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMateria.ForeColor = ComboBox.DefaultForeColor;
        }
    }
}
