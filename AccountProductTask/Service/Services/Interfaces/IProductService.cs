using AccountProductTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProductTask.Services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();

    }
}
