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
using static QRCoder.PayloadGenerator;
using ZXing.Aztec.Internal;

namespace _2_BUS.Services
{
	public class NhanVienServices: INhanVienServices
	{
		List<ViewNhanVien> _viewNhanVienList;
		IChucVuRepository _IChucVuRepository;
		INhanVienRepository _INhanVienRepository;
		List<NhanVien> _lstNhanVien;
		public NhanVienServices()
		{
			_lstNhanVien = new List<NhanVien>();
			_viewNhanVienList = new List<ViewNhanVien>();
			_IChucVuRepository = new ChucVuRepository();
			_INhanVienRepository = new NhanVienRepository();
		}

		public bool AddNhanVien(ViewNhanVien nhanVien)
		{
			NhanVien nv = new NhanVien()
			{
				ID = nhanVien.ID,
				Username = nhanVien.Username,
				HoTen = nhanVien.HoTen,
				IDCV = nhanVien.IDCV,
				GioiTinh = nhanVien.GioiTinh,
				AnhNv = nhanVien.AnhNv,
				Email = nhanVien.Email,
				NgaySinh = nhanVien.NgaySinh,
				CCCD = nhanVien.CCCD,
				DiaChi = nhanVien.DiaChi,
				SoDienThoai = nhanVien.SoDienThoai,
				MatKhau = nhanVien.MatKhau,
				TrangThai = nhanVien.TrangThai,
				GhiChu = nhanVien.GhiChu
			};
			_INhanVienRepository.addNhanVien(nv);
			return true;
		}

		public bool DeleteNhanVien(Guid ID)
		{
			var delete = _INhanVienRepository.GetNhanVien().FirstOrDefault(c => c.ID == ID);
            _INhanVienRepository.deleteNhanVien(delete);
            return true;
		}

		public List<NhanVien> GetAllNhanVien()
		{
			_lstNhanVien = _INhanVienRepository.GetNhanVien().ToList();
			return _lstNhanVien;
		}

		public List<ViewNhanVien> GetAllViewNhanVien()
		{
			_viewNhanVienList = (from a in _INhanVienRepository.GetNhanVien()
								 join b in _IChucVuRepository.GetAll() on a.IDCV equals b.ID
								 select new ViewNhanVien
								 {
									 Username = a.Username,
									 ID = a.ID,
									 HoTen = a.HoTen,
									 IDCV = b.ID,
									 GioiTinh = a.GioiTinh,
									 AnhNv = a.AnhNv,
									 Email = a.Email,
									 NgaySinh = a.NgaySinh,
									 CCCD = a.CCCD,
									 DiaChi = a.DiaChi,
									 SoDienThoai = a.SoDienThoai,
									 MatKhau = a.MatKhau,
									 TrangThai = a.TrangThai,
									 GhiChu = a.GhiChu,
								 }).ToList();
			return _viewNhanVienList;
		}

		public bool UpdateNhanVien(ViewNhanVien nhanVien)
		{
			var update = _INhanVienRepository.GetNhanVien().FirstOrDefault(c => c.ID == nhanVien.ID);
			update.Username = nhanVien.Username;
			update.HoTen = nhanVien.HoTen;
			update.IDCV = nhanVien.IDCV;
			update.GioiTinh = nhanVien.GioiTinh;
			update.AnhNv = nhanVien.AnhNv;
			update.Email = nhanVien.Email;
			update.NgaySinh = nhanVien.NgaySinh;
			update.CCCD = nhanVien.CCCD;
			update.DiaChi = nhanVien.DiaChi;
			update.SoDienThoai = nhanVien.SoDienThoai;
			update.MatKhau = nhanVien.MatKhau;
			update.TrangThai = nhanVien.TrangThai;
			update.GhiChu = nhanVien.GhiChu;
			_INhanVienRepository.updateNhanVien(update);
			return true;
		}

		public bool updateSanPhamChiTiets(NhanVien nhanVien)
		{
			_INhanVienRepository.updateNhanVien(nhanVien);
			return true;
		}
	}
}
