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
	public class SanPhamChiTietRepository : ISanPhamChiTietRepository
	{
		private QuanLyBanHangGiayContext _dbContext;
		private List<SanPhamChiTiet> _lstSanPhamCT;
		public SanPhamChiTietRepository()
		{
			_dbContext = new QuanLyBanHangGiayContext();
			_lstSanPhamCT = new List<SanPhamChiTiet>();
		}
		public bool Add(SanPhamChiTiet obj)
		{
			_dbContext.SanPhamChiTiets.Add(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public bool Delete(SanPhamChiTiet obj)
		{
			_dbContext.SanPhamChiTiets.Remove(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public List<SanPhamChiTiet> GetChiTietSP()
		{
			_lstSanPhamCT = _dbContext.SanPhamChiTiets.ToList();
			return _lstSanPhamCT;
		}

		public bool Update(SanPhamChiTiet obj)
		{
			_dbContext.SanPhamChiTiets.Update(obj);
			_dbContext.SaveChanges();
			return true;
		}
	}
}
