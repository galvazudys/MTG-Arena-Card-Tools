using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace MTGArena
{
    public class ShowCards
    {
        static ShowCards()
        {
            using (StreamReader file = new StreamReader("cards.json"))
            {
                string json = file.ReadToEnd();
                ApiObject.Rootobject cardsCollection = JsonConvert.DeserializeObject<ApiObject.Rootobject>(json);
                AllCards = cardsCollection;


            }
        }
        private static List<ApiObject.Rootobject> allCards;

        public static List<ApiObject.Rootobject> AllCards { get => allCards; set => allCards = value; }

        public static List<ApiObject.Rootobject> GetCards()
        {
            return AllCards;
        }
    }
}
