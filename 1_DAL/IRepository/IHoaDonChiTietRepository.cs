using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
	public interface IHoaDonChiTietRepository
	{
		public bool Add(HoaDonChiTiet obj);
		public bool Update(HoaDonChiTiet obj);
		public bool Delete(HoaDonChiTiet obj);
		public List<HoaDonChiTiet> GetAll();
	}
}
