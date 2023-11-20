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
	public class KhuyenMaiServices : IKhuyenMaiServices
	{
		private IKhuyenMaiRepository _ikhuyenMaiRepository;
		private List<KhuyenMai> _lstkhuyenMais;
		public KhuyenMaiServices()
		{
			_ikhuyenMaiRepository = new KhuyenMaiRepository();
			_lstkhuyenMais = new List<KhuyenMai>();

		}
		public bool Add(KhuyenMai obj)
		{
			_ikhuyenMaiRepository.Add(obj);
			return true;
		}

		public bool Delete(KhuyenMai obj)
		{
			_ikhuyenMaiRepository.Delete(obj);
			return true;
		}

		public List<KhuyenMai> GetAll()
		{
			_lstkhuyenMais = _ikhuyenMaiRepository.GetAll();
			return _lstkhuyenMais;
		}

		public List<KhuyenMai> GetAll(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return GetAll();
			}
			return _ikhuyenMaiRepository.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.Ma.ToLower().Contains(input.ToLower())).ToList();
		}

		public bool Update(KhuyenMai obj)
		{
			_ikhuyenMaiRepository.Update(obj);
			return true;
		}
	}
}
