using System.Collections.Generic;
using BenchmarkMappings.Domain;

namespace BenchmarkMappings.Domain
{
    public static partial class ProductMapper
    {
        public static ProductCodeGenDto AdaptToCodeGenDto(this Product p1)
        {
            return p1 == null ? null : new ProductCodeGenDto()
            {
                Id = p1.Id,
                ProductName = p1.ProductName,
                Weight = p1.Weight,
                Description = p1.Description,
                DefaultOption = p1.DefaultOption == null ? null : new ProductVariantCodeGenDto()
                {
                    ProductVariantId = p1.DefaultOption.ProductVariantId,
                    Colour = p1.DefaultOption.Colour,
                    Size = p1.DefaultOption.Size
                },
                Options = funcMain1(p1.Options)
            };
        }
        public static ProductCodeGenDto AdaptTo(this Product p3, ProductCodeGenDto p4)
        {
            if (p3 == null)
            {
                return null;
            }
            ProductCodeGenDto result = p4 ?? new ProductCodeGenDto();
            
            result.Id = p3.Id;
            result.ProductName = p3.ProductName;
            result.Weight = p3.Weight;
            result.Description = p3.Description;
            result.DefaultOption = funcMain2(p3.DefaultOption, result.DefaultOption);
            result.Options = funcMain3(p3.Options, result.Options);
            return result;
            
        }
        
        private static List<ProductVariantCodeGenDto> funcMain1(List<ProductVariant> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            List<ProductVariantCodeGenDto> result = new List<ProductVariantCodeGenDto>(p2.Count);
            
            int i = 0;
            int len = p2.Count;
            
            while (i < len)
            {
                ProductVariant item = p2[i];
                result.Add(item == null ? null : new ProductVariantCodeGenDto()
                {
                    ProductVariantId = item.ProductVariantId,
                    Colour = item.Colour,
                    Size = item.Size
                });
                i++;
            }
            return result;
            
        }
        
        private static ProductVariantCodeGenDto funcMain2(ProductVariant p5, ProductVariantCodeGenDto p6)
        {
            if (p5 == null)
            {
                return null;
            }
            ProductVariantCodeGenDto result = p6 ?? new ProductVariantCodeGenDto();
            
            result.ProductVariantId = p5.ProductVariantId;
            result.Colour = p5.Colour;
            result.Size = p5.Size;
            return result;
            
        }
        
        private static List<ProductVariantCodeGenDto> funcMain3(List<ProductVariant> p7, List<ProductVariantCodeGenDto> p8)
        {
            if (p7 == null)
            {
                return null;
            }
            List<ProductVariantCodeGenDto> result = new List<ProductVariantCodeGenDto>(p7.Count);
            
            int i = 0;
            int len = p7.Count;
            
            while (i < len)
            {
                ProductVariant item = p7[i];
                result.Add(item == null ? null : new ProductVariantCodeGenDto()
                {
                    ProductVariantId = item.ProductVariantId,
                    Colour = item.Colour,
                    Size = item.Size
                });
                i++;
            }
            return result;
            
        }
    }
}