using System;
using System.Collections.Generic;
using System.Linq;


namespace Patxi.Models
{
    public class Persona
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

        private string apeliidoPaterno;

        public string LastNameP
        {
            get { return apeliidoPaterno; }
            set { apeliidoPaterno = value; }
        }

        private string apellidoMaterno;

        public string LastNameM
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }


        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string cellphone;

        public string Cellphone
        {
            get { return cellphone; }
            set { cellphone = value; }
        }

        private DateTime fechaNacimiento;

        public DateTime BirthDay
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        private bool gender;

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }







    }
}
