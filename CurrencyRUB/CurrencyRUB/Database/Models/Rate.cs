using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace CurrencyRUB
{
    class Rate
    {
        [MaxLength(10)]
        [MinLength(10)]
        [Key]
        public string Date { get; set; }
        [MaxLength(3)]
        [MinLength(3)]
        [Key]
        public string FromCurrency { get; set; }
        [MaxLength(3)]
        [MinLength(3)]
        [Key]
        public string ToCurrency { get; set; }
        public decimal Value { get; set; }
        
    }

}
