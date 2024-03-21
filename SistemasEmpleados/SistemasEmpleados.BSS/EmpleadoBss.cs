using SistemasEmpleados.DAL;
using SistemasEmpleados.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasEmpleados.BSS
{
    public class EmpleadoBss
    {
        EmpleadoDal dal = new EmpleadoDal();
        public DataTable ListarEmpleadosBass()
        {
            return dal.ListarEmpleadosDal();
        }

        public void InsertarEmpleadoBss(Empleado empleado)
        {
            dal.InsertarEmpleadoDal(empleado);
        }

        public Empleado ObtenerEmpleadoIdBss(int id)
        {
            return dal.ObtenerEmpleadoId(id);
        }

        public void EditarEmpleadoBss(Empleado empleado)
        {
            dal.EditarEmpleadoDal(empleado);
        }

        public void EliminarEmpleadoBss(int id)
        {
            dal.EliminarEmpleadoDal(id);
        }
    }
}
