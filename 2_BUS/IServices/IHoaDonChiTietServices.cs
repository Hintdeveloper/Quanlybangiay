using _2_BUS.ViewMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
	public interface IHoaDonChiTietServices
	{
		string Add(ViewHoaDonCT obj);
		string Update(ViewHoaDonCT obj);
		string Delete(ViewHoaDonCT obj);
		List<ViewHoaDonCT> GetAll(Guid id);
		List<ViewHoaDonCT> GetAll();
	}
}
