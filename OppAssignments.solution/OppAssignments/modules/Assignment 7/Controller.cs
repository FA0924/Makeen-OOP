using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAssignments.modules.Assignment_7
{
    public class Controller
    {
        public Controller()
        {
            Console.WriteLine("Smart Home Controller initialized");
        }

        public void OperateDevice(IDevice device, string operation)
        {
            Console.WriteLine("\nOperating device...");

            if (operation == "on")
            {
                device.TurnOn();
            }
            else if (operation == "off")
            {
                device.TurnOff();
            }
            else if (operation == "status")
            {
                device.ShowStatus();
            }
            else
            {
                Console.WriteLine("invalid operation");
            }
        }

        public void OperateAllDevices(List<IDevice> devices, string operation)
        {
            Console.WriteLine($"\nOperating all devices: {operation}");
            Console.WriteLine("----------------------------");

            for (int i = 0; i < devices.Count; i++)
            {
                if (operation == "on")
                {
                    devices[i].TurnOn();
                }
                else if (operation == "off")
                {
                    devices[i].TurnOff();
                }
                else if (operation == "status")
                {
                    devices[i].ShowStatus();
                }
            }

            Console.WriteLine();
        }
    }
}