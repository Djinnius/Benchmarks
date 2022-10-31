using System;
using System.Drawing;

namespace BenchmarkMappings.Dtos
{
    public class ProductVariantDto
    {
        public Guid ProductVariantId { get; set; }

        public Color Colour { get; set; }

        public string Size { get; set; }
    }
}
