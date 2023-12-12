using System.IO;
using System.Text.Json;

namespace CalculatorTesting.Utils
{
    public static class ConfigReader
    {
        public struct Entity
        {
            public string calcpath { get; set; }
        }

        public static string GetPath()
        {
            string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filePath = Path.GetFullPath($"{dir}\\Config.json");
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var entity = JsonSerializer.Deserialize<Entity>(json);
                return entity.calcpath;
            }
        }
    }
}
