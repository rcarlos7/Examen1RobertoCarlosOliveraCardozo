﻿using SistemasEmpleados.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasEmpleados.DAL
{
    public class PersonaDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "select * from persona";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarPersonaDal(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.Nombre + "'," +
                                                         "'" + persona.Apellido + "'," +
                                                         "'" + persona.Estado + "')";
            Conexion.Ejecutar(consulta);
        }

        public Persona ObtenerPersonaId(int id)
        {
            string consulta = "select * from persona where idpersona = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Persona persona = new Persona();
            if (tabla.Rows.Count > 0)
            {
                persona.IdPersona = Convert.ToInt32(tabla.Rows[0]["idPersona"]);
                persona.Nombre = tabla.Rows[0]["nombre"].ToString();
                persona.Apellido = tabla.Rows[0]["apellido"].ToString();
                persona.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return persona;
        }

        public void EditarPersonaDal(Persona persona)
        {
            string consulta = "update persona set nombre ='" + persona.Nombre + "'," +
                                                 "apellido ='" + persona.Apellido + "'," +
                                                 "estado ='" + persona.Estado + "' " +
                                    "where idpersona=" + persona.IdPersona;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarPersonaDal(int id)
        {
            string consulta = "delete from persona where idpersona =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
