﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ExistingDb.Models.Manual
{
    public class Shoe
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        [Column("ColorId")]
        public long StyleId { get; set; }

        [ForeignKey("StyleId")]
        public Style Style { get; set; }

        public long WidthId { get; set; }
        public ShoeWidth Width { get; set; }
    }
}
