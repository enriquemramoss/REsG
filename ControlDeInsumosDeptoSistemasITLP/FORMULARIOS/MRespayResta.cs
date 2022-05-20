using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CENTIDAD;
using CNEGOCIO;

namespace WindowsFormsApp1.FORMULARIOS
{
    public partial class MRespayResta : Form
    {
        
        Contacto Con = new Contacto();
        public MRespayResta()
        {
            InitializeComponent();
        }

        private void btnElegirDestino_Click(object sender, EventArgs e)
        {
            //codido para buscar ruta para guardar archivo de respaldo
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tRuta.Text = fbd.SelectedPath;
                btnElegirDestino.Enabled = true;
            }
        }

        private void btnRealizarRespaldo_Click(object sender, EventArgs e)
        {
            if(tRuta.Text!= "")
            {
                try
                {
                    Con.RespaldoBD(tRuta.Text);
                    Mensaje2 me1 = new Mensaje2("Respaldo realizado con éxito", "Base de datos respaldada");
                    me1.ShowDialog();
                }
                catch (Exception ex)
                {
                    Mensaje2 me2 = new Mensaje2("Error al respaldar la base de datos", "Error de respaldo");
                    me2.ShowDialog();
                }
            }
            else
            {
                Mensaje2 me = new Mensaje2("Elija una ruta para guardar el respaldo", "Error de respaldo");
                me.ShowDialog();
            }
          

        }

        private void btnElegirRestauración_Click(object sender, EventArgs e)
        {
            //codigo para buscar archivo de restauración
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tOrigen.Text = ofd.FileName;
                btnElegirRestauración.Enabled = true;
            }
        }

        private void btnRestauracion_Click(object sender, EventArgs e)
        {
            if (tOrigen.Text != "")
            {
                try
                {
                    Con.RestaurarBD(tOrigen.Text);
                    Mensaje2 me1 = new Mensaje2("Restauración realizada con éxito", "Base de datos restaurada");
                    me1.ShowDialog();
                }
                catch (Exception ex)
                {
                    Mensaje2 me2 = new Mensaje2("Error al restaurar la base de datos","Error de restauración");
                    me2.ShowDialog();
                }
            }
            else
            {
                Mensaje2 me3 = new Mensaje2("Elija un archivo de restauración", "Error de restauración");
                me3.ShowDialog();
            }
           
        }
    }
}
