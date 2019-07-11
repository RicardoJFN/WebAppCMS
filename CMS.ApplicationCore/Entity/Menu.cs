using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.ApplicationCore.Entity
{
    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? MenuId { get; set; }
        public ICollection<Menu> SubMenu { get; set; }
    }
}
