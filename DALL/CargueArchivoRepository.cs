using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DALL
{
    public class CargueArchivoRepository
    {
        Parametros parametros = new Parametros();
        List<Patrones> patrones = new List<Patrones>();

        public List<Patrones> CargarDatos(string fileName)
        {
            
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            int validate = 0;
            parametros.Patrones = 0;
            while ((linea = reader.ReadLine()) != null)
            {
                if(validate == 0)
                {
                    ValidateParametros(linea);
                    validate++;
                }
                else
                {
                    MapFile(linea);
                    parametros.Patrones++;
                    
                }
                
            }
            reader.Close();
            file.Close();

            return patrones;

            Console.WriteLine(parametros);
            Console.WriteLine(patrones);
        }

        private void MapFile(string linea)
        {
            int positionE = 0;
            int positionS = 0;
            char delimeter = ';';
            string[] vectorParametros = linea.Split(delimeter);
            Patrones patron = new Patrones();
            
            List<Entradas> listValidateEntrada = new List<Entradas>();
            List<Salidas> listValidateSalida = new List<Salidas>();
            
            for (int i = 0; i < vectorParametros.Length; i++)
            {
                Entradas validateEntrada = new Entradas();
                Salidas validateSalida = new Salidas();

                if (parametros.Entradas>i)
                {
                    validateEntrada.Validate = int.Parse(vectorParametros[i]);
                    validateEntrada.Posicion = positionE;
                    positionE++;

                    listValidateEntrada.Add(validateEntrada);
                }
                else
                {
                    validateSalida.Validate = int.Parse(vectorParametros[i]);
                    validateSalida.Posicion = positionS;
                    positionS++;

                    listValidateSalida.Add(validateSalida);
                }

                
                
            }
            patron.Entradas = (listValidateEntrada);
            patron.Salidas = (listValidateSalida);

            patrones.Add(patron);



        }

        private void ValidateParametros(string linea)
        {
            parametros.Entradas = 0;
            parametros.Salidas = 0;
            

            List<Entradas> entradas = new List<Entradas>();
            List<Salidas> salidas = new List<Salidas>();

            Patrones patron = new Patrones();

            char delimeter = ';';
            string[] vectorParametros = linea.Split(delimeter);
            for(int i = 0; i < vectorParametros.Length; i++)
            {
                if (vectorParametros[i].Contains("x")|| vectorParametros[i].Contains("X"))
                {
                    
                    Entradas validateEntrada = new Entradas();
                    validateEntrada.Nombre=(vectorParametros[i]);
                    validateEntrada.Posicion = parametros.Entradas;
                    parametros.Entradas++;

                    entradas.Add(validateEntrada);
                }
                if (vectorParametros[i].Contains("y") || vectorParametros[i].Contains("Y"))
                {
                    
                    Salidas validateSalida = new Salidas();
                    validateSalida.Nombre=(vectorParametros[i]);
                    validateSalida.Posicion = parametros.Salidas;
                    parametros.Salidas++;

                    salidas.Add(validateSalida);
                }
            }

            patron.Entradas = entradas;
            patron.Salidas = salidas;

            patrones.Add(patron);   




        }

    }
}
