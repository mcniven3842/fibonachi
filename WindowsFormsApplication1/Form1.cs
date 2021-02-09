using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero, fibo1, fibo2, i;
            string Cadena;
            StringBuilder builder = new StringBuilder();

            do
            {
                numero = int.Parse(textBox1.Text);
            } while (numero <= 1);
            string[] myArray = new string[numero];

            fibo1 = 1;
            fibo2 = 1;
            myArray[0] = Convert.ToString(fibo1);
            myArray[1] = Convert.ToString(fibo2);
            for (i = 2; i < numero; i++)
            {
                fibo2 = fibo1 + fibo2;
                fibo1 = fibo2 - fibo1;
                myArray[i] = Convert.ToString(fibo2);
            }

            for (int x = 0; x < myArray.Length; x++)
            {
                builder = builder.Append(myArray[x]);
                builder = builder.Append(" ");
            }

            Cadena = builder.ToString();
            label3.Text = Cadena;
        }
    }
}
