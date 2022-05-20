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

namespace WindowsFormsApp1.FORMULARIOS
{
    public partial class MPrivilegios : Form
    {
        USUARIO US;
        USUARIOACTIVO UA;
        string privilegios;
        public MPrivilegios(USUARIO US,USUARIOACTIVO UA)
        {
            InitializeComponent();
            this.US = US;
            this.UA = UA;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            privilegios = Checado(CHRegIns) + " " + Checado(CHGenRep) + " " + Checado(CHRequi) + " " + Checado(CHRepoReq) + " " + Checado(CHVale) + " " + Checado(CHRepoIns) + " " + Checado(CHRepRes) + " " + Checado(CHConsul) + " " + Checado(CHModIn) + " " + Checado(CHEliIns) + " " + Checado(chConsultaReportes);
            US.Privilegio = privilegios;
            this.Close();
        }
        public char Checado(CheckBox cb)
        {
            if (cb.Checked)
                return '1';
            else
                return '0';
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {

        }

        private void chTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (chTodo.Checked == true)
            {
                CHRegIns.Checked = true;
                CHGenRep.Checked = true;
                CHRequi.Checked = true;
                CHRepoReq.Checked = true;
                CHVale.Checked = true;
                CHRepoIns.Checked = true;
                CHRepRes.Checked = true;
                CHConsul.Checked = true;
                CHModIn.Checked = true;
                CHEliIns.Checked = true;
                chConsultaReportes.Checked = true;
            }
            if (chTodo.Checked == false)
            {
                CHRegIns.Checked = false;
                CHGenRep.Checked = false;
                CHRequi.Checked = false;
                CHRepoReq.Checked = false;
                CHVale.Checked = false;
                CHRepoIns.Checked = false;
                CHRepRes.Checked = false;
                CHConsul.Checked = false;
                CHModIn.Checked = false;
                CHEliIns.Checked = false;
                chConsultaReportes.Checked = false;
            }
        }

        private void MPrivilegios_Load(object sender, EventArgs e)
        {
            if (US.Privilegio[0] == '1')
            {
                CHRegIns.Checked = true;
            }
            if (US.Privilegio[2] == '1')
            {
                CHGenRep.Checked = true;
            }
            if (US.Privilegio[4] == '1')
            {
                CHRequi.Checked = true;
            }
            if (US.Privilegio[6] == '1')
            {
                CHRepoReq.Checked = true;
            }
            if (US.Privilegio[8] == '1')
            {
                CHVale.Checked = true;
            }
            if (US.Privilegio[10] == '1')
            {
                CHRepoIns.Checked = true;
            }
            if (US.Privilegio[12] == '1')
            {
                CHRepRes.Checked = true;
            }

            if (US.Privilegio[14] == '1')
            {
                CHConsul.Checked = true;
            }
            if (US.Privilegio[16] == '1')
            {
                CHModIn.Checked = true;
            }
            if (US.Privilegio[18] == '1')
            {
                CHEliIns.Checked = true;
            }
            if (US.Privilegio[20] == '1')
            {
                chConsultaReportes.Checked = true;
            }
        }
    }
}
