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
    public partial class Form2 : Form
    {
        public Player current_player;
        public Form2()
        {
            InitializeComponent();
        }

        //DO NOTHING
        private void start_option4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.current_player = current_player;
            this.Hide();
            form3.ShowDialog();
            Application.Exit();
        }

        //BEACH
        private void start_option1_Click(object sender, EventArgs e)
        {
            current_player.incrementExtroversion(2);
            Form3 form3 = new Form3();
            form3.current_player = current_player;
            this.Hide();
            form3.ShowDialog();
            Application.Exit();
        }
        //MOUNTAIN
        private void start_option2_Click(object sender, EventArgs e)
        {
            current_player.incrementIntroversion(1);
            Form3 form3 = new Form3();
            form3.current_player = current_player;
            this.Hide();
            form3.ShowDialog();
            Application.Exit();
        }

        //SKI
        private void start_option3_Click(object sender, EventArgs e)
        {
            current_player.incrementExtroversion(1);
            Form3 form3 = new Form3();
            form3.current_player = current_player;
            this.Hide();
            form3.ShowDialog();
            Application.Exit();
        }
    }
}
