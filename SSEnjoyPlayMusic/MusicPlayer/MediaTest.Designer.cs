namespace MusicPlayer
{
    partial class MediaTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaTest));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.trackbar = new Bunifu.Framework.UI.BunifuTrackbar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.CausesValidation = false;
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 152);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(548, 201);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // trackbar
            // 
            this.trackbar.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.trackbar.BackColor = System.Drawing.Color.Gainsboro;
            this.trackbar.BackgroudColor = System.Drawing.Color.Silver;
            this.trackbar.BorderRadius = 0;
            this.trackbar.ForeColor = System.Drawing.Color.Coral;
            this.trackbar.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.trackbar.IndicatorColor = System.Drawing.Color.DarkGreen;
            this.trackbar.Location = new System.Drawing.Point(100, 118);
            this.trackbar.MaximumValue = 100;
            this.trackbar.MinimumValue = 0;
            this.trackbar.Name = "trackbar";
            this.trackbar.Size = new System.Drawing.Size(415, 28);
            this.trackbar.SliderRadius = 0;
            this.trackbar.TabIndex = 3;
            this.trackbar.Value = 100;
            this.trackbar.Visible = false;
            this.trackbar.ValueChanged += new System.EventHandler(this.trackbar_ValueChanged);
            this.trackbar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trackbar_MouseClick);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.PeachPuff;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(41, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(377, 97);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MediaTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 353);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.trackbar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "MediaTest";
            this.Text = "MediaTest";
            this.Load += new System.EventHandler(this.MediaTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Bunifu.Framework.UI.BunifuTrackbar trackbar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}