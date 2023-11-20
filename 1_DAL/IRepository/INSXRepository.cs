using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
	public interface INSXRepository
	{
		public bool Add(NSX obj);
		public bool Update(NSX obj);
		public bool Delete(NSX obj);
		public List<NSX> GetAll();
	}
}
