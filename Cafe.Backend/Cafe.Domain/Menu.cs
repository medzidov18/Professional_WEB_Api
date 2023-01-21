using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Domain
{
    public class Menu
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public float Price { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
