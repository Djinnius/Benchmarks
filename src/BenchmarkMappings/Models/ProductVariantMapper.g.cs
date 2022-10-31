using BenchmarkMappings.Domain;

namespace BenchmarkMappings.Domain
{
    public static partial class ProductVariantMapper
    {
        public static ProductVariantCodeGenDto AdaptToCodeGenDto(this ProductVariant p1)
        {
            return p1 == null ? null : new ProductVariantCodeGenDto()
            {
                ProductVariantId = p1.ProductVariantId,
                Colour = p1.Colour,
                Size = p1.Size
            };
        }
        public static ProductVariantCodeGenDto AdaptTo(this ProductVariant p2, ProductVariantCodeGenDto p3)
        {
            if (p2 == null)
            {
                return null;
            }
            ProductVariantCodeGenDto result = p3 ?? new ProductVariantCodeGenDto();
            
            result.ProductVariantId = p2.ProductVariantId;
            result.Colour = p2.Colour;
            result.Size = p2.Size;
            return result;
            
        }
    }
}