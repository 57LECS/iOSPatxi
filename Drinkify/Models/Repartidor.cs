using System;
using System.Collections.Generic;
using System.Linq;

namespace Patxi.Models
{
    public class Repartidor
    {
        private double id;

        public double Id
        {
            get { return id; }
            set { id = value; }
        }

        private Persona persona;

        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        private string rfc;

        public string RFC
        {
            get { return rfc; }
            set { rfc = value; }
        }

        private string curp;

        public string Curp
        {
            get { return curp; }
            set { curp = value; }
        }

        private bool available;

        public bool Available
        {
            get { return available; }
            set { available = value; }

        }




    }
}