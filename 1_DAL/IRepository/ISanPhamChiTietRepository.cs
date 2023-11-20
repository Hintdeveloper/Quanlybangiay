using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
	public interface ISanPhamChiTietRepository
	{
		public bool Add(SanPhamChiTiet obj);
		public bool Update(SanPhamChiTiet obj);
		public bool Delete(SanPhamChiTiet obj);
		public List<SanPhamChiTiet> GetChiTietSP();
	}
}
