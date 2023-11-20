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
	public class ChucVuServices : IChucVuServices
	{
		private IChucVuRepository _ichucVuRepository;
		private List<ChucVu> _lstChucVu;
		public ChucVuServices()
		{
			_ichucVuRepository = new ChucVuRepository();
			_lstChucVu = new List<ChucVu>();
		}
		public bool Add(ChucVu obj)
		{
			_ichucVuRepository.Add(obj);
			return true;
		}

		public bool Delete(ChucVu obj)
		{
			_ichucVuRepository.Delete(obj);
			return true;
		}

		public List<ChucVu> GetAll()
		{
			_lstChucVu = _ichucVuRepository.GetAll();
			return _lstChucVu;
		}

		public List<ChucVu> GetAll(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return GetAll();
			}
			return _ichucVuRepository.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.Ma.ToLower().Contains(input.ToLower())).ToList();
		}

		public bool Update(ChucVu obj)
		{
			_ichucVuRepository.Update(obj);
			return true;
		}
	}
}
