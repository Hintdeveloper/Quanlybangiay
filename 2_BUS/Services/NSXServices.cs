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
	public class NSXServices : INSXServices
	{
		private INSXRepository _InSXRepository;
		private List<NSX> _lstnSX;
		public NSXServices()
		{
			_InSXRepository = new NSXRepository();
			_lstnSX = new List<NSX>();
		}
		public bool Add(NSX obj)
		{
			_InSXRepository.Add(obj);
			return true;
		}

		public bool Delete(NSX obj)
		{
			_InSXRepository.Delete(obj);
			return true;
		}

		public List<NSX> GetAll()
		{
			_lstnSX = _InSXRepository.GetAll();
			return _lstnSX; ;
		}

		public List<NSX> GetAll(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return GetAll();
			}
			return _InSXRepository.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.GhiChu.ToLower().Contains(input.ToLower())).ToList();
		}

		public bool Update(NSX obj)
		{
			_InSXRepository.Update(obj);
			return true;
		}
	}
}
