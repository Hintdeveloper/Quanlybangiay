using _1_DAL.DomainMolder;
using _1_DAL.IRepository;
using _1_DAL.Repository;
using _2_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class SanPhamServices : ISanPhamServices
    {
        private ISanPhamRepository _isanPhamRepository;
        private List<SanPham> _lstsanPhams;
        public SanPhamServices()
        {
            _isanPhamRepository = new SanPhamRepository();
            _lstsanPhams = new List<SanPham>();
        }
        public bool Add(SanPham obj)
        {
            _isanPhamRepository.Add(obj);
            return true;
        }

        public bool Delete(SanPham obj)
        {
            _isanPhamRepository.Delete(obj);
            return true;
        }

        public List<SanPham> GetAll()
        {
            _lstsanPhams = _isanPhamRepository.GetAll();
            return _lstsanPhams;
        }

        public List<SanPham> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _isanPhamRepository.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.Ma.ToLower().Contains(input.ToLower())).ToList();
        }

        public bool Update(SanPham obj)
        {
            _isanPhamRepository.Update(obj);
            return true;
        }
    }
}
