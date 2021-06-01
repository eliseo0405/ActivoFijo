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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //ola
            int? edad = getEdad();
            if (edad == null)
            {
                //MessageBox.Show("Error, edad no es valida.");
                return;
            }
            string category = cmbCategory.SelectedItem.ToString();
            
            string Message = "No coinciden la edad y la categoria";
            switch (category)
            {
                case "Baby":
                    if(validateEdad(edad?? 0, 0, 4))
                    {
                        Message = "You are a baby";
                    }
                    break;
                case "Kids":
                    if (validateEdad(edad ?? 5, 5, 11))
                    {
                        Message = "You are a kid";
                    }
                    break;
                case "Teen":
                    if (validateEdad(edad ?? 12, 12, 17))
                    {
                        Message = "You are a teen";
                    }
                    break;
                case "Adult":
                    if (validateEdad(edad ?? 18, 18, 59))
                    {
                        Message = "You are an aldult person";
                    }
                    break;
                case "Old":
                    if (validateEdad(edad ?? 60, 60, 120))
                    {
                        Message = "You are an old person";
                    }
                    break;
            }

            MessageBox.Show(Message);
            
        }

        private int? getEdad()
        {
            if (int.TryParse(txtEdad.Text, out int edad))
            {
                return edad;
            }
            return int.MinValue;
        }

        private bool validateEdad(int edad, int min,int max)
        {
            if(edad>= min && edad <= max)
            {
                return true;
            }
            return false;
        }

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            txtEdad.Text = "";
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                txtEdad.Text = "Edad";
            }
        }
    }


}
