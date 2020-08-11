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

namespace MusicPlayer
{
    public partial class frmCaSi : Form
    {
        CaSi_BLL da = new CaSi_BLL();
        string maCS;

        
        public frmCaSi()
        {
            InitializeComponent();
        }

        public string MaCaSi
        {
            get { return maCS; }
            set { maCS = value; }
        }

        private void frmCaSi_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_CaSi.DataSource = da.layDSCaSi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load, vui lòng kiểm tra lại dữ liệu");
            }
        }

        private void dgv_CaSi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //public delegate void GETDATA(string data);
        //public GETDATA mydata;

        private void btn_Phat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_maCaSi.Text == "")
                {
                    MessageBox.Show("Vui long chon ma ca si ban can phat");
                }
                else
                {
                    if (da.check_CaSi(txt_maCaSi.Text))
                    {
                        frmPlayList frm = new frmPlayList();
                        frm.temp = txt_maCaSi.Text;
                        //mydata(txt_maCaSi.Text);
                        MessageBox.Show("" + txt_maCaSi.Text);
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Khong co ca si nay");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex);
                
            }
        }
    }
}
