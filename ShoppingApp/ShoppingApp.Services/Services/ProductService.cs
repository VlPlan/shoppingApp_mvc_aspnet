using AutoMapper;
using ShoppingApp.DataAccess.Interfaces;
using ShoppingApp.DataAccess.Repositories;
using ShoppingApp.Domain.Models;
using ShoppingApp.Services.Interfaces;
using ShoppingApp.WebModels_.Enums;
using ShoppingApp.WebModels_.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingApp.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public int CreateProduct(ProductViewModel product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            //Without using automapper

            //var products = _productRepository.GetAll().ToList();

            //ProductViewModel model = new ProductViewModel();
            //List<ProductViewModel> mappedProducts = new List<ProductViewModel>();

            //foreach (var product in products)
            //{
            //    model.Id = product.Id;
            //    model.Name = product.Name;
            //    model.Description = product.Description;
            //    model.Category = (CategoryTypeViewModel)product.Category;
            //    model.Price = product.Price;

            //    mappedProducts.Add(model);
            //}

            //By using automapper
            var products = _productRepository.GetAll();
            return _mapper.Map<List<ProductViewModel>>(products);
        }

        public ProductViewModel GetProductById(int id)
        {
            //ProductViewModel model = new ProductViewModel();
            //var product =  _productRepository.GetById(id);
            
            //model.Id = product.Id;
            //model.Name = product.Name;
            //model.Description = product.Description;
            //model.Category = (CategoryTypeViewModel)product.Category;
            //model.Price = product.Price;
            ProductViewModel product = _mapper.Map<ProductViewModel>(_productRepository.GetById(id));
            if(product != null)
            {
                return product;
            }
            else
            {
                throw new Exception("Product with that id does not exist!");
            }
        }

        public int RemoveProduct(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateProduct(ProductViewModel product)
        {
            throw new NotImplementedException();
        }
    }
}
