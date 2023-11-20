using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
	public interface INhaCCServices
	{
		bool Add(NhaCungCap obj);
		bool Update(NhaCungCap obj);
		bool Delete(NhaCungCap obj);
		List<NhaCungCap> GetAll();
		List<NhaCungCap> GetAll(string input);
	}
}
