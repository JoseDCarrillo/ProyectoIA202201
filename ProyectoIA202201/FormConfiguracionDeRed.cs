using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIA202201
{
    public partial class FormConfiguracionDeRed : Form
    {
        public FormConfiguracionDeRed()
        {
            InitializeComponent();

            cmbTipoRed.Items.Add("UNICAPA");
            cmbTipoRed.Items.Add("MULTICAPA");
            cmbTipoRed.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cmbTipoRed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoRed.Text.Equals("UNICAPA"))
            {
                MessageBox.Show("es unicapa");
            }
            if (cmbTipoRed.Text.Equals("MULTICAPA"))
            {
                MessageBox.Show("es Multicapa");
            }
        }
    }
}
