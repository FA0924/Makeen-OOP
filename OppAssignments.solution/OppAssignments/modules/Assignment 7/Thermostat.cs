using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAssignments.modules.Assignment_7
{
    public class Thermostat : IDevice
    {
        private bool isOn;
        private int currentTemp;

        public Thermostat(string location)
        {
            this.location = location;
            this.isOn = false;
            this.currentTemp = 20;
        }

        public string location { get; set; }

        public bool IsOn
        {
            get { return this.isOn; }
        }

        public int CurrentTemp
        {
            get { return this.currentTemp; }
            set
            {
                if (value >= 10 && value <= 35)
                {
                    this.currentTemp = value;
                }
                else
                {
                    Console.WriteLine("temperature must be between 10 and 35 degrees");
                }
            }
        }

        public void TurnOn()
        {
            this.isOn = true;
            Console.WriteLine($"{location} Thermostat is now ON at {currentTemp}°C");
        }

        public void TurnOff()
        {
            this.isOn = false;
            Console.WriteLine($"{location} Thermostat is now OFF");
        }

        public void ShowStatus()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Device: Thermostat ({location})");
            Console.WriteLine($"Status: {(isOn ? "ON" : "OFF")}");
            Console.WriteLine($"Current Temperature: {currentTemp}°C");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }

        public void SetTemperature(int temp)
        {
            if (isOn)
            {
                CurrentTemp = temp;
                Console.WriteLine($"{location} Thermostat temperature set to {currentTemp}°C");
            }
            else
            {
                Console.WriteLine("cant set temperature when thermostat is off");
            }
        }
    }
}
