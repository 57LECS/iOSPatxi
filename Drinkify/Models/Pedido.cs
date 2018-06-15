using System;
using System.Collections.Generic;
using System.Linq;

namespace Patxi.Models
{
    public class Pedido
    {
        private double id;

        public double Id
        {
            get { return id; }
            set { id = value; }
        }


        private int idRepartidor;

        public int IdRepartidor
        {
            get { return idStatus; }
            set { idStatus = value; }
        }

        private Repartidor delivery;

        public Repartidor Delivery    
        {
            get { return delivery; }
            set { delivery = value; }
        }

        private int idUser;

        public int IdUser
        {
            get { return idStatus; }
            set { idStatus = value; }
        }

        private Usuario user;

        public Usuario User
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

        private DateTime fecha;

        public DateTime Date
        {
            get { return fecha; }
            set { fecha = value; }
        }


        private int idStatus;

        public int IdStatus
        {
            get { return idStatus; }
            set { idStatus = value; }
        }



        private Status status;

        public Status Status
        {
            get { return status; }
            set { status = value; }
        }

        private double totalPrice;

        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private List<ProductoPedido> lista;

        public List<ProductoPedido> Products
        {
            get { return lista; }
            set { lista = value; }
        }

    }
}