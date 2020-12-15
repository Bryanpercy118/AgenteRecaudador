using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;
namespace AgenteRecaudadorGUI
{
    public partial class Form1 : Form
    {
        public AgenteRecaudadorService agenteRecaudadorS;
        string RutaArchivo = " ";
        public Form1()
        {
            InitializeComponent();
            agenteRecaudadorS = new AgenteRecaudadorService(ConfiguracionConexion.connectionString);
        }

        public void Btonabrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            RutaArchivo = openFile.FileName;
            MessageBox.Show(RutaArchivo);
            Agentetxt.DataSource = agenteRecaudadorS.AbrirArchivo(RutaArchivo);
            
         

        }

      

        private void btonguardar_Click(object sender, EventArgs e)
        {

            agenteRecaudadorS.GuardarArchivoPlano(RutaArchivo);
            agenteBD.DataSource = agenteRecaudadorS.ConsultarTodos();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            string identificacion = txtAgente.Text;
            if (identificacion != " ")
            {
                AgenteRecaudador agente = agenteRecaudadorS.BuscarID(identificacion,RutaArchivo);

                if (agente != null)
                {
                    MessageBox.Show($"Nit:{agente.NitAgenteRecaudador}, Mes Reporte:{agente.MesReporte}," +
                        $" Año Reporte:{agente.AñoReporte},Contratista: {agente.NombreContratista}," +
                        $" Valor: {agente.ValorImpuesto}");
                    
                   

                }
                else
                {
                    MessageBox.Show($"LA PERSONA CON LA IDENTIFICACIÓN:  {identificacion} NO SE ENCUENTRA REGISTRADA");
                }

            }
            else
            {
                MessageBox.Show("DIGITE IDENTIFICACIÓN");
            }



        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void CmbEstampilla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbEstampilla.Text.Equals("Adulto Mayor"))
            {
                TxtTotal.Text = agenteRecaudadorS.ValorTotalAdultoMayor().ToString();
            }

            if (CmbEstampilla.Text.Equals("Pro Cultura"))
            {
                TxtTotal.Text = agenteRecaudadorS.ValorTotalProCultura().ToString();
            }

            if (CmbEstampilla.Text.Equals("Todos"))
            {
                TxtTotal.Text = agenteRecaudadorS.ValorTotalTodos().ToString();
            }
            if (CmbEstampilla.Text.Equals("Pro-UPC"))
            {
                TxtTotal.Text = agenteRecaudadorS.ValorTotalProUPC().ToString();
            }
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = agenteRecaudadorS.ValorTotalAdultoMayor().ToString();
        }
    }
}
