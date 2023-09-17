using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string CategoryCode { get; set; }
    }
}
