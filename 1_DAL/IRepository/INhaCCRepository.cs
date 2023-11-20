using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
	public interface INhaCCRepository
	{
		public bool Add(NhaCungCap obj);
		public bool Update(NhaCungCap obj);
		public bool Delete(NhaCungCap obj);
		public List<NhaCungCap> GetAll();
	}
}
