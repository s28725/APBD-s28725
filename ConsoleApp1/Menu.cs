using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu
    {
        private List<Container> Containers;
        private List<ContainerShip> ContainerShips;

        public void DisplayMenu()
        {
            Console.WriteLine("Number of containers: " + (Containers.Count == 0 ? "None" : $"{Containers.Count}"));
            Console.WriteLine("Number of container ships: " + (ContainerShips.Count == 0 ? "None" : $"{ContainerShips.Count}"));

            Console.WriteLine("Possible actions: ");
            Console.WriteLine("Add a container ship -> 1");
            Console.WriteLine("Remove a container ship -> 2");
            Console.WriteLine("Add a container -> 3");
            Console.WriteLine("Remove a container ship -> 4");
            Console.WriteLine("Place container on a ship -> 5");

            Console.Write("Choose an option: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    AddContainerShip();
                    break;
                case 2:
                    MethodForNumberTwo();
                    break;
                case 3:
                    MethodForNumberThree();
                    break;
                case 4:
                    MethodForNumberFour();
                    break;
                case 5:
                    MethodForNumberFive();
                    break;
                default:
                    Console.WriteLine("Number is not between 1 and 5.");
                    break;
            }
        }

        private void AddContainerShip()
        {
            Console.WriteLine("Enter the speed in knots:");
            double speedInKnots = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the maximum container number:");
            int maxContainerNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the maximum weight:");
            double maxWeight = int.Parse(Console.ReadLine());

            ContainerShips.Add(new ContainerShip(speedInKnots, maxContainerNumber, maxWeight));
        }
    }
}
