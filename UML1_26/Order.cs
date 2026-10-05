using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_26
{
    public class Order
    {
        public Customer Customer { get; }
        public Pizza Pizza { get; }

        private string _orderDate;
        private int _tableNo;
        public bool Deliver
        {
            get;
            set;
        }
        public Order(Pizza pizza, Customer customer, string orderDate, int tableNo, bool deliver)
        {
            Pizza = pizza;
            Customer = customer;
            _orderDate = orderDate;
            _tableNo = tableNo;
            Deliver = deliver;
        }
        
        
        public int TableNo
        {
            get { return _tableNo; }
            set { _tableNo = value; }
        }
        public string OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }
        public double CalculateTotalPrice()
        {
            if (Deliver == true)
            {
                return (Pizza.Price * 1.25) + 40;
            }
            return (Pizza.Price * 1.25);
        }
        public override string ToString()
        {
            if (Deliver == true)
            {
                return $"Ordrenummer 1 er bestilt {_orderDate} af {Customer.Name} på {Customer.Address} og der er bestilt 1 nummer {Pizza.Number}-{Pizza.Name}-{Pizza.Price}kr + moms. totalPrice:{CalculateTotalPrice()}kr.";
            }
            return $"Ordrenummer 1 er bestilt {_orderDate} af {Customer.Name} til bord {_tableNo} og der er bestilt 1 nummer {Pizza.Number}-{Pizza.Name}-{Pizza.Price}kr. totalPrice:{CalculateTotalPrice()}kr.";
        }
    }
}
