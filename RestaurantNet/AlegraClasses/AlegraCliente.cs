using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantNet.AlegraClasses
{
    public class AlegraCliente
    {
        public class Identification
        {
            public string number { get; set; }
            public string type { get; set; }
        }

        public class Address
        {
            public string address { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public string district { get; set; }
            public string urbanization { get; set; }
            public string ubigeoCode { get; set; }
        }

        public class Term
        {
            public string id { get; set; }
            public string name { get; set; }
            public string days { get; set; }
        }

        public class InternalContact
        {
            public string id { get; set; }
            public string name { get; set; }
            public string lastName { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string mobile { get; set; }
            public bool sendNotifications { get; set; }
        }

        public class Client
        {
            public string id { get; set; }
            public string name { get; set; }
            public Identification identification { get; set; }
            public string email { get; set; }
            public string phonePrimary { get; set; }
            public string phoneSecondary { get; set; }
            public string fax { get; set; }
            public string mobile { get; set; }
            public string observations { get; set; }
            public Address address { get; set; }
            public List<string> type { get; set; }
            public object seller { get; set; }
            public Term term { get; set; }
            public object priceList { get; set; }
            public List<InternalContact> internalContacts { get; set; }
        }
    }
}
