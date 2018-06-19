using System;
using System.Collections.Generic;
using System.Linq;

namespace Patxi.Models
{
    public class Producto
    {

        private string id;

        public string Id
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

        private string quantity;

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private string itemsBought;

        public string ItemsBought
        {
            get { return itemsBought; }
            set { itemsBought = value; }
        }

        private string imageURL;

        public string ImageURL
        {
            get { return imageURL; }
            set { imageURL = value; }
        }




    }
}