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
    public partial class Frm_registrar_Control : Form
    {
        

        public Frm_registrar_Control()
        {
            InitializeComponent();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtfaltas.Text=="")
            {
                MessageBox.Show("Debe ingresar todos los campos!!!");
            }

            else
            {
                int duplicad = Ndepartamento.duplicado(Convert.ToInt32(txtid.Text));

                if (duplicad > 0)
                {
                    MessageBox.Show("Codigo duplicado");
                    txtid.Focus();
                }
                string rpta = "";

                rpta = Ndepartamento.insertar(Convert.ToInt32(txtid.Text.Trim().ToUpper()), dateTimePicker3.Value, dateTimePicker4.Value, Convert.ToInt32(txtretraso.Text.Trim().ToUpper()), txtfaltas.Text.Trim().ToUpper(),
                    txtpermiso.Text.Trim().ToUpper(), comboBox1.Text, txthoraentrada.Text.Trim().ToUpper(), txthorasalida.Text.Trim().ToUpper());

                if (rpta.Equals("ok"))
                {

                    MessageBox.Show("Se añadio exitosamente!");

                    Close();
                }
            }



        }

        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        if (char.IsLetter(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }

        //        else if (char.IsControl(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else if (char.IsSeparator(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else
        //        {
        //            e.Handled = true;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        if (char.IsLetter(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }

        //        else if (char.IsControl(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else if (char.IsSeparator(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else
        //        {
        //            e.Handled = true;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        if (char.IsLetter(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }

        //        else if (char.IsControl(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else if (char.IsSeparator(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else
        //        {
        //            e.Handled = true;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        if (char.IsLetter(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }

        //        else if (char.IsControl(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else if (char.IsSeparator(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else
        //        {
        //            e.Handled = true;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        if (Char.IsDigit(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else if (Char.IsControl(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else if (Char.IsSeparator(e.KeyChar))
        //        {
        //            e.Handled = false;
        //        }
        //        else
        //        {
        //            e.Handled = true;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

   

        private void txtretraso_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_registrar_Control_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                    e.Handled = true;
         
           
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

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
