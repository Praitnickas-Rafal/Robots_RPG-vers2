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
                    string line = $"{robot.getName()},{robot.getType()},{robot.getAttackPower()},{robot.getSpeed()},{robot.getHealth()}";
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

                    robot.setName(robotData[0]);
                    robot.setType(robotData[1]);
                    robot.setAttackPower(int.Parse(robotData[2]));
                    robot.setSpeed(int.Parse(robotData[3]));
                    robot.setHealth(int.Parse(robotData[4]));

                    listaRobotow.Add(robot);
                }
            }

            return listaRobotow;
        }
    }
}