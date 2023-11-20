using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
	public interface IHinhThucThanhToanRepository
	{
		public bool Add(HinhThucThanhToan obj);
		public bool Update(HinhThucThanhToan obj);
		public bool Delete(HinhThucThanhToan obj);
		public List<HinhThucThanhToan> GetAll();
	}
}
