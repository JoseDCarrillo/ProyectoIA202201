using BLL;
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
    public partial class Form1 : Form
    {
        CargueArchivoService cargueService;
        public Form1()
        {
            InitializeComponent();
            cargueService = new CargueArchivoService();


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

        private void button2_Click(object sender, EventArgs e)
        {
            var respuesta = cargueService.CargarArchivo(file);

            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            if (!respuesta.Error)
            {

                DialogResult resultadoForm = MessageBox.Show("Los datos del archivo fueron cargado correctamente, ¿Desea continuar?", "Mensaje Informativo", botones, MessageBoxIcon.Question );
                if (resultadoForm == DialogResult.Yes)
                {
                    //this.Close();
                    FormConfiguracionDeRed formConfirgurarRed = new FormConfiguracionDeRed();
                    formConfirgurarRed.Show();
                    
                }
            }
            
        }


    }
}
