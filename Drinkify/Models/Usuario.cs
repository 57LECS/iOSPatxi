using System;
using System.Collections.Generic;
using System.Linq;

namespace Patxi.Models
{
    public class Usuario
    {
        private double id;

        public double Id
        {
            get { return id; }
            set { id = value; }
        }

        private double personaId;

        public double PersonaId
        {
            get { return personaId; }
            set { personaId = value; }
        }

    }
}