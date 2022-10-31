using Mapster;
using System;
using System.Drawing;

namespace BenchmarkMappings.Domain
{
    [AdaptTo("[name]CodeGenDto"), GenerateMapper]
    public class ProductVariant
    {
        public Guid ProductVariantId { get; set; }

        public Color Colour { get; set; }

        public string Size { get; set; }
    }
}
