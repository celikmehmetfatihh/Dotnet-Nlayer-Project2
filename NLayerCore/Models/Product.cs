﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerCore.Models
{
    public class Product : BaseEntity
    {

        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        //[ForeignKey("Kategory_id")]
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }

    }
}
