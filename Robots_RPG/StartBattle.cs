using Robots_RPG.Class;
using System;
using System.Windows.Forms;

namespace Robots_RPG
{
    public partial class StartBattle : Form
    {
        public StartBattle() // dodajemy parametr do konstruktora
        {
            InitializeComponent();
        }

        private void StartBattle_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm F3 = new MenuForm(); // przekazujemy global do nowego MenuForm
            F3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StartBattle_Arena b1 = new StartBattle_Arena();
            b1.Show();
            this.Hide();
            //selectedRobot.getRobots();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Garage g1 = new Garage();
            g1.Show();
            this.Hide();
        }
    }
}
