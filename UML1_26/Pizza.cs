using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_26
{
    public class Pizza
    {
        private string _name;
        private string _discription;
        private double _price;
        private int _number;

        public Pizza(int number, string name, string discription, double price)
        {
            _name = name;
            _discription = discription;
            _price = price;
            _number = number;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Discription
        {
            get { return _discription; }
            set { _discription = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public override string ToString()
        {
            return $"Number {_number} Name {_name} Discription {_discription} ...... {_price}kr";
        }
    }
}
