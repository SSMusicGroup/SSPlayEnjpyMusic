using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class CaSi_BLL
    {
        QLMusicDataContext da = new QLMusicDataContext();
        public CaSi_BLL() { }

        public List<CaSi> getDSCaSi()
        {
            return da.CaSis.Select(k => k).ToList();
        }

        public IQueryable getDSBaiHatByCaSi(string maCaSi)
        {
            var bh = from t in da.BaiHats where t.maCaSi == maCaSi select new { t.tenBaiHat };
            return bh;
        }
        public bool check_CaSi(string maCaSi)
        {
            if ((da.BaiHats.Where(k => k.maCaSi == maCaSi).FirstOrDefault()) == null)
            {
                return false;
            }
            return true;
        }

        public bool check_CaSi_DaTonTai(string tenCS)
        {
            if (da.CaSis.Where(t => t.tenCaSi == tenCS).FirstOrDefault() == null)
                return false;
            return true;
        }

        public void addCaSi(string tenCS)
        {
            CaSi cs = new CaSi();
            int count = da.CaSis.Select(k => k).ToList().Count + 1;
            cs.maCaSi = "CS00" + count;
            cs.tenCaSi = tenCS;

            da.CaSis.InsertOnSubmit(cs);
            da.SubmitChanges();
        }
    }
}
