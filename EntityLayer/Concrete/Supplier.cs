using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }

        [MaxLength(100)]
        public string SuplierAddress{ get; set; }
        public string SupplierCity { get; set;}
        public string SupplierState { get; set;}
        public string SupplierPhoneNumber { get; set;}
        public string SupplierEmail { get; set;}

    }
}
