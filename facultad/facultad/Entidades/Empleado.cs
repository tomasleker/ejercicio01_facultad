using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facultad.Entidades
{
    public abstract class Empleado : Persona
    {
        private DateTime _fechaIngreso;
        private int _legajo;

        protected DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }
        protected int Legajo { get => _legajo; set => _legajo = value; }

        //METODODS
        public DateTime FechaNacimiento { get => FechaNac; set => FechaNac = value; }
        public int Antiguedad { get => (DateTime.Now - FechaIngreso).Days /365 ; }
        protected override void GetCredencial()
        { }
        


    }
}
