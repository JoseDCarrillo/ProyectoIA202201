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
        StreamWriter sw ;
        public CargueArchivoRepository(StreamWriter sw2)
        {
            sw = sw2;
        }
        public CargueArchivoRepository()
        {
            
        }
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

        //multicapa
        public void PesosYUmbralesMulticapa (int numI, int numJ)
        {
            bool signo = true;
            var random = new Random();
            double[,] matrizPesos = new double[numI, numJ];
            double[] vectorUmbral = new double[numJ];
            for (int i = 0; i < numI; i++)
            {
                for (int j = 0; j < numJ; j++)
                {
                    if (signo)
                    {
                        matrizPesos[i, j] = Math.Round(random.NextDouble(), 1);
                        signo = false;
                    }
                    else
                    {
                        double num = Math.Round(random.NextDouble(), 1);
                        matrizPesos[i, j] = num - (num * 2);
                        signo = true;
                    }

                }
            }

            for (int i = 0; i < numJ; i++)
            {
                if (signo)
                {
                    vectorUmbral[i] = Math.Round(random.NextDouble(), 1);
                    signo = false;
                }
                else
                {
                    double num = Math.Round(random.NextDouble(), 1);
                    vectorUmbral[i] = num - (num * 2);
                    signo = true;
                }
            }
            Console.WriteLine(matrizPesos);
            Console.WriteLine(vectorUmbral);
            WriteFileMulticapa(matrizPesos, vectorUmbral, numJ, numI);
        }

        public void WriteFileMulticapa(double[,] matriz, double[] vector, int numOutputs, int numInputs)
        {
            WriteMatrizFileMulticapa(matriz, numOutputs, numInputs);
            WriteVectorFileMulticapa(vector, numOutputs);
        }
        public void WriteMatrizFileMulticapa(double[,] matriz, int numOutputs, int numInputs)
        {
            sw.WriteLine("");
            sw.WriteLine("Matriz de pesos");
            for (int i = 0; i < numInputs; i++)
            {
                string line = "";
                for (int j = 0; j < numOutputs; j++)
                {
                    line = line + matriz[i, j].ToString() + " ;";
                }
                sw.WriteLine(line);
            }
        }
        public void WriteVectorFileMulticapa(double[] vector, int numInputs)
        {
            sw.WriteLine("");
            sw.WriteLine("Vector de umbrales");
            for (int i = 0; i < numInputs; i++)
            {
                sw.WriteLine(vector[i]);
            }
        }


        //Unicapa
        public void Unicapa(int numInputs, int numOutputs)
        {
            bool signo = true;
            var random = new Random();
            double[,] matrizPesos = new double[numInputs, numOutputs];
            double[] vectorUmbral = new double[numOutputs];
            for (int i = 0; i < numInputs; i++)
            {
                for (int j = 0; j < numOutputs; j++)
                {
                    if (signo)
                    {
                        matrizPesos[i, j] = Math.Round(random.NextDouble(), 1);
                        signo = false;
                    }
                    else
                    {
                        double num = Math.Round(random.NextDouble(), 1);
                        matrizPesos[i, j] = num - (num * 2);
                        signo = true;
                    }

                }
            }

            for (int i = 0; i < numOutputs; i++)
            {
                if (signo)
                {
                    vectorUmbral[i] = Math.Round(random.NextDouble(), 1);
                    signo = false;
                }
                else
                {
                    double num = Math.Round(random.NextDouble(), 1);
                    vectorUmbral[i] = num - (num * 2);
                    signo = true;
                }
            }
            Console.WriteLine(matrizPesos);
            Console.WriteLine(vectorUmbral);
            WriteFileUnicapa(matrizPesos, vectorUmbral, numOutputs, numInputs);
        }
        public void WriteVectorFileUnicapa(double[] vector, int numOutputs)
        {
            sw.WriteLine("");
            sw.WriteLine("Vector de umbrales");
            for (int i = 0; i < numOutputs; i++)
            {
                sw.WriteLine(vector[i]);
            }
        }

        public void WriteMatrizFileUnicapa(double[,] matriz, int numOutputs, int numInputs)
        {
            sw.WriteLine("");
            sw.WriteLine("Matriz de pesos");
            for (int i = 0; i < numInputs; i++)
            {
                string line = "";
                for (int j = 0; j < numOutputs; j++)
                {
                    line = line + matriz[i, j].ToString() + " ;";
                }
                sw.WriteLine(line);
            }
        }


        public void WriteFileUnicapa(double[,] matriz, double[] vector, int numOutputs, int numInputs)
        {
            WriteMatrizFileUnicapa(matriz, numOutputs, numInputs);
            WriteVectorFileUnicapa(vector, numOutputs);
            sw.Close();
        }

        public void CloseFile()
        {
            sw.Close();
            sw.Dispose();
        }






    }

    

}

/*
 public class RepositoryLearningAlgorithm
  {
      Parameters parameters = new Parameters();
      List<Pattern> patterns = new List<Pattern>();
      StreamWriter sw = new StreamWriter("C:\\Users\\deyner solano\\Documents\\Texto.txt");

      public void initializeWeightsAndThresholdsMulticapa(int numI, int numJ)
      {
          bool signo = true;
          var random = new Random();
          double[,] matrizPesos = new double[numI, numJ];
          double[] vectorUmbral = new double[numJ];
          for (int i = 0; i < numI; i++)
          {
              for (int j = 0; j < numJ; j++)
              {
                  if (signo)
                  {
                      matrizPesos[i, j] = Math.Round(random.NextDouble(), 1);
                      signo = false;
                  }
                  else
                  {
                      double num = Math.Round(random.NextDouble(), 1);
                      matrizPesos[i, j] = num - (num * 2);
                      signo = true;
                  }

              }
          }

          for (int i = 0; i < numJ; i++)
          {
              if (signo)
              {
                  vectorUmbral[i] = Math.Round(random.NextDouble(), 1);
                  signo = false;
              }
              else
              {
                  double num = Math.Round(random.NextDouble(), 1);
                  vectorUmbral[i] = num - (num * 2);
                  signo = true;
              }
          }
          Console.WriteLine(matrizPesos);
          Console.WriteLine(vectorUmbral);
          WriteFileMulticapa(matrizPesos, vectorUmbral, numJ, numI);
      }
      public void WriteVectorFileMulticapa(double[] vector, int numInputs)
      {
          sw.WriteLine("");
          sw.WriteLine("Vector de umbrales");
          for (int i = 0; i < numInputs; i++)
          {
              sw.WriteLine(vector[i]);
          }
      }

      public void WriteMatrizFileMulticapa(double[,] matriz, int numOutputs, int numInputs)
      {
          sw.WriteLine("");
          sw.WriteLine("Matriz de pesos");
          for (int i = 0; i < numInputs; i++)
          {
              string line = "";
              for (int j = 0; j < numOutputs; j++)
              {
                  line = line + matriz[i, j].ToString() + " ;";
              }
              sw.WriteLine(line);
          }
      }

      public void WriteFileMulticapa(double[,] matriz, double[] vector, int numOutputs, int numInputs)
      {
          WriteMatrizFileMulticapa(matriz, numOutputs, numInputs);
          WriteVectorFileMulticapa(vector, numOutputs);
      }

      public void CloseFile()
      {
          sw.Close();
          sw.Dispose();
      }

      //******************Unicapa********************


      public void   Unicapa(int numInputs, int numOutputs)
      {
          bool signo = true;
          var random = new Random();
          double[,] matrizPesos = new double[numInputs, numOutputs];
          double[] vectorUmbral = new double[numOutputs];
          for (int i = 0; i < numInputs; i++)
          {
              for(int j = 0; j < numOutputs; j++)
              {
                  if (signo)
                  {
                      matrizPesos[i, j] = Math.Round(random.NextDouble(),1);
                      signo = false;
                  }
                  else
                  {
                      double num = Math.Round(random.NextDouble(), 1);
                      matrizPesos[i, j] = num - (num*2);
                      signo = true;
                  }

              }
          }

          for(int i = 0; i < numOutputs; i++)
          {
              if (signo)
              {
                  vectorUmbral[i] = Math.Round(random.NextDouble(), 1);
                  signo = false;
              }
              else
              {
                  double num = Math.Round(random.NextDouble(), 1);
                  vectorUmbral[i] = num - (num * 2);
                  signo = true;
              }
          }
          Console.WriteLine(matrizPesos);
          Console.WriteLine(vectorUmbral);
          WriteFileUnicapa(matrizPesos, vectorUmbral, numOutputs, numInputs);
      }
      public void WriteVectorFileUnicapa(double[] vector,int numOutputs)
      {
          sw.WriteLine("");
          sw.WriteLine("Vector de umbrales");
          for (int i = 0; i < numOutputs; i++)
          {
              sw.WriteLine(vector[i]);
          }
      }

      public void WriteMatrizFileUnicapa(double[,] matriz, int numOutputs, int numInputs)
      {
          sw.WriteLine("");
          sw.WriteLine("Matriz de pesos");
          for (int i = 0; i < numInputs; i++)
          {
              string line = "";
              for (int j = 0; j < numOutputs; j++)
              {
                  line = line + matriz[i, j].ToString() + " ;";
              }
              sw.WriteLine(line);
          }
      }


      public void WriteFileUnicapa(double[,] matriz, double[] vector, int numOutputs, int numInputs)
      {
          WriteMatrizFileUnicapa(matriz, numOutputs, numInputs);
          WriteVectorFileUnicapa(vector, numOutputs);
          sw.Close();
      }

      public ReadFileResponse ReadFile(string fileName)
      {
          ReadFileResponse response = new ReadFileResponse();
          FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
          StreamReader reader = new StreamReader(file);
          string line = string.Empty;
          int position = 0;
          parameters.Patterns = 0;
          while ((line = reader.ReadLine()) != null)
          {
              if (position == 0)
              {
                  ReadNameParameters(line);
              }
              else
              {
                  MapPatterns(line);
                  parameters.Patterns++;
              }
              position++;
          }
          reader.Close();
          file.Close();
          response.Patterns = patterns;
          response.Parameters = parameters;
          return response;

          Console.WriteLine(parameters);
          Console.WriteLine(patterns);
      }

      private void MapPatterns(string line)
      {
          int positionInput = 0;
          int positionOutput = 0;
          char delimeter = ';';
          string[] vectorParameters = line.Split(delimeter);
          Pattern pattern = new Pattern();

          List<Input> listInputsValue = new List<Input>();
          List<Output> listOutputValue = new List<Output>();

          for (int i = 0; i < vectorParameters.Length; i++)
          {
              Input input = new Input();
              Output output = new Output();

              if (parameters.Inputs > i)
              {
                  input.Value = int.Parse(vectorParameters[i]);
                  input.Position = positionInput;
                  positionInput++;

                  listInputsValue.Add(input);
              }
              else
              {
                  output.Value = int.Parse(vectorParameters[i]);
                  output.Position = positionOutput;
                  positionOutput++;

                  listOutputValue.Add(output);
              }
          }
          pattern.Inputs = listInputsValue;
          pattern.Outputs = listOutputValue;
          patterns.Add(pattern);
      }


      private void ReadNameParameters(string line)
      {
          parameters.Inputs = 0;
          parameters.Outputs = 0;

          Pattern pattern = new Pattern();
          List<Input> listInputsValue = new List<Input>();
          List<Output> listOutputValue = new List<Output>();

      char delimeter = ';';
          string[] vectorParameters = line.Split(delimeter);
          for (int i = 0; i < vectorParameters.Length; i++)
          {
              if (vectorParameters[i].Contains("x") || vectorParameters[i].Contains("X"))
              {
                  Input input = new Input();
                  input.NameParameter = (vectorParameters[i]);
                  input.Position = parameters.Inputs;
                  parameters.Inputs++;

                  listInputsValue.Add(input);
              }
              if (vectorParameters[i].Contains("y") || vectorParameters[i].Contains("Y"))
              {
                  Output output = new Output();
                  output.NameParameter = (vectorParameters[i]);
                  output.Position = parameters.Outputs;
                  parameters.Outputs++;

                  listOutputValue.Add(output);
              }
          }
          pattern.Inputs = listInputsValue;
          pattern.Outputs = listOutputValue;
          patterns.Add(pattern);

      }

  }

  public class ReadFileResponse
  {
      public List<Pattern> Patterns { get; set; }
      public Parameters Parameters { get; set; }
  }*/