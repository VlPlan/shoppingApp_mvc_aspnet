﻿using AutoMapper;
using ShoppingApp.DataAccess.Interfaces;
using ShoppingApp.Domain.Models;
using ShoppingApp.Models.Domain;
using ShoppingApp.Services.Interfaces;
using ShoppingApp.WebModels_.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Services.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IRepository<Invoice> _invoiceRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public InvoiceService(IRepository<Order> orderRepository, IRepository<Invoice> invoiceRepository, IMapper mapper)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
            _invoiceRepository = invoiceRepository;
        }

        public IEnumerable<InvoiceViewModel> GetAll(string userId)
        {
            throw new NotImplementedException();
        }

        public InvoiceViewModel GetById(int id, string userId)
        {
            return _mapper.Map<InvoiceViewModel>(_invoiceRepository.GetById(id));
        }

        public InvoiceViewModel GetByOrderId(int id, string userId)
        {
            Order order = _orderRepository.GetById(id);
            return _mapper.Map<InvoiceViewModel>(_invoiceRepository.GetById(order.Invoice.Id));
        }

        public int Insert(InvoiceViewModel model, string userId, int orderId)
        {
            Order order = _orderRepository.GetById(orderId);
            Invoice invoice = _mapper.Map<Invoice>(model);
            invoice.Order = order;
            return _invoiceRepository.Insert(invoice);
        }
    }
}
