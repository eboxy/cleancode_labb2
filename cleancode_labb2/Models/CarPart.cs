using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace cleancode_labb2.Models
{
    public class CarPart
    {
        public int Id { get; set; }
        public string PartName { get; set; }
        public int PartPrice { get; set; }
        public string PartCategory { get; set; }
        public int Quantity { get; set; }
        public string Section { get; set; }

    }
}
