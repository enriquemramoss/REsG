using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.FORMULARIOS
{
    public partial class Mensaje2 : Form
    {
        public Mensaje2(String msg, String AVISO)
        {
            InitializeComponent();
            label1.Text = AVISO;
            label2.Text = msg;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
