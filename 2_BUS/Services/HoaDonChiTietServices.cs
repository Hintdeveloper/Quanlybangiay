using _1_DAL.DomainMolder;
using _1_DAL.IRepository;
using _1_DAL.Repository;
using _2_BUS.IServices;
using _2_BUS.ViewMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
	public class HoaDonChiTietServices : IHoaDonChiTietServices
	{
		private IHoaDonRepository _ihoaDonRepository;
		private IHoaDonChiTietRepository _ihoaDonChiTietRepository;
		private ISanPhamChiTietRepository _isanPhamChiTietRepository;
		private ISanPhamRepository _isanPhamRepository;
		public HoaDonChiTietServices()
		{
			_ihoaDonRepository = new HoaDonReposiory();
			_ihoaDonChiTietRepository = new HoaDonChiTietRepository();
			_isanPhamChiTietRepository = new SanPhamChiTietRepository();
			_isanPhamRepository = new SanPhamRepository();
		}

		public string Add(ViewHoaDonCT obj)
		{
			if (obj == null)
			{
				return "Không thành công";
			}
			HoaDonChiTiet HD = new HoaDonChiTiet()
			{
				ID = obj.ID,
				IDHD = obj.IDHD,
				IDSPCT = obj.IDSPCT,
				DonGia = obj.DonGia,
				SoLuong = obj.SoLuong,
			};
			if (_ihoaDonChiTietRepository.Add(HD)) return "Thêm thành công";
			return "không thành công";
		}

		public string Delete(ViewHoaDonCT obj)
		{
			if (obj == null)
			{
				return "Không thành công";
			}
			HoaDonChiTiet HD = new HoaDonChiTiet()
			{
				ID = obj.ID,
				IDHD = obj.IDHD,
				IDSPCT = obj.IDSPCT,
				DonGia = obj.DonGia,
				SoLuong = obj.SoLuong,
			};
			if (_ihoaDonChiTietRepository.Delete(HD)) return "Xóa thành công";
			return "không thành công";
		}

		public List<ViewHoaDonCT> GetAll(Guid id)
		{
			List<ViewHoaDonCT> lsthd = new List<ViewHoaDonCT>();
			lsthd = (from a in _ihoaDonChiTietRepository.GetAll()
					 join b in _isanPhamChiTietRepository.GetChiTietSP() on a.IDSPCT equals b.ID
					 join c in _ihoaDonRepository.GetAll() on a.IDHD equals c.ID
					 join d in _isanPhamRepository.GetAll() on b.IDSP equals d.ID
					 select new ViewHoaDonCT
					 {
						 ID = a.ID,
						 IDHD = a.IDHD,
						 IDSPCT = a.IDSPCT,
						 SoLuong = a.SoLuong,
						 DonGia = a.DonGia,
						 TenSP = d.Ten,
						 thanhTien = Convert.ToDecimal(a.SoLuong * Convert.ToInt64(a.DonGia)),
						 Ma = d.Ma,
					 }).ToList();
			return lsthd;
		}

		public List<ViewHoaDonCT> GetAll()
		{
			List<ViewHoaDonCT> lsthd = new List<ViewHoaDonCT>();
			lsthd = (from a in _ihoaDonChiTietRepository.GetAll()
					 join b in _isanPhamChiTietRepository.GetChiTietSP() on a.IDSPCT equals b.ID
					 join c in _ihoaDonRepository.GetAll() on a.IDHD equals c.ID
					 join d in _isanPhamRepository.GetAll() on b.IDSP equals d.ID
					 select new ViewHoaDonCT
					 {
						 ID = a.ID,
						 IDHD = a.IDHD,
						 IDSPCT = a.IDSPCT,
						 SoLuong = a.SoLuong,
						 DonGia = a.DonGia,
						 TenSP = d.Ten,
					 }).ToList();
			return lsthd;
		}

		public string Update(ViewHoaDonCT obj)
		{
			if (obj == null)
			{
				return "Không thành công";
			}
			HoaDonChiTiet HD = new HoaDonChiTiet()
			{
				ID = obj.ID,
				IDHD = obj.IDHD,
				IDSPCT = obj.IDSPCT,
				DonGia = obj.DonGia,
				SoLuong = obj.SoLuong,
			};
			if (_ihoaDonChiTietRepository.Update(HD)) return "Sửa thành công";
			return "không thành công";
		}
	}
}
