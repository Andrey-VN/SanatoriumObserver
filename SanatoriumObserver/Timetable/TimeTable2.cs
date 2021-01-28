using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatoriumObserver.Timetable
{
    public class TimeTable2
    {
        static Random random;

        public TimeTable2()
        {
            random = new Random();
        }

        public string RandomTimetable()
        {
            switch (random.Next(1, 5))
            {
                case 1:
                    return "Доброе утро! Время 9:00, на улице дождь, температура воздуха +15 градусов, день обещает быть дождлвым."+
                        "Завтрак сегодня будет доставлен в комнаты";
                case 2:
                    return "Сегодня в 11:00 будет футбол, играет команда 1 с командой 2";
                case 3:
                    return "Сегодня в 15:00 в планах у нас многоборье, будет три вида сорвенований, кураторы групп проведут инструктаж";
                case 4:
                    return "Добрый вечер! Вечером жмем штангу.";
                case 5:
                    return "Сегодня день будет без спорта и мероприятий, можите отправиться в город";
                default:
                    return "";
                    
            }
          
        }
    }
}
