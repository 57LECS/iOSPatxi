using System;
using System.Collections.Generic;
using System.Linq;

namespace Patxi.Models
{
    public class Status
    {
        private double id;

        public double Id
        {
            get { return id; }
            set { id = value; }
        }

        private string Nombre;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }


        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }




    }
}