using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
	public interface INhanVienRepository
	{
		bool addNhanVien(NhanVien nhanVien);
		bool updateNhanVien(NhanVien nhanVien);
		bool deleteNhanVien(NhanVien nhanVien);
		NhanVien GetCheck(string gmail);
		List<NhanVien> GetNhanVien();
	}
}
