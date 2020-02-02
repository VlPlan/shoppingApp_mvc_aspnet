﻿using AutoMapper;
using ShoppingApp.Domain.Models;
using ShoppingApp.Models.Domain;
using ShoppingApp.WebModels_.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingApp.Services.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderViewModel>()
                .ForMember(dest => dest.Status, src => src.MapFrom(x => x.Status))
                .ForMember(dest => dest.Price, src => src.Ignore())
                .ForMember(dest => dest.Products, src => src.MapFrom(x => x.ProductOrders.Select(y => y.Product)))
                .ReverseMap()
                .ForMember(dest => dest.ProductOrders, src => src.Ignore())
                .ForMember(dest => dest.DateOfOrder, src => src.Ignore());

            CreateMap<Product, ProductViewModel>()
                .ForMember(dest => dest.Category, src => src.MapFrom(x => x.Category))
                .ReverseMap()
                .ForMember(dest => dest.ProductOrders, src => src.Ignore());

            CreateMap<Invoice, InvoiceViewModel>()
                .ReverseMap();
        }
    }
}
