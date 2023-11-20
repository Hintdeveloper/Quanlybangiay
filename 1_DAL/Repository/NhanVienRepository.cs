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
	public class NhanVienRepository : INhanVienRepository
	{
		private QuanLyBanHangGiayContext _dbContext;
		private List<NhanVien> _lstnv;
		public NhanVienRepository()
		{
			_dbContext = new QuanLyBanHangGiayContext();
			_lstnv = new List<NhanVien>();
		}
		public bool addNhanVien(NhanVien nhanVien)
		{
			_dbContext.NhanViens.Add(nhanVien);
			_dbContext.SaveChanges();
			return true;
		}

		public bool deleteNhanVien(NhanVien nhanVien)
		{
			_dbContext.NhanViens.Remove(nhanVien);
			_dbContext.SaveChanges();
			return true;
		}

		public NhanVien GetCheck(string gmail)
		{
			NhanVien nv = _dbContext.NhanViens.FirstOrDefault(p => p.Email == gmail);
			return nv;
		}

		public List<NhanVien> GetNhanVien()
		{
			_lstnv = _dbContext.NhanViens.ToList();
			return _lstnv;
		}

		public bool updateNhanVien(NhanVien nhanVien)
		{
			_dbContext.NhanViens.Update(nhanVien);
			_dbContext.SaveChanges();
			return true;
		}
	}
}
