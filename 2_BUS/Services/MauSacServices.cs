using _1_DAL.DomainMolder;
using _2_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.IRepository;
using _1_DAL.Repository;

namespace _2_BUS.Services
{
    public class MauSacServices : IMauSacServices
    {
        private IMauSacRepository _iMausacRepository;
        private List<MauSac> _lstMausac;

        public MauSacServices()
        {
            _iMausacRepository = new MauSacRepository();
            _lstMausac = new List<MauSac>();
        }
        public bool Add(MauSac obj)
        {
            _iMausacRepository.Add(obj);
            return true;
        }

        public bool Delete(MauSac obj)
        {
            _iMausacRepository.Delete(obj);
            return true;
        }

        public List<MauSac> GetAll()
        {
            _lstMausac = _iMausacRepository.GetAll();
            return _lstMausac;
        }

        public List<MauSac> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _iMausacRepository.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.GhiChu.ToLower().Contains(input.ToLower())).ToList();
        }

        public bool Update(MauSac obj)
        {
            _iMausacRepository.Update(obj);
            return true;
        }
    }
}
