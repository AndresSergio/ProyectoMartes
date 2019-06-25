    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
   public class Ndepartamento
    {
        public static string insertar(int _IdControl,
         DateTime _FechaEntrada,
         DateTime _FechaSalida,
         int _Retraso,
         string _Faltas,
         string _Permiso,
         string _Turno,
         string _HorarioEntrada,
         string _HorarioSalida
         )
        {
            Ddepartamento depar = new Ddepartamento();
            depar.IdControl = _IdControl;
         depar.FechaEntrada= _FechaEntrada;
         depar.FechaSalida= _FechaSalida;
         depar.Retraso= _Retraso;
         depar.Faltas= _Faltas;
         depar.Permiso= _Permiso;
         depar.Turno= _Turno;
         depar.HorarioEntrada= _HorarioEntrada;
         depar.HorarioSalida= _HorarioSalida;

            return depar.insertar(depar);

        }

        public static string editar(int _IdControl,
         DateTime _FechaEntrada,
         DateTime _FechaSalida,
         int _Retraso,
         string _Faltas,
         string _Permiso,
         string _Turno,
         string _HorarioEntrada,
         string _HorarioSalida)
        {
            Ddepartamento depar = new Ddepartamento();
            depar.IdControl = _IdControl;
            depar.FechaEntrada = _FechaEntrada;
            depar.FechaSalida = _FechaSalida;
            depar.Retraso = _Retraso;
            depar.Faltas = _Faltas;
            depar.Permiso = _Permiso;
            depar.Turno = _Turno;
            depar.HorarioEntrada = _HorarioEntrada;
            depar.HorarioSalida = _HorarioSalida;

            return depar.editar(depar);

           

        }


        public static string eliminar(int cicliente)
        {

            Ddepartamento obj = new Ddepartamento();
            obj.IdControl = cicliente;
            return obj.eliminar(obj);

        }

       


        public static DataTable mostrar()
        {
            return new Ddepartamento().mostrar();
        }





        public static DataTable buscarnombre(string txtbuscar)
        {
            Ddepartamento obj = new Ddepartamento();

            obj.Txtbuscar = txtbuscar;
            return obj.buscarnombre(obj);
        }


        public static string estado(int cicliente, string estado)
        {
            Ddepartamento obj = new Ddepartamento();
            obj.IdControl = cicliente;
            obj.Estado = estado;
            return obj.estado(obj);
        }


        public static int duplicado(int ci)
        {
            Ddepartamento obj = new Ddepartamento();

            obj.IdControl = ci;
            return obj.codiduplicado(obj);
        }



    }
}

