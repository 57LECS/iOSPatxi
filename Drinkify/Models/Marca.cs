using System;
using System.Collections.Generic;
using System.Linq;

namespace Patxi.Models
{
    public class Marca
    {
        private double id;

        public double Id
        {
            get { return id; }
            set { id = value; }
        }


        private string nombre;

        public string Name
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string pais;

        public string Country
        {
            get { return pais; }
            set { pais = value; }
        }

    }
}