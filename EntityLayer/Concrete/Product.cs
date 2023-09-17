using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductCode{ get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductStock { get; set; }
        public string ProductColor { get; set; }
        public double ProductPrice{ get; set; }
        public DateTime ProductUpdateTime { get; set; }

    }
}
