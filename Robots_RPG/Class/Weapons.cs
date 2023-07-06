using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_RPG.Class
{
    internal class Weapons
    {
        //----------------------------Varebles--------------------------------
        private int weaponID = 0;
        private List<int> weaponIDList = new List<int>();
        private string name;
        private readonly string[] listOfTypes = { "Long Range", "Short Range", "Melee One heanded", "Melee two heanded"};
        private string type;
        private string description = "";
        private int damage, range, accuracy;
        private readonly string[] listOfRarity = { "Legendary", "Epic", "Rare", "Good", "Common" };
        private string rarity;
        //--------------------------------------------------------------------

        //---------------------------Constructors-----------------------------
        public Weapons(string name, string type, string description, string rarity)
        {
            this.name = name;
            this.type = type;
            this.description = description;
            this.rarity = rarity;

            int tmpID = 0;
            Random rnd = new Random();

            while (weaponID == 0)
            {
                tmpID = rnd.Next(10000000, 99999999); ;
                if (!weaponIDList.Contains(tmpID))
                {
                    weaponIDList.Add(tmpID);
                    weaponID = tmpID;
                }
            }
        }

        public Weapons(string type)
        {
            this.type = type;
            this.rarity = "Common";
            this.description = "it's a standart weapon";
            this.name = type;
            this.damage = 10;
            this.range = 10;
            this.accuracy = 10;

            int tmpID = 0;
            Random rnd = new Random();

            while (weaponID == 0)
            {
                tmpID = rnd.Next(10000000, 99999999); ;
                if (!weaponIDList.Contains(tmpID))
                {
                    weaponIDList.Add(tmpID);
                    weaponID = tmpID;
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

        public int getDamage()
        {
            return this.damage;
        }

        public int getRange()
        {
            return this.range;
        }

        public int getAccuracy()
        {
            return this.accuracy;
        }
        //--------------------------------------------------------------------

        //---------------------------------Methods----------------------------
        void fillParameters()
        {
            if((type == "Melee One heanded") || (type == "Melee two heanded")){
                range = 1;
                if(type == "Melee One heanded")
                {
                    damage = 10;
                    accuracy = 70;
                }
                else
                {
                    damage = 20;
                    accuracy = 60;
                }
            }
            else if(type == "Short Range")
            {
                range = 7;
                damage = 10;
                accuracy = 60;
            }
            else if(type == "Long Range")
            {
                range = 10;
                damage = 15;
                accuracy = 80;
            }
        }
        //--------------------------------------------------------------------
    }
}
