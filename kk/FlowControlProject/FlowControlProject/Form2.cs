using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowControlProject
{
    public partial class Form2 : Form
    {
        private List<int> numeros;
        public Form2()
        {
            InitializeComponent();
            numeros = new List<int>();
        }

        private int? getValue(string value)
        {
            if(int.TryParse(value,out int v))
            {
                return v;
            }
            return null;
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            int? value = getValue(txtNum.Text);
            if (e.KeyCode == Keys.Enter)
            {
                
                if (value == null)
                {
                    return;
                }

                numeros.Add(value ?? 0);
                txtNum.Text = "";
                if (numeros.Count == 10)
                {
                    txtNum.Enabled = false;
                    Sqr();
                    return;
                }
            }
        }

        private void Sqr()
        {
            long result = 0;

            //FOR
            //for(int i= 0; i< numeros.Count; i++)
            //{
            //    result += (long)Math.Pow(numeros.ElementAt(i), 2);
            //    txtResult.AppendText($"{numeros.ElementAt(i)}² = {Math.Pow(numeros.ElementAt(i), 2)}"+ Environment.NewLine);
            //}

            //FOREACH
            //foreach (int i in numeros)
            //{
            //    result += (long) Math.Pow(i,2);
            //    txtResult.AppendText($"{i}² = {Math.Pow(i, 2)}"+ Environment.NewLine);
            //}

            //LAMDA
            result = (long)numeros.Select(i => Math.Pow(i, 2)).Sum();
            numeros.ForEach(i => txtResult.AppendText($"{i}² = {Math.Pow(i, 2)}" + Environment.NewLine));


            //WHILE
            //int i = 0;
            //while(i < numeros.Count)
            //{
            //    result += (long)Math.Pow(numeros.ElementAt(i), 2);
            //    txtResult.AppendText($"{numeros.ElementAt(i)}² = {Math.Pow(numeros.ElementAt(i), 2)}"+ Environment.NewLine);
            //    i++;
            //}

            //DO-WHILE
            //int i = 0;
            //do
            //{
            //    result += (long)Math.Pow(numeros.ElementAt(i), 2);
            //    txtResult.AppendText($"{numeros.ElementAt(i)}² = {Math.Pow(numeros.ElementAt(i), 2)}" + Environment.NewLine);
            //    i++;
            //} while (i < numeros.Count);

            txtResult.AppendText($"Total = \"{result}\"");
        }
    }
}
