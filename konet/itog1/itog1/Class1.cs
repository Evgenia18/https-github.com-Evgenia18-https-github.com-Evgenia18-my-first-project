using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    public class FunctionInsp

    {
        public static string fullname = "Васильев Василий Иванович"; //переменная, хранящая имя глав.инспектора
        public static string[] workers = new string[] { "Иванов Иван Иваныч", "Зиронов Тимур Александрович", "Миронов Алексей Валерьевич", "Васильев Василий Иванович" };//массив, в котором хранятся имена всех сотрудников
        public static void GetInspector()
        {
            Console.WriteLine($"Главный инспектор – {fullname}");//вывод имени глав.инспектора
        }
        public static void GetСarInspection()
        {
            Console.WriteLine("Название: Автоинспекция г. Чита");//вывод названия инспекции
        }
        public static void SetInspector()
        {
            for (int i = 0; i < workers.Length; i++) //цикл для перебора всех сотрудников
            {
                if (workers[i] != fullname) //если имя сотрудника не совпадает с именем инспектора, то действие пропускается
                {
                    continue;//осуществляет принудительный переход к следующему шагу цикла, пропуская любой код, оставшийся невыполненным
                }
                else //если найден сотрудник с именем инспектора, то пользователь изменяет фамилию имя отчество инспектора
                {
                    Console.WriteLine("Измените имя глав. инспектора");// вывод на экран данных
                    fullname = Console.ReadLine(); //изменение фамилии имени отчества
                    Console.WriteLine($"Измененное имя инспектора: {fullname}");// вывод на экран данных
                }
            }
        }
        public static void GetWorker()
        {
            Console.WriteLine("Cписок сотрудников:");
            for (int i = 0; i < workers.Length; i++) //вывод всех сотрудников с помоцью цикла
            {
                Console.WriteLine($"{i + 1}.{workers[i]}");
            }
        }

        public static void AddWorker()
        {
            Console.WriteLine("Введите имя нового сотрудника");// вывод на экран данных
            string newWorker = Console.ReadLine(); //ввод новых данных
            workers = workers.Concat(new string[] { newWorker }).ToArray(); //добавление нового сотрудника в список
            Console.WriteLine("Новый список сотрудников автоинспекции:");// вывод на экран данных
            for (int i = 0; i < workers.Length; i++) //вывод нового списка сотрудников через цикл
            {
                Console.WriteLine($"{i + 1}.{workers[i]}");
            }
        }

        public static void GenerateNumber()
        {
            const int code = 75; //номер региона
            Console.WriteLine("Ваш номер: ");// вывод на экран данных
            Random rndNum = new Random();
            int number = rndNum.Next(100, 999); //генерация трехзначного чихсла, которое будет записываться в номер
            Random randChar = new Random();
            char symbol = (char)randChar.Next('А', 'Я' + 1);//генерация буквы, которая будет записана в номер
            Console.WriteLine($"{symbol}{number}_{code}"); //вывод сгенерированого номера
        }
    }

}