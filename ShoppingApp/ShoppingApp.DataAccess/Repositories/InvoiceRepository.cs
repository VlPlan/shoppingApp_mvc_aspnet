﻿using ShoppingApp.DataAccess.Interfaces;
using ShoppingApp.Domain.Models;
using ShoppingApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingApp.DataAccess.Repositories
{
    public class InvoiceRepository : BaseRepository, IRepository<Invoice>
    {
        public InvoiceRepository(ShoppingDbContext context) : base(context) { }


        public int Delete(int id)
        {
            Invoice invoice = _context.Invoices.FirstOrDefault(x => x.Id == id);
            if (invoice == null) return -1;
            _context.Invoices.Remove(invoice);
            return _context.SaveChanges();
        }

        public IEnumerable<Invoice> GetAll()
        {
            return _context.Invoices;
        }

        public Invoice GetById(int id)
        {
            return _context.Invoices.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Invoice entity)
        {
            _context.Invoices.Add(entity);
            return _context.SaveChanges();

        }

        public int Update(Invoice entity)
        {
            _context.Invoices.Update(entity);
            return _context.SaveChanges();
        }
    }
}
