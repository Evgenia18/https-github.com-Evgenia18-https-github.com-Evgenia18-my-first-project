using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorLib;
namespace Stragova_Test
{
internal class Program
{
static void Main(string[] args)
{
FunctionInsp.GetInspector();//вывод имени инспектора
Console.WriteLine();
FunctionInsp.GetСarInspection(); //вывод названия инспекции
Console.WriteLine();
FunctionInsp.SetInspector(); //изменить имя главного инспектора при совпадении с именами сотрудников
Console.WriteLine();
FunctionInsp.GetWorker(); //вывод всех сотрудников
Console.WriteLine();
FunctionInsp.AddWorker();//добавление нового сотрудника
Console.WriteLine();
FunctionInsp.GenerateNumber();//генерация номера


}
}
}