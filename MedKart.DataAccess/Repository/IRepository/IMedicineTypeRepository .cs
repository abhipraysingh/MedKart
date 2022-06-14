using MedKart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedKart.DataAccess.Repository.IRepository
{
    public interface IMedicineTypeRepository : IRepository<MedicineType>
    {
        void Update(MedicineType obj);
    }
}
