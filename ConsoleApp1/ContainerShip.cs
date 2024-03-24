using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ContainerShip
    {
        public double MaxSpeedInKnots { get; }
        public int MaxContainerNumber { get; }
        public double MaxWeight { get; }
        public List<Container> Containers { get; }

        public ContainerShip(double maxSpeedInKnots, int maxContainerNumber, double maxWeight)
        {
            MaxSpeedInKnots = maxSpeedInKnots;
            MaxContainerNumber = maxContainerNumber;
            MaxWeight = maxWeight;
            Containers = new List<Container>();
        }

        public void UnloadContainer(Container container)
        {
            Containers.Remove(container);
        }

        public void LoadContainer(Container container)
        {
            if (Containers.Count >= MaxContainerNumber)
            {
                throw new Exception("Ship has no spare space for containers");
            }

            double totalWeight = 0;
            foreach (var c in Containers)
            {
                totalWeight = c.TareWeight + c.CargoMass;
            }

            if (container.CargoMass + container.TareWeight + totalWeight > MaxWeight)
            {
                throw new Exception("Ship's weight load is exceeded");
            }

            Containers.Add(container);
        }

        public void LoadContainers(List<Container> containersToAdd)
        {
            if (Containers.Count + containersToAdd.Count > MaxContainerNumber)
            {
                throw new Exception("Ship has no spare space for containers");
            }

            double totalWeight = 0;
            foreach (var c in Containers)
            {
                totalWeight += c.TareWeight + c.CargoMass;
            }

            foreach (var container in containersToAdd)
            {
                totalWeight += container.TareWeight + container.CargoMass;
                if (totalWeight > MaxWeight)
                {
                    throw new Exception("Ship's weight load is exceeded");
                }
                Containers.Add(container);
            }
        }

        public void ReplaceContainer(string serialNumberToReplace, Container newContainer)
        {
            int index = Containers.FindIndex(c => c.SerialNumber == serialNumberToReplace);

            if (index == -1)
            {
                throw new Exception($"Container with serial number {serialNumberToReplace} not found.");
            }

            double totalWeight = 0;
            foreach (var c in Containers.Where((c, i) => i != index))
            {
                totalWeight += c.TareWeight + c.CargoMass;
            }

            totalWeight += newContainer.TareWeight + newContainer.CargoMass;

            if (totalWeight > MaxWeight)
            {
                throw new Exception("Ship's weight load is exceeded");
            }

            Containers[index] = newContainer;
        }

        public override string ToString()
        {
            string containerInfo = $"Number of Containers: {Containers.Count}\n";

            foreach (var container in Containers)
            {
                containerInfo += container.ToString() + "\n";
            }

            return $"Container ship, Max Speed: {MaxSpeedInKnots}, Max Container Number: {MaxContainerNumber}, Max Weight: {MaxWeight}, " + containerInfo;
        }
    }
}
