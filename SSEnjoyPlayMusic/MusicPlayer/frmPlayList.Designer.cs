namespace MusicPlayer
{
    partial class frmPlayList
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
            this.dgv_phatCaSi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phatCaSi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_phatCaSi
            // 
            this.dgv_phatCaSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phatCaSi.Location = new System.Drawing.Point(31, 145);
            this.dgv_phatCaSi.Name = "dgv_phatCaSi";
            this.dgv_phatCaSi.RowTemplate.Height = 24;
            this.dgv_phatCaSi.Size = new System.Drawing.Size(626, 303);
            this.dgv_phatCaSi.TabIndex = 0;
            // 
            // frmPlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 605);
            this.Controls.Add(this.dgv_phatCaSi);
            this.Name = "frmPlayList";
            this.Text = "frmPlayList";
            this.Load += new System.EventHandler(this.frmPlayList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phatCaSi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_phatCaSi;
    }
}