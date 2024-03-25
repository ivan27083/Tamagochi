using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// время создания считывается при нажатии на кнопку создания  DateTime startTime = DateTime.Now;
// хранить время в файле, чтобы не пересекались данные; В КАКОМ БЛЯТЬ ФАЙЛЕ. 
// обновлять данные в файле при выходе из программы;

// ищем разницу, добавляем голод и прочее, что необходимо
// DateTime nowTime = DateTime.Now;
// TimeSpan timeDifference = endTime - startTime;

// переприсваиваем время
// если (разность времени больше 10(?) минут) голод++; и т.д.
/*
   if (timeDifference.TotalMinutes == 10)
        {
           + действие
            startTime = endTime;
        }
 */

// метод расчёта голода и пр. при запуске (???)
// если прошло больше времени, чем, не знаю, два часа(?), то снимаем возможный максимум и может выводим сообщение о том, что питомец соскучился
// если меньше, то рассчёт того, сколько необходимо добавить единиц голода и пр.

// запись Datetime в файл
/* string startTimeFromFile;
using (StreamWriter writer = new StreamWriter("time.txt"))
{
    writer.WriteLine(endTime.ToString());
}*/


// чтение из файла 
/*
 using (StreamReader reader = new StreamReader("time.txt"))
 {
    endTimeFromFile = reader.ReadLine();
 }

  DateTime endTimeFromF = DateTime.Parse(endTimeFromFile);
 */

namespace Tamagochi.Classes
{
    internal class Timer
    {
        DateTime startTime { get; set; } 

    }
}
