﻿using ShoppingApp.WebModels_.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductViewModel> GetAllProducts();
        ProductViewModel GetProductById(int id);
        int CreateProduct(ProductViewModel product);
        int UpdateProduct(ProductViewModel product);
        int RemoveProduct(int id);
    }
}
