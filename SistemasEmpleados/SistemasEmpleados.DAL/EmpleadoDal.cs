using SistemasEmpleados.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasEmpleados.DAL
{
    public class EmpleadoDal
    {
        public DataTable ListarEmpleadosDal()
        {
            string consulta = "select * from empleado";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarEmpleadoDal(Empleado empleado)
        {
            string consulta = "insert into empleado values(" + empleado.IdPersona + "," +
                                                         "'" + empleado.Puesto + "'," +
                                                          "" + empleado.Salario + "," +
                                                         "'" + empleado.FechadeContratacion + "')";
            Conexion.Ejecutar(consulta);
        }

        public Empleado ObtenerEmpleadoId(int id)
        {
            string consulta = "select * from empleado where idempleado = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Empleado empleado = new Empleado();
            if (tabla.Rows.Count > 0)
            {
                empleado.IdEmpleado = Convert.ToInt32(tabla.Rows[0]["idEmpleado"]);
                empleado.IdPersona = Convert.ToInt32(tabla.Rows[0]["idPersona"]);
                empleado.Puesto = tabla.Rows[0]["puesto"].ToString();
                empleado.Salario = Convert.ToDecimal(tabla.Rows[0]["salario"].ToString());
                empleado.FechadeContratacion = Convert.ToDateTime(tabla.Rows[0]["fechadeContratacion"].ToString());
            }
            return empleado;
        }

        public void EditarEmpleadoDal(Empleado empleado)
        {
            string consulta = "update empleado set idpersona = " + empleado.IdPersona + "," +
                                                     "puesto = '" + empleado.Puesto + "'," +
                                                    "salario = " + empleado.Salario + "," +
                                        "fechadeContratacion = '" + empleado.FechadeContratacion + "' " +
                                    "where idempleado = " + empleado.IdEmpleado;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarEmpleadoDal(int id)
        {
            string consulta = "delete from empleado where idempleado =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
