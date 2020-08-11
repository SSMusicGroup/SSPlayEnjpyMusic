using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;
using MusicPlayer;

namespace MusicPlayer
{
    public partial class frmPlayList : Form
    {
        CaSi_BLL ca_bll = new CaSi_BLL();
        BaiHat_BLL bh_bll = new BaiHat_BLL();

        private string getMaCaSi;

        public string temp;
        
        public frmPlayList()
        {
            InitializeComponent();
        }

        public void GETVALUE(string value)
        {
            getMaCaSi = value;   
        }

        private void frmPlayList_Load(object sender, EventArgs e)
        {
            try
            {
                frmCaSi f_CaSi = new frmCaSi();
                MessageBox.Show("" + temp);
                dgv_phatCaSi.DataSource = ca_bll.layDSBaiHatByCaSi(temp);

                //dgv_phatCaSi.DataSource = bh_bll.layDSBaiHat();
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
        }
    }
}
