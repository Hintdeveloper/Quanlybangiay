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
	public class HinhThucThanhToanServices : IHinhThucThanhToanServices
	{
		private IHinhThucThanhToanRepository _ihinhThucThanhToanRepository;
		private List<HinhThucThanhToan> _lsthinhThucThanhToans;
		public HinhThucThanhToanServices()
		{
			_ihinhThucThanhToanRepository = new HinhThucThanhToanRepository();
			_lsthinhThucThanhToans = new List<HinhThucThanhToan>();
		}
		public bool Add(HinhThucThanhToan obj)
		{
			_ihinhThucThanhToanRepository.Add(obj);
			return true;
		}

		public bool Delete(HinhThucThanhToan obj)
		{
			_ihinhThucThanhToanRepository.Delete(obj);
			return true;
		}

		public List<HinhThucThanhToan> GetAll()
		{
			_lsthinhThucThanhToans = _ihinhThucThanhToanRepository.GetAll();
			return _lsthinhThucThanhToans;
		}

		public List<HinhThucThanhToan> GetAll(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return GetAll();
			}
			return _ihinhThucThanhToanRepository.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.Ma.ToLower().Contains(input.ToLower())).ToList();
		}

		public bool Update(HinhThucThanhToan obj)
		{
			_ihinhThucThanhToanRepository.Update(obj);
			return true;
		}
	}
}
