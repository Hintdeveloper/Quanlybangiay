using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewMolder
{
	public class ViewSanPhamChiTiet
	{
		public Guid ID { get; set; }
		public Guid IDSZ { get; set; }
		public string TenSZ { get; set; }
		public Guid IDSP { get; set; }
		public string TenSP { get; set; }
		public Guid IDKM { get; set; }
		public string TenKM { get; set; }
		public Guid IDLOAI { get; set; }
		public string TenLOAI { get; set; }
		public Guid IDNSX { get; set; }
		public string TenNSX { get; set; }
		public Guid IDNCC { get; set; }
		public string TenNCC { get; set; }
		public Guid IDMS { get; set; }
		public string TenMS { get; set; }

		public string Ma { get; set; }
		public int SoLuongTon { get; set; }
		public decimal GiaBan { get; set; }
		public decimal GiaNhap { get; set; }
		public string? HinhAnh { get; set; }
		public int TrangThai { get; set; }
		public string MoTa { get; set; }
	}
}
