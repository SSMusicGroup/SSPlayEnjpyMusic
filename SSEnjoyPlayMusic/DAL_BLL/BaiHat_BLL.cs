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

        public IQueryable layDSBaiHatByCaSi(string maCaSi)
        {
            var bh = from t in da.BaiHats where t.maCaSi == maCaSi select new { t.maBaiHat, t.tenBaiHat, t.maCaSi };
            return bh;
        }
    }
}
