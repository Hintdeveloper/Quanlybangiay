using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.DomainMolder
{
	public class HoaDon
	{
		public Guid ID { get; set; }
		public Guid IDKH { get; set; }
		public Guid IDNV { get; set; }
		public Guid IDHTTT { get; set; }
		public string Ma { get; set; }
		public DateTime NgayTao { get; set; }
		public DateTime NgayThanhToan { get; set; }
		public decimal ThanhTien { get; set; }
		public int TrangThai { get; set; }
		public NhanVien nhanvien { get; set; }
		public KhachHang khachhang { get; set; }
		public HinhThucThanhToan hinhthucthanhtoan { get; set; }
		public List<HoaDonChiTiet> hoadonchitiet { get; set; }
	}
}
