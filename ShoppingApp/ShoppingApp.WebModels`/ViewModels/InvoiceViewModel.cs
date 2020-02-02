using ShoppingApp.WebModels_.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.WebModels_.ViewModels
{
    public class InvoiceViewModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public PaymentTypeViewModel PaymentType { get; set; }
        public OrderViewModel Order { get; set; }
    }
}
