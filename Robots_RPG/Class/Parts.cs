using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_RPG.Class
{
    internal class Parts
    {
        //----------------------------Varebles--------------------------------
        private int partID=0;
        private List<int> partIDList = new List<int>();
        private string name;
        private readonly string[] listOfTypes = { "Head", "Legs", "Tors" };
        private string type;
        private string description="";
        private int health, speed, attackPower;
        private readonly string[] listOfRarity = { "Legendary","Epic","Rare","Good","Common"};
        private string rarity;
        //--------------------------------------------------------------------

        //---------------------------Constructors-----------------------------
        public Parts(string name, string type, string description, string rarity)
        {
            this.name = name;
            this.type = type;
            this.description = description;
            this.rarity = rarity;

            int tmpID = 0;
            Random rnd = new Random();

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
            Random rnd = new Random();

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
        //--------------------------------------------------------------------

        //----------------------------Setters---------------------------------
        //--------------------------------------------------------------------

        //------------------------------Getters-------------------------------
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
