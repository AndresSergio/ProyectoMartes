using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisRecursoHumano
{
    public partial class Frm_Lista_Personas : Form
    {
        public Frm_Lista_Personas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_registar_Persona frm = new frm_registar_Persona();
            frm.ShowDialog();
        }

        private void Frm_Lista_Personas_Load(object sender, EventArgs e)
        {
          
        }

        private void r1_CheckedChanged(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                dt_Fecha1.Visible = true;
                dt_Fecha2.Visible = true;
                lbl_Fechas.Visible = true;
            }
            else
            {
                dt_Fecha1.Visible = false;
                dt_Fecha2.Visible = false;
                lbl_Fechas.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }
    }
}
