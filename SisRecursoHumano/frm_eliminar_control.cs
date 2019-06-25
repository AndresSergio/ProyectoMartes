using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace SisRecursoHumano
{
    public partial class frm_eliminar_control : Form
    {
        public string cambioestado = "";
        public string id = "";
        public frm_eliminar_control()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_eliminar_control_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rpta = "";
            // en la tabla privilegio usamos el comando compareto() para comparar lo que contenia cambioestado... en este caso no 
            //necesitamos el comparador directamente usamos la comsulta if() para comprara cambioestado....
            if (cambioestado == "activo")
            {
                cambioestado = "inactivo";
                rpta = Ndepartamento.estado(Convert.ToInt32(id), cambioestado);
                MessageBox.Show("cambio de estado actualizado");
                Close();

            }

            else
            {
                cambioestado = "activo";
                rpta = Ndepartamento.estado(Convert.ToInt32(id), cambioestado);
                MessageBox.Show("cambio de estado actualizado");
                Close();
            }

        }
    }
}
