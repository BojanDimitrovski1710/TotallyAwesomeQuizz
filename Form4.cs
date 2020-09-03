using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_forms_aoo
{
    public partial class Form4 : Form
    {

        public Player current_player;

        public Form4()
        {
            InitializeComponent();
        }

        //Summer
        private void start_option1_Click(object sender, EventArgs e)
        {
            current_player.setFavSeason("Summer");
            Form5 form5 = new Form5();
            form5.current_player = current_player;
            this.Hide();
            form5.ShowDialog();
            Application.Exit();
        }

        //Winter
        private void start_option2_Click(object sender, EventArgs e)
        {
            current_player.setFavSeason("Winter");
            Form5 form5 = new Form5();
            form5.current_player = current_player;
            this.Hide();
            form5.ShowDialog();
            Application.Exit();
        }

        //Autum
        private void start_option3_Click(object sender, EventArgs e)
        {
            current_player.setFavSeason("Autum");
            Form5 form5 = new Form5();
            form5.current_player = current_player;
            this.Hide();
            form5.ShowDialog();
            Application.Exit();
        }

        //Spring
        private void start_option4_Click(object sender, EventArgs e)
        {
            current_player.setFavSeason("Spring");
            Form5 form5 = new Form5();
            form5.current_player = current_player;
            this.Hide();
            form5.ShowDialog();
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
