using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.ApplicationCore.Entity
{
    public class Address
    {
        public Address()
        {

        }

        public int Id { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Reference { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
