using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatoriumObserver.Timetable
{
    public class TimeTable1
    {
        static Random random;

        public TimeTable1()
        {
            random = new Random();
        }

        public string RandomTimetable()
        {
            
            switch (random.Next(1, 5))
            {
                case 1:
                    return "Доброе утро! Время 9:00, на улице солнечно, температура воздуха +25 градусов, день обещает быть без облачным."+
                        "На завтрак сегодня пельмени с лучком и сметанкой, апельсиновый сок, яичница.";
                case 2:
                    return "Сегодня в 12:00 планируются водные процедуры, с собой иметь банные принадлежности. Маску мы выдаем сами, т.к. мы заботимся о вашем комфорте и здоровье.";
                case 3:
                    return "Сегодня в 15:00 идем на Кудыкину гору, все, кто желает ее посетить, ждем в 14:30 у базы \"Чудесный отдых\". Снаряжение выдается непосредствыенно на базе";
                case 4:
                    return "Добрый вечер! Сегодня в 21:00 проводится мероприятие в честь какого-то праздника. Мероприятие будет проходить в ресторане \"Черный дельфин\"";
                case 5:
                    return "Приносим свои извенения, парная во всех комплексах закрыта на ремонтные работы. Открытие будет завтра в 9:00";
                default:
                    return "";
                    
            }
          
        }
    }
}
