using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
	public interface IKhuyenMaiRepository
	{
		public bool Add(KhuyenMai obj);
		public bool Update(KhuyenMai obj);
		public bool Delete(KhuyenMai obj);
		public List<KhuyenMai> GetAll();
	}
}
