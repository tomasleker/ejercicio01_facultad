using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facultad.Entidades
{
    public abstract class Persona
    {
        //Atributos
        private string _apellido;
        private string _nombre;
        private DateTime _fechaNac;

        protected string Apellido { get => _apellido; set => _apellido = value; }
        protected string Nombre { get => _nombre; set => _nombre = value; }
        protected DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }


        // METODOS
        protected abstract void GetCredencial();
        protected virtual void GetNombreCompleto()
        { }
        protected void GetSaludoInformal() { }


    }


  

}
