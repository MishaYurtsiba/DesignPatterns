using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Structure university = new Structure("University");
            Structure SO = new Structure("Кафедра системного аналізу");
            Structure PM = new Structure("Кафедра прикладної математики");

            Worker workerName = new Worker("Юрій Васильвич Андрашко", "викладач");
            Worker workerName2 = new Worker("Чупов Сергій Вікторович", "викладач");

            university.Add(SO);
                SO.Add(workerName);
            university.Add(PM);
                PM.Add(workerName2);

            Console.WriteLine(university.ToString(0));

            Console.ReadLine();

        }
    }
}
