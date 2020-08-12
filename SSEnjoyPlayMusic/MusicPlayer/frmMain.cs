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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        CaSi_BLL daCS = new CaSi_BLL();
        BaiHat_BLL daBH = new BaiHat_BLL();
        PlayList_BLL daPL = new PlayList_BLL();
        string maCS;
        string[] paths, files;
        int Startindex = 0;
        string[] Filename, Filepath;
        Boolean playnext = false;
        int indexCboCaSi = 0;

        bool _playing = false;

        public string MaCaSi
        {
            get { return maCS; }
            set { maCS = value; }
        }

        public void loadCbo_CaSi()
        {
            cbo_CaSi.DataSource = daCS.layDSCaSi();
            cbo_CaSi.DisplayMember = "tenCaSi";
            cbo_CaSi.ValueMember = "maCaSi";
        }


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

        public void load_dsBaiHat()
        {
            dgvBaiHat.DataSource = daBH.load_DSBaiHat();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            load_dsBaiHat();
            loadCbo_PlayList();
            Startindex = 0;
            playnext = false;
            StopPlayer();
            bunifuSlider1.Value = 100;
            loadCbo_CaSi();
            indexCboCaSi++;
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
            gbPLaylist.BringToFront();
        }

        private void btn_NowPlay_Click(object sender, EventArgs e)
        {
            lbox_ListNhac.BringToFront();
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            axWMP_main.settings.volume = bunifuSlider1.Value;
            lbl_AmLuong.Text = bunifuSlider1.Value.ToString();
            if (bunifuSlider1.Value == 0)
            {
                btn_AmLuong.Image = Image.FromFile(@"F:\Githud\SSPlayEnjpyMusic\SSEnjoyPlayMusic\MusicPlayer\Image\Mute_100px.png");
            }
            else
            {
                btn_AmLuong.Image = Image.FromFile(@"F:\Githud\SSPlayEnjpyMusic\SSEnjoyPlayMusic\MusicPlayer\Image\audio_100px.png");
            }
        }

        private void btn_AmLuong_Click(object sender, EventArgs e)
        {
            if (bunifuSlider1.Value > 0)
            {
                btn_AmLuong.Image = Image.FromFile(@"F:\Githud\SSPlayEnjpyMusic\SSEnjoyPlayMusic\MusicPlayer\Image\No Audio_100px.png");
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

        private void cbo_CaSi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (indexCboCaSi > 0)
            {
                dgvCaSi.DataSource = daCS.layDSBaiHatByCaSi(cbo_CaSi.SelectedValue.ToString());
            }
        }

        private void dgvCaSi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Casi_Click(object sender, EventArgs e)
        {
            gbCaSi.BringToFront();
        }

        private void btn_BaiHat_Click(object sender, EventArgs e)
        {
            gbBaihat.BringToFront();
        }

        private void dgvBaiHat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                ContextMenuStrip baihat_menu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy_mouse_row = dgvBaiHat.HitTest(e.X, e.Y).RowIndex;
                if(position_xy_mouse_row >= 0)
                {
                    baihat_menu.Items.Add("Thêm tên ca sĩ").Name = "menu_item_them_ten_ca_si";
                    baihat_menu.Items.Add("Thêm vào playlist").Name = "menu_item_them_vao_play_list";
                }
                baihat_menu.Show(dgvBaiHat,new Point(e.X,e.Y));
                baihat_menu.ItemClicked += Baihat_menu_ItemClicked;

            }
        }

        private void Baihat_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show(e.ClickedItem.Name.ToString());
            switch(e.ClickedItem.Name.ToString())
            {
                case "menu_item_them_ten_ca_si":
                    break;
                case "menu_item_them_vao_play_list":
                    break;
            }
        }

        private void lbox_ListNhac_MouseClick(object sender, MouseEventArgs e)
        {
            Startindex = lbox_ListNhac.SelectedIndex;
            playfile(Startindex);
            lbl_Name_Song.Text = lbox_ListNhac.Text;
        }

        private void cboPlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPlaylist.DataSource = daPL.getDSBaiHatCuaPLaylist(cboPlayList.SelectedValue.ToString());
        }

        public void loadCbo_PlayList()
        {
            cboPlayList.DataSource = daPL.layDSPlayList();
            cboPlayList.DisplayMember = "tenPlayList";
            cboPlayList.ValueMember = "maPlayList";
        }

        private void cboPlayList_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvPlaylist.DataSource = daPL.getDSBaiHatCuaPLaylist(cboPlayList.SelectedValue.ToString());          
        }

        private void lbox_ListNhac_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Startindex = lbox_ListNhac.SelectedIndex;
            //playfile(Startindex);
            //lbl_Name_Song.Text = lbox_ListNhac.Text;
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
                    try
                    {

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Bài hát chứa ký tự đặc biệt, không thể lưu trữ.");
                    }               
                    lbox_ListNhac.Items.Add(Filename[i]);
                }
                Startindex = 0;
                playfile(0);
                
            }
        }
    }
}
