using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
	public interface ISanPhamRepository
	{
        public bool Add(SanPham obj);
        public bool Update(SanPham obj);
        public bool Delete(SanPham obj);
        public List<SanPham> GetAll();
    }
}
