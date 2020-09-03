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
    public partial class Form6 : Form
    {
        public Player current_player;
        public Form6()
        {
            InitializeComponent();
        }

        //go after
        private void start_option1_Click(object sender, EventArgs e)
        {
            current_player.incrementBravery(2);
            current_player.incrementEmpathy(1);
            Form7 form7 = new Form7();
            form7.current_player = current_player;
            this.Hide();
            form7.ShowDialog();
            Application.Exit();
        }

        //do nothing
        private void start_option3_Click(object sender, EventArgs e)
        {
            current_player.incrementEmpathy(-1);
            Form7 form7 = new Form7();
            form7.current_player = current_player;
            this.Hide();
            form7.ShowDialog();
            Application.Exit();
        }

        //buy doll
        private void start_option2_Click(object sender, EventArgs e)
        {
            current_player.incrementEmpathy(2);
            Form7 form7 = new Form7();
            form7.current_player = current_player;
            this.Hide();
            form7.ShowDialog();
            Application.Exit();
        }
    }
}
