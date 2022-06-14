using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedKart.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IMedicineTypeRepository MedicineType { get; }
        IProductRepository Product { get; }
        void Save();
    }
}
