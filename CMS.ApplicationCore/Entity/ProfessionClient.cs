﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.ApplicationCore.Entity
{
    public class ProfessionClient
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }
    }
}
