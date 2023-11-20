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
	public class ChucVuRepository : IChucVuRepository
	{
		private QuanLyBanHangGiayContext _dbContext;
		public List<ChucVu> _lstChucVu;
		public ChucVuRepository()
		{
			_dbContext = new QuanLyBanHangGiayContext();
			_lstChucVu = new List<ChucVu>();
		}
		public bool Add(ChucVu obj)
		{
			_dbContext.ChucVus.Add(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public bool Delete(ChucVu obj)
		{
			_dbContext.ChucVus.Remove(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public List<ChucVu> GetAll()
		{
			_lstChucVu = _dbContext.ChucVus.ToList();
			return _lstChucVu;
		}

		public bool Update(ChucVu obj)
		{
			_dbContext.ChucVus.Update(obj);
			_dbContext.SaveChanges();
			return true;
		}
	}
}
