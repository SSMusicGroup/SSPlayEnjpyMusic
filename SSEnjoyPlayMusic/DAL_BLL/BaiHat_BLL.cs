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

        public IQueryable getDSBaiHat()
        {
            var bh = from a in da.BaiHats select new { a.tenBaiHat};
            return bh;
        }

        public IQueryable getDSBaiHatByCaSi(string maCaSi)
        {
            var bh = from t in da.BaiHats where t.maCaSi == maCaSi select new { t.maBaiHat, t.tenBaiHat, t.maCaSi };
            return bh;
        }

        public List<BaiHat> layDSBaiHatTonTai(string mCS)
        {
            return da.BaiHats.Where(k => k.maCaSi == mCS).ToList();
        }

        public int getSLBaiHat()
        {
            return da.BaiHats.Select(k => k).ToList().Count;
        }

        public bool KtraTonTaiBaiHat(string tenBaiHat)
        {
            if (da.BaiHats.Where(t => t.tenBaiHat == tenBaiHat).FirstOrDefault() == null)
                return false;
            return true;
        }
        public string getPathBaiHat(string tenBH)
        {
            BaiHat bh = da.BaiHats.Where(t => t.tenBaiHat == tenBH).FirstOrDefault();
            return bh.pathBaiHat;
        }
        public void setBaiHat(string tenBH, string pathName)
        {
            BaiHat bh = new BaiHat();
            int count = da.BaiHats.Select(k => k).ToList().Count + 1;

            bh.maBaiHat = "BH00" + count;
            bh.tenBaiHat = tenBH;
            bh.maCaSi = "CS001";
            bh.pathBaiHat = pathName;

            da.BaiHats.InsertOnSubmit(bh);
            da.SubmitChanges();
        }
    }
}
