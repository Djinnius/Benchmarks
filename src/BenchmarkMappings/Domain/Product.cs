using Mapster;
using System;
using System.Collections.Generic;

namespace BenchmarkMappings.Domain
{
    [AdaptTo("[name]CodeGenDto"), GenerateMapper]
    public class Product
    {
        public Guid Id { get; set; }

        public string ProductName { get; set; }

        public decimal Weight { get; set; }

        public string Description { get; set; }

        public ProductVariant DefaultOption { get; set; }

        public List<ProductVariant> Options { get; set; }
    }
}
