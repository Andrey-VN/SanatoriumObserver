using SanatoriumObserver.Observable;
using SanatoriumObserver.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatoriumObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsSanatorium observableSanatorium = new NewsSanatorium();
            //добавляем гостей в первый санаторий
            IObserver observer1 = new Guest_1("Иван");
            IObserver observer2 = new Guest_1("Владимир");
            IObserver observer3 = new Guest_1("Евгения");
            //добавляем гостей во второй  санаторий
            IObserver observer4 = new Guest_2("Федор");
            IObserver observer5 = new Guest_2("Елена");
            IObserver observer6 = new Guest_2("Ксения");


            //подписываем на уведомления гостей первого санатория
            observableSanatorium.AddObserver(observer1);
            observableSanatorium.AddObserver(observer2);
            observableSanatorium.AddObserver(observer3);
            //подписываем на уведомления гостей второго
            observableSanatorium.AddObserver(observer4);
            observableSanatorium.AddObserver(observer5);
            observableSanatorium.AddObserver(observer6);

            //отправляем гостям двух санаторий уведомления
            observableSanatorium.NotifyObservers();
            Console.WriteLine();


            Console.ResetColor();
            Console.WriteLine("Обновляем информацию.");

            //отправляем гостям двух санаторий уведомления
            observableSanatorium.NotifyObservers();

            Console.ResetColor();
            Console.WriteLine("Обновляем информацию.");

            //отправляем гостям двух санаторий уведомления
            observableSanatorium.NotifyObservers();



            //отписываем от уведомлений некоторых гостей первого санатория
            observableSanatorium.RemoveObserver(observer1);
            observableSanatorium.RemoveObserver(observer2);

            //отписываем от уведомлений некоторых гостей второго санатория
            observableSanatorium.RemoveObserver(observer4);
            observableSanatorium.RemoveObserver(observer5);


            Console.ResetColor();
            Console.WriteLine("Обновляем информацию.");

            //отправляем оставшимся подписанным гостям двух санаторий уведомления
            observableSanatorium.NotifyObservers();

            Console.ReadKey();

        }
    }
}
