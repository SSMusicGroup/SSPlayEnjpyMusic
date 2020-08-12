using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class PlayList_BLL
    {
        QLMusicDataContext da = new QLMusicDataContext();

        public PlayList_BLL() { }

        public List<Playlist> getDSPlayList()
        {
            return da.Playlists.Select(k => k).ToList();
        }

        public IQueryable getDSBaiHatCuaPLaylist(string maPlaylist)
        {
            var ds = from a in da.BaiHatVaPlayLists join b in da.BaiHats on a.maBaiHat equals b.maBaiHat where a.maPlaylist == maPlaylist select new { b.tenBaiHat};
            return ds;
        }
    }
}
