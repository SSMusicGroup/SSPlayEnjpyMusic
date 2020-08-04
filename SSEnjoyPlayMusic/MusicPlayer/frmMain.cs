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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string[] paths, files;
        int Startindex = 0;
        string[] Filename, Filepath;
        Boolean playnext = false;

        bool _playing = false;

        private void frmMain_Load(object sender, EventArgs e)
        {
            Startindex = 0;
            playnext = false;
            StopPlayer();
        }

        public void StopPlayer()
        {
            axWMP_main.Ctlcontrols.stop();
        }

        public void playfile(int playListIndex)
        {
            try
            {
                if (lbox_ListNhac.Items.Count <= 0)
                {
                    return;
                }
                if (playListIndex < 0)
                {
                    return;
                }
                axWMP_main.settings.autoStart = true;
                axWMP_main.URL = Filepath[playListIndex];
                axWMP_main.Ctlcontrols.next();
                axWMP_main.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex);
            }
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
            this.Close();
        }

        private void btn_PlayList_Click(object sender, EventArgs e)
        {
            lbox_ListNhac.BringToFront();
        }

        private void btn_NowPlay_Click(object sender, EventArgs e)
        {
            axWMP_main.BringToFront();
        }

        private void lbox_ListNhac_SelectedIndexChanged(object sender, EventArgs e)
        {
            Startindex = lbox_ListNhac.SelectedIndex;
            playfile(Startindex);
            lbl_Name_Song.Text = lbox_ListNhac.Text;
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            Startindex = 0;
            playnext = false;
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Multiselect = true;
            openFD.Filter = "(*.mp3)|*.mp3|all files(*.*)|*.*";
            if (openFD.ShowDialog()==DialogResult.OK)
            {
                Filename = new[] { openFD.SafeFileName };
                Filepath = new[] { openFD.FileName };
                for (int i = 0; i <= Filename.Length - 1; i++)
                {
                    lbox_ListNhac.Items.Add(Filename[i]);
                }
                Startindex = 0;
                playfile(0);
            }
        }
    }
}
