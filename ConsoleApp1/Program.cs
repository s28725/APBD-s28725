using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                LiquidContainer liquidContainer = new LiquidContainer("KON-L-1", 100, 100, 100, 100, 1000000, true);
                liquidContainer.LoadCargo(10);
                Console.WriteLine($"Loaded cargo mass: {liquidContainer.CargoMass}");

                ContainerShip ship = new ContainerShip(100000, 1000000, 1000000);
                ship.LoadContainer(liquidContainer);
                Console.WriteLine($"Number of containers on ship: {ship.Containers.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
