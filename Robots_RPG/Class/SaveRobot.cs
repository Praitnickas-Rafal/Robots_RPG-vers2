using Robots_RPG.Class;
using System.Collections.Generic;
using System.IO;

namespace Robots_RPG
{
    public class SaveRobot
    {
        public static void Save(List<Robots> listaRobotow, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Robots robot in listaRobotow)
                {
                    string line = $"{robot.getID()},{robot.getName()},{robot.getType()},{robot.getAttackPower()},{robot.getSpeed()},{robot.getHealth()},{robot.getSelectedHead()},{robot.getSelectedTors()},{robot.getSelectedLegs()}";
                    writer.WriteLine(line);
                }
            }
        }

        public List<Robots> Load(string fileName)
        {
            List<Robots> listaRobotow = new List<Robots>(); // Tworzenie nowej listy

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Robots robot = new Robots();
                    string[] robotData = line.Split(',');

                    robot.setID(int.Parse(robotData[0]));
                    robot.setName(robotData[1]);
                    robot.setType(robotData[2]);
                    robot.setAttackPower(int.Parse(robotData[3]));
                    robot.setSpeed(int.Parse(robotData[4]));
                    robot.setHealth(int.Parse(robotData[5]));
                    robot.setSelectedHead(int.Parse(robotData[6]));
                    robot.setSelectedTors(int.Parse(robotData[7]));
                    robot.setSelectedLegs(int.Parse(robotData[8]));
                    robot.setParts(LoadParts("Parts.txt", robot));

                    listaRobotow.Add(robot);
                }
            }

            return listaRobotow;
        }

        //---------------------------------------------------LoadParts/SaveParts---------------------------------------------------------

        public static void SaveParts(List<Robots> listaRobotow, string fileName)
        {
            if (!File.Exists(fileName))
            {
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    foreach (Robots robot in listaRobotow)
                    {
                        //writer.WriteLine(robot.getID());
                        foreach (Parts part in robot.getParts())
                        {
                            string line = $"{robot.getID()},{part.getPartID()},{part.getName()},{part.getType()},{part.getAttackPower()},{part.getSpeed()},{part.getHealth()},{part.getRarity()},{part.getDescription()}";
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            else
            {
                File.Delete(fileName);
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    foreach (Robots robot in listaRobotow)
                    {
                        //writer.WriteLine(robot.getID());
                        foreach (Parts part in robot.getParts())
                        {
                            string line = $"{robot.getID()},{part.getPartID()},{part.getName()},{part.getType()},{part.getAttackPower()},{part.getSpeed()},{part.getHealth()},{part.getRarity()},{part.getDescription()}";
                            writer.WriteLine(line);
                        }
                    }
                }
            }
        }
        
        public List<Parts> LoadParts(string fileName, Robots robot)
        {
            List<Parts> listaParts = new List<Parts>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] robotData = line.Split(',');

                    if (int.Parse(robotData[0])==robot.getID())
                    {
                        Parts part = new Parts();

                        part.setPartID(int.Parse(robotData[1]));
                        part.setName(robotData[2]);
                        part.setType(robotData[3]);
                        part.setAttackPower(int.Parse(robotData[4]));
                        part.setSpeed(int.Parse(robotData[5]));
                        part.setHealth(int.Parse(robotData[6]));
                        part.setRarity(robotData[7]);
                        part.setDescription(robotData[8]);
        
                        listaParts.Add(part);
                    }
                }
            }
            return listaParts;
        }
        
    }
}