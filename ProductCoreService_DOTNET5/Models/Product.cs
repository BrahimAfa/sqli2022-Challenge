using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCoreService_DOTNET5.Models
{
    public class Product
    {
        public string name { get; set; }
        public string category { get; set; }
        public int price { get; set; }
        public int discount { get; set; }
        public int quantity { get; set; }
        public int barcode { get; set; }
    }
}
