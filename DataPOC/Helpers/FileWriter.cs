using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPOC.Helpers
{
    public class FileWriter
    {



        public static async Task WriteNewMarkdownDocs(Dictionary<string, string> dataDict)
        {
            foreach (string key in dataDict.Keys)
            {
                //Console.WriteLine(dataDict[key]);
                string[] lines = dataDict[key].Split("\n");
                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = lines[i].Replace("\\n", "");
                }

                string dateFormatted = DateTime.Now.ToString().Replace("/", "").Replace(" ", "_").Replace(":", "");
                string filePath = $"Output/Markdown/{key.Replace(".", "_")}_{dateFormatted}.md";

                try
                {
                    //Console.WriteLine($"Writing {key} to a new Markdown document...");
                    File.WriteAllLines(path: filePath, contents: lines);
                    //Console.WriteLine($"{key} has been written to a new Markdown document.");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Writing of {key} failed: \n \n {ex.Message}");
                }
            }
        }


        public static async Task WriteNewJsonFile(string dbName, string dataJson)
        {
            string dateFormatted = DateTime.Now.ToString().Replace("/", "").Replace(" ", "_").Replace(":", "");
            string filePath = $"Output/Json/{dbName}_{dateFormatted}.json";

            try
            {
                Console.WriteLine($"Writing {filePath} to a new Json document...");
                File.WriteAllText(path: filePath, contents: dataJson);
                Console.WriteLine($"{filePath} has been written.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Writing of {filePath} failed: \n \n {ex.Message}");
            }
        }
    }
}
