using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyProjectCrud.Data;
using MyProjectCrud.Models;
using MyProjectCrud.Repository;

namespace MyProjectCrud.UnitOfWork
{
    public class UnitOfWordApp : DbContext
    {
        ContextApp context = new ContextApp();
        Repository.Repository<Product> productRepository;

        public Repository<Product> ProductRepository
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new Repository<Product>(context);
                }
                return productRepository;
            }
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}