using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
	public interface IKhachHangRepository
	{
		public bool Add(KhachHang obj);
		public bool Update(KhachHang obj);
		public bool Delete(KhachHang obj);
		public List<KhachHang> GetAll();
		public KhachHang GetByID(Guid id);
	}
}
