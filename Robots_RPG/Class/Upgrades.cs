using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_RPG.Class
{
    internal class Upgrades
    {
        //----------------------------Varebles--------------------------------
        private int upgradeID = 0;
        private List<int> upgradeIDList = new List<int>();
        private string name;
        private readonly string[] listOfTypes = { "Diffens", "Attack", "Health"};
        private string type;
        private string description = "";
        private int atributeBoost;
        private readonly string[] listOfRarity = { "Legendary", "Epic", "Rare", "Good", "Common" };
        private string rarity;
        //--------------------------------------------------------------------

        //---------------------------Constructors-----------------------------
        public Upgrades(string name, string type, string description, string rarity)
        {
            this.name = name;
            this.type = type;
            this.description = description;
            this.rarity = rarity;

            int tmpID = 0;
            Random rnd = new Random();

            while (upgradeID == 0)
            {
                tmpID = rnd.Next(10000000, 99999999); ;
                if (!upgradeIDList.Contains(tmpID))
                {
                    upgradeIDList.Add(tmpID);
                    upgradeID = tmpID;
                }
            }
        }

        public Upgrades(string type)
        {
            this.type = type;
            this.rarity = "Common";
            this.description = "it's a standart weapon";
            this.atributeBoost = 2;

            int tmpID = 0;
            Random rnd = new Random();

            while (upgradeID == 0)
            {
                tmpID = rnd.Next(10000000, 99999999); ;
                if (!upgradeIDList.Contains(tmpID))
                {
                    upgradeIDList.Add(tmpID);
                    upgradeID = tmpID;
                }
            }
        }

        public Upgrades()
        {
            this.name = "Empty";
            this.rarity = String.Empty;
            this.description = String.Empty;
            this.type = String.Empty;
            this.upgradeID = 00000001;
            this.atributeBoost = 0;
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

        public int getAtributeBoost()
        {
            return this.atributeBoost;
        }

        //--------------------------------------------------------------------

        //---------------------------------Methods----------------------------
        //--------------------------------------------------------------------

    }
}
