using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
	public interface ISizeRepository
	{
		public bool Add(KichThuoc obj);
		public bool Update(KichThuoc obj);
		public bool Delete(KichThuoc obj);
		public List<KichThuoc> GetAll();
	}
}
