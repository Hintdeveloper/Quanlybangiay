using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
	public interface IChucVuRepository
	{
		public bool Add(ChucVu obj);
		public bool Update(ChucVu obj);
		public bool Delete(ChucVu obj);
		public List<ChucVu> GetAll();
	}
}
