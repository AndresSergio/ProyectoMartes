using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Ddepartamento
    {

        private int _IdControl;
        private DateTime _FechaEntrada;
        private DateTime _FechaSalida;
        private int _Retraso;
        private string _Faltas;
        private string _Permiso;
        private string _Turno;
        private string _HorarioEntrada;
        private string _HorarioSalida;
        private string _Estado;
        private string _Txtbuscar;

        public int IdControl { get => _IdControl; set => _IdControl = value; }
        public DateTime FechaEntrada { get => _FechaEntrada; set => _FechaEntrada = value; }
        public DateTime FechaSalida { get => _FechaSalida; set => _FechaSalida = value; }
        public int Retraso { get => _Retraso; set => _Retraso = value; }
        public string Faltas { get => _Faltas; set => _Faltas = value; }
        public string Permiso { get => _Permiso; set => _Permiso = value; }
        public string Turno { get => _Turno; set => _Turno = value; }
        public string HorarioEntrada { get => _HorarioEntrada; set => _HorarioEntrada = value; }
        public string HorarioSalida { get => _HorarioSalida; set => _HorarioSalida = value; }
        public string Txtbuscar { get => _Txtbuscar; set => _Txtbuscar = value; }
        public string Estado { get => _Estado; set => _Estado = value; }

        public Ddepartamento()
        {

        }



        public Ddepartamento(  int _IdControl,
         DateTime _FechaEntrada,
         DateTime _FechaSalida,
         int _Retraso,
         string _Faltas,
         string _Permiso,
         string _Turno,
        string _HorarioEntrada,
         string _HorarioSalida,
         string _Estado)
        {
            this.IdControl = _IdControl;
            this.FechaEntrada = _FechaEntrada;
            this.FechaSalida = _FechaSalida;
            this.Retraso = _Retraso;
            this.Faltas = _Faltas;
            this.Permiso = _Permiso;
            this.Turno = _Turno;
            this.HorarioEntrada = _HorarioEntrada;
            this.HorarioSalida = _HorarioSalida;
            this.Estado = _Estado;
        }




        public string insertar(Ddepartamento objcliente)
        {
            string rpta = "";

             SqlConnection sqlcon  = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spinsertar_control";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parcicliente = new SqlParameter();
                parcicliente.ParameterName = "@IdControl";
                parcicliente.SqlDbType = SqlDbType.Int;
                parcicliente.Value = objcliente.IdControl;
                sqlcmd.Parameters.Add(parcicliente);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@FechaEntrada";
                parnombre.SqlDbType = SqlDbType.Date;
                parnombre.Value = objcliente.FechaEntrada;
                sqlcmd.Parameters.Add(parnombre);

                SqlParameter parapellpa = new SqlParameter();
                parapellpa.ParameterName = "@FechaSalida";
                parapellpa.SqlDbType = SqlDbType.Date;
                parapellpa.Value = objcliente.FechaSalida;
                sqlcmd.Parameters.Add(parapellpa);

                SqlParameter parapellma = new SqlParameter();
                parapellma.ParameterName = "@Retraso";
                parapellma.SqlDbType = SqlDbType.Int;
                parapellma.Value = objcliente.Retraso;
                sqlcmd.Parameters.Add(parapellma);

                SqlParameter partelefono = new SqlParameter();
                partelefono.ParameterName = "@Faltas";
                partelefono.SqlDbType = SqlDbType.VarChar;
                partelefono.Size = 50;
                partelefono.Value = objcliente.Faltas;
                sqlcmd.Parameters.Add(partelefono);

                SqlParameter parpermiso = new SqlParameter();
                parpermiso.ParameterName = "@Permiso";
                parpermiso.SqlDbType = SqlDbType.VarChar;
                parpermiso.Size = 50;
                parpermiso.Value = objcliente.Permiso;
                sqlcmd.Parameters.Add(parpermiso);

                SqlParameter parturno = new SqlParameter();
                parturno.ParameterName = "@Turno";
                parturno.SqlDbType = SqlDbType.VarChar;
                parturno.Size = 25;
                parturno.Value = objcliente.Turno;
                sqlcmd.Parameters.Add(parturno);

                SqlParameter parhorasal = new SqlParameter();
                parhorasal.ParameterName = "@HorarioEntrada";
                parhorasal.SqlDbType = SqlDbType.VarChar;
                parhorasal.Size = 15;
                parhorasal.Value = objcliente.HorarioEntrada;
                sqlcmd.Parameters.Add(parhorasal);

                SqlParameter parhorasal2 = new SqlParameter();
                parhorasal2.ParameterName = "@HorarioSalida";
                parhorasal2.SqlDbType = SqlDbType.VarChar;
                parhorasal2.Size = 15;
                parhorasal2.Value = objcliente.HorarioSalida;
                sqlcmd.Parameters.Add(parhorasal2);

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "no se inserto nada";


            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }


            return rpta;

        }


        public string editar(Ddepartamento objcliente)
        {
            string rpta ="";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "speditar_control";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parcicliente = new SqlParameter();
                parcicliente.ParameterName = "@IdControl";
                parcicliente.SqlDbType = SqlDbType.Int;
                parcicliente.Value = objcliente.IdControl;
                sqlcmd.Parameters.Add(parcicliente);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@FechaEntrada";
                parnombre.SqlDbType = SqlDbType.Date;
                parnombre.Value = objcliente.FechaEntrada;
                sqlcmd.Parameters.Add(parnombre);

                SqlParameter parapellpa = new SqlParameter();
                parapellpa.ParameterName = "@FechaSalida";
                parapellpa.SqlDbType = SqlDbType.Date;
                parapellpa.Value = objcliente.FechaSalida;
                sqlcmd.Parameters.Add(parapellpa);

                SqlParameter parapellma = new SqlParameter();
                parapellma.ParameterName = "@Retraso";
                parapellma.SqlDbType = SqlDbType.Int;
                parapellma.Value = objcliente.Retraso;
                sqlcmd.Parameters.Add(parapellma);

                SqlParameter partelefono = new SqlParameter();
                partelefono.ParameterName = "@Faltas";
                partelefono.SqlDbType = SqlDbType.VarChar;
                partelefono.Size = 50;
                partelefono.Value = objcliente.Faltas;
                sqlcmd.Parameters.Add(partelefono);

                SqlParameter parpermiso = new SqlParameter();
                parpermiso.ParameterName = "@Permiso";
                parpermiso.SqlDbType = SqlDbType.VarChar;
                parpermiso.Size = 50;
                parpermiso.Value = objcliente.Permiso;
                sqlcmd.Parameters.Add(parpermiso);

                SqlParameter parturno = new SqlParameter();
                parturno.ParameterName = "@Turno";
                parturno.SqlDbType = SqlDbType.VarChar;
                parturno.Size = 25;
                parturno.Value = objcliente.Turno;
                sqlcmd.Parameters.Add(parturno);

                SqlParameter parhorasal = new SqlParameter();
                parhorasal.ParameterName = "@HorarioEntrada";
                parhorasal.SqlDbType = SqlDbType.VarChar;
                parhorasal.Size = 15;
                parhorasal.Value = objcliente.HorarioEntrada;
                sqlcmd.Parameters.Add(parhorasal);

                SqlParameter parhorasal2 = new SqlParameter();
                parhorasal2.ParameterName = "@HorarioSalida";
                parhorasal2.SqlDbType = SqlDbType.VarChar;
                parhorasal2.Size = 15;
                parhorasal2.Value = objcliente.HorarioSalida;
                sqlcmd.Parameters.Add(parhorasal2);        

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "no se edito nada";


            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }


            return rpta;

        }

       

        public string eliminar(Ddepartamento objcliente)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spelimnar_control";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parcicliente = new SqlParameter();
                parcicliente.ParameterName = "@IdControl";
                parcicliente.SqlDbType = SqlDbType.Int;
                parcicliente.Value = objcliente.IdControl;
                sqlcmd.Parameters.Add(parcicliente);



                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "no se elimino nada";


            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }


            return rpta;

        }



        public DataTable mostrar()
        {
            DataTable dataresul = new DataTable("Control_Trabajador");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spmostrar_control";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter datatabla = new SqlDataAdapter(sqlcmd);
                datatabla.Fill(dataresul);


            }
            catch (Exception ex)
            {

                dataresul = null;
            }

            return dataresul;

        }

        

        public DataTable buscarnombre(Ddepartamento objcategoria)
        {
            DataTable datoscategoria = new DataTable("Control_Trabajador");

            SqlConnection sqlcone = new SqlConnection();

            try
            {
                sqlcone.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcone;
                sqlcmd.CommandText = "spbuscar_control";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parbuscar = new SqlParameter();
                parbuscar.ParameterName = "@txtbuscar";
                parbuscar.SqlDbType = SqlDbType.VarChar;
                parbuscar.Size = 50;
                parbuscar.Value = objcategoria.Txtbuscar;
                sqlcmd.Parameters.Add(parbuscar);

                SqlDataAdapter sqldata = new SqlDataAdapter(sqlcmd);
                sqldata.Fill(datoscategoria);


            }
            catch (Exception)
            {

                datoscategoria = null;
            }

            return datoscategoria;
        }


        //duplicado


        public string estado(Ddepartamento objcliente)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spestado_departamento";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parcicliente = new SqlParameter();
                parcicliente.ParameterName = "@idcliente";
                parcicliente.SqlDbType = SqlDbType.Int;
                parcicliente.Value = objcliente.IdControl;
                sqlcmd.Parameters.Add(parcicliente);

                SqlParameter parestado = new SqlParameter();
                parestado.ParameterName = "@estado";
                parestado.SqlDbType = SqlDbType.VarChar;
                parestado.Size = 15;
                parestado.Value = objcliente.Estado;
                sqlcmd.Parameters.Add(parestado);

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "no se edito nada";


            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }


            return rpta;

        }


        public int codiduplicado(Ddepartamento objcliente)
        {
            int rpta = 0;

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "spcodiduplicado_departamento";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parduplicado = new SqlParameter();
                parduplicado.ParameterName = "cod";
                parduplicado.SqlDbType = SqlDbType.Int;
                parduplicado.Value = objcliente.IdControl;
                sqlcmd.Parameters.Add(parduplicado);
                //el parametro executescalar sirve para comparar de todos los registros contados y de vuelve una sola fila
                rpta = Convert.ToInt32(sqlcmd.ExecuteScalar());





            }
            catch (Exception)
            {


            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return rpta;
        }



    }
}
