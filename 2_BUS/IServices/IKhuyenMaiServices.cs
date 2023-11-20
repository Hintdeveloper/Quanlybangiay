using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
	public interface IKhuyenMaiServices
	{
		bool Add(KhuyenMai obj);
		bool Update(KhuyenMai obj);
		bool Delete(KhuyenMai obj);
		List<KhuyenMai> GetAll();
		List<KhuyenMai> GetAll(string input);
	}
}
