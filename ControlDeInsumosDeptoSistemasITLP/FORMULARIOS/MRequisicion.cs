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
using CVALIDACION;

namespace WindowsFormsApp1.FORMULARIOS
{
    public partial class MRequisicion : Form
    {
        USUARIOACTIVO UA;
        Contacto Con = new Contacto();
        REQUISICION EREQ = new REQUISICION();
        Vista V;
        ExpresionesRegulares EX = new ExpresionesRegulares();
        Formato FR = new Formato();
        public MRequisicion(USUARIOACTIVO UA)
        {
            this.UA = UA;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value >= 1 && textBox2.Text != "" && textBox3.Text != "")
            {
                DGR.RowCount++;
                DGR[0, DGR.RowCount - 1].Value = numericUpDown1.Value;
                DGR[1, DGR.RowCount - 1].Value = textBox2.Text;
                DGR[2, DGR.RowCount - 1].Value = textBox3.Text;
                DGR[3, DGR.RowCount - 1].Value = comboBox1.Text;


                numericUpDown1.Value = 1;
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Text = "";
            }
            else
            {
                Mensaje M = new Mensaje("Favor de llenar los campos vacios","Error Requisición");
            }
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DGR.RowCount > 0)
            {
                DGR.Rows.RemoveAt(DGR.CurrentRow.Index);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DGR.RowCount) >= 1)
            {
                DataTable da = new DataTable();
                da.Columns.Add("Cantidad Insumo", typeof(string));
                da.Columns.Add("Insumo", typeof(string));
                da.Columns.Add("Característica", typeof(string));
                da.Columns.Add("Ubicación Destino", typeof(string));
                LlenarDatos();
                Con.CrearRequisicion(EREQ);
                for (int i = 0; i < DGR.RowCount; i++)
                {
                    EREQ.CantidadInsumo = Convert.ToInt32(DGR[0, i].Value);
                    EREQ.Insumo = (DGR[1, i].Value.ToString());
                    EREQ.Caracteristica = (DGR[2, i].Value.ToString());
                    EREQ.Ubicacion = (DGR[3, i].Value.ToString());
                    Con.RegistrarInsumoRequisicion(EREQ);
                    da.Rows.Add(DGR[0, i].Value, DGR[1, i].Value, DGR[2, i].Value, DGR[3, i].Value);
                }
                EREQ.Datatable = da;
                V = new Vista(UA, EREQ, 2);
                V.Show();
                this.Close();
            }
            else
            {
                Mensaje2 m = new Mensaje2("Favor de seleccionar registros", "Error al generar reporte");
                m.ShowDialog();
            }
  
        }
        public void LlenarDatos()
        {
            EREQ.NoEconomico = UA.NoEconomico;
            EREQ.FechaRequisicion = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            FR.SoloLetras(e);
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
