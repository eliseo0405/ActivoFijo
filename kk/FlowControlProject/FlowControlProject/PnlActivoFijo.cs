using FlowControlProject.poco;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FlowControlProject
{
    public partial class PnlActivoFijo : Form
    {
        private ActivoFijo[] activosFijo;
        //List<ActivoFijo> activos;
        public PnlActivoFijo()
        {
            InitializeComponent();
            loadTipoActivo();
            //activos = new List<ActivoFijo>();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ReadActivoFijo();

            
        }

        private void ReadActivoFijo()
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            int index = cmbTipo.SelectedIndex;
            TipoActivo tipoActivo = (TipoActivo)Enum.GetValues(typeof(TipoActivo)).GetValue(index);
            //TipoActivo tipo = index == 0 ? TipoActivo.Edificio :
            //                  index == 1 ? TipoActivo.Vehiculo :
            //                  index == 2 ? TipoActivo.Mobiliario :
            //                  index == 3 ? TipoActivo.Maquinaria :
            //                  TipoActivo.Equipo_Computo;

            decimal.TryParse(txtValor.Text, out decimal valor);
            decimal.TryParse(txtValorSalv.Text, out decimal valorsalv);


            ActivoFijo af = new ActivoFijo()
            {
                Codigo = codigo,
                Nombre = nombre,
                Tipo = tipoActivo,
                ValorActivo = valor,
                ValorSalvamento = valorsalv,


            };

            activosFijo = AddElement(activosFijo, af);
            dgvActivos.DataSource = activosFijo;
            MessageBox.Show("Activo agregado correctamente :D");
        }

        private ActivoFijo[] AddElement(ActivoFijo[] activos, ActivoFijo af)
        {
            if(activos == null)
            {
                activos = new ActivoFijo[1];
                activos[0] = af;
                return activos;
            }
            ActivoFijo[] temp = new ActivoFijo[activos.Length +1];
            Array.Copy(activos, temp, activos.Length);
            temp[temp.Length - 1] = af;

            return temp;
        }

        private void loadTipoActivo()
        {
            cmbTipo.Items.AddRange(Enum.GetValues(typeof(TipoActivo)).Cast<object>().ToArray());
            cmbTipo.SelectedIndex = 0;
        }


        private void txtCodigo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                txtCodigo.BackColor = Color.Pink;
                e.Cancel = true;
            }
            else
            {
                txtCodigo.BackColor = Color.White;
            }
        }

        private void PnlActivoFijo_Load(object sender, EventArgs e)
        {
          
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            txtCodigo.Text  = "";
            txtNombre.Text = "";
            txtValor.Text = "";
            txtValorSalv.Text = "";
            cmbTipo.SelectedIndex = 0;
            cmbMetodo.SelectedIndex = 0;
        }
    }
}
