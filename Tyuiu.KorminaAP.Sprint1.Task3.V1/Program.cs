using Tyuiu.KorminaAP.Sprint1.Task3.V1.Lib;
namespace Tyuiu.KorminaAP.Sprint1.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Кормина А. П. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Кормина Анна Павловна | ПИНб-26-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Объявите необходимые переменные и напишите программу вычисления объема  *");
            Console.WriteLine("* цилиндра, предполагающий ввод исходных данных. Ответ округлите          *");
            Console.WriteLine("* до 3 знаков после запятой.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            double r;
            double h;

            Console.WriteLine("Введите радиус цилиндра: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Высоту цилиндра: ");
            h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Объема цилиндра = " + ds.CylinderVolume(r, h));
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
