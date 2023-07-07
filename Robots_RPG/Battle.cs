using Robots_RPG.Class;
using System;
using System.Drawing;
using System.IO;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Robots_RPG
{
    public partial class Battle : Form
    {
        private Robots robot1;
        private Robots robot2;
        private Random random;
        private int clickCounter = 0;

        

        public Battle(Robots robot1, Robots robot2)
        {
            InitializeComponent();
            this.robot1 = robot1;
            this.robot2 = robot2;
            random = new Random();
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            MenuGarageLorWButton.Visible = false;
            string robotPictureName1 = Path.Combine("C:\\Users\\MSI\\OneDrive\\Рабочий стол\\Robots_RPG-Rafala-Develop-Rafala\\Robots_RPG\\img", robot1.getType() + "-L.png");
            string robotPictureName2 = Path.Combine("C:\\Users\\MSI\\OneDrive\\Рабочий стол\\Robots_RPG-Rafala-Develop-Rafala\\Robots_RPG\\img", robot2.getType() + "-R.png");
            if (File.Exists(robotPictureName1) && File.Exists(robotPictureName2))
            {
                LeftRobotPicterBox.Image = Image.FromFile(robotPictureName1);
                RightRobotPictureBox.Image = Image.FromFile(robotPictureName2);
            }

            UAttackArenaComboBox.Items.Add("Głowa");
            UAttackArenaComboBox.Items.Add("Tors");
            UAttackArenaComboBox.Items.Add("Nogi");
            UAttackArenaComboBox.SelectedIndex = 0;

            UDefArenaComboBox.Items.Add("Głowa");
            UDefArenaComboBox.Items.Add("Tors");
            UDefArenaComboBox.Items.Add("Nogi");
            UDefArenaComboBox.SelectedIndex = 0;

            HpUsera.Text = "HP Usera: " + robot1.getHealth().ToString();
            HpRobotaCumputer.Text = "HP Enemy: " + robot2.getHealth().ToString();

            UDamageBattleLabel.Text = "Damage: " + robot1.getAttackPower().ToString();
            USpeedBattleLabel.Text = "Speed: " + robot1.getSpeed().ToString();
        }

        private void Attack(Robots attacker, Robots defender)
        {
            int damage = attacker.getAttackPower();
            defender.DecreaseHealth(damage);
        }

        private void BattleExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kapitulacja?", "Czy naprawdę chcesz wyjść?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                StartBattle_Arena k1 = new StartBattle_Arena();
                k1.Show();
                this.Hide();
            }
        }

        private void AttackButton_Click_1(object sender, EventArgs e)
        {
            clickCounter++;
            // Wybór ataku gracza
            string playerAttackSelection = UAttackArenaComboBox.SelectedItem.ToString();
            string playerDefenseSelection = UDefArenaComboBox.SelectedItem.ToString();
            // Losowy wybór ataku komputera
            string computerAttackSelection = GetRandomSelection();
            string computerDefenseSelection = GetRandomSelection();

            RoundTagLabel.Visible = true;
            RoundBattleLabel.Visible = true;
            RoundBattleLabel.Text = clickCounter.ToString();

            string com = $"----ROUND {clickCounter}-----";
            CommentBattleTextBox.AppendText(com + Environment.NewLine);
            if (playerDefenseSelection == computerAttackSelection)
            {
                string comment = "Komputer uderzył obronę gracza!";
                CommentBattleTextBox.AppendText(comment + Environment.NewLine);
            }
            else
            {
                int damage = robot2.getAttackPower();
                string comment = $"Komputer uderzył gracza! Zadane obrażenia: {damage}";
                CommentBattleTextBox.AppendText(comment + Environment.NewLine);
                Attack(robot2, robot1);
            }

            if (computerDefenseSelection == playerAttackSelection)
            {
                string comment = "Gracz uderzył obronę Komputera!";
                CommentBattleTextBox.AppendText(comment + Environment.NewLine);
            }
            else
            {
                int damage = robot1.getAttackPower();
                string comment = $"Gracz uderzył Komputera! Zadane obrażenia: {damage}";
                CommentBattleTextBox.AppendText(comment + Environment.NewLine);
                Attack(robot1, robot2);
            }

            // Aktualizacja punktów zdrowia
            HpUsera.Text = "HP Usera: " + robot1.getHealth().ToString();
            HpRobotaCumputer.Text = "HP Enemy: " + robot2.getHealth().ToString();

            // Sprawdzenie, czy któryś z robotów stracił wszystkie punkty zdrowia
            if (robot1.getHealth() <= 0)
            {
                string end = "---KONIEC GRY---";
                CommentBattleTextBox.AppendText(end + Environment.NewLine);
                string comment = "Gracz przegrał!";
                CommentBattleTextBox.AppendText(comment + Environment.NewLine);
                AttackButton.Enabled = false;
                BattleExitButton.Enabled = false;
                MenuGarageLorWButton.Visible = true;

                MessageBox.Show($"Przegrałeś dla Komputera;(", "Porażka", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return; // Zakończ tę rundę
            }

            if (robot2.getHealth() <= 0)
            {

                string end = "---KONIEC GRY---";
                CommentBattleTextBox.AppendText(end + Environment.NewLine);
                string comment = "Komputer przegrał!";
                CommentBattleTextBox.AppendText(comment + Environment.NewLine);

                

                // Dodawanie 500 coins i 500 tools do globalnych zmiennych
                FileHelper.GlobalResources.Coins += 500;
                FileHelper.GlobalResources.xTools += 15;
                // Zapisz dane do pliku
                string filePath = "dane.txt";
                FileHelper.SaveDataToFile(filePath, FileHelper.GlobalResources.Coins, FileHelper.GlobalResources.xTools);
                AttackButton.Enabled = false;
                BattleExitButton.Enabled = false;
                MenuGarageLorWButton.Visible = true;

                MessageBox.Show($"Wygrałeś: 500 Kronów oraz 15 Instrumentów!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return; // Zakończ tę rundę
            }
        }

        private string GetRandomSelection()
        {
            string[] selections = { "Głowa", "Tors", "Nogi" };
            int randomIndex = random.Next(0, selections.Length);
            return selections[randomIndex];
        }

        private void UDefArenaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // tutaj wybieramy obronę
        }

        private void CommentBattleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartBattle_Arena k1 = new StartBattle_Arena();
            k1.Show();
            this.Hide();
        }
    }
}