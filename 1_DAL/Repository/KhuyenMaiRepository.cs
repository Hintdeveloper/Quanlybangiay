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
	public class KhuyenMaiRepository : IKhuyenMaiRepository
	{
		private QuanLyBanHangGiayContext _dbContext;
		private List<KhuyenMai> _lstKhuyenMai;
		public KhuyenMaiRepository()
		{
			_dbContext = new QuanLyBanHangGiayContext();
			_lstKhuyenMai = new List<KhuyenMai>();
		}
		public bool Add(KhuyenMai obj)
		{
			_dbContext.KhuyenMais.Add(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public bool Delete(KhuyenMai obj)
		{
			_dbContext.KhuyenMais.Remove(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public List<KhuyenMai> GetAll()
		{
			_lstKhuyenMai = _dbContext.KhuyenMais.ToList();
			return _lstKhuyenMai;
		}

		public bool Update(KhuyenMai obj)
		{
			_dbContext.KhuyenMais.Update(obj);
			_dbContext.SaveChanges();
			return true;
		}
	}
}
