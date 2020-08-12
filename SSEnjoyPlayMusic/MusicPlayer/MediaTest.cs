using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MediaTest : Form
    {
        public MediaTest()
        {
            InitializeComponent();
        }

        private void MediaTest_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"E:\Nhạc\♪ Đường Một Chiều ‣ Những Bản Acoustic Hay Nhất Về Tình Yêu Đơn Phương Thầm Lặng.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            MessageBox.Show(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration.ToString());
            listView1.Columns.Add("Bla bla bal",100);
            listView1.Columns.Add("Bla bla bal",100);
            listView1.Columns.Add("Bla bla bal",100);
            listView1.Columns.Add("Bla bla bal",100);
        }

        private void trackbar_MouseClick(object sender, MouseEventArgs e)
        {
           // axWindowsMediaPlayer1.Ctlcontrols.currentPosition = int.Parse(trackbar.Value.ToString());
        }

        private void trackbar_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = int.Parse(trackbar.Value.ToString());
            MessageBox.Show(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration.ToString());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
