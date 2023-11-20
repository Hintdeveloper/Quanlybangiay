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
	public class KhachHangRepository : IKhachHangRepository
	{
		private QuanLyBanHangGiayContext _dbContext;
		private List<KhachHang> _lstkh;
		public KhachHangRepository()
		{
			_dbContext = new QuanLyBanHangGiayContext();
			_lstkh = new List<KhachHang>();
		}
		public bool Add(KhachHang obj)
		{
			_dbContext.KhachHangs.Add(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public bool Delete(KhachHang obj)
		{
			_dbContext.KhachHangs.Remove(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public List<KhachHang> GetAll()
		{
			_lstkh = _dbContext.KhachHangs.ToList();
			return _lstkh;
		}

		public KhachHang GetByID(Guid id)
		{
			return _dbContext.KhachHangs.FirstOrDefault(c => c.ID == id);
		}

		public bool Update(KhachHang obj)
		{
			_dbContext.KhachHangs.Update(obj);
			_dbContext.SaveChanges();
			return true;
		}
	}
}
