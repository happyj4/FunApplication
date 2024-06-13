using System.Text.Json;



namespace FunApplication.Models
{
    public class SportsmanScript
    {
        // конструктор
        public SportsmanScript()
        {
            SportsmanList = new List<SportsmanList>();
        }


        public List<SportsmanList> SportsmanList { get; set; } // поле 


        // алгоритм пошуку спортсмена
        public List<SportsmanList> Search(string sport, string name, string surname, string country, string club)
        {
            var result = new List<SportsmanList>();

            foreach (var param in SportsmanList)
            {
                bool match = true;

                if (!string.IsNullOrEmpty(name) && param.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    match = false;
                }

                if (!string.IsNullOrEmpty(surname) && param.Surname.IndexOf(surname, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    match = false;
                }

                if (!string.IsNullOrEmpty(country) && param.Country.IndexOf(country, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    match = false;
                }

                if (!string.IsNullOrEmpty(club) && param.Club.IndexOf(club, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    match = false;
                }

                if (!string.IsNullOrEmpty(sport) && param.Sport.IndexOf(sport, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    match = false;
                }

                if (match)
                {
                    result.Add(param);
                }
            }

            return result;
        }


        // алгоритм пошуку рекордсмена 
        public List<SportsmanList> Search(string sport)
        {
            SportsmanList topSportsman = null;

            foreach (var param in SportsmanList)
            {
                if (!string.IsNullOrEmpty(sport) && param.Sport.Equals(sport, StringComparison.OrdinalIgnoreCase))
                {
                    if (topSportsman == null || param.sportsRecord > topSportsman.sportsRecord)
                    {
                        topSportsman = param;
                    }
                }
            }

            var result = new List<SportsmanList>();
            if (topSportsman != null)
            {
                result.Add(topSportsman);
            }

            return result;
        }


        // метод збереження з  файлу
        public void SaveData(string path)
        {
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(path, jsonString);
        }


        // метод читання з  файллу
        public SportsmanScript LoadData(string path)
        {
            var jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<SportsmanScript>(jsonString);
        }


    }

}
