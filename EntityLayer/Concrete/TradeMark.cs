using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TradeMark
    {
        [Key]
        public int Id { get; set; }
        public string TradeName { get; set; }
        public string TradeCode { get; set; }
    }
}
