using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    abstract class Product
    {
        //private Product()
        //public abstract bool Checkout();
        //public abstract void Edit();

        public string Name;
        public string Description;
    }

    class Item : Product 
    {
        public string PartNumber;
        public double Price;
        public int OnHand = 0;
        //private Brand Brand;
    }

    class Service : Product
    {
        public double Price;
    }

    class Rental : Product
    {
        //private Rental();
        //public Rental();
        //public bool Return();

        public double Hourly;
        public double FourHours;
        public double Daily;
        public double Weekly;

        public bool OnHand = true;
        public Client CurrentRenter = null;
        public Client[] RecentRenters = {null,null};

    }

    class Repair : Product
    {
        public List<Item> PartsUsed;
        public List<string> ServiceRecord;
        public double Hours = 0;
    }
}