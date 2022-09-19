using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormL
{
    public partial class Form1 : Form
    {
        private List<string> lista;
        private Dictionary<string, int> dic;
        
        public Form1()
        {
            InitializeComponent();
            lista = new List<string>();
            dic = new Dictionary<string, int>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContarPalabras(textBox1.Text);

            MessageBox.Show(Mostrar());
        }

        public void ContarPalabras(string text)
        {
            char[] caracteres = new char[] { ' ', ',', '.', ':', '\t', '\n' };
            lista.AddRange(text.Split(caracteres, StringSplitOptions.RemoveEmptyEntries));

            foreach (string word in lista)
            {
                if (!dic.ContainsKey(word) && word != " ")
                {
                    dic.Add(word, 1);
                }
                else
                {
                    dic[word] += 1;
                }
            }
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            string eliminar = "";

            while (i < 3)
            {
                foreach (KeyValuePair<string, int> elemento in dic)
                {
                    if (dic.Values.Max() == elemento.Value && i < 3)
                    {
                        eliminar = elemento.Key;
                        sb.AppendLine($"{elemento.Key}   {elemento.Value}");
                        break;
                    }
                }

                if (dic.Remove(eliminar))
                {
                    i++;
                }
            }

            return sb.ToString();
        }

    }
}
