using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunApplication.Models
{
    public class SportsmanList
    {

        public int Id { get; set; } // унікальний id спортсмена 

        public string Name { get; set; } // ім'я спортсмена

        public string Surname { get; set; }    // прізвище спортсмена 

        public int Age { get; set; } // вік спортсмена

        public string ImageLocation { get; set; } // Місце картинки (обличяя)

        public string ImageLocationFlag { get; set; } // Місце картинки флагу (рідна карїна спортсмена)

        public string Country { get; set; } // рідна країна спортсмена 

        public int Height { get; set; } // зріст спортсмена 

        public int Weight { get; set; }   // вага спортсмена 

        public string Club { get; set; }   // клуб спортсмена (його може не бути у деяких спортсменів)

        public string Sport { get; set; }  // вид спорту спортсмена 

        public string aboutSportsman { get; set; } // дані про спортсмена

        public int sportsRecord { get; set; } // особистий рекорд спортсмена (рахуется за формулами)


    }
}
