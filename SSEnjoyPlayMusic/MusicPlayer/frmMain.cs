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

        public bool isPlaying
        {
            get
            {
                return _playing;
            }
            set
            {
                _playing = value;
                if (_playing)
                {
                    axWMP_main.Ctlcontrols.pause();
                    btn_Action.Image = play.Image;
                }
                else
                {
                    axWMP_main.Ctlcontrols.play();
                    btn_Action.Image = pause.Image;
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Startindex = 0;
            playnext = false;
            StopPlayer();
            bunifuSlider1.Value = 100;
           
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
                bunifuSlider1.Value = 100;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                bunifuSlider1.Value = 100;
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

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            axWMP_main.settings.volume = bunifuSlider1.Value;
            lbl_AmLuong.Text = bunifuSlider1.Value.ToString();
            if (bunifuSlider1.Value == 0)
            {
                btn_AmLuong.Image = Properties.Resources.Mute_100px;
            }
            else
            {
                btn_AmLuong.Image = Properties.Resources.audio_100px;
            }
        }

        private void btn_AmLuong_Click(object sender, EventArgs e)
        {
            if (bunifuSlider1.Value > 0)
            {
                btn_AmLuong.Image = Properties.Resources.No_Audio_100px;
                axWMP_main.settings.volume = 0;
            }
        }

        public EventHandler onAction = null;

        private void btn_Action_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
            if (onAction != null)
            {
                onAction.Invoke(this, e);
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            axWMP_main.Ctlcontrols.pause();
        }

        private void play_Click(object sender, EventArgs e)
        {
            axWMP_main.Ctlcontrols.play();
        }

        private void btn_Stop_song_Click(object sender, EventArgs e)
        {
            StopPlayer();
        }

        private void btn_next_song_Click(object sender, EventArgs e)
        {
            if (Startindex == lbox_ListNhac.Items.Count -1)
            {
                Startindex = lbox_ListNhac.Items.Count - 1;
            }
            else if (Startindex < lbox_ListNhac.Items.Count)
            {
                Startindex = Startindex + 1;
            }
            playfile(Startindex);
        }

        private void btn_back_Song_Click(object sender, EventArgs e)
        {
            if (Startindex > 0)
            {
                Startindex = Startindex - 1;
            }
            playfile(Startindex);
        }

        private void time_song_Tick(object sender, EventArgs e)
        {
            lbl_time_start.Text = axWMP_main.Ctlcontrols.currentPositionString;
            lbl_time_end.Text = axWMP_main.Ctlcontrols.currentItem.durationString.ToString();
            if (axWMP_main.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                PB_Timer.Value = (int)axWMP_main.Ctlcontrols.currentPosition;
            }
        }

        private void axWMP_main_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWMP_main.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                PB_Timer.MaximumValue = (int)axWMP_main.Ctlcontrols.currentItem.duration;
                time_song.Start();
            }
            else if (axWMP_main.playState==WMPLib.WMPPlayState.wmppsPaused)
            {
                time_song.Stop();
            }
            else if (axWMP_main.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                time_song.Stop();
                PB_Timer.Value = 0;
            }
        }

        private void PB_Timer_progressChanged(object sender, EventArgs e)
        {
            if (axWMP_main.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                
            }
        }

        private void btn_Casi_Click(object sender, EventArgs e)
        {

        }

        private void btn_BaiHat_Click(object sender, EventArgs e)
        {

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
                Filename = openFD.SafeFileNames;
                Filepath = openFD.FileNames;
                for (int i = 0; i <= Filename.Length - 1; i++)
                {
                    lbox_ListNhac.Items.Add(Filename[i]);
                }
                Startindex = 0;
                playfile(0);
                MessageBox.Show(openFD.SafeFileName);
            }
        }
    }
}
