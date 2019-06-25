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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = contenedor_principal.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la coleccion el formulario
            //Si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.None;
                contenedor_principal.Controls.Add(formulario);
                contenedor_principal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                
            }
            //si el formulario existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BarraLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelCotenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pn_reclutamiento.Visible == true)
            {
                pn_reclutamiento.Visible = false;
            }
            else
            {
                pn_reclutamiento.Visible = true;
            }
            //btn_reclutamiento.Location = new Point(22, 148);
            pn_reclutamiento.Location = new Point(22, 190);
            btn_contratacion.Location = new Point(22, 282);
            btn_control_trabajador.Location = new Point(22, 330);
            btn_departamento.Location = new Point(22, 384);
            btn_seguro_social.Location = new Point(22, 430);
            btn_motivacion.Location = new Point(22, 480);
            btn_despido.Location = new Point(22, 530);
            pn_contratacion.Hide();
            pn_control_tra.Hide();
            pn_despido.Hide();
            pn_motivacion.Hide();
            pn_seguro_social.Hide();
            pn_departamento.Hide();

            if (pn_reclutamiento.Visible == false)
            {
                //btn_reclutamiento.Location = new Point(22, 148);
                btn_contratacion.Location = new Point(22, 194);
                btn_control_trabajador.Location = new Point(22, 247);
                btn_departamento.Location = new Point(22, 293);
                btn_seguro_social.Location = new Point(22, 338);
                btn_motivacion.Location = new Point(22, 384);
                btn_despido.Location = new Point(22, 430);

            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (pn_contratacion.Visible == true)
            {
                pn_contratacion.Visible = false;
            }
            else
            {
                pn_contratacion.Visible = true;
            }
            pn_contratacion.Location = new Point(22, 240);

            btn_contratacion.Location = new Point(22, 200);
            btn_reclutamiento.Location = new Point(22, 148);
            btn_control_trabajador.Location = new Point(22, 338);
            btn_departamento.Location = new Point(22, 384);
            btn_seguro_social.Location = new Point(22, 430);
            btn_motivacion.Location = new Point(22, 480);
            btn_despido.Location = new Point(22, 530);

            pn_reclutamiento.Hide();
            pn_control_tra.Hide();
            pn_departamento.Hide();
            if (pn_contratacion.Visible == false)
            {
                btn_reclutamiento.Location = new Point(22, 148);
                btn_contratacion.Location = new Point(22, 194);
                btn_control_trabajador.Location = new Point(22, 247);
                btn_departamento.Location = new Point(22, 293);
                btn_seguro_social.Location = new Point(22, 338);
                btn_motivacion.Location = new Point(22, 384);
                btn_despido.Location = new Point(22, 430);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            pn_contratacion.Visible = false;
            pn_reclutamiento.Visible = false;
            pn_control_tra.Visible = false;
            pn_departamento.Visible = false;
            pn_seguro_social.Visible = false;
            pn_motivacion.Visible = false;
            pn_despido.Visible = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btn_control_trabajador_Click(object sender, EventArgs e)
        {
            if (pn_control_tra.Visible == true)
            {
                pn_control_tra.Visible = false;
            }
            else
            {
                pn_control_tra.Visible = true;
            }
            btn_control_trabajador.Location = new Point(22, 247);
            pn_control_tra.Location = new Point(22, 286);
            btn_departamento.Location = new Point(22, 384);
            btn_seguro_social.Location = new Point(22, 430);
            btn_motivacion.Location = new Point(22, 480);
            btn_despido.Location = new Point(22, 530);
            btn_departamento.Location=new Point(22,385);
            pn_contratacion.Hide();
            pn_despido.Hide();
            pn_motivacion.Hide();
            pn_seguro_social.Hide();
            pn_departamento.Hide();
            pn_reclutamiento.Hide();
            if (pn_control_tra.Visible == false)
            {
                btn_reclutamiento.Location = new Point(22, 148);
                btn_contratacion.Location = new Point(22, 194);
                btn_departamento.Location = new Point(22, 293);
                btn_seguro_social.Location = new Point(22, 338);
                btn_motivacion.Location = new Point(22, 384);
                btn_despido.Location = new Point(22, 430);
            }
        }

        private void btn_tepartamento_Click(object sender, EventArgs e)
          
        {
            if (pn_departamento.Visible == true)
            {
                pn_departamento.Visible = false;
            }
            else
            {
               
                pn_departamento.Visible = true;
            }
            
            btn_departamento.Location = new Point(22, 293);
            pn_departamento.Location = new Point(22, 339);
            btn_seguro_social.Location = new Point(22, 430);
            btn_motivacion.Location = new Point(22, 480);
            btn_despido.Location = new Point(22, 530);

            pn_contratacion.Hide();
            pn_despido.Hide();
            pn_motivacion.Hide();
            pn_seguro_social.Hide();
            
            pn_reclutamiento.Hide();

            pn_control_tra.Hide();

            if (pn_departamento.Visible == false)
            {
                btn_reclutamiento.Location = new Point(22, 148);
                btn_contratacion.Location = new Point(22, 194);
                btn_departamento.Location = new Point(22, 293);
                btn_seguro_social.Location = new Point(22, 338);
                btn_motivacion.Location = new Point(22, 384);
                btn_despido.Location = new Point(22, 430);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_seguro_social_Click(object sender, EventArgs e)
        {
            if (pn_seguro_social.Visible == true)
            {
                pn_seguro_social.Visible = false;
            }
            else
            {
                pn_seguro_social.Visible = true;
            }
            btn_seguro_social.Location = new Point(22, 338);
            pn_seguro_social.Location = new Point(18, 384);

            btn_motivacion.Location = new Point(22, 480);
            btn_despido.Location = new Point(22, 530);

            pn_contratacion.Hide();
            pn_despido.Hide();
            pn_motivacion.Hide();
            pn_reclutamiento.Hide();
            pn_control_tra.Hide();
            pn_departamento.Hide();

            if (pn_seguro_social.Visible == false)
            {
                btn_reclutamiento.Location = new Point(22, 148);
                btn_contratacion.Location = new Point(22, 194);
                btn_departamento.Location = new Point(22, 293);
                btn_motivacion.Location = new Point(22, 384);
                btn_despido.Location = new Point(22, 430);
            }
        }

        private void btn_motivacion_Click(object sender, EventArgs e)
        {
            if (pn_motivacion.Visible == true)
            {
                pn_motivacion.Visible = false;
            }
            else
            {
                pn_motivacion.Visible = true;
            }
            btn_motivacion.Location = new Point(22, 384);
            pn_motivacion.Location = new Point(22, 430);

            btn_despido.Location = new Point(22, 530);

            pn_contratacion.Hide();
            pn_despido.Hide();
            pn_reclutamiento.Hide();
            pn_control_tra.Hide();
            pn_departamento.Hide();
            pn_seguro_social.Hide();

            if (pn_motivacion.Visible == false)
            {
                btn_reclutamiento.Location = new Point(22, 148);
                btn_contratacion.Location = new Point(22, 194);
                btn_departamento.Location = new Point(22, 293);
                btn_despido.Location = new Point(22, 430);
            }
        }

        private void btn_despido_Click(object sender, EventArgs e)
        {
            if (pn_despido.Visible == true)
            {
                pn_despido.Visible = false;
            }
            else
            {
                pn_despido.Visible = true;
            }
            btn_despido.Location = new Point(22, 430);
            pn_despido.Location = new Point(22, 466);

            pn_contratacion.Hide();
            pn_reclutamiento.Hide();
            pn_control_tra.Hide();
            pn_departamento.Hide();
            pn_seguro_social.Hide();
            pn_motivacion.Hide();

            if (pn_despido.Visible == false)
            {
                btn_reclutamiento.Location = new Point(22, 148);
                btn_contratacion.Location = new Point(22, 194);
                btn_departamento.Location = new Point(22, 293);

            }
        }

        private void btn_trabajador_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Listar_Trabajadores>();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<frm_listar_benificiario>();
        }

        private void btn_desempaño_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Listar_Desempeño>();
        }

        private void btn_mot_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Listar_Motivacion>();
        }

        private void btn_memorandum_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_memorandum>();
        }

        private void btn_tipo_incum_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Tipo_De_Incumplimiento>();
        }

        private void btn_desp_colec_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Despido_Colectivo>();
        }

        private void btn_desp_disci_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Despido_Diciplinario>();
        }

        private void btn_personas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Lista_Personas>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_tipo_seguro>();
        }

        private void cpn_deplegable_1_Click(object sender, EventArgs e)
        {

        }

        private void btn_control_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Listar_Control>();
        }

        private void btn_departamentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_departamento>();
        }
    }
}
