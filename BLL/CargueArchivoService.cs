using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class CargueArchivoService
    {
        CargueArchivoRepository cargueArchivoRepository = new CargueArchivoRepository();



        public CargarArchivoResponse CargarArchivo(string ruta)
        {
            CargarArchivoResponse respuesta = new CargarArchivoResponse();
            try
            {
                respuesta.PatronesCarga = cargueArchivoRepository.CargarDatos(ruta);

                if (respuesta.PatronesCarga.Count > 0)
                {
                    respuesta.Mensaje = "Se guardaron los datos";
                }
                else
                {
                    respuesta.Mensaje = "Error jj";
                }
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }

        }

    }

    public class CargarArchivoResponse
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public List<Patrones> PatronesCarga { get; set; }

    }
}
