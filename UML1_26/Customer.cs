using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_26
{
    public class Customer
    {
        private string _name;
        private int _tlf;
        private string _address;
        

        public Customer(string name, int tlf, string address)
        {
            _name = name;
            _tlf = tlf;
            _address = address;
            
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        
        
        public override string ToString()
        {
            return $"Name {_name} Tlf {_tlf} Address {_address}";
        }
    }
}
