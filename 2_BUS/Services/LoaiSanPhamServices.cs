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
	public class LoaiSanPhamServices : ILoaiSanPhamServices
	{
		private ILoaiSanPhamRepository _iloaiSanPhamRepository;
		private List<LoaiSanPham> _lstloaiSanPham;
		public LoaiSanPhamServices()
		{
			_iloaiSanPhamRepository = new LoaiRepository();
			_lstloaiSanPham = new List<LoaiSanPham>();
		}
		public bool Add(LoaiSanPham obj)
		{
			_iloaiSanPhamRepository.Add(obj);
			return true;
		}

		public bool Delete(LoaiSanPham obj)
		{
			_iloaiSanPhamRepository.Delete(obj);
			return true;
		}

		public List<LoaiSanPham> GetAll()
		{
			_lstloaiSanPham = _iloaiSanPhamRepository.GetAll();
			return _lstloaiSanPham;
		}

		public List<LoaiSanPham> GetAll(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return GetAll();
			}
			return _iloaiSanPhamRepository.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.Ma.ToLower().Contains(input.ToLower())).ToList();
		}

		public bool Update(LoaiSanPham obj)
		{
			_iloaiSanPhamRepository.Update(obj);
			return true;
		}
	}
}
