<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormL
{
    public partial class Form1 : Form
    {
        private List<string> lista;
        private Dictionary<string, int> dicccionario;
        
        public Form1()
        {
            InitializeComponent();
            lista = new List<string>();
            dicccionario = new Dictionary<string, int>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Palabras(textBox1.Text);

            MessageBox.Show();
        }

        public void Palabras(string aux)
        {
            
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormL
{
    public partial class Form1 : Form
    {
        private List<string> lista;
        private Dictionary<string, int> dicccionario;
        
        public Form1()
        {
            InitializeComponent();
            lista = new List<string>();
            dicccionario = new Dictionary<string, int>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Palabras(textBox1.Text);

            MessageBox.Show();
        }

        public void Palabras(string aux)
        {
            
        }
    }
}
>>>>>>> 5b63a2e02c465abaafd091827697c2e99c3842c4
