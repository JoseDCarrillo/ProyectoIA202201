using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class CargueArchivoService
    {
        CargueArchivoRepository cargueArchivoRepository ;

        CargarArchivoResponse validate ;
        public CargueArchivoService(StreamWriter sw2)
        {
            cargueArchivoRepository = new CargueArchivoRepository(sw2);
        }
        public CargueArchivoService()
        {
            cargueArchivoRepository = new CargueArchivoRepository();
        }

        public CargarArchivoResponse CargarArchivo(string ruta)
        {
            CargarArchivoResponse respuesta = new CargarArchivoResponse();
            try
            {
                respuesta.PatronesCarga = cargueArchivoRepository.CargarDatos(ruta);
                validate = respuesta;
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

        public void PesosYUmbralesUnicapa(int numInputs, int numOutputs)
        {
            cargueArchivoRepository.Unicapa(numInputs, numOutputs);
        }

        public void PesosYUmbralesMulticapa(int numI, int numJ)
        {
            cargueArchivoRepository.PesosYUmbralesMulticapa(numI, numJ);
        }

        public void CloseFile()
        {
            cargueArchivoRepository.CloseFile();
        }


        public CargarArchivoResponse ConsultaDatos()
        {
            return validate;
        }

    }

    public class CargarArchivoResponse
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public List<Patrones> PatronesCarga { get; set; }

    }
}


/*
 public class ServiceLearningAlgorithm
    {

        RepositoryLearningAlgorithm repositoryLearningAlgorithm = new RepositoryLearningAlgorithm();

        public ReadFileResponseService ReadFile(string route)
        {
            ReadFileResponseService response = new ReadFileResponseService();
            ReadFileResponse readFileResponse = new ReadFileResponse();
            try
            {
                readFileResponse = repositoryLearningAlgorithm.ReadFile(route);
                response.Patterns = readFileResponse.Patterns;
                response.Parameters = readFileResponse.Parameters;
                
                if (response.Patterns.Count > 0)
                {
                    response.Message = "Se guardaron los datos";
                }
                else
                {
                    response.Message = "No hay patrones en el archivo";
                }
                response.Error = false;
                return response;
            }
            catch (Exception e)
            {
                response.Message = $"Error de la Aplicacion: {e.Message}";
                response.Error = true;
                return response;
            }

        }

        public void initializeWeightsAndThresholdsUnicapa(int numInputs, int numOutputs)
        {
          repositoryLearningAlgorithm.initializeWeightsAndThresholdsUnicapa(numInputs,numOutputs);        
        }

        public void initializeWeightsAndThresholdsMulticapa(int numI, int numJ)
        {
            repositoryLearningAlgorithm.initializeWeightsAndThresholdsMulticapa(numI, numJ);
        }

        public void CloseFile()
        {
            repositoryLearningAlgorithm.CloseFile();
        }

    }

    public class ReadFileResponseService
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public List<Pattern> Patterns { get; set; }
        public Parameters Parameters { get; set; }

    }
 */