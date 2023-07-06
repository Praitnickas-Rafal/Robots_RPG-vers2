using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Robots_RPG.Class
{
    public class Robots
    {
        //----------------------------Varebles--------------------------------
        // private Globals global;
        private static Random rnd = new Random();
        private int ID = 0;
        private List<int> IDList = new List<int>();
        //private List<Robots> listaRobotow = new List<Robots>();
        private string name;
        private string description;
        private readonly string[] listOfTypes = { "Fury", "Griffin", "Patton", "Destrier", "Conquerors", "Legioners" };
        private List<Parts> parts = new List<Parts>();
        private int selectedHead;
        private int selectedTors;
        private int selectedLegs;
        private Weapons[] weapons;
        private Upgrades[] upgrades;
        private string type;
        private int health, speed, attackPower;
        //--------------------------------------------------------------------

        //---------------------------Constructors-----------------------------

        public Robots() { }

        public Robots(string Name)
        {
            this.name = Name;
            //Random rnd = new Random();
            type = listOfTypes[rnd.Next(listOfTypes.Length)];
            // description = "ROBOT " + ID + "\n name: " + name + "\n class: " + type;
            fillParameters();

            generateStandartParts();
            generateStandartUpgrades();
            
            // int tmpID = 0;
            //  Random rnd = new Random();
            /*
            while (ID == 0)
            {
                tmpID = rnd.Next(10000000, 99999999);   ;
                if (!IDList.Contains(tmpID))
                {
                    IDList.Add(tmpID);
                    ID = tmpID;
                }
            }
            */
        }

        public Robots(string Name, string Type)
        {

            this.name = Name;
            this.type = Type;
            fillParameters();
            generateStandartParts();

            int tmpID = 0;
            //Random rnd = new Random();

            while (ID == 0)
            {
                tmpID = rnd.Next(10000000, 99999999); ;
                if (!IDList.Contains(tmpID))
                {
                    IDList.Add(tmpID);
                    ID = tmpID;
                }
            }
        }
        //--------------------------------------------------------------------

        //----------------------------Setters---------------------------------
        public void setID(int ID)
        {
            this.ID = ID;
            IDList.Add(ID);
        }
        
            public void setName(string name)
            {
                this.name = name;
            }

            public void setType(string type)
            {
                this.type = type;
            }

            public void setDescription(string description)
            {
                this.description = description;
            }

            public void setHealth(int health)
            {
                this.health = health;
            }

            public void setSpeed(int speed)
            {
                this.speed = speed;
            }

            public void setAttackPower(int attackPower)
            {
                this.attackPower = attackPower;
            }

            public void setSelectedHead(int selectedHead)
            {
                this.selectedHead = selectedHead;
            }
            public void setSelectedTors(int selectedTors)
            {
                this.selectedTors = selectedTors;
            }
            public void setSelectedLegs(int selectedLegs)
            {
                this.selectedLegs = selectedLegs;
            }

            public void setParts(List<Parts> parts)
            {
                this.parts = parts;
            }

            public void DecreaseHealth(int damage)
            {
                health -= damage;
                if (health < 0)
                    health = 0;
            }
            //public void setRewards(List<Robots> listaRobotow) 
            //{
            //    this.listaRobotow = listaRobotow; 
            //}
            //--------------------------------------------------------------------

            //------------------------------Getters-------------------------------
            public int getID()
            {
                return this.ID;
            }

            public string getName()
            {
                return this.name;
            }

            public string getDescription()
            {
                return this.description;
            }

            public string getType()
            {
                return this.type;
            }

            public int getHealth()
            {
                return this.health;
                //return (this.health + parts[0].getHealth()+ parts[1].getHealth()+ parts[2].getHealth());
            }

            public int getSpeed()
            {
                return this.speed;
            }

            public int getAttackPower()
            {
                return this.attackPower;
            }
            public List<Parts> getParts()
            {
                return this.parts;
            }
            public int getSelectedHead()
            {
                return this.selectedHead;
            }
            public int getSelectedTors()
            {
                return this.selectedTors;
            }
            public int getSelectedLegs()
            {
                return this.selectedLegs;
            }

            //public List<Robots> getRobots()
            //{
            //    return this.listaRobotow;
            //}
            //--------------------------------------------------------------------

            //---------------------------------Methods----------------------------

            //method with on the start fell parameters by type of robot
            public void fillParameters()
            {
                try
                {
                    switch (this.type)
                    {
                        case "Fury":
                            this.health = 60;
                            this.speed = 100;
                            this.attackPower = 6;
                            break;
                        case "Griffin":
                            this.health = 100;
                            this.speed = 50;
                            this.attackPower = 7;
                            break;
                        case "Patton":
                            this.health = 60;
                            this.speed = 80;
                            this.attackPower = 8;
                            break;
                        case "Destrier":
                            this.health = 60;
                            this.speed = 60;
                            this.attackPower = 10;
                            break;
                        case "Conquerors":
                            this.health = 80;
                            this.speed = 80;
                            this.attackPower = 6;
                            break;
                        case "Legioners":
                            this.health = 70;
                            this.speed = 70;
                            this.attackPower = 7;
                            break;
                        default:
                            throw new Exception("wrong type of robot");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //at the start of robot genereting generate robot parts for tobot
            void generateStandartParts()
            {
                // Thread.Sleep(1000);
                Parts partHead = new Parts("Head");
                parts.Add(partHead);
                selectedHead = partHead.getPartID();
                // Thread.Sleep(1000);
                Parts partLegs = new Parts("Legs");
                parts.Add(partLegs);
                selectedLegs = partLegs.getPartID();
                //  Thread.Sleep(1000);
                Parts partTors = new Parts("Tors");
                parts.Add(partTors);
                selectedTors = partTors.getPartID();


                //foreach (Parts part in parts)
                //{
                //    health += part.getHealth();
                //    speed += part.getSpeed();
                //    attackPower += part.getAttackPower();
                //}

            }

            void generateStandartWeapons()
            {
                try
                {
                    switch (this.type)
                    {
                        case "Fury":

                            break;
                        case "Griffin":

                            break;
                        case "Patton":

                            break;
                        case "Destrier":

                            break;
                        case "Conquerors":

                            break;
                        case "Legioners":

                            break;
                        default:
                            throw new Exception("wrong type of robot");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //generate two slots of empte upgrades
            void generateStandartUpgrades()
            {
                upgrades[0] = new Upgrades();
                upgrades[1] = new Upgrades();
            }
            //--------------------------------------------------------------------

        }
    }



