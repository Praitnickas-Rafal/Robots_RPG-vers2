using Robots_RPG;
using Robots_RPG.Class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Robots_RPG
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        public void AppExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartBattleMenuButton_Click(object sender, EventArgs e)
        {
            StartBattle s1 = new StartBattle(); 
            s1.Show();
            this.Hide();
        }

        private void ChooseRobotMenuButton_Click(object sender, EventArgs e)
        {
            Garage s2 = new Garage(); 
            s2.Show();
            this.Hide();
        }
    }
}
