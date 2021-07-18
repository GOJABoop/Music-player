using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
	public partial class MainForm : Form
	{
		string[] files;
		string[] filesPaths;
		Boolean play;

		public MainForm(){
			InitializeComponent();
			play = true;
		}

		private void pictureBox1_Click(object sender, EventArgs e){
			if(openFileDialogFile.ShowDialog() == System.Windows.Forms.DialogResult.OK){
				files = openFileDialogFile.SafeFileNames;
				filesPaths = openFileDialogFile.FileNames;
				foreach(var file in files){
					listBoxSongs.Items.Add(file);
				}
				player.URL = filesPaths[0];
				listBoxSongs.SelectedIndex = 0;
			}
		}

		private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e){
			player.URL = filesPaths[listBoxSongs.SelectedIndex];
		}
	}
}
