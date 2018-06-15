using System;
using System.Collections.Generic;
using System.Linq;

namespace Patxi.Models
{
    public class Alcohol
    {
        private double id;

        public double Id
        {
            get { return id; }
            set { id = value; }
        }

        private Marca brand;

        public Marca Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private float porcentage;

        public float Porcentage
        {
            get { return porcentage; }
            set { porcentage = value; }
        }

        private string flavor;

        public string Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }


    }

    public enum Alcoholes
    {
        Brandy,
        Cerveza,
        Cognac,
        Ginebra,
        Mezcal,
        Ron,
        Tequila,
        Vino,
        Vodka,
        Whisky

    }
}