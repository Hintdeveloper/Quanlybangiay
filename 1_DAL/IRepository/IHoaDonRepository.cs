using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
	public interface IHoaDonRepository
	{
		public bool Add(HoaDon obj);
		public bool Update(HoaDon obj);
		public bool Delete(HoaDon obj);
		public List<HoaDon> GetAll();
	}
}
