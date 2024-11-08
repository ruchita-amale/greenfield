﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;
namespace Catalog
{
    /// <summary>
    /// Every interface defined in program is called Propotype, contract, specification, etc
    /// </summary>
    public interface IProductService
    {
        List<Product> GetAll();               //abstract method
        Product Get(int id);
        bool Insert(Product product);
        bool Update(Product product);
        bool Delete(int id);
    }
}
