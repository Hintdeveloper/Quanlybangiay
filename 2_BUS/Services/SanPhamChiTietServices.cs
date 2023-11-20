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
	public class SanPhamChiTietServices: ISanPhamChiTietServices
	{
		private ISanPhamChiTietRepository _isanPhamChiTietRepository;
		private ISanPhamRepository _isanPhamRepository;
		private INhaCCRepository _nhaCCRepository;
		private ILoaiSanPhamRepository _iloaiSanPhamRepository;
		private INSXRepository _inSXRepository;
		private IMauSacRepository _mauSacRepository;
		private ISizeRepository _isizeRepository;
		private IKhuyenMaiRepository _ikhuyenMaiRepository;
		private List<ViewSanPhamChiTiet> _viewSanPhamChiTiets;
		private List<SanPhamChiTiet> _lstsanPhamChiTiets;
		public SanPhamChiTietServices()
		{
			_isanPhamChiTietRepository = new SanPhamChiTietRepository();
			_isanPhamRepository = new SanPhamRepository();
			_inSXRepository = new NSXRepository();
			_nhaCCRepository = new NCCRepository();
			_iloaiSanPhamRepository = new LoaiRepository();
			_mauSacRepository = new MauSacRepository();
			_isizeRepository = new SizeRepository();
			_ikhuyenMaiRepository = new KhuyenMaiRepository();
			_viewSanPhamChiTiets = new List<ViewSanPhamChiTiet>();
			_lstsanPhamChiTiets = new List<SanPhamChiTiet>();
		}

		public bool addSanPhamChiTiet(ViewSanPhamChiTiet chiTietSP)
		{
			var nv = new SanPhamChiTiet()
			{
				ID = chiTietSP.ID,
				Ma = chiTietSP.Ma,
				IDSP = chiTietSP.IDSP,
				IDSZ = chiTietSP.IDSZ,
				IDKM = chiTietSP.IDKM,
				IDLOAI = chiTietSP.IDLOAI,
				IDMS = chiTietSP.IDMS,
				IDNCC = chiTietSP.IDNCC,
				IDNSX = chiTietSP.IDNSX,
				SoLuongTon = chiTietSP.SoLuongTon,
				GiaBan = chiTietSP.GiaBan,
				GiaNhap = chiTietSP.GiaNhap,
				HinhAnh = chiTietSP.HinhAnh,
				TrangThai = chiTietSP.TrangThai,
				MoTa = chiTietSP.MoTa,

			};
			_isanPhamChiTietRepository.Add(nv);
			return true;
		}

		public bool deleteSanPhamChiTiet(Guid idspct)
		{
			var x = _isanPhamChiTietRepository.GetChiTietSP().FirstOrDefault(p => p.ID == idspct);
			_isanPhamChiTietRepository.Delete(x);
			return true;
		}

		public List<SanPhamChiTiet> GetChiTietSPs()
		{
			_lstsanPhamChiTiets = _isanPhamChiTietRepository.GetChiTietSP().ToList();
			return _lstsanPhamChiTiets;
		}

		public List<ViewSanPhamChiTiet> GetViewChiTietSps()
		{
			_viewSanPhamChiTiets = (from a in _isanPhamChiTietRepository.GetChiTietSP()
									join b in _mauSacRepository.GetAll() on a.IDMS equals b.ID
									join c in _isanPhamRepository.GetAll() on a.IDSP equals c.ID
									join d in _isizeRepository.GetAll() on a.IDSZ equals d.ID
									join e in _iloaiSanPhamRepository.GetAll() on a.IDLOAI equals e.ID
									join f in _inSXRepository.GetAll() on a.IDNSX equals f.ID
									join g in _nhaCCRepository.GetAll() on a.IDNCC equals g.ID
									join h in _ikhuyenMaiRepository.GetAll() on a.IDKM equals h.ID
									select new ViewSanPhamChiTiet
									{
										ID = a.ID,
										Ma = a.Ma,
										IDMS = a.IDMS,
										IDLOAI = a.IDLOAI,
										IDSZ = a.IDSZ,
										IDKM = a.IDKM,
										IDSP = a.IDSP,
										IDNCC = a.IDNCC,
										IDNSX = a.IDNSX,
										GiaBan = a.GiaBan,
										GiaNhap = a.GiaNhap,
										MoTa = a.MoTa,
										SoLuongTon = a.SoLuongTon,
										TenMS = b.Ten,

										TenSP = c.Ten,
										TenSZ = d.Ten,
										TenLOAI = e.Ten,
										TenNSX = f.Ten,
										TenNCC = g.Ten,
										TenKM = h.Ten,
										HinhAnh = a.HinhAnh,
										TrangThai = a.TrangThai,

									}).ToList();
			return _viewSanPhamChiTiets;
		}

		public bool updateSanPhamChiTiet(ViewSanPhamChiTiet chiTietSP)
		{
			var x = _isanPhamChiTietRepository.GetChiTietSP().FirstOrDefault(p => p.ID == chiTietSP.ID);
			x.IDMS = chiTietSP.IDMS;
			x.Ma = chiTietSP.Ma;
			x.HinhAnh = chiTietSP.HinhAnh;
			x.IDLOAI = chiTietSP.IDLOAI;
			x.IDNCC = chiTietSP.IDNCC;
			x.IDNSX = chiTietSP.IDNSX;
			x.IDSP = chiTietSP.IDSP;
			x.IDSZ = chiTietSP.IDSZ;
			x.IDKM = chiTietSP.IDKM;
			x.GiaNhap = chiTietSP.GiaNhap;
			x.GiaBan = chiTietSP.GiaBan;
			x.MoTa = chiTietSP.MoTa;
			x.SoLuongTon = chiTietSP.SoLuongTon;
			x.TrangThai = chiTietSP.TrangThai;


			_isanPhamChiTietRepository.Update(x);
			return true;
		}
	}
}
