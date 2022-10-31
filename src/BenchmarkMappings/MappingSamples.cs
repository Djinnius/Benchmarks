using AutoMapper;
using BenchmarkMappings.Domain;
using BenchmarkMappings.Dtos;
using Mapster;
using System.Linq;
using ExpressMapper;

namespace BenchmarkMappings
{
    /// <summary>
    ///     Mapping configurations and public methods for four conversions between
    ///     a Product and Product DTO:
    ///         - Manual
    ///         - Express Mapper
    ///         - Auto Mapper
    ///         - Mapster
    /// </summary>
    public class MappingSamples
    {
        public static IMapper AutoMapper;
        public static TypeAdapterConfig TypeAdapterConfig;
        public static MapsterMapper.IMapper MapsterMapper;

        #region Express Mapper Setup

        //static MappingSamples()
        //{
        //    ExpressMapper.Mapper.Register<Product, ProductDto>();
        //}

        #endregion

        #region AutoMapper Setup

        //public static readonly IMapper AutoMapper =
        //    new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapperProfile())));

        //private class AutoMapperProfile : Profile
        //{
        //    public AutoMapperProfile()
        //    {
        //        CreateMap<ProductVariant, ProductVariantDto>();
        //        CreateMap<Product, ProductDto>();
        //    }
        //}

        #endregion

        #region Mapster Setup

        //private static readonly TypeAdapterConfig TypeAdapterConfig = GetTypeAdapterConfig();
        //private static readonly MapsterMapper.IMapper MapsterMapper = new MapsterMapper.Mapper(TypeAdapterConfig);

        //private static TypeAdapterConfig GetTypeAdapterConfig()
        //{
        //    var config = new TypeAdapterConfig();
        //    config.NewConfig<Product, ProductDto>();
        //    return config;
        //}

        #endregion

        /// <summary>
        ///     Maps a Product to a Product DTO using a traditional manual
        ///     copy of properties from product to product DTO.
        /// </summary>
        /// <returns> A Product DTO </returns>
        public static ProductDto ManualMapSample(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Description = product.Description,
                Weight = product.Weight,
                ProductName = product.ProductName,
                DefaultOption = new ProductVariantDto
                {
                    ProductVariantId = product.DefaultOption.ProductVariantId,
                    Colour = product.DefaultOption.Colour,
                    Size = product.DefaultOption.Size
                },
                Options = product.Options.Select(x => new ProductVariantDto
                {
                    ProductVariantId = x.ProductVariantId,
                    Colour = x.Colour,
                    Size = x.Size
                }).ToList()
            };
        }

        /// <summary>
        ///     Maps a Product to a Product DTO using Express Mapper.
        /// </summary>
        /// <returns> A Product DTO </returns>
        public static ProductDto ExpressMapperSample(Product product)
            => ExpressMapper.Mapper.Map<Product, ProductDto>(product);

        /// <summary>
        ///     Maps a Product to a Product DTO using Auto Mapper.
        /// </summary>
        /// <returns> A Product DTO </returns>
        public static ProductDto AutoMapperSample(Product product)
            => AutoMapper.Map<ProductDto>(product);

        /// <summary>
        ///     Maps a Product to a Product DTO using Mapster with no pre-configuration
        ///     applied.
        /// </summary>
        /// <returns> A Product DTO </returns>
        public static ProductDto MapsterAdaptWithoutConfigSample(Product product)
            => product.Adapt<ProductDto>();

        /// <summary>
        ///     Maps a Product to a Product DTO using Mapster with a type mapping
        ///     configuration pre-applied.
        /// </summary>
        /// <returns> A Product DTO </returns>
        public static ProductDto MapsterAdaptWithConfigSample(Product product)
            => product.Adapt<ProductDto>(TypeAdapterConfig);

        /// <summary>
        ///     Maps a Product to a Product DTO using Mapster with a type mapping
        ///     configuration pre-applied and a reference to configured mapster mapper.
        /// </summary>
        /// <returns> A Product DTO </returns>
        public static ProductDto MapsterAdaptToTypeSample(Product product)
            => MapsterMapper.From(product).AdaptToType<ProductDto>();

        /// <summary>
        ///     Maps a Product to a Product DTO using Mapster's code generation.
        /// </summary>
        /// <returns> A Product DTO </returns>
        public static ProductCodeGenDto MapsterCodeGenSample(Product product)
            => product.AdaptToCodeGenDto();
    }
}
