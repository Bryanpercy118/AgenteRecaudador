using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALL;
using ENTITY;
namespace BLL
{
    public class AgenteRecaudadorService
    {
        public AgenteRecaudadorRepository agenteRecaudadorR;
        ManejadorConexion Conexion;
        List<AgenteRecaudador> agentes;

        public AgenteRecaudadorService(string conexion)
        {
            Conexion = new ManejadorConexion(conexion);
            agenteRecaudadorR = new AgenteRecaudadorRepository(Conexion);

        }

        public AgenteRecaudadorService()
        {
        }

        public IList<AgenteRecaudador> AbrirArchivo(string ruta)
        {
            try
            {
                return agenteRecaudadorR.CargarArchivo(ruta);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<AgenteRecaudador> ConsultarTodos()
        {
            Conexion.Open();
            agentes = new List<AgenteRecaudador>();
            agentes = agenteRecaudadorR.ConsultarTodos();
            Conexion.Close();
            return agentes;
        }
        public AgenteRecaudador BuscarID(string nit, string ruta)
        {
            try
            {
                var agentes =  agenteRecaudadorR.Buscar(nit, ruta);
                return agentes.Find(a => a.NitAgenteRecaudador == nit);

            }
            catch (Exception e)
            {
                string mensaje = " ERROR" + e.Message;
                return null;
            }
        }


        public string GuardarArchivoPlano(string ruta)
        {
            try
            {
                Conexion.Open();
                agenteRecaudadorR.GuardarArchivoPlano(ruta);
                Conexion.Close();
                return $"Se exporto el archivo a la BASE DE DATOS CON EXITO";


            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { Conexion.Close(); }

        }
        public decimal ValorTotalAdultoMayor()
        {
            return agenteRecaudadorR.ValorTotalAdultoMayor();
        }


        public decimal ValorTotalTodos()
        {
            return agenteRecaudadorR.ValorTotalTodos();
        }
        public decimal ValorTotalProCultura()
        {
            return agenteRecaudadorR.ValorTotalProCultura();
        }
        public decimal ValorTotalProUPC()
        {
            return agenteRecaudadorR.ValorTotalProUpc();
        }
    }
}
