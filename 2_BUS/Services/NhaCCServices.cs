using _1_DAL.DomainMolder;
using _1_DAL.IRepository;
using _1_DAL.Repository;
using _2_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
	public class NhaCCServices : INhaCCServices
	{
		private INhaCCRepository _inhaCCRepository;
		private List<NhaCungCap> _lstnhaCungCaps;
		public NhaCCServices()
		{
			_inhaCCRepository = new NCCRepository();
			_lstnhaCungCaps = new List<NhaCungCap>();
		}
		public bool Add(NhaCungCap obj)
		{
			_inhaCCRepository.Add(obj);
			return true;
		}

		public bool Delete(NhaCungCap obj)
		{
			_inhaCCRepository.Delete(obj);
			return true;
		}

		public List<NhaCungCap> GetAll()
		{
			_lstnhaCungCaps = _inhaCCRepository.GetAll();
			return _lstnhaCungCaps;
		}

		public List<NhaCungCap> GetAll(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return GetAll();
			}
			return _inhaCCRepository.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.Ma.ToLower().Contains(input.ToLower())).ToList();
		}

		public bool Update(NhaCungCap obj)
		{
			_inhaCCRepository.Update(obj);
			return true;
		}
	}
}
