using _1_DAL.Dbcontext;
using _1_DAL.DomainMolder;
using _1_DAL.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repository
{
	public class HinhThucThanhToanRepository : IHinhThucThanhToanRepository
	{
		private QuanLyBanHangGiayContext _dbContext;
		private List<HinhThucThanhToan> _lstHinhThucThanhToan;
		public HinhThucThanhToanRepository()
		{
			_dbContext = new QuanLyBanHangGiayContext();
			_lstHinhThucThanhToan = new List<HinhThucThanhToan>();
		}
		public bool Add(HinhThucThanhToan obj)
		{
			_dbContext.HinhThucThanhToans.Add(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public bool Delete(HinhThucThanhToan obj)
		{
			_dbContext.HinhThucThanhToans.Remove(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public List<HinhThucThanhToan> GetAll()
		{
			_lstHinhThucThanhToan = _dbContext.HinhThucThanhToans.ToList();
			return _lstHinhThucThanhToan;
		}

		public bool Update(HinhThucThanhToan obj)
		{
			_dbContext.HinhThucThanhToans.Update(obj);
			_dbContext.SaveChanges();
			return true;
		}
	}
}
