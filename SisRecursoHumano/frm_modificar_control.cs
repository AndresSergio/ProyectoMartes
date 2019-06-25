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
    public partial class frm_modificar_control : Form
    {
        public frm_modificar_control()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtfaltas.Text == "" || txtpermiso.Text== "" || txtretraso.Text ==""
                || txthoraentrada.Text =="" || txthorasalida.Text == "")
            {
                MessageBox.Show("rellenar todos los campos");
            }
            else
            {
                string rpta = "";
                rpta = Ndepartamento.editar(Convert.ToInt32(txtid.Text.Trim().ToUpper()), dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(txtretraso.Text.Trim().ToUpper()), txtfaltas.Text.Trim().ToUpper(),
                    txtpermiso.Text.Trim().ToUpper(), comboBox1.Text, txthoraentrada.Text.Trim().ToUpper(), txthorasalida.Text.Trim().ToUpper());

                if (rpta.Equals("ok"))
                {

                    MessageBox.Show(" Se modifico exitosamente!");

                    Close();
                }
            }
           
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void txtretraso_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void txtfaltas_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void txtpermiso_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void txthoraentrada_KeyPress(object sender, KeyPressEventArgs e)
        {

            int tecla = Convert.ToInt32(e.KeyChar);
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 59 && e.KeyChar <= 255))
            {

                e.Handled = true;
                return;
            }

            else if (tecla == 13)
            {
                txthoraentrada.Focus();

            }
        }

        private void txthorasalida_KeyPress(object sender, KeyPressEventArgs e)
        {

            int tecla = Convert.ToInt32(e.KeyChar);
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 59 && e.KeyChar <= 255))
            {

                e.Handled = true;
                return;
            }

            else if (tecla == 13)
            {
                txthorasalida.Focus();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_modificar_control_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
