using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewMolder
{
	public class ViewHoaDon
	{
		public Guid ID { get; set; }
		public Guid IDKH { get; set; }
		public string TenKH { get; set; }
		public Guid IDNV { get; set; }
		public string TenNV { get; set; }
		public Guid IDHTTT { get; set; }
		public string TenHTTT { get; set; }
		public string SDT { get; set; }
		public string Ma { get; set; }
		public DateTime NgayTao { get; set; }
		public DateTime NgayThanhToan { get; set; }
		public int TrangThai { get; set; }
		public decimal ThanhTien { get; set; }
	}
}
