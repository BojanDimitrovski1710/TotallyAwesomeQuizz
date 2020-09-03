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
    public partial class Form3 : Form
    {

        public Player current_player;
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Do Nothing
        private void start_option4_Click(object sender, EventArgs e)
        {
            current_player.incrementResponsibility(-1);
            current_player.incrementEmpathy(-1);
            current_player.incrementBravery(-1);
            Form4 form4 = new Form4();
            form4.current_player = current_player;
            this.Hide();
            form4.ShowDialog();
            Application.Exit();
        }
        //Just Watch
        private void start_option3_Click(object sender, EventArgs e)
        {
            current_player.incrementBravery(-2);
            current_player.incrementEmpathy(1);
            Form4 form4 = new Form4();
            form4.current_player = current_player;
            this.Hide();
            form4.ShowDialog();
            Application.Exit();
        }
        //Go In
        private void start_option2_Click(object sender, EventArgs e)
        {
            current_player.incrementBravery(1);
            Form4 form4 = new Form4();
            form4.current_player = current_player;
            this.Hide();
            form4.ShowDialog();
            Application.Exit();
        }
        //Firemen
        private void start_option1_Click(object sender, EventArgs e)
        {
            current_player.incrementResponsibility(1);
            current_player.incrementEmpathy(1);
            Form4 form4 = new Form4();
            form4.current_player = current_player;
            this.Hide();
            form4.ShowDialog();
            Application.Exit();
        }
    }
}
