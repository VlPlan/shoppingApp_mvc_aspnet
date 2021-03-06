﻿using ShoppingApp.WebModels_.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Services.Interfaces
{
    public interface IInvoiceService
    {
        IEnumerable<InvoiceViewModel> GetAll(string userId);
        InvoiceViewModel GetById(int id, string userId);
        InvoiceViewModel GetByOrderId(int id, string userId);
        int Insert(InvoiceViewModel model, string userId, int orderId);
    }
}
