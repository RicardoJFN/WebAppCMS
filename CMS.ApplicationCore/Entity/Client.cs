using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.ApplicationCore.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long CCNumber { get; set; }

        public Client()
        {

        }
    }
}
