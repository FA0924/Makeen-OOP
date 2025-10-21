using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAssignments.modules.Assignment_7
{
    public class Light : IDevice
    {
        private bool isOn;
        private int brightnessLevel;

        public Light(string location)
        {
            this.location = location;
            this.isOn = false;
            this.brightnessLevel = 0;
        }

        public string location { get; set; }

        public bool IsOn
        {
            get { return this.isOn; }
        }

        public int BrightnessLevel
        {
            get { return this.brightnessLevel; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.brightnessLevel = value;
                }
                else
                {
                    Console.WriteLine("brightness must be between 0 and 100");
                }
            }
        }

        public void TurnOn()
        {
            this.isOn = true;
            this.brightnessLevel = 100;
            Console.WriteLine($"{location} Light is now ON at {brightnessLevel}% brightness");
        }

        public void TurnOff()
        {
            this.isOn = false;
            this.brightnessLevel = 0;
            Console.WriteLine($"{location} Light is now OFF");
        }

        public void ShowStatus()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Device: Light ({location})");
            Console.WriteLine($"Status: {(isOn ? "ON" : "OFF")}");
            Console.WriteLine($"Brightness Level: {brightnessLevel}%");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }

        public void SetBrightness(int level)
        {
            if (isOn)
            {
                BrightnessLevel = level;
                Console.WriteLine($"{location} Light brightness set to {brightnessLevel}%");
            }
            else
            {
                Console.WriteLine("cant set brightness when light is off");
            }
        }
    }
}