using BlogTest.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BlogTest.FileUitls
{
    public class TitleRead
    {
       public static List<Title> GetTitles()
        {
            string filePath = "C:\\Users\\absol\\source\\repos\\BlogTest\\BlogTest\\TempData\\Titles.json";

            string json = File.ReadAllText(filePath);
            
            List<Title> list = JsonConvert.DeserializeObject<List<Title>>(json);

            if (list != null)
            {
                return list;
            }

            return null;

        }

    }
}
