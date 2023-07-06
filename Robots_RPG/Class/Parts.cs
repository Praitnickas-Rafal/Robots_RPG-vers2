using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_RPG.Class
{
    public class Parts
    {
        //----------------------------Varebles--------------------------------
        private static Random rnd = new Random();
        private int partID=0;
        private List<int> partIDList = new List<int>();
        private string name;
        private readonly string[] listOfTypes = { "Head", "Legs", "Tors" };
        private string type;
        private string description="No description provided!";
        private int health, speed, attackPower;
        private readonly string[] listOfRarity = { "Legendary","Epic","Rare","Good","Common"};
        private string rarity;
        //--------------------------------------------------------------------

        //---------------------------Constructors-----------------------------
        public Parts(string name, string type, int health, int speed, int attackPower)
        {
            this.name = name;
            this.type = type;
            this.health = health;
            this.speed = speed;
            this.attackPower = attackPower;
            //this.rarity = rarity;

            int tmpID = 0;
            //Random rnd = new Random();

            while (partID == 0)
            {
                tmpID = rnd.Next(10000000, 99999999); ;
                if (!partIDList.Contains(tmpID))
                {
                    partIDList.Add(tmpID);
                    partID = tmpID;
                }
            }
        }

        public Parts(string type)
        { 
            this.type=type;
            this.rarity = "Common";
            this.description = "it's a standart item";
            this.name = type;
            this.health = 10;
            this.speed = 10;
            this.attackPower = 10;

            int tmpID = 0;
            //Random rnd = new Random((int)DateTime.Now.Ticks);

            while (partID == 0)
            {
                tmpID = rnd.Next(10000000, 99999999); ;
                if (!partIDList.Contains(tmpID))
                {
                    partIDList.Add(tmpID);
                    partID = tmpID;
                }
            }
        }

        public Parts(){ }
        //--------------------------------------------------------------------

        //----------------------------Setters---------------------------------
        public void setPartID(int partID)
        {
            this.partID = partID;
            partIDList.Add(partID);
        }
        public void setRarity(string rarity)
        {
            this.rarity = rarity;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void setType(string type)
        {
            this.type = type;
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
        //--------------------------------------------------------------------

        //------------------------------Getters-------------------------------
        public int getPartID()
        {
            return this.partID;
        }
        public string getRarity()
        {
            return this.rarity;
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
        }

        public int getSpeed()
        {
            return this.speed;
        }

        public int getAttackPower()
        {
            return this.attackPower;
        }
        //--------------------------------------------------------------------

        //---------------------------------Methods----------------------------
        //--------------------------------------------------------------------
    }
}
