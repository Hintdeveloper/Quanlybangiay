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
	 public class NCCRepository: INhaCCRepository
	{
		private QuanLyBanHangGiayContext _dbContext;
		private List<NhaCungCap> _lstNCC;
		public NCCRepository()
		{
			_dbContext = new QuanLyBanHangGiayContext();
			_lstNCC = new List<NhaCungCap>();
		}

		public bool Add(NhaCungCap obj)
		{
			_dbContext.NhaCungCaps.Add(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public bool Delete(NhaCungCap obj)
		{
			_dbContext.NhaCungCaps.Remove(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public List<NhaCungCap> GetAll()
		{
			_lstNCC = _dbContext.NhaCungCaps.ToList();
			return _lstNCC;
		}

		public bool Update(NhaCungCap obj)
		{
			_dbContext.NhaCungCaps.Update(obj);
			_dbContext.SaveChanges();
			return true;
		}
	}
}
