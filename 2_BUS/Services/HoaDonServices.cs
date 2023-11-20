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
	public class HoaDonServices : IHoaDonServices
	{
		private IHoaDonRepository _ihoaDonRepository;
		private INhanVienRepository _inhanVienRepository;
		private IKhachHangRepository _ikhachHangRepository;
		private IHinhThucThanhToanRepository _ihinhThucThanhToanRepository;
		public HoaDonServices()
		{
			_ihoaDonRepository = new HoaDonReposiory();
			_inhanVienRepository = new NhanVienRepository();
			_ikhachHangRepository = new KhachHangRepository();
			_ihinhThucThanhToanRepository = new HinhThucThanhToanRepository();
		}
		public string Add(ViewHoaDon obj)
		{
			if (obj == null)
			{
				return "Không thành công";
			}
			HoaDon hd = new HoaDon()
			{
				ID = obj.ID,
				IDHTTT = obj.IDHTTT,
				IDKH = obj.IDKH,
				IDNV = obj.IDNV,
				Ma = obj.Ma,
				NgayTao = obj.NgayTao,
				NgayThanhToan = obj.NgayThanhToan,
				TrangThai = obj.TrangThai,
				ThanhTien = obj.ThanhTien,
			};
			if (_ihoaDonRepository.Add(hd)) return "Thêm thành công";
			return "Không thành công";
		}

		public string Delete(ViewHoaDon obj)
		{
			if (obj == null)
			{
				return "Không thành công";
			}
			HoaDon hd = new HoaDon()
			{
				ID = obj.ID,
				IDHTTT = obj.IDHTTT,
				IDKH = obj.IDKH,
				IDNV = obj.IDNV,
				Ma = obj.Ma,
				NgayTao = obj.NgayTao,
				NgayThanhToan = obj.NgayThanhToan,
				TrangThai = obj.TrangThai,
				ThanhTien = obj.ThanhTien,
			};
			if (_ihoaDonRepository.Delete(hd)) return "Xóa thành công";
			return "Không thành công";
		}

		public List<ViewHoaDon> GetAll(string input)
		{
			List<ViewHoaDon> lsthd = new List<ViewHoaDon>();
			lsthd = (from a in _ihoaDonRepository.GetAll()
					 join b in _ikhachHangRepository.GetAll() on a.IDKH equals b.ID
					 join c in _inhanVienRepository.GetNhanVien() on a.IDNV equals c.ID
					 join d in _ihinhThucThanhToanRepository.GetAll() on a.IDHTTT equals d.ID
					 select new ViewHoaDon
					 {
						 ID = a.ID,
						 IDKH = a.IDKH,
						 IDNV = a.IDNV,
						 IDHTTT = a.IDHTTT,
						 Ma = a.Ma,
						 NgayTao = a.NgayTao,
						 NgayThanhToan = a.NgayThanhToan,
						 TrangThai = a.TrangThai,
						 TenKH = b.HovaTen,
						 TenNV = c.HoTen,
						 TenHTTT = d.Ten,
						 SDT = b.SDT,
						 ThanhTien = a.ThanhTien,

					 }).ToList();
			return lsthd;
		}

		public List<ViewHoaDon> GetAll()
		{
			List<ViewHoaDon> lsthd = new List<ViewHoaDon>();
			lsthd = (from a in _ihoaDonRepository.GetAll()
					 join b in _ikhachHangRepository.GetAll() on a.IDKH equals b.ID
					 join c in _inhanVienRepository.GetNhanVien() on a.IDNV equals c.ID
					 select new ViewHoaDon
					 {
						 ID = a.ID,
						 IDKH = a.IDKH,
						 IDNV = a.IDNV,
						 Ma = a.Ma,
						 NgayTao = a.NgayTao,
						 NgayThanhToan = a.NgayThanhToan,
						 TrangThai = a.TrangThai,
						 TenKH = b.HovaTen,
						 TenNV = c.HoTen,
						 SDT = b.SDT,
						 ThanhTien = a.ThanhTien,

					 }).ToList();
			return lsthd;
		}

		public string Update(ViewHoaDon obj)
		{
			if (obj == null)
			{
				return "Không thành công";
			}
			HoaDon hd = new HoaDon()
			{
				ID = obj.ID,
				IDHTTT = obj.IDHTTT,
				IDKH = obj.IDKH,
				IDNV = obj.IDNV,
				Ma = obj.Ma,
				NgayTao = obj.NgayTao,
				NgayThanhToan = obj.NgayThanhToan,
				TrangThai = obj.TrangThai,
				ThanhTien = obj.ThanhTien,
			};
			if (_ihoaDonRepository.Update(hd)) return "Sửa thành công";
			return "Không thành công";
		}
	}
}
