using Robots_RPG.Class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Robots_RPG
{
    public partial class Garage : Form
    {
        public List<Robots> listaRobotow; // Lista robotów dostępna w różnych plikach
        public Robots selectedRobot;
        public SaveRobot sr = new SaveRobot();
        public string typeRobota;
        public string nameRobota;

        private static Garage instance; // Instancja klasy Garage

        public static Garage Instance
        {
            get
            {
                if (instance == null)
                    instance = new Garage();
                return instance;
            }
        }

        public Garage()
        {
            listaRobotow = new List<Robots>(); // Inicjalizacja listy robotów
            List<Robots> loadedRobots = sr.Load("file.txt");
            if (loadedRobots != null)
            {
                listaRobotow.AddRange(loadedRobots);
            }
            InitializeComponent();

            if (selectedRobot != null)
            {
                parse_robot();
            }
        }

        private void Garage_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            TypeRobotaCComboBox.Items.Add("Fury");
            TypeRobotaCComboBox.Items.Add("Griffin");
            TypeRobotaCComboBox.Items.Add("Patton");
            TypeRobotaCComboBox.Items.Add("Destrier");
            TypeRobotaCComboBox.Items.Add("Conquerors");
            TypeRobotaCComboBox.Items.Add("Legioners");

            foreach (Robots robot in listaRobotow)
            {
                choiseModRobotaComboBox.Items.Add(robot.getName());
            }
            HeadRobotaCComboBox.Items.Add(PartsStorage.head1.getName());
            HeadRobotaCComboBox.Items.Add(PartsStorage.head2.getName());
            HeadRobotaCComboBox.Items.Add(PartsStorage.head3.getName());
            HeadRobotaCComboBox.Items.Add(PartsStorage.head4.getName());
            TorsRobotCComboBox.Items.Add(PartsStorage.tors1.getName());
            TorsRobotCComboBox.Items.Add(PartsStorage.tors2.getName());
            TorsRobotCComboBox.Items.Add(PartsStorage.tors3.getName());
            TorsRobotCComboBox.Items.Add(PartsStorage.tors4.getName());
            LegsRobotCComBox.Items.Add(PartsStorage.legs1.getName());
            LegsRobotCComBox.Items.Add(PartsStorage.legs2.getName());
            LegsRobotCComBox.Items.Add(PartsStorage.legs3.getName());
            LegsRobotCComBox.Items.Add(PartsStorage.legs4.getName());

        }

        private void GarageMenuBack_Click(object sender, EventArgs e)
        {
            MenuForm m1 = new MenuForm();
            m1.Show();
            this.Hide();
        }

        private void TypeRobotaCComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void NameRobotaCTextBox_TextChanged(object sender, EventArgs e) { }
        private void HeadRobotaCComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void TorsRobotCComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void LegsRobotCComBox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void AcceptRobotCButton_Click(object sender, EventArgs e)
        {
            if (TypeRobotaCComboBox.SelectedItem != null && !string.IsNullOrEmpty(NameRobotaCTextBox.Text))
            {
                typeRobota = TypeRobotaCComboBox.SelectedItem.ToString();
                nameRobota = NameRobotaCTextBox.Text;
                
                MessageBox.Show($"Sukces! Dodałeś nowego robota: {nameRobota} {typeRobota}", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Nie wybrałeś Typ", "Wybierz atrybut", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Robots robot = new Robots(nameRobota, typeRobota);
            selectedRobot = robot;

            listaRobotow.Add(robot); // Dodanie robota do listy

            parse_robot();
            SaveRobot.Save(listaRobotow, "file.txt");
            SaveRobot.SaveParts(listaRobotow, "Parts.txt");
        }

        private void choiseModRobotaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choiseModRobotaComboBox.SelectedItem != null)
            {
                parametryRobotaGarage.Visible = true;

                string selectedRobotName = choiseModRobotaComboBox.SelectedItem.ToString();

                foreach (Robots robot in listaRobotow)
                {
                    if (robot.getName() == selectedRobotName)
                    {
                        // Odczytaj nazwę i parametry robota
                        string robotName = robot.getName();
                        int robotHealth = robot.getHealth();
                        int robotDamage = robot.getAttackPower();
                        int robotSpeed = robot.getSpeed();
                        foreach (Parts part in robot.getParts())
                        {
                            headModComboBox.Items.Clear();
                            TorsModComboBox.Items.Clear();
                            LegsModComboBox.Items.Clear();
                            if (part.getType() == "Head")
                            {
                                headModComboBox.Items.Add(part.getName());
                            }
                            if (part.getType() == "Tors")
                            {
                                TorsModComboBox.Items.Add(part.getName());
                            }
                            if (part.getType() == "Legs")
                            {
                                LegsModComboBox.Items.Add(part.getName());
                            }

                            if (part.getPartID()==robot.getSelectedHead())
                            {
                                headModComboBox.SelectedItem = part.getName();

                            }
                            if (part.getPartID() == robot.getSelectedTors())
                            {
                                TorsModComboBox.SelectedItem = part.getName();
                            }
                            if (part.getPartID() == robot.getSelectedLegs())
                            {
                                LegsModComboBox.SelectedItem = part.getName();
                            }


                        }


                        // Wyświetl parametry robota w odpowiednich labelach
                        HealthParametsGarageLabel.Text = robotHealth.ToString();
                        DamageParametsGarageLabel.Text = robotDamage.ToString();
                        SpeedParametsGarageLabel.Text = robotSpeed.ToString();
                        //HeadParametsGarageLabel.Text = 
                        break;
                    }
                }
            }
        }




        void parse_robot()
        {
            choiseModRobotaComboBox.Items.Clear(); // Wyczyść poprzednie elementy
            foreach (Robots robot in listaRobotow)
            {
                choiseModRobotaComboBox.Items.Add(robot.getName());
            }
        }
    }
}
