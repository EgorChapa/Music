using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Music
{
    partial class Form1
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
        int music = -1;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Text = "Form1";

            delete_music.Text = "Delete";
            delete_music.Location = new Point(300, 300);
            delete_music.Size = new System.Drawing.Size(50, 50);
            Controls.Add(delete_music);

            start.Location = new Point(175, 150);
            start.Text = "start";
            start.Size = new System.Drawing.Size(50, 50);
            Controls.Add(start);

            right.Location = new Point(225, 150);
            right.Text = ">";
            right.Size = new System.Drawing.Size(50, 50);
            Controls.Add(right);

            left.Location = new Point(125,150);
            left.Text = "<";
            left.Size = new System.Drawing.Size(50, 50);
            Controls.Add(left);

            add_music.Location = new Point(300, 250);
            add_music.Text = "Add";
            add_music.Size = new System.Drawing.Size(50, 50);
            add_music.Click += Add_music_Click;
            Controls.Add(add_music);

            image.Location = new Point(125, 0);
            image.Size = new System.Drawing.Size(150, 150);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.Image = Image.FromFile("CompactDisc.jpg");
            Controls.Add(image);

            musics.Size = new System.Drawing.Size(250, 200);
            musics.Click += Musics_Click;
            musics.Location = new Point(50, 250);
            Controls.Add(musics);
        }

        private void Musics_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Add_music_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "*.mp3|*.mp3|*.wav|*.wav";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    music++;
                    musica.Add(dialog.FileName);
                    var watcher = new FileSystemWatcher(@"C:\Users\student\Desktop\drssdrwropen01.mp3");
                    musics.Items.Add(watcher.NotifyFilter = NotifyFilters.FileName);
                    //musics.Items.Add(musica.Last().ToString()); надо
                }
            }
        }

        Button add_music = new Button();
        Button delete_music = new Button();
        Button start = new Button();
        Button right = new Button();
        Button left = new Button();

        PictureBox image = new PictureBox();

        List<string> musica = new List<string>();
        ListBox musics = new ListBox();
        #endregion
    }
}

