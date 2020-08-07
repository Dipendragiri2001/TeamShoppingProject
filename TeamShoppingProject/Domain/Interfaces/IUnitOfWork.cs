using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
   public interface IUnitOfWork :IDisposable
    {
        IProductRepository Products { get; }
        
        int Complete();
    }
}
