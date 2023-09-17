using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OrderContent
    {
        [Key]
        public int Id { get; set; }
        public string OrderContentCode { get; set; }
        public string OrderContentTitle { get; set;}
    }
}
