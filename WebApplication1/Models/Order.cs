﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        [Required]
        public string Number { get; set; }
        public decimal Amount { get; set; }
       // public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}