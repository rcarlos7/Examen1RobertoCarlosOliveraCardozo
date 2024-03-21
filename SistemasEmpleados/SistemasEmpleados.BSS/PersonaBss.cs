﻿using SistemasEmpleados.DAL;
using SistemasEmpleados.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasEmpleados.BSS
{
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListarPersonasBass()
        {
            return dal.ListarPersonasDal();
        }

        public void InsertarPersonaBss(Persona persona)
        {
            dal.InsertarPersonaDal(persona);
        }

        public Persona ObtenerPersonaIdBss(int id)
        {
            return dal.ObtenerPersonaId(id);
        }

        public void EditarPersonaBss(Persona persona)
        {
            dal.EditarPersonaDal(persona);
        }

        public void EliminarPersonaBss(int id)
        {
            dal.EliminarPersonaDal(id);
        }
    }
}
