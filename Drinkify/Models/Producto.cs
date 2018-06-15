using System;
using System.Collections.Generic;
using System.Linq;

namespace Patxi.Models
{
    public class Producto
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private double  price;

        public double  Price
        {
            get { return price; }
            set { price = value; }
        }

        private decimal quantity;

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private Alcohol alcohol;

        public Alcohol Alcohol
        {
            get { return alcohol; }
            set { alcohol = value; }
        }

        public static implicit operator string(Producto v)
        {
            throw new NotImplementedException();
        }
    }
}