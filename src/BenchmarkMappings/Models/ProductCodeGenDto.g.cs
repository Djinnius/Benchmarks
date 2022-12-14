using System;
using System.Collections.Generic;
using BenchmarkMappings.Domain;

namespace BenchmarkMappings.Domain
{
    public partial class ProductCodeGenDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }
        public ProductVariantCodeGenDto DefaultOption { get; set; }
        public List<ProductVariantCodeGenDto> Options { get; set; }
    }
}