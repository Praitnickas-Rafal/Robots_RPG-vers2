using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_RPG.Class
{
    internal class Story
    {
        //----------------------------Varebles--------------------------------
        private string name;
        private string description;
        private List<Battle> battles = new List<Battle>();
        private Battle battle;
        //private List<Rewards> rewards = new List<Rewards>();
        //--------------------------------------------------------------------

        //---------------------------Constructors-----------------------------
        public Story(Robots user,Robots Enemy)
        {
            name = string.Empty;
            description = string.Empty;
            battle = new Battle(user, Enemy);
            battles.Add(battle);
            //ewards = new List<Rewards>();
        }
        //--------------------------------------------------------------------

        //----------------------------Setters---------------------------------

        public void setName(string name) { this.name = name; }

        public void setDescription(string description) { this.description = description; }

        //public void setBattles(List<Battles> battles) { this.battles = battles; }

        //public void setRewards(List<Rewards> rewards) { this.rewards = rewards; }
        //--------------------------------------------------------------------

        //----------------------------Getters---------------------------------
        public string getName() { return name; }

        public string getDescription() { return description; }

        //public List<Battles> getBattles() { return battles; }

        //public List<Rewards> getRewards() { return rewards; }
        //--------------------------------------------------------------------

        //----------------------------Methods---------------------------------
        //--------------------------------------------------------------------
    }
}