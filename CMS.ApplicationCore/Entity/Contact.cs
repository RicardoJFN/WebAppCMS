using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.ApplicationCore.Entity
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public Contact()
        {

        }
    }

}
