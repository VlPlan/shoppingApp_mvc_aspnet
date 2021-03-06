﻿using AutoMapper;
using ShoppingApp.DataAccess.Interfaces;
using ShoppingApp.Domain.Models;
using ShoppingApp.Domain.Models.Enums;
using ShoppingApp.Services.Interfaces;
using ShoppingApp.WebModels_.Enums;
using ShoppingApp.WebModels_.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingApp.Services.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public OrderService(IRepository<Product> productRepository,
                            IRepository<Order> orderRepository,
                            IUserRepository userRepository,
                            IMapper mapper)
        {
            _productRepository = productRepository;
            _orderRepository = orderRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public int AddProduct(int orderId, int productId, string userId, out string productName)
        {
            try
            {
                Product product = _productRepository.GetById(productId);
                Order order = _orderRepository.GetById(orderId);

                productName = product.Name;
                User user = _userRepository.GetById(userId);
                order.ProductOrders.Add(
                    new ProductOrder()
                    {
                        Product = product,
                        Order = order
                    });

                order.User = user;
                return _orderRepository.Update(order);
            }
            catch (Exception ex)
            {
                string message = $"Something went wrong adding product! {ex.InnerException}";
                throw new Exception(message, ex);
            }
            
        }

        public int ChangeStatus(int orderId, string userId, StatusTypeViewModel status)
        {
            try
            {
                Order order = _orderRepository.GetById(orderId);
                User user = _userRepository.GetById(userId);

                order.Status = (StatusType)status;

                if (status == StatusTypeViewModel.Processing)
                {
                    _orderRepository.Insert(new Order()
                    {
                        User = user,
                        Status = StatusType.Init
                    });
                }

                return _orderRepository.Update(order);
            }
            catch (Exception ex)
            {
                string message = $"Something went wrong changing status! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }

        public int CreateOrder(OrderViewModel order, string userId)
        {
            try
            {
                User user = _userRepository.GetById(userId);

                Order mappedOrder = _mapper.Map<Order>(order);

                mappedOrder.User = user;
                return _orderRepository.Insert(mappedOrder);
            }
            catch (Exception ex)
            {
                string message = $"Something went wrong creating order! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }

        public IEnumerable<OrderViewModel> GetAllOrders()
        {
            return _mapper.Map<List<OrderViewModel>>(_orderRepository.GetAll());
        }

        public OrderViewModel GetCurrentOrder(string userId)
        {
            try
            {
                Order order = _orderRepository.GetAll()
                                              .Where(x => x.UserId == userId)
                                              .LastOrDefault();
                IEnumerable<Product> products = order.ProductOrders
                                                     .Select(x =>
                                                     _productRepository.GetById(x.ProductId));
                OrderViewModel orderModel = _mapper.Map<OrderViewModel>(order);

                orderModel.Products = _mapper.Map<List<ProductViewModel>>(products);

                return orderModel;
            }
            catch (Exception ex)
            {
                string message = $"Order not exist! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }

        public OrderViewModel GetOrderById(int id)
        {
            try
            {
                return _mapper.Map<OrderViewModel>(_orderRepository.GetById(id));
            }
            catch (Exception ex)
            {
                string message = $"Order not exist! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }

        public OrderViewModel GetOrderById(int orderId, string userId)
        {
            User user = _userRepository.GetById(userId);
            Order order = _orderRepository.GetById(orderId);

            if(user.Id == order.UserId)
            {
                return _mapper.Map<OrderViewModel>(order);
            }
            else
            {
                return new OrderViewModel();
            }
            
        }

        public int RemoveProduct(int orderId, int productId)
        {
            throw new NotImplementedException();
        }
    }
}
