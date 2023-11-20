using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
	public interface IMauSacRepository
	{
        public bool Add(MauSac obj);
        public bool Update(MauSac obj);
        public bool Delete(MauSac obj);
        public List<MauSac> GetAll();
    }
}
