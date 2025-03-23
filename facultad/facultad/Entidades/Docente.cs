using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facultad.Entidades
{
    public class Docente : Empleado
    {

        protected void GetNombreCompleto(string Nombre, string Apellido)
        {
            string nombreCompleto = Nombre + " " + Apellido;
        }
        protected override bool ListarEmpleados(bool listarConId)
        {
            return listarConId;
        }

    }
}
