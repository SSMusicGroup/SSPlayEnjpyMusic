namespace SSMusicWindows
{
    partial class Main_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_UI));
            this.pSlideMenu = new System.Windows.Forms.Panel();
            this.pLogo = new System.Windows.Forms.Panel();
            this.btn_Media = new System.Windows.Forms.Button();
            this.pChildForm = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pSlideMenu.SuspendLayout();
            this.pChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // pSlideMenu
            // 
            this.pSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pSlideMenu.Controls.Add(this.btn_Media);
            this.pSlideMenu.Controls.Add(this.pLogo);
            this.pSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSlideMenu.Location = new System.Drawing.Point(0, 0);
            this.pSlideMenu.Name = "pSlideMenu";
            this.pSlideMenu.Size = new System.Drawing.Size(250, 665);
            this.pSlideMenu.TabIndex = 0;
            // 
            // pLogo
            // 
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(250, 100);
            this.pLogo.TabIndex = 0;
            // 
            // btn_Media
            // 
            this.btn_Media.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Media.Location = new System.Drawing.Point(0, 100);
            this.btn_Media.Name = "btn_Media";
            this.btn_Media.Size = new System.Drawing.Size(250, 45);
            this.btn_Media.TabIndex = 1;
            this.btn_Media.Text = "Media";
            this.btn_Media.UseVisualStyleBackColor = true;
            // 
            // pChildForm
            // 
            this.pChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pChildForm.Controls.Add(this.pictureBox9);
            this.pChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pChildForm.Location = new System.Drawing.Point(250, 0);
            this.pChildForm.Name = "pChildForm";
            this.pChildForm.Size = new System.Drawing.Size(768, 665);
            this.pChildForm.TabIndex = 3;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(263, 219);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(226, 218);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            // 
            // Main_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 665);
            this.Controls.Add(this.pChildForm);
            this.Controls.Add(this.pSlideMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_UI";
            this.Text = "Main_UI";
            this.pSlideMenu.ResumeLayout(false);
            this.pChildForm.ResumeLayout(false);
            this.pChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSlideMenu;
        private System.Windows.Forms.Button btn_Media;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Panel pChildForm;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}