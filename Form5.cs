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
    public partial class Form5 : Form
    {

        public Player current_player;

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string movie = favMovie.Text;
            current_player.setFavMovie(movie);

            Form6 form6 = new Form6();
            form6.current_player = current_player;
            this.Hide();
            form6.ShowDialog();
            Application.Exit();
        }
    }
}
