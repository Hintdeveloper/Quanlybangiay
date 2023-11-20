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
	public class SizeRepository: ISizeRepository
	{
		private QuanLyBanHangGiayContext _dbContext;
		private List<KichThuoc> _lstSize;
		public SizeRepository()
		{
			_dbContext = new QuanLyBanHangGiayContext();
			_lstSize = new List<KichThuoc>();
		}
		public bool Add(KichThuoc obj)
		{
			_dbContext.Sizes.Add(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public bool Update(KichThuoc obj)
		{
			_dbContext.Sizes.Update(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public bool Delete(KichThuoc obj)
		{
			_dbContext.Sizes.Remove(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public List<KichThuoc> GetAll()
		{
			_lstSize = _dbContext.Sizes.ToList();
			return _lstSize;
		}
	}
}
