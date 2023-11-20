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
	public class SizeServices : ISizeServices
	{
		private ISizeRepository _iSizeRepository;
		private List<KichThuoc> _lstsize;
		public SizeServices()
		{
			_iSizeRepository = new SizeRepository();
			_lstsize = new List<KichThuoc>();
		}
		public bool Add(KichThuoc obj)
		{
			_iSizeRepository.Add(obj);
			return true;
		}

		public bool Delete(KichThuoc obj)
		{
			_iSizeRepository.Delete(obj);
			return true;
		}

		public List<KichThuoc> GetAll()
		{
			_lstsize = _iSizeRepository.GetAll();
			return _lstsize;
		}

		public List<KichThuoc> GetAll(string input)
		{

			if (string.IsNullOrEmpty(input))
			{
				return GetAll();
			}
			return _iSizeRepository.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.Ma.ToLower().Contains(input.ToLower())).ToList();
		}

		public bool Update(KichThuoc obj)
		{
			_iSizeRepository.Update(obj);
			return true;
		}
	}
}
