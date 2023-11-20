using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
	public interface ILoaiSanPhamRepository
	{
		public bool Add(LoaiSanPham obj);
		public bool Update(LoaiSanPham obj);
		public bool Delete(LoaiSanPham obj);
		public List<LoaiSanPham> GetAll();
	}
}
