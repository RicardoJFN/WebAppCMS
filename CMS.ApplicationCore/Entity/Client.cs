﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.ApplicationCore.Entity
{
    public class Client
    {
        public Client()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public long CCNumber { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public Address Address { get; set; }
        public ICollection<ProfessionClient> ProfessionsClients { get; set; }
    }
}
