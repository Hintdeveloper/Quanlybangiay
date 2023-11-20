using _2_BUS.ViewMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
	public interface IHoaDonServices
	{
		string Add(ViewHoaDon obj);
		string Update(ViewHoaDon obj);
		string Delete(ViewHoaDon obj);
		List<ViewHoaDon> GetAll(string input);
		List<ViewHoaDon> GetAll();
	}
}
