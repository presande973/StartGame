using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace StartGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void startButton_Click_1(object sender, EventArgs e)
        {
            SoundPlayer terrain = new SoundPlayer(Properties.Resources.terrain_warning);

            startButton.Visible = false; 
            
            outputLabel.Text = "Starting In 3...";
            Refresh();
            Thread.Sleep(1000);
            terrain.Play();

            outputLabel.Text = "Starting In 2...";
            Refresh();
            Thread.Sleep(1000);
            terrain.Play();

            outputLabel.Text = "Starting In 1...";
            Refresh();
            Thread.Sleep(1000);
            terrain.Play();

            outputLabel.Text = "";
            Refresh();
            Thread.Sleep(1000);
            terrain.Play();

            pictureBox1.BackColor = Color.Transparent;
            Refresh();
            Thread.Sleep(1000);
            terrain.Play();

            pictureBox1.Visible = false;
            pictureBox2.BackColor = Color.Transparent;
            Refresh();
            Thread.Sleep(1000);
            terrain.Play();

            pictureBox2.Visible = false;
            pictureBox3.BackColor = Color.Transparent;
            Refresh();
            Thread.Sleep(1000);
            terrain.Play();

            pictureBox3.Visible = false;
            pictureBox4.BackColor = Color.Transparent;
            Refresh();
            Thread.Sleep(1000);
            terrain.Play();

            pictureBox4.Visible = false;
            terrain.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
