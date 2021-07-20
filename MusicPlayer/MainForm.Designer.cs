/*
 * Created by SharpDevelop.
 * User: Alberto
 * Date: 06/07/2021
 * Time: 11:02 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MusicPlayer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.OpenFileDialog openFileDialogFile;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialogFile = new System.Windows.Forms.OpenFileDialog();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.pictureBoxStop = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.macTrackBarVolume = new XComponent.SliderBar.MACTrackBar();
            this.macTrackBarSongScrolling = new XComponent.SliderBar.MACTrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogFile
            // 
            this.openFileDialogFile.FileName = "openFileDialog1";
            this.openFileDialogFile.Multiselect = true;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(161, 12);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(392, 64);
            this.player.TabIndex = 3;
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.Location = new System.Drawing.Point(12, 10);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(143, 225);
            this.listBoxSongs.TabIndex = 4;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdd.Image")));
            this.pictureBoxAdd.Location = new System.Drawing.Point(282, 241);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(37, 36);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdd.TabIndex = 5;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxStop
            // 
            this.pictureBoxStop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStop.Image")));
            this.pictureBoxStop.Location = new System.Drawing.Point(382, 241);
            this.pictureBoxStop.Name = "pictureBoxStop";
            this.pictureBoxStop.Size = new System.Drawing.Size(37, 36);
            this.pictureBoxStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStop.TabIndex = 6;
            this.pictureBoxStop.TabStop = false;
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlay.Image")));
            this.pictureBoxPlay.Location = new System.Drawing.Point(325, 232);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(51, 45);
            this.pictureBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlay.TabIndex = 7;
            this.pictureBoxPlay.TabStop = false;
            // 
            // macTrackBarVolume
            // 
            this.macTrackBarVolume.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBarVolume.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBarVolume.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBarVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBarVolume.IndentHeight = 6;
            this.macTrackBarVolume.Location = new System.Drawing.Point(46, 243);
            this.macTrackBarVolume.Maximum = 100;
            this.macTrackBarVolume.Minimum = 0;
            this.macTrackBarVolume.Name = "macTrackBarVolume";
            this.macTrackBarVolume.Size = new System.Drawing.Size(109, 29);
            this.macTrackBarVolume.TabIndex = 8;
            this.macTrackBarVolume.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBarVolume.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackBarVolume.TickHeight = 4;
            this.macTrackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBarVolume.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.macTrackBarVolume.TrackerSize = new System.Drawing.Size(10, 17);
            this.macTrackBarVolume.TrackLineColor = System.Drawing.Color.Silver;
            this.macTrackBarVolume.TrackLineHeight = 3;
            this.macTrackBarVolume.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBarVolume.Value = 0;
            // 
            // macTrackBarSongScrolling
            // 
            this.macTrackBarSongScrolling.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBarSongScrolling.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBarSongScrolling.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBarSongScrolling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBarSongScrolling.IndentHeight = 6;
            this.macTrackBarSongScrolling.Location = new System.Drawing.Point(178, 199);
            this.macTrackBarSongScrolling.Maximum = 10;
            this.macTrackBarSongScrolling.Minimum = 0;
            this.macTrackBarSongScrolling.Name = "macTrackBarSongScrolling";
            this.macTrackBarSongScrolling.Size = new System.Drawing.Size(375, 27);
            this.macTrackBarSongScrolling.TabIndex = 9;
            this.macTrackBarSongScrolling.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBarSongScrolling.TickColor = System.Drawing.Color.RoyalBlue;
            this.macTrackBarSongScrolling.TickHeight = 4;
            this.macTrackBarSongScrolling.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBarSongScrolling.TrackerColor = System.Drawing.Color.Silver;
            this.macTrackBarSongScrolling.TrackerSize = new System.Drawing.Size(15, 15);
            this.macTrackBarSongScrolling.TrackLineColor = System.Drawing.Color.Gray;
            this.macTrackBarSongScrolling.TrackLineHeight = 3;
            this.macTrackBarSongScrolling.TrackLineSelectedColor = System.Drawing.Color.Silver;
            this.macTrackBarSongScrolling.Value = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(565, 279);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.macTrackBarSongScrolling);
            this.Controls.Add(this.macTrackBarVolume);
            this.Controls.Add(this.pictureBoxPlay);
            this.Controls.Add(this.pictureBoxStop);
            this.Controls.Add(this.pictureBoxAdd);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.player);
            this.Name = "MainForm";
            this.Text = "MusicPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.PictureBox pictureBoxStop;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private XComponent.SliderBar.MACTrackBar macTrackBarVolume;
        private XComponent.SliderBar.MACTrackBar macTrackBarSongScrolling;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
