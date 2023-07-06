using System.IO;
using System.Windows.Forms;

namespace Robots_RPG.Class
{
    public static class FileHelper
    {
        public static class GlobalResources
        {
            public static int Coins { get; set; } = 1000;
            public static int xTools { get; set; } = 1000;
        }
        public static void SaveDataToFile(string filePath, int coins, int tools)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(coins);
                    writer.WriteLine(tools);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisywania danych do pliku: " + ex.Message, "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LoadDataFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string coinsLine = reader.ReadLine();
                        string toolsLine = reader.ReadLine();

                        int coins, tools;
                        if (int.TryParse(coinsLine, out coins))
                        {
                            GlobalResources.Coins = coins;
                        }
                        if (int.TryParse(toolsLine, out tools))
                        {
                            GlobalResources.xTools = tools;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Wystąpił błąd podczas odczytywania danych z pliku: " + ex.Message, "Błąd odczytu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
