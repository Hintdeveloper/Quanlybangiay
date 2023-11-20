using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.DomainMolder
{
	public class SanPhamChiTiet
	{
		public Guid ID { get; set; }
		public Guid IDSZ { get; set; }
		public Guid IDSP { get; set; }
		public Guid IDKM { get; set; }
		public Guid IDLOAI { get; set; }
		public Guid IDNSX { get; set; }
		public Guid IDNCC { get; set; }
		public Guid IDMS { get; set; }

		public string Ma { get; set; }
		public int SoLuongTon { get; set; }
		public decimal GiaBan { get; set; }
		public decimal GiaNhap { get; set; }
		public string HinhAnh { get; set; }
		public int TrangThai { get; set; }
		public string MoTa { get; set; }
		public NhaCungCap nhacungcap { get; set; }
		public NSX nsx { get; set; }
		public KhuyenMai khuyenmai { get; set; }
		public MauSac mausac { get; set; }
		public LoaiSanPham loaiSanPham { get; set; }
		public SanPham sanpham { get; set; }
		public KichThuoc size { get; set; }
		public List<HoaDonChiTiet> hoadonchitiet { get; set; }
	}
}
