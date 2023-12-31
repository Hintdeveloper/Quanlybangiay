﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewMolder
{
	public class ViewNhanVien
	{
		public Guid ID { get; set; }
		public Guid IDCV { get; set; }
		public string Username { get; set; }
		public string HoTen { get; set; }
		public int GioiTinh { get; set; }
		public string Email { get; set; }
		public string AnhNv { get; set; }
		public DateTime NgaySinh { get; set; }
		public string SoDienThoai { get; set; }
		public string CCCD { get; set; }
		public string MatKhau { get; set; }
		public string DiaChi { get; set; }
		public int TrangThai { get; set; }
		public string GhiChu { get; set; }
		public string ChucVu { get; set; }
	}
}
