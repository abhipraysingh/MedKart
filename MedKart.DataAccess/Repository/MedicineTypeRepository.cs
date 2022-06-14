using MedKart.DataAccess.Repository.IRepository;
using MedKart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedKart.DataAccess.Repository
{
    public class MedicineTypeRepository : Repository<MedicineType>, IMedicineTypeRepository
    {
        private ApplicationDbContext _db;
        public MedicineTypeRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        public void Update(MedicineType obj)
        {
            _db.MedicineTypes.Update(obj);
        }
    }
}
