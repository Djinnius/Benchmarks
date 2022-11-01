using AutoMapper;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkMappings.Domain;
using BenchmarkMappings.Dtos;
using Mapster;
using System;
using System.Collections.Generic;
using System.Drawing;
using ExpMapper = ExpressMapper;

namespace BenchmarkMappings;

[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class MappingBenchmarks
{
    private Product _product;

    [GlobalSetup]
    public void SetupData()
    {
        // Create the object to map.
        _product = GenerateProduct;

        // Express Mapper Setup
        ExpMapper.Mapper.Register<Product, ProductDto>();

        //AutoMapper Setup
        MappingSamples.AutoMapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapperProfile())));

        // Mapster Setup
        MappingSamples.TypeAdapterConfig = GetTypeAdapterConfig();
        MappingSamples.MapsterMapper = new MapsterMapper.Mapper(MappingSamples.TypeAdapterConfig);
    }

    #region Product Generation

    private readonly Product GenerateProduct = new()
    {
        Id = Guid.Parse("13B14E77-4F00-485F-84F8-905991191D10"),
        Description = "Totally fabulous product, completely unbelieveble, five stars",
        Weight = 69m,
        ProductName = "Super Mapping",
        DefaultOption = new ProductVariant
        {
            ProductVariantId = Guid.Parse("7C40091D-E6E0-4586-97D4-7B634F7F354A"),
            Colour = Color.Red,
            Size = "Extra large"
        },
        Options = new List<ProductVariant>
            {
                new()
                {
                    ProductVariantId = Guid.Parse("7C40091D-E6E0-4586-97D4-7B634F7F354A"),
                    Colour = Color.Orange,
                    Size = "Extra Small"
                },
                new()
                {
                    ProductVariantId = Guid.Parse("8C40091D-E6E0-4586-97D4-7B634F7F354A"),
                    Colour = Color.Yellow,
                    Size = "Extra Long"
                },
                new()
                {
                    ProductVariantId = Guid.Parse("9C40091D-E6E0-4586-97D4-7B634F7F354A"),
                    Colour = Color.Green,
                    Size = "Extra Medium"
                }
            }
    };

    #endregion

    #region AutoMapper Profile

    private class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProductVariant, ProductVariantDto>();
            CreateMap<Product, ProductDto>();
        }
    }

    #endregion

    #region Mapster Config

    private static TypeAdapterConfig GetTypeAdapterConfig()
    {
        var config = new TypeAdapterConfig();
        config.NewConfig<Product, ProductDto>();
        return config;
    }

    #endregion

    [Benchmark(Baseline = true)]
    public ProductDto ManualMap() => MappingSamples.ManualMapSample(_product);

    [Benchmark]
    public ProductDto ExpressMapper() => MappingSamples.ExpressMapperSample(_product);

    [Benchmark]
    public ProductDto AutoMapper() => MappingSamples.AutoMapperSample(_product);

    [Benchmark]
    public ProductDto MapsterAdaptWithoutConfig() => MappingSamples.MapsterAdaptWithoutConfigSample(_product);

    [Benchmark]
    public ProductDto MapsterAdaptWithConfig() => MappingSamples.MapsterAdaptWithConfigSample(_product);

    [Benchmark]
    public ProductDto MapsterAdaptToType() => MappingSamples.MapsterAdaptToTypeSample(_product);

    [Benchmark]
    public ProductCodeGenDto MapsterCodeGen() => MappingSamples.MapsterCodeGenSample(_product);
}
