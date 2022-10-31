using System;
using System.Drawing;

namespace BenchmarkMappings.Domain
{
    public partial class ProductVariantCodeGenDto
    {
        public Guid ProductVariantId { get; set; }
        public Color Colour { get; set; }
        public string Size { get; set; }
    }
}