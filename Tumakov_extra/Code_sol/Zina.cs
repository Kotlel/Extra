using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_sol
{
    public class Zina
    {
        static int checkingint()
        {
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
                Console.Write("Неверный ввод!\nПовторите: ");
            return x;
        }
        public void HandleResident(Resident resident, List<Resident> firstWindow, List<Resident> secondWindow, List<Resident> thirdWindow)
        {
            Console.WriteLine($"Житель {resident.Name} с проблемой: {resident.Problem.Description}");
            int windowNumber = DetermineWindow(resident);

            if (resident.Temperament.Scandalousness >= 5)
            {
                Console.WriteLine($"{resident.Name} - скандалист, сколько человек обгонит?");
                int skipCount = checkingint();
                Console.WriteLine($"{resident.Name} обогнал {skipCount} человек и идет в окно {windowNumber}.");
            }
            else
            {
                Console.WriteLine($"{resident.Name} идет в окно {windowNumber}.");
            }
            switch (windowNumber)
            {
                case 1:
                    firstWindow.Add(resident);
                    break;
                case 2:
                    secondWindow.Add(resident);
                    break;
                case 3:
                    thirdWindow.Add(resident);
                    break;
            }
        }

        private int DetermineWindow(Resident resident)
        { 
            if (resident.Temperament.Intelligence == 0)
            {
                Random random = new Random();
                return random.Next(1, 4);
            }
            else
            {
                if (resident.Problem.Number == 1)
                {
                    return 1;
                }
                else if (resident.Problem.Number == 2)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
