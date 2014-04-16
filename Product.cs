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

        protected string Name;
        protected string Description;
    }

    class Item : Product 
    {
        private string PartNumber;
        private double Price;
        private int OnHand = 0;
        //private Brand Brand;
    }

    class Service : Product
    {
        private double Price;
    }

    class Rental : Product
    {
        //private Rental();
        //public Rental();
        //public bool Return();

        private double Hourly;
        private double FourHours;
        private double Daily;
        private double Weekly;

        private bool OnHand = true;
        private Client CurrentRenter = null;
        //rental history

    }

    class Repair : Product
    {
        //private Item[] PartsUsed;
        //private string[] ServiceRecord;
        private double Hours = 0;
    }
}