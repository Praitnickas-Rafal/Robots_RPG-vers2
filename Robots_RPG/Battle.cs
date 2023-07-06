using Robots_RPG.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robots_RPG
{
    public partial class Battle : Form
    {
        private Robots robot1;
        private Robots robot2;
        public Battle(Robots robot1,Robots robot2)
        {
            InitializeComponent();
            this.robot1 = robot1;
            this.robot2 = robot2;
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            string robotPictureName1 = Path.Combine("C:\\Users\\MSI\\OneDrive\\Рабочий стол\\Robots_RPG-Rafala-Develop-Rafala\\Robots_RPG\\img", robot1.getType() + "-L.png");
            string robotPictureName2 = Path.Combine("C:\\Users\\MSI\\OneDrive\\Рабочий стол\\Robots_RPG-Rafala-Develop-Rafala\\Robots_RPG\\img", robot2.getType() + "-R.png");
            if (File.Exists(robotPictureName1)&& File.Exists(robotPictureName2))
            {

                LeftRobotPicterBox.Image = Image.FromFile(robotPictureName1);
                RightRobotPictureBox.Image = Image.FromFile(robotPictureName2);
            }

            UAttackArenaComboBox.Items.Add("Głowa");
            UAttackArenaComboBox.Items.Add("Tors");
            UAttackArenaComboBox.Items.Add("Nogi");

            UDefArenaComboBox.Items.Add("Głowa");
            UDefArenaComboBox.Items.Add("Tors");
            UDefArenaComboBox.Items.Add("Nogi");

            HpUsera.Text = "HP Usera: " + robot1.getHealth().ToString();

            HpRobotaCumputer.Text = "HP Enemy: " + robot2.getHealth().ToString();

            UDamageBattleLabel.Text = "Damage: " + robot1.getAttackPower().ToString();
            USpeedBattleLabel.Text = "Speed: " + robot1.getSpeed().ToString();


        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            Attack(robot1, robot2);
            Attack(robot2, robot1);

            HpUsera.Text = "HP Usera: " + robot1.getHealth().ToString();
            HpRobotaCumputer.Text = "HP Enemy: " + robot2.getHealth().ToString();
 

            if (robot1.getHealth() <= 0)
            {
                MessageBox.Show("Robot1 przegrał!");
            }

            if (robot2.getHealth() <= 0)
            {
                MessageBox.Show("Robot2 przegrał!");
            }
        }

        private void Attack(Robots attacker, Robots defender)
        {
            int damage = 50;
            defender.DecreaseHealth(damage);
        }

        private void BattleExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kapitulacja?", "Czy naprawdę chcesz wyjści?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
               StartBattle_Arena k1 = new StartBattle_Arena();
                k1.Show();
                this.Hide();
            }
        }

        private void UAttackArenaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
