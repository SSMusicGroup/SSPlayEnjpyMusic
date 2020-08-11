﻿using System;
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

        public List<CaSi> layDSCaSi()
        {
            return da.CaSis.Select(k => k).ToList();
        }

        public IQueryable layDSBaiHatByCaSi(string maCaSi)
        {
            var bh = from t in da.BaiHats where t.maCaSi == maCaSi select new { t.maBaiHat, t.tenBaiHat, t.maCaSi };
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
    }
}