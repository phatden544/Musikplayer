using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musikplayer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime currenttime = DateTime.Now;
            if (currenttime.Hour < 12)
            {
                
                label2.Text = "Chào buổi sáng !";
                label3.Text = "Playlist chào ngày mới";
                button1.Visible = false;
                button2.Visible =true;
                button3.Visible = false;
}
            else if (currenttime.Hour < 19)
            {
                label2.Text = "Chào buổi chiều !";
                label3.Text = "Playlist cho buổi trà chiều";
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
            }

            else
            {
                label2.Text = "Chào buổi tối  !";
                label3.Text = "Playist cho buổi tối thư giãn";
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
