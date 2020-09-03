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
    public partial class Quizz : Form
    {
        public Quizz()
        {
            InitializeComponent();
        }

        private void textField_CheckChanged(object sender, EventArgs e)
        {
            if (NameField.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string name = NameField.Text;
            Player newPlayer = new Player();
            newPlayer.SetName(name);

            Form2 form2 = new Form2();
            form2.current_player = newPlayer;
            this.Hide();
            form2.ShowDialog();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
