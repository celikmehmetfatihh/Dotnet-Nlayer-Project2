using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerCore.DTOs
{
    public class ProductFeatureDto
    {
        public int ID { get; set; }
        public string Color { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int ProductId { get; set; }
    }
}
