using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;

namespace DALL
{
    public class AgenteRecaudadorRepository
    {
        public List<AgenteRecaudador> agentes;
        ManejadorConexion Conexion;
       
        public AgenteRecaudadorRepository(ManejadorConexion conexion)
        {
            agentes = new List<AgenteRecaudador>();
            Conexion = conexion;
        }


        public List<AgenteRecaudador> CargarArchivo(string ruta)
        {
            FileStream source = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(source);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                AgenteRecaudador agente;
                agente = Mapear(linea);
                agentes.Add(agente);
            }
            reader.Close();
            source.Close();
            return agentes;
        }


        public AgenteRecaudador Mapear(string linea)
        {
            char delimiter = ';';
            string[] Datos = linea.Split(delimiter);
            AgenteRecaudador agente = new AgenteRecaudador();
            agente.NitAgenteRecaudador = Datos[0];
            agente.MesReporte = Convert.ToInt32(Datos[1]);
            agente.AñoReporte = Convert.ToInt32(Datos[2]);
            agente.TipoEstampilla = Datos[3];
            agente.ValorImpuesto = Convert.ToDecimal(Datos[4]);
            agente.IdentificacionContratista = Datos[5];
            agente.NombreContratista = Datos[6];
            return agente;

        }

        public void GuardarArchivoPlano(string ruta)
        {


            using (var command = Conexion.connection.CreateCommand())
            {

                command.CommandText = "BULK INSERT Agente FROM '" + ruta + "' WITH (FIELDTERMINATOR = ';' , ROWTERMINATOR = '\n')";
                command.CommandType = CommandType.Text;

                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }

        }

        public List<AgenteRecaudador> ConsultarTodos()
        {
            SqlDataReader dataReader;
            using (var command = Conexion.connection.CreateCommand())
            {
                command.CommandText = "Select * from Agente";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        AgenteRecaudador agente = Mapear(dataReader);
                        agentes.Add(agente);
                    }
                }
            }
            return agentes;
        }

        public List<AgenteRecaudador> Buscar(string nit, string ruta)
        {
            agentes.Clear();
            agentes = CargarArchivo(ruta);
            return agentes;
        }
        public List<AgenteRecaudador> Consultar(string ruta)
        {
            agentes.Clear();
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream);
            string linea = string.Empty;
            AgenteRecaudador agente = new AgenteRecaudador();
            while ((linea = streamReader.ReadLine()) != null)
            {
                string[] datos = linea.Split(';');
               
                agente.NitAgenteRecaudador = datos[0];
                agente.MesReporte = int.Parse(datos[1]);
                agente.AñoReporte = int.Parse(datos[2]);
                agente.TipoEstampilla = datos[3];
                agente.ValorImpuesto = decimal.Parse(datos[4]);
                agente.IdentificacionContratista = datos[5];
                agente.NombreContratista = datos[6];
                agentes.Add(agente);
               
            }
            fileStream.Close();
            streamReader.Close();
            return agentes;
        }

          public List<AgenteRecaudador> ConsultarNit(int nit) {

             SqlDataReader dataReader;
             using (var command = Conexion.connection.CreateCommand())
             {
                 command.CommandText = "Select * from Agente where Nit = '"+ nit + "' ";
                 dataReader = command.ExecuteReader();
                 if (dataReader.HasRows)
                 {
                     while (dataReader.Read())
                     {
                         AgenteRecaudador agente = MapearNit(dataReader);
                         agentes.Add(agente);
                     }
                 }
             }
             return agentes;
         }

        private AgenteRecaudador MapearNit(SqlDataReader dataReader)
         {
             if (!dataReader.HasRows) return null;
             AgenteRecaudador agente = new AgenteRecaudador();
             agente.NitAgenteRecaudador = (string)dataReader["Nit"].ToString();
             return agente;
         }

         private AgenteRecaudador Mapear(SqlDataReader dataReader)
         {
             if (!dataReader.HasRows) return null;
             AgenteRecaudador agente = new AgenteRecaudador();
             agente.NitAgenteRecaudador = (string)dataReader["Nit"].ToString();
             agente.MesReporte = int.Parse(((object)dataReader["MesReporte"]).ToString());
             agente.AñoReporte = int.Parse(((object)dataReader["Vigenciadereporte"]).ToString());
             agente.TipoEstampilla = (string)dataReader["TipoEstampilla"];
             agente.ValorImpuesto = decimal.Parse(((object)dataReader["ValorImpuesto"]).ToString());
             agente.IdentificacionContratista = (string)dataReader["Identificacion"];
             agente.NombreContratista = (string)dataReader["Nombrecontratista"];


             return agente;
         }

        public decimal ValorTotalAdultoMayor()
        {
            return agentes.Where(p => p.TipoEstampilla.Equals("Adulto Mayor") && p.ValorImpuesto.Equals(p.ValorImpuesto)).Sum(p => p.ValorImpuesto);
        }
        public decimal ValorTotalTodos()
        {
            return agentes.Where(p => p.TipoEstampilla.Equals("Todos") && p.ValorImpuesto.Equals(p.ValorImpuesto)).Sum(p => p.ValorImpuesto);
        }
        public decimal ValorTotalProCultura()
        {
            return agentes.Where(p => p.TipoEstampilla.Equals("Pro Cultura") && p.ValorImpuesto.Equals(p.ValorImpuesto)).Sum(p => p.ValorImpuesto);
        }
        public decimal ValorTotalProUpc()
        {
            return agentes.Where(p => p.TipoEstampilla.Equals("Pro-UPC") && p.ValorImpuesto.Equals(p.ValorImpuesto)).Sum(p => p.ValorImpuesto);
        }


    }
}
