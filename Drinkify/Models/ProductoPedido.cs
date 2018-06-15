using System;
using System.Collections.Generic;
using System.Linq;

namespace Patxi.Models
{
    public class ProductoPedido
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private Producto producto;

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }


    }
}