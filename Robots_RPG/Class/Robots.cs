using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robots_RPG.Class
{
    public class Robots
    {
        //----------------------------Varebles--------------------------------
       // private Globals global;
        private int ID=0;
        private List<int> IDList = new List<int>();
        private List<Robots> listaRobotow = new List<Robots>();
        private string name;
        private string description;
        private readonly string[] listOfTypes = { "Fury", "Griffin", "Patton", "Destrier", "Conquerors", "Legioners" };
        private List<Parts> parts = new List<Parts>();
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
            Random rnd = new Random();
            type = listOfTypes[rnd.Next(listOfTypes.Length)];
           // description = "ROBOT " + ID + "\n name: " + name + "\n class: " + type;
            fillParameters();
            
            //generateStandartParts();
            //generateStandartUpgrades();

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
            Random rnd = new Random();

            while (ID == 0)
            {
            tmpID = rnd.Next(10000000, 99999999);   ;
            if (!IDList.Contains(tmpID))
                {
                IDList.Add(tmpID);
                ID = tmpID;
                }
            }
            //global.listaRobotow.Add(this);
        }
//--------------------------------------------------------------------

//----------------------------Setters---------------------------------
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

//public void setRobots(List<Robots> newRobotsList)
//  {
//     this.listaRobotow = newRobotsList;
//  }

        public void DecreaseHealth(int damage)
{
health -= damage;
if (health < 0)
    health = 0;
}
//public void setRewards(List<Robots> listaRobotow) 
//        {
//            this.listaRobotow = listaRobotow; 
//        }
//--------------------------------------------------------------------

//------------------------------Getters-------------------------------
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
return this.
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
            this.attackPower = 60;
        break;
        case "Griffin":
            this.health = 100;
            this.speed = 50;
            this.attackPower = 70;
        break;
        case "Patton":
            this.health = 60;
            this.speed = 80;
            this.attackPower = 80;
        break;
        case "Destrier":
            this.health = 60;
            this.speed = 60;
            this.attackPower = 100;
        break;
        case "Conquerors":
            this.health = 80;
            this.speed = 80;
            this.attackPower = 60;
        break;
        case "Legioners":
            this.health = 70;
            this.speed = 70;
            this.attackPower = 70;
        break;
        default: 
            throw new Exception("wrong type of robot");
    }

}
catch(Exception ex)
{
    MessageBox.Show(ex.Message,"Erorr",MessageBoxButtons.OK,MessageBoxIcon.Error);
}
}

//at the start of robot genereting generate robot parts for tobot
void generateStandartParts()
{
parts.Add("Head");
parts.Add("Legs");
parts.Add("Tors");

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
