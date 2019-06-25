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
    public partial class ReporteControl : Form
    {
        public ReporteControl()
        {
            InitializeComponent();
        }

        private void ReporteControl_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Control_Trabajador' Puede moverla o quitarla según sea necesario.
            this.Control_TrabajadorTableAdapter.Fill(this.DataSet1.Control_Trabajador);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
