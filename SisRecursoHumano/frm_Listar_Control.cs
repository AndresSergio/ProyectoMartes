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
    public partial class frm_Listar_Control : Form
    {
        frm_modificar_control frm = new frm_modificar_control();
        public frm_Listar_Control()
        {
            InitializeComponent();
        }

        private void frm_Listar_Control_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rRHH1DataSet.Control_Trabajador' Puede moverla o quitarla según sea necesario.
            //this.control_TrabajadorTableAdapter.Fill(this.rRHH1DataSet.Control_Trabajador);

        }

        private void dt_Fecha2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_registrar_Control frm = new Frm_registrar_Control();
            frm.ShowDialog();
        }

 

        private void button8_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Control frm = new Frm_Reporte_Control();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm_Mostrar_contron frm = new frm_Mostrar_contron();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_modificar_control frm = new frm_modificar_control();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_eliminar_control frm = new frm_eliminar_control();
            frm.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_registrar_Control frm = new Frm_registrar_Control();
            
            frm.ShowDialog();
            frm.txtid.Focus();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount>0)
            {
                frm_modificar_control frm = new frm_modificar_control();

                frm.txtid.Text = this.dataGridView1.CurrentRow.Cells["IdControl"].Value.ToString();
                frm.txtpermiso.Text = this.dataGridView1.CurrentRow.Cells["Permiso"].Value.ToString();
                frm.txtretraso.Text = this.dataGridView1.CurrentRow.Cells["Retraso"].Value.ToString();
                frm.txthorasalida.Text = this.dataGridView1.CurrentRow.Cells["HorarioSalida"].Value.ToString();
                frm.txthoraentrada.Text = this.dataGridView1.CurrentRow.Cells["HorarioEntrada"].Value.ToString();
                frm.comboBox1.Text = this.dataGridView1.CurrentRow.Cells["Turno"].Value.ToString();
                frm.txtfaltas.Text = this.dataGridView1.CurrentRow.Cells["Faltas"].Value.ToString();
                frm.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells["FechaEntrada"].Value.ToString();
                frm.dateTimePicker2.Text = this.dataGridView1.CurrentRow.Cells["FechaSalida"].Value.ToString();

                frm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Debe filtrar datos y selecionar!!!");
            }
           
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount>0)
            {
                frm_Mostrar_contron frm = new frm_Mostrar_contron();
                frm.txtid.Text = this.dataGridView1.CurrentRow.Cells["IdControl"].Value.ToString();
                frm.txtpermiso.Text = this.dataGridView1.CurrentRow.Cells["Permiso"].Value.ToString();
                frm.txtretraso.Text = this.dataGridView1.CurrentRow.Cells["Retraso"].Value.ToString();
                frm.txthorasalida.Text = this.dataGridView1.CurrentRow.Cells["HorarioSalida"].Value.ToString();
                frm.txthoraentrada.Text = this.dataGridView1.CurrentRow.Cells["HorarioEntrada"].Value.ToString();
                frm.comboBox1.Text = this.dataGridView1.CurrentRow.Cells["Turno"].Value.ToString();
                frm.txtfalta.Text = this.dataGridView1.CurrentRow.Cells["Faltas"].Value.ToString();
                frm.txtfechaentrada.Text = this.dataGridView1.CurrentRow.Cells["FechaEntrada"].Value.ToString();
                frm.txtfechasalida.Text = this.dataGridView1.CurrentRow.Cells["FechaSalida"].Value.ToString();
                frm.txtestado.Text = this.dataGridView1.CurrentRow.Cells["estado"].Value.ToString();

                frm.txtpermiso.Enabled = false;
                frm.txtretraso.Enabled = false;
                frm.txthorasalida.Enabled = false;
                frm.txthoraentrada.Enabled = false;
                frm.txtfechasalida.Enabled = false;
                frm.txtfechaentrada.Enabled = false;
                frm.txtfalta.Enabled = false;
                frm.txtid.Enabled = false;
                frm.comboBox1.Enabled = false;
                frm.txtestado.Enabled = false;

                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Debe filtrar datos y selecionar!!!");
            }
            
        }

        private void cambioDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount>0)
            {
                frm_eliminar_control frm = new frm_eliminar_control();

                frm.cambioestado = Convert.ToString(this.dataGridView1.CurrentRow.Cells["estado"].Value);

                frm.id = Convert.ToString(this.dataGridView1.CurrentRow.Cells["IdControl"].Value);
                frm.txtid.Text = this.dataGridView1.CurrentRow.Cells["IdControl"].Value.ToString();
                frm.txtpermiso.Text = this.dataGridView1.CurrentRow.Cells["Permiso"].Value.ToString();
                frm.txtretraso.Text = this.dataGridView1.CurrentRow.Cells["Retraso"].Value.ToString();
                frm.txthorasalida.Text = this.dataGridView1.CurrentRow.Cells["HorarioSalida"].Value.ToString();
                frm.txthoraentrada.Text = this.dataGridView1.CurrentRow.Cells["HorarioEntrada"].Value.ToString();
                frm.comboBox1.Text = this.dataGridView1.CurrentRow.Cells["Turno"].Value.ToString();
                frm.txtfaltas.Text = this.dataGridView1.CurrentRow.Cells["Faltas"].Value.ToString();
                frm.txtfechaentrada.Text = this.dataGridView1.CurrentRow.Cells["FechaEntrada"].Value.ToString();
                frm.txtfechasalida.Text = this.dataGridView1.CurrentRow.Cells["FechaSalida"].Value.ToString();
                frm.comboBox2.Text = this.dataGridView1.CurrentRow.Cells["estado"].Value.ToString();

                frm.txtpermiso.Enabled = false;
                frm.txtretraso.Enabled = false;
                frm.txthorasalida.Enabled = false;
                frm.txthoraentrada.Enabled = false;
                frm.txtfechasalida.Enabled = false;
                frm.txtfechaentrada.Enabled = false;
                frm.txtfaltas.Enabled = false;
                frm.txtid.Enabled = false;
                frm.comboBox1.Enabled = false;
                frm.comboBox2.Enabled = false;



                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe filtrar datos y selecionar!!!");
            }
            
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteControl frm = new ReporteControl();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar));

            try
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("  Ingrese parámetros!!!");
            }
            else
            {
                this.dataGridView1.DataSource = Ndepartamento.buscarnombre(textBox1.Text);
                
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string est = "";
            est= this.dataGridView1.CurrentRow.Cells["estado"].Value.ToString();
            if (est == "inactivo")
            {
                this.mostrarToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.mostrarToolStripMenuItem.Enabled = true;
            }
           


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Ndepartamento.mostrar();
        }
    }
}
