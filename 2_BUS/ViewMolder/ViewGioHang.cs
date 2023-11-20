using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewMolder
{
	public class ViewGioHang
	{
		private static ViewGioHang instance = null;
		private static readonly object padlock = new object();
		private List<GioHangItem> items;
		private ViewGioHang()
		{
			items = new List<GioHangItem>();
		}
		public static ViewGioHang Instance
		{
			get
			{
				lock (padlock)
				{
					if (instance == null)
					{
						instance = new ViewGioHang();
					}
					return instance;
				}
			}
		}
		public void AddItem(GioHangItem item)
		{
			items.Add(item);
		}
		public void RemoveItem(GioHangItem item)
		{
			items.Remove(item);
		}
		public List<GioHangItem> GetItems()
		{
			return items;
		}

	}
	public class GioHangItem
	{
		public Guid ID { get; set; }
		public string Ma { get; set; }
		public Guid IDSPCT { get; set; }
		public string Ten { get; set; }
		public int SoLuong { get; set; }
		public decimal DonGia { get; set; }
	}

}
