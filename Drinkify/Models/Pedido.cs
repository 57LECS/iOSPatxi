using System;
using System.Collections.Generic;
using System.Linq;

namespace Patxi.Models
{
    public class Pedido
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        private string repartidor;

        public string Repartidor
        {
            get { return repartidor; }
            set { repartidor = value; }
        }



        private string user;

        public string IdUser
        {
            get { return user; }
            set { user = value; }
        }



        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string fecha;

        public string Date
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        private int idStatus;

        public int IdStatus
        {
            get { return idStatus; }
            set { idStatus = value; }
        }


        private double totalPrice;

        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private double totalProducts;

        public double TotalProducts
        {
            get { return totalProducts; }
            set { totalProducts = value; }
        }



        private List<Producto> lista;

        public List<Producto> Products
        {
            get { return lista; }
            set { lista = value; }
        }

    }
}