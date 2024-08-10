using EcommerceApi.Domen.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApi.Application.Abstractions
{
    public interface IProductService
    {
        List<Product > GetProducts();
    }
}
