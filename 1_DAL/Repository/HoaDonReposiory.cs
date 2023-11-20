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
	public class HoaDonReposiory : IHoaDonRepository
	{
		private QuanLyBanHangGiayContext _dbContext;
		private List<HoaDon> _lstHoaDon;
		public HoaDonReposiory()
		{
			_dbContext = new QuanLyBanHangGiayContext();
			_lstHoaDon = new List<HoaDon>();
		}
		public bool Add(HoaDon obj)
		{
			if (obj == null) return false;
			_dbContext.HoaDons.Add(obj);
			_dbContext.SaveChanges();
			return true;
		}

		public bool Delete(HoaDon obj)
		{
			if (obj == null) return false;
			var temp = _dbContext.HoaDons.FirstOrDefault(c => c.ID == obj.ID);
			_dbContext.HoaDons.Remove(temp);
			_dbContext.SaveChanges();
			return true;
		}

		public List<HoaDon> GetAll()
		{
			_lstHoaDon = _dbContext.HoaDons.ToList();
			return _lstHoaDon;
		}

		public bool Update(HoaDon obj)
		{
			if (obj == null) return false;
			var temp = _dbContext.HoaDons.FirstOrDefault(c => c.ID == obj.ID);
			temp.IDHTTT = obj.IDHTTT;
			temp.IDKH = obj.IDKH;
			temp.IDNV = obj.IDNV;
			temp.Ma = obj.Ma;
			temp.NgayTao = obj.NgayTao;
			temp.NgayThanhToan = obj.NgayThanhToan;
			temp.TrangThai = obj.TrangThai;
			_dbContext.HoaDons.Update(temp);
			_dbContext.SaveChanges();
			return true;
		}
	}
}
