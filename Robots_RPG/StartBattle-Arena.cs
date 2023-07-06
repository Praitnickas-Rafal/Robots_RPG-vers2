using Robots_RPG.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robots_RPG
{
    public partial class StartBattle_Arena : Form
    {
        public List<Robots> listaRobotow;
        public SaveRobot sr = new SaveRobot();
        private Robots robot1;
        private Robots robot2;

        public StartBattle_Arena()
        {
            listaRobotow = new List<Robots>(); // Inicjalizacja listy robotów
            List<Robots> loadedRobots = sr.Load("file.txt");
            if (loadedRobots != null)
            {
                listaRobotow.AddRange(loadedRobots);
            }
            InitializeComponent();
        }

        private void StartBattle_Arena_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            foreach (Robots robot in listaRobotow)
            {
               ChoiseRobotArenaComboBox.Items.Add(robot.getName());
               ChoiseRobotaEComboBox.Items.Add(robot.getName());
            }
        }

        private void ArenaStartBattleButton_Click(object sender, EventArgs e)
        {
            // Form ktury przezuca na form battle ->
            if (ChoiseRobotArenaComboBox.SelectedItem!=null && ChoiseRobotaEComboBox.SelectedItem != null)
            {
                Battle s1 = new Battle(robot1, robot2);
                s1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wybierz 2 robotów dla walki","error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            //Battle s1 = new Battle(robot1,robot2);
            //s1.Show();
            //this.Hide();
            // Trzeba save -> 2 obiektów

            

        }

        private void ChoiseRobotArenaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Robots robot in listaRobotow)
            {
                if(robot.getName() == ChoiseRobotArenaComboBox.Text){
                    string robotPictureName = Path.Combine("C:\\Users\\MSI\\OneDrive\\Рабочий стол\\Robots_RPG-Rafala-Develop-Rafala\\Robots_RPG\\img", robot.getType() + "-L.png");
                    if (File.Exists(robotPictureName))
                    {
                        //UserArenaSPictureBox.Image = null;
                        UserArenaSPictureBox.Image = Image.FromFile(robotPictureName);
                    }
                    robot1 = robot;
                }
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm m1 = new MenuForm();
            m1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Garage g1 = new Garage();
            g1.Show();
            this.Hide();
        }

        private void UserArenaSPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void ChoiseRobotaEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Robots robot in listaRobotow)
            {
                if (robot.getName() == ChoiseRobotaEComboBox.Text)
                {
                    string robotPictureName = Path.Combine("C:\\Users\\MSI\\OneDrive\\Рабочий стол\\Robots_RPG-Rafala-Develop-Rafala\\Robots_RPG\\img", robot.getType() + "-R.png");
                    if (File.Exists(robotPictureName))
                    {
                        //UserArenaSPictureBox.Image = null;
                        EnemyArenaSPictureBox.Image = Image.FromFile(robotPictureName);

                    }
                    robot2 = robot;
                }
            }
        }
    }
}
