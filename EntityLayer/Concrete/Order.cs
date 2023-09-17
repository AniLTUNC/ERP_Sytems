using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string OrderName { get; set; }
        public string OrderCode { get; set; }
        public DateTime OrderTime { get; set; }
        public double OrderPrice { get; set; }
        public double OrderTotalPrice { get; set; }
    }
}
