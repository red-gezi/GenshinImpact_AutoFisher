using System.IO;

namespace 坎瑞亚钓鱼机
{
    class Config
    {
        static string path = "config.txt";
        public static int GetConfig(int i) => int.Parse(File.ReadAllLines(path)[i]);
        public static void SetConfig(int i, int value)
        {
            string[] text = File.ReadAllLines(path);
            text[i] = value.ToString();
            File.WriteAllLines(path, text);
        }
    }
}
