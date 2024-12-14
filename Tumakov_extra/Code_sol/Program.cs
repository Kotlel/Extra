using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_sol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Resident> residentsStack = new Stack<Resident>();
            Zina zina = new Zina();
            List<Resident> firstWindow = new List<Resident>();
            List<Resident> secondWindow = new List<Resident>();
            List<Resident> thirdWindow = new List<Resident>();
            residentsStack.Push(new Resident("Иванов Иван", new Problem(1, "Проблема с отоплением"), new Temperament(6, 1)));
            residentsStack.Push(new Resident("Петров Петр", new Problem(2, "Оплата отопления"), new Temperament(4, 1)));
            residentsStack.Push(new Resident("Сидорова Мария", new Problem(3, "Другие проблемы"), new Temperament(8, 0)));
            residentsStack.Push(new Resident("Смирнов Алексей", new Problem(3, "Проблема с водоснабжением"), new Temperament(5, 0)));
            residentsStack.Push(new Resident("Кузнецова Анна", new Problem(3, "Проблема с электричеством"), new Temperament(3, 1)));
            residentsStack.Push(new Resident("Попов Сергей", new Problem(3, "Проблемы с ремонтом"), new Temperament(7, 0)));
            residentsStack.Push(new Resident("Лебедева Ольга", new Problem(1, "Проблема с отоплением"), new Temperament(2, 0)));
            residentsStack.Push(new Resident("Соловьев Дмитрий", new Problem(3, "Оплата коммунальных услуг"), new Temperament(4, 1)));
            residentsStack.Push(new Resident("Васильева Мария", new Problem(3, "Проблемы с соседями"), new Temperament(9, 2)));
            residentsStack.Push(new Resident("Федоров Игорь", new Problem(3, "Проблемы с крышей"), new Temperament(1, 1)));
            residentsStack.Push(new Resident("Григорьева Светлана", new Problem(3, "Не хватает горячей воды"), new Temperament(6, 0)));
            residentsStack.Push(new Resident("Борисов Николай", new Problem(3, "Проблемы с канализацией"), new Temperament(8, 1)));
            residentsStack.Push(new Resident("Павлова Татьяна", new Problem(1, "Проблема с отоплением"), new Temperament(5, 0)));
            Console.WriteLine("Очередь жителей:");
            while (residentsStack.Count > 0)
            {
                Resident resident = residentsStack.Pop();
                zina.HandleResident(resident, firstWindow, secondWindow, thirdWindow);
            }
            Console.WriteLine("Первое окно (проблемы с отоплением):");
            foreach (var res in firstWindow)
            {
                Console.WriteLine($"- {res.Name}: {res.Problem.Description}");
            }

            Console.WriteLine("Второе окно (оплата отопления):");
            foreach (var res in secondWindow)
            {
                Console.WriteLine($"- {res.Name}: {res.Problem.Description}");
            }

            Console.WriteLine("Третье окно (другие проблемы):");
            foreach (var res in thirdWindow)
            {
                Console.WriteLine($"- {res.Name}: {res.Problem.Description}");
            }
        }
    }
}
