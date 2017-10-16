using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem40
{
    public interface IVehicle
    {
        void Start();
        int Drive();
        void Stop();
        //void Empty();
        //bool Running { get; }
    }

    class Car : IVehicle
    {
        private bool running = false;
        int fuel = 10;

        public void Start()
        {
            if (fuel > 0)
            {
                if (running == false)
                {
                    Console.WriteLine("\n The vehicle has started.\n");
                    running = true;
                }
                else
                {
                    Console.WriteLine($"\n Vehicle already running, please choose again.\n");
                }
            }
            else
            {
                Console.WriteLine("\n You are out of fuel, vehicle will not start.");
                running = false;
            }
        }

        public int Drive()
        {
            if (fuel > 0)
            {
                if (running == true)
                {
                    fuel = fuel - 1;
                    Console.WriteLine($"\n Now driving. You have {fuel} gallons of fuel remaining.\n");
                    return fuel;
                }
                else
                {
                    Console.WriteLine($"\n You must first start the vehicle before you can drive.\n");
                    return fuel;
                }
            }
            else
            {
                Console.WriteLine("\n You are out of fuel, vehicle will not start.");
                return fuel;
            }
        }
        public void Stop()
        {
            if (running == true)
            {
                Console.WriteLine("\n The vehicle has stopped.\n");
                running = false;
            }
            else
            {
                Console.WriteLine("\n Vehicle was never started. \n");
            }
        }
    }

    class Boat : IVehicle
    {
        private bool running = false;
        int fuel = 10;

        public void Start()
        {
            if (fuel > 0)
            {
                if (running == false)
                {
                    Console.WriteLine("\n The vehicle has started.\n");
                    running = true;
                }
                else
                {
                    Console.WriteLine($"\n Vehicle already running, please choose again.\n");
                }
            }
            else
            {
                Console.WriteLine("\n You are out of fuel, vehicle will not start.");
                running = false;
            }
        }

        public int Drive()
        {
            if (fuel > 0)
            {
                if (running == true)
                {
                    fuel = fuel - 1;
                    Console.WriteLine($"\n Now driving. You have {fuel} gallons of fuel remaining.\n");
                    return fuel;
                }
                else
                {
                    Console.WriteLine($"\n You must first start the vehicle before you can drive.\n");
                    return fuel;
                }
            }
            else
            {
                Console.WriteLine("\n You are out of fuel, vehicle will not start.");
                return fuel;
            }
        }
        public void Stop()
        {
            if (running == true)
            {
                Console.WriteLine("\n The vehicle has stopped.\n");
                running = false;
            }
            else
            {
                Console.WriteLine("\n Vehicle was never started. \n");
            }
        }
    }

    class MyClass40
    {
        public void Problem40()
        {
            IVehicle vehicle = null;
            Console.Write("\n Greetings user, please choose a vehicle.  Your choices are 'boat' or 'car': ");
            var choice = Console.ReadLine().ToLower();
            Car car = new Car();
            Boat boat = new Boat();
            if (choice == "boat")
            {
                boat = new Boat();
                vehicle = boat;
            }
            else if (choice == "car")
            {
                car = new Car();
                vehicle = car;
            }
            else
            {
                Console.WriteLine("\n Please enter a valid selection. Your choices are 'boat' or 'car'.");
                choice = Console.ReadLine();
            }

            Console.Write("\n what would you like to do?");
            Console.WriteLine(" (Choices are 'start' 'drive' 'stop')");
            string input = Console.ReadLine().ToLower();

            while (input != null)
            {
                if (input == "start")
                {
                    vehicle.Start();
                }
                else if (input == "drive")
                {
                    vehicle.Drive();
                }
                else if (input == "stop")
                {
                    vehicle.Stop();
                }
                else
                {
                    Console.WriteLine("\n Please enter a vaild command.\n");
                }
                Console.WriteLine("\n What would you like to do? (Choices are 'start' 'drive' 'stop')");
                input = Console.ReadLine().ToLower();
            }
        }
    }
}
