﻿using ShoppingApp.Domain.Models.Enums;
using ShoppingApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoppingApp.Domain.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime DateOfOrder { get; set; }

        [Required]
        public StatusType Status { get; set; }
        
        [Required]
        public string UserId { get; set; }
        
        public virtual User User { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual List<ProductOrder> ProductOrders { get; set; }
    }
}
