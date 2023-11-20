using _1_DAL.Dbcontext;
using _1_DAL.DomainMolder;
using _1_DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repository
{
    public class MauSacRepository : IMauSacRepository
    {
        private QuanLyBanHangGiayContext _dbContext;
        private List<MauSac> _lstMauSac;
        public MauSacRepository()
        {
            _dbContext = new QuanLyBanHangGiayContext();
            _lstMauSac = new List<MauSac>();
        }
        public bool Add(MauSac obj)
        {
            _dbContext.MauSacs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(MauSac obj)
        {
            _dbContext.MauSacs.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<MauSac> GetAll()
        {
            _lstMauSac = _dbContext.MauSacs.ToList();
            return _lstMauSac;
        }

        public bool Update(MauSac obj)
        {
            _dbContext.MauSacs.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
