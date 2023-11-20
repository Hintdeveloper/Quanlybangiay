using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewMolder
{
	public class ViewHoaDonCT
	{
		public Guid ID { get; set; }
		public Guid IDHD { get; set; }
		public Guid IDSPCT { get; set; }
		public string TenSP { get; set; }
		public string Ma  { get; set; }
		public int SoLuong { get; set; }
		public decimal thanhTien { get; set; }
		public decimal DonGia { get; set; }
	}
}
