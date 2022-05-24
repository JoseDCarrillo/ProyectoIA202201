using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIA202201
{
    public partial class FormConfiguracionDeRed : Form
    {
        CargueArchivoService cargueService;
        CargarArchivoResponse response1;
        public FormConfiguracionDeRed(CargarArchivoResponse response)
        {
            InitializeComponent();
            this.response1 = response;
            
            StreamWriter sw = new StreamWriter("C:\\Users\\USER\\Documents\\Texto.txt");

            cargueService = new CargueArchivoService(sw);
            cmbTipoRed.Items.Add("UNICAPA");
            cmbTipoRed.Items.Add("MULTICAPA");
            cmbTipoRed.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbTipoNeurona.Items.Add("PERCEPTRON");
            cmbTipoNeurona.Items.Add("ADALINE");
            cmbTipoNeurona.Items.Add("BACKPROPAGATION");
            cmbTipoNeurona.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbNumCapas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgoritmoEntrenamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuncionActivacion.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cmbTipoRed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoRed.Text.Equals("UNICAPA"))
            {
                

                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult resultadoForm = MessageBox.Show("Eligió Unicapa, ¿Desea continuar?", "Mensaje Informativo", botones, MessageBoxIcon.Question);
                if (resultadoForm == DialogResult.Yes)
                {
                     
                    cargueService.PesosYUmbralesUnicapa(response1.PatronesCarga[1].Entradas.Count, response1.PatronesCarga[1].Salidas.Count);

                }
                else
                {
                    
                }
            }
            if (cmbTipoRed.Text.Equals("MULTICAPA"))
            {
                

                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult resultadoForm = MessageBox.Show("Eligió Multicapa, ¿Desea continuar?", "Mensaje Informativo", botones, MessageBoxIcon.Question);
                if (resultadoForm == DialogResult.Yes)
                {
                    //Aqui va el servicio del multicapa 
                    cargueService.PesosYUmbralesMulticapa(response1.PatronesCarga[1].Entradas.Count, response1.PatronesCarga[1].Salidas.Count);
                    
                }
                else
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbNumCapas.SelectedIndex == 0)
            {
                int numNeuronasCap1 = int.Parse(NumNeuronasCap1.Text.ToString());
                cargueService.PesosYUmbralesMulticapa(response1.PatronesCarga[1].Entradas.Count, numNeuronasCap1);
                cargueService.PesosYUmbralesMulticapa(numNeuronasCap1, response1.PatronesCarga[1].Salidas.Count);
                cargueService.CloseFile();

            }

            if (cmbNumCapas.SelectedIndex == 1)
            {
                int numNeuronasCap1 = int.Parse(NumNeuronasCap1.Text);
                int numNeuronasCap2 = int.Parse(NumNeuronasCap2.Text);
                
                cargueService.PesosYUmbralesMulticapa(response1.PatronesCarga[1].Entradas.Count, numNeuronasCap1);
                cargueService.PesosYUmbralesMulticapa(numNeuronasCap1, numNeuronasCap2);
                cargueService.PesosYUmbralesMulticapa(numNeuronasCap2, response1.PatronesCarga[1].Salidas.Count);
                cargueService.CloseFile();

            }
            if (cmbNumCapas.SelectedIndex == 2)
            {
                int numNeuronas1 = int.Parse(NumNeuronasCap1.Text);
                int numNeuronas2 = int.Parse(NumNeuronasCap2.Text);
                int numNeuronas3 = int.Parse(NumNeuronasCap3.Text);

                cargueService.PesosYUmbralesMulticapa(response1.PatronesCarga[1].Entradas.Count, numNeuronas1);
                cargueService.PesosYUmbralesMulticapa(numNeuronas1, numNeuronas2);
                cargueService.PesosYUmbralesMulticapa(numNeuronas2, numNeuronas3);
                cargueService.PesosYUmbralesMulticapa(numNeuronas3, response1.PatronesCarga[1].Salidas.Count);
                cargueService.CloseFile();
            }

        }

        private void cmbTipoNeurona_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFuncionActivacion.DataSource = null;
            cmbFuncionActivacion.Items.Clear();
            if (cmbTipoNeurona.Text== "PERCEPTRON")
            {
                cmbFuncionActivacion.DataSource = null;
                cmbFuncionActivacion.Items.Clear();

                cmbFuncionActivacion.Items.Add("ESCALON");


                cmbAlgoritmoEntrenamiento.DataSource = null;
                cmbAlgoritmoEntrenamiento.Items.Clear();

                cmbAlgoritmoEntrenamiento.Items.Add("REGLA DELTA");


            }
            if (cmbTipoNeurona.Text == "ADALINE")
            {
                cmbFuncionActivacion.DataSource = null;
                cmbFuncionActivacion.Items.Clear();

                cmbFuncionActivacion.Items.Add("LINEAL");

                cmbAlgoritmoEntrenamiento.DataSource = null;
                cmbAlgoritmoEntrenamiento.Items.Clear();

                cmbAlgoritmoEntrenamiento.Items.Add("REGLA DELTA");
            }
            if (cmbTipoNeurona.Text == "BACKPROPAGATION")
            {
                cmbFuncionActivacion.DataSource = null;
                cmbFuncionActivacion.Items.Clear();

                cmbFuncionActivacion.Items.Add("SIGMOIDE");
                cmbFuncionActivacion.Items.Add("TANGENTE HIPERBOLICA");

                cmbAlgoritmoEntrenamiento.DataSource = null;
                cmbAlgoritmoEntrenamiento.Items.Clear();

                cmbAlgoritmoEntrenamiento.Items.Add("PROPAGACION INVERSA");
            }
        }

        private void cmbFuncionActivacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumNeuronasCap1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void NumNeuronasCap2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

/*
 public partial class Form1 : Form
    {
        ServiceLearningAlgorithm serviceLearningAlgorithm;
        ReadFileResponseService Response;
        FormUnicapa frUnicapa;
        FormMulticapa frmulticapa;
        public Form1()
        {
            InitializeComponent();
            serviceLearningAlgorithm = new ServiceLearningAlgorithm();
            comboBox1.Enabled = false;
            Response = new ReadFileResponseService();
        }
        string file;
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK && openFile.FileName != null)
            {
                file = openFile.FileName;
                txtFile.Text = file;
            }
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
             Response = serviceLearningAlgorithm.ReadFile(file);

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (!Response.Error)
            {

                DialogResult ResultOfForm = MessageBox.Show("Los datos del archivo fueron cargado correctamente, ¿Desea continuar?", "Mensaje Informativo", buttons, MessageBoxIcon.Question);
                if (ResultOfForm == DialogResult.Yes)
                {
                    comboBox1.Enabled = true;

                }
                else
                {
                    comboBox1.Enabled = false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Unicapa"))
            {
                serviceLearningAlgorithm.initializeWeightsAndThresholdsUnicapa(Response.Parameters.Inputs, Response.Parameters.Outputs);
            }
            if (comboBox1.Text.Equals("Multicapa"))
            {
                
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text.Equals("PERCEPTRON"))
            {
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox3.Items.Add("ESCALON");
                comboBox4.Items.Add("DELTA");
            }
            if (comboBox2.Text.Equals("ADALINE"))
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("LINEAL");
                comboBox4.Items.Clear();
                comboBox4.Items.Add("DELTA");
            }
            if (comboBox2.Text.Equals("BACKPROPAGATION"))
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("SIGMOIDE");
                comboBox3.Items.Add("TANGENTE HIPERBOLICA");
                comboBox4.Items.Clear();
                comboBox4.Items.Add("PROPAGACION INVERTIDA");

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == 0)
            {
                int numNeuronas = int.Parse(textBox1.Text.ToString());
                string funcion = comboBox5.Text;
                serviceLearningAlgorithm.initializeWeightsAndThresholdsMulticapa(Response.Parameters.Inputs, numNeuronas);
                serviceLearningAlgorithm.initializeWeightsAndThresholdsMulticapa(numNeuronas, Response.Parameters.Outputs);
                serviceLearningAlgorithm.CloseFile();
                
            }
            if (comboBox6.SelectedIndex == 1)
            {
                int numNeuronas1 = int.Parse(textBox1.Text);
                int numNeuronas2 = int.Parse(textBox2.Text);
                string funcion1 = comboBox5.Text;
                string funcion2 = comboBox6.Text;
                serviceLearningAlgorithm.initializeWeightsAndThresholdsMulticapa(Response.Parameters.Inputs, numNeuronas1);
                serviceLearningAlgorithm.initializeWeightsAndThresholdsMulticapa(numNeuronas1,numNeuronas2);
                serviceLearningAlgorithm.initializeWeightsAndThresholdsMulticapa(numNeuronas2,Response.Parameters.Outputs);
                serviceLearningAlgorithm.CloseFile();

            }
            if (comboBox6.SelectedIndex == 2)
            {
                int numNeuronas1 = int.Parse(textBox1.Text);
                int numNeuronas2 = int.Parse(textBox2.Text);
                int numNeuronas3 = int.Parse(textBox3.Text);
                string funcion1 = comboBox5.Text;
                string funcion2 = comboBox6.Text;
                string funcion3 = comboBox7.Text;
                serviceLearningAlgorithm.initializeWeightsAndThresholdsMulticapa(Response.Parameters.Inputs, numNeuronas1);
                serviceLearningAlgorithm.initializeWeightsAndThresholdsMulticapa(numNeuronas1, numNeuronas2);
                serviceLearningAlgorithm.initializeWeightsAndThresholdsMulticapa(numNeuronas2,numNeuronas3);
                serviceLearningAlgorithm.initializeWeightsAndThresholdsMulticapa(numNeuronas3, Response.Parameters.Outputs);
                serviceLearningAlgorithm.CloseFile();
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.Text.Equals("PERCEPTRON") || comboBox10.Text.Equals("ADALINE"))
            {
                comboBox11.Items.Clear();
                comboBox11.Items.Add("DELTA");
            }
            
            if (comboBox10.Text.Equals("BACKPROPAGATION"))
            {
                comboBox11.Items.Clear();
                comboBox11.Items.Add("PROPAGACION INVERSA");

            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 */