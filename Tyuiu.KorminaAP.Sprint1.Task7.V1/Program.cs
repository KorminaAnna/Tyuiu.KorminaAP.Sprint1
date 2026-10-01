using Tyuiu.KorminaAP.Sprint1.Task7.V1.Lib;
namespace Tyuiu.KorminaAP.Sprint1.Task7.V1
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Кормина Анна Павловна | ПИНб-26-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, водимых пользователем.                    *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*     b + √(b^2+4ac)                                                      *");
            Console.WriteLine("* z = -------------- - a^3*c+b^(-2)                                       *");
            Console.WriteLine("*           2a                                                            *");

            double a, b, c;
            Console.WriteLine("Введите значение A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение C: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a, b, c));
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
