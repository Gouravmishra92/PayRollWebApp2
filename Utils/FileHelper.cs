using System.Text.Json;

namespace PayrollWebApp.Utils
{
    public static class FileHelper
    {
        public static void SaveToFile<T>(string path, T data)
        {
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        public static T LoadFromFile<T>(string path) where T : new()
        {
            if (!File.Exists(path))
                return new T();

            string json = File.ReadAllText(path);
            if (string.IsNullOrWhiteSpace(json))
                return new T();

            return JsonSerializer.Deserialize<T>(json) ?? new T();
        }
    }
}
