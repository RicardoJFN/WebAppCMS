using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.ApplicationCore.Entity
{
    public class Profession
    {
        public Profession()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public ICollection<ProfessionClient> ProfessionsClients { get; set; }
    }
}
