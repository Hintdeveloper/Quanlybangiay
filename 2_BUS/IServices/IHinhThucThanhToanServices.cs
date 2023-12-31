﻿using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
	public interface IHinhThucThanhToanServices
	{
		bool Add(HinhThucThanhToan obj);
		bool Update(HinhThucThanhToan obj);
		bool Delete(HinhThucThanhToan obj);
		List<HinhThucThanhToan> GetAll();
		List<HinhThucThanhToan> GetAll(string input);
	}
}
