using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstProject.Model.DAL.ORM.Entity
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }


    }
}
