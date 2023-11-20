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
    public class SanPhamRepository : ISanPhamRepository
    {
        private QuanLyBanHangGiayContext _dbContext;
        private List<SanPham> _lstSanPham;
        public SanPhamRepository()
        {
            _dbContext = new QuanLyBanHangGiayContext();
            _lstSanPham = new List<SanPham>();
        }
        public bool Add(SanPham obj)
        {
            _dbContext.SanPhams.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham obj)
        {
            _dbContext.SanPhams.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            _lstSanPham = _dbContext.SanPhams.ToList();
            return _lstSanPham;
        }

        public bool Update(SanPham obj)
        {
            _dbContext.SanPhams.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
