using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BaiHat_BLL
    {
        QLMusicDataContext da = new QLMusicDataContext();

        public BaiHat_BLL() { }

        public List<BaiHat> layDSBaiHat()
        {
            return da.BaiHats.Select(k => k).ToList();
        }
        public IQueryable load_DSBaiHat()
        {
            var ds = from a in da.BaiHats join b in da.CaSis on a.maCaSi equals b.maCaSi select new {a.tenBaiHat, b.tenCaSi };
            return ds;
        }
        public IQueryable layDSBaiHatByCaSi(string maCaSi)
        {
            var bh = from t in da.BaiHats where t.maCaSi == maCaSi select new { t.tenBaiHat};
            return bh;
        }

        public List<BaiHat> layDSBaiHatTonTai(string mCS)
        {
            return da.BaiHats.Where(k => k.maCaSi == mCS).ToList();
        }
        public void themBaiHat(string maBH, string tenBH, string maCaSi, string pathBH)
        {
            BaiHat bh = new BaiHat();
            bh.maBaiHat = maBH;
            bh.maCaSi = maCaSi;
            bh.tenBaiHat = tenBH;
            bh.pathBaiHat = pathBH;

            da.BaiHats.InsertOnSubmit(bh);
            da.SubmitChanges();
        }
        public string getMaBHMax()
        {
            BaiHat bh = da.BaiHats.ToList().OrderByDescending(t => t.maBaiHat).First();
            return bh.maBaiHat;
        }
        public string getMaCSMax()
        {
            CaSi bh = da.CaSis.ToList().OrderByDescending(t => t.maCaSi).First();
            return bh.maCaSi;
        }
    }
}
