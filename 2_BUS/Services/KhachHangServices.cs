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
	public class KhachHangServices: IKhachHangServices
	{
		private IKhachHangRepository _IkhachHangRepository;
		List<KhachHang> _lstKhachHang;
		List<ViewKhachHang> _lstViewKhachHang;
		public KhachHangServices()
		{
			_IkhachHangRepository = new KhachHangRepository();
			_lstKhachHang = new List<KhachHang>();
			_lstViewKhachHang = new List<ViewKhachHang>();
		}

		public bool Add(ViewKhachHang obj)
		{
			KhachHang kh = new KhachHang()
			{
				ID = obj.ID,
				HovaTen = obj.HovaTen,
				Poin = obj.Poin,
				SDT = obj.SDT,
				TrangThai = obj.TrangThai,
			};
			_IkhachHangRepository.Add(kh);
			return true;
		}

		public bool Delete(Guid ID)
		{
			var delete = _IkhachHangRepository.GetAll().FirstOrDefault(c => c.ID == ID);
			_IkhachHangRepository.Delete(delete);
			return true;
		}

		public List<KhachHang> GetAll()
		{
			_lstKhachHang = _IkhachHangRepository.GetAll();
			return _lstKhachHang;
		}

		public List<ViewKhachHang> GetAllViewKhachHang()
		{
			_lstViewKhachHang = (from a in _IkhachHangRepository.GetAll()
								 select new ViewKhachHang()
								 {
									 ID = a.ID,
									 HovaTen = a.HovaTen,
									 Poin = a.Poin,
									 SDT = a.SDT,
									 TrangThai = a.TrangThai,
								 }).ToList();
			return _lstViewKhachHang;
		}

		public KhachHang GetByID(Guid ID)
		{
			return _IkhachHangRepository.GetByID(ID);
		}

		public bool Update(ViewKhachHang obj)
		{
			var update = _IkhachHangRepository.GetAll().FirstOrDefault(_ => _.ID == obj.ID);
			update.HovaTen = obj.HovaTen;
			update.Poin = obj.Poin;
			update.SDT = obj.SDT;
			update.TrangThai = obj.TrangThai;
			_IkhachHangRepository.Update(update);
			return true;
		}

		public bool UpdateKhachHang(KhachHang obj)
		{
			_IkhachHangRepository.Update(obj);
			return true;
		}
	}
}
