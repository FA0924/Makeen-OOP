
using OppAssignments.modules;
using OppAssignments.modules.Assignment_4;
using OppAssignments.modules.Assignment_5;
using OppAssignments.modules.Assignment_6;
using OppAssignments.modules.Assignment_7;
/// --------------------------------------------------- BOOK CLASS SYSTEM ---------------------------------------------------

//namespace OppAssignments
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("BOOK CLASS SYSTEM DEMONSTRATION\n");


//            book book = new book("The Poppy War", "R. F. Kuang", 2018, "978‑0062662569");
//            book book1 = new book("The Song of Achilles", "Madeline Miller", 2011, "978‑0062060624");
//            book book2 = new book("A Storm of Swords", "George R. R. Martin", 2003, "9780006479901");

//            Console.WriteLine("Book 1 Information:");
//            book.PrintBookInfo();

//            Console.WriteLine("Book 2 Information:");
//            book1.PrintBookInfo();

//            Console.WriteLine("Book 3 Information:");
//            book2.PrintBookInfo();

//            int checkingyear = 2010;

//            Console.WriteLine($"\nIs '{book.title}' older than {checkingyear}? {book.IsOlderThan(checkingyear)}");
//            Console.WriteLine($"Is '{book1.title}' older than {checkingyear}? {book1.IsOlderThan(checkingyear)}");
//            Console.WriteLine($"Is '{book2.title}' older than {checkingyear}? {book2.IsOlderThan(checkingyear)}");


//        }
//    }
//}





/// --------------------------------------------------- STUDENT GRADE TRACKER ---------------------------------------------------


//namespace OppAssignments
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            student student1 = new student(1, "Fatima Alshanfari");
//            student student2 = new student(2, "Hamada Hilal");


//            student1.AddGrade(85);
//            student1.AddGrade(92);
//            student1.AddGrade(78);
//            student1.AddGrade(88);


//            student2.AddGrade(72);
//            student2.AddGrade(68);
//            student2.AddGrade(75);
//            student2.AddGrade(70);


//            student1.PrintStudentReport();
//            Console.Write("Grades: ");
//            for (int i = 0; i < student1.grades.Count; i++)
//            {
//                Console.Write(student1.grades[i]);
//                if (i < student1.grades.Count - 1)
//                {
//                    Console.Write(", ");
//                }
//            }
//            Console.WriteLine();
//            double avg1 = student1.CalcAverage();
//            Console.WriteLine("Average: " + avg1);
//            Console.WriteLine("Letter Grade: " + student1.GetLetterGrade(avg1));
//            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

//            student2.PrintStudentReport();
//            Console.Write("Grades: ");
//            for (int i = 0; i < student2.grades.Count; i++)
//            {
//                Console.Write(student2.grades[i]);
//                if (i < student2.grades.Count - 1)
//                {
//                    Console.Write(", ");
//                }
//            }
//            Console.WriteLine();
//            double avg2 = student2.CalcAverage();
//            Console.WriteLine("Average: " + avg2);
//            Console.WriteLine("Letter Grade: " + student2.GetLetterGrade(avg2));
//            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");


//        }
//    }
//}

/// ---------------------------------------------- Assignmet 3 Vehicle Hierarchy System ---------------------------------------------------

//namespace OppAssignments
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("VEHICLE HIERARCHY SYSTEM DEMONSTRATION\n");

//            Car car1 = new Car("Toyota", "Camry", 2022, 4);
//            Car car2 = new Car("Honda", "Civic", 2021, 2);

//            Truck truck1 = new Truck("Ford", "F-150", 2023, 2.5);
//            Truck truck2 = new Truck("Chevrolet", "Silverado", 2020, 3.2);

//            Console.WriteLine("Car 1 Information:");
//            car1.DisplayInfo();

//            Console.WriteLine("Car 2 Information:");
//            car2.DisplayInfo();

//            Console.WriteLine("Truck 1 Information:");
//            truck1.DisplayInfo();

//            Console.WriteLine("Truck 2 Information:");
//            truck2.DisplayInfo();
//        }
//    }
//}


/// ---------------------------------------------- Assignmet 4: E-Commerce Order System (Medium) ---------------------------------------------------

// shopping app , allows me to create products, add them to an order and calculate the total cost

//namespace OppAssignment

//{
//    public class Program
//    {
//        static void Main(string[] args) { 
//        {


//                // ----------------------------------------- honestly, i dont fully get the question, upon researching appearantly this is what im supposed to be doing? but i dont fully get it

//                ///////  constructor overloading
//                //Product product1 = new Product();
//                //Console.WriteLine($"Default constructor: {product1.name}, Price: {product1.price:C}\n");

//                //Product product2 = new Product("Laptop", 1200.00m, 2);
//                //Console.WriteLine($"Full constructor: {product2.name}, Price: {product2.price:C}, Quantity: {product2.quantity}\n");



//                ///////  method overloading 
//                //Console.WriteLine($"CalculateTotal() with class fields: {product2.CalculateTotal():C}");
//                //Console.WriteLine($"CalculateTotal(950, 3) with parameters: {product2.CalculateTotal(950.00m, 3):C}\n");





//                ///// built in 
//                //Console.WriteLine("Creating Orders:\n");

//                //// order 1
//                //Order order1 = new Order(101, "Fatima Alshanfari");
//                //order1.AddProduct(new Product("Laptop", 1200.00m, 1));
//                //order1.AddProduct(new Product("Mouse", 25.50m, 2));
//                //order1.AddProduct(new Product("Keyboard", 75.00m, 1));
//                //Console.WriteLine();

//                //// order 2
//                //Order order2 = new Order(102, "Hamada Hilal");
//                //order2.AddProduct(new Product("Phone", 899.99m, 1));
//                //order2.AddProduct(new Product("Phone Case", 15.00m, 2));
//                //order2.AddProduct(new Product("Screen Protector", 10.00m, 3));
//                //order2.AddProduct(new Product("Charger", 30.00m, 1));
//                //Console.WriteLine();


//                //// ----------------------- Summary
//                //Console.WriteLine("Order Details:\n");
//                //order1.OrderSummary();
//                //order2.OrderSummary();





//                // interactive

//                Console.WriteLine("\t\t\t\t\t Creating New Order\n");

//                Console.WriteLine("please enter customer name: ");
//                string customerName = Console.ReadLine();

//                Console.WriteLine("please enter order ID: ");
//                int orderID = int.Parse(Console.ReadLine());

//                Order order = new Order(orderID, customerName);

//                Console.WriteLine("how many products do u want to add? ");
//                int numberOfProducts = int.Parse(Console.ReadLine());

//                for (int i = 0; i < numberOfProducts; i++)
//                {
//                    Console.WriteLine($"\n--- Product {i + 1} ---");

//                    Console.WriteLine("enter product name: ");
//                    string productName = Console.ReadLine();

//                    Console.WriteLine("enter product price: ");
//                    decimal productPrice = decimal.Parse(Console.ReadLine());

//                    Console.WriteLine("enter product quantity: ");
//                    int productQuantity = int.Parse(Console.ReadLine());

//                    order.AddProduct(new Product(productName, productPrice, productQuantity));
//                }

//                Console.WriteLine();

//                // ----------------------- Displaying Order Summary
//                Console.WriteLine("Order Details:\n");
//                order.OrderSummary();

//            }
//        }
//        }
//} 








// --------------------------------------------------- Assignment 5: Animal Sound Simulation ---------------------------------------------------
//namespace OppAssignment

//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            {
//                List<Animal> animals = new List<Animal>();
//                animals.Add(new Dog("max"));
//                animals.Add(new Cat("luly"));
//                animals.Add(new Cow("marie"));
//                Console.WriteLine($"we have {animals.Count} animals in the farm\n");


//                Console.WriteLine("do u want to add more animals? (yes/no): ");
//                string answer = Console.ReadLine();

//                if (answer == "yes")
//                {
//                    Console.WriteLine("how many animals do u want to add? ");
//                    int numberOfAnimals = int.Parse(Console.ReadLine());

//                    for (int i = 0; i < numberOfAnimals; i++)
//                    {
//                        Console.WriteLine($"\n--- Animal {i + 1} ---");
//                        Console.WriteLine("enter animal type (dog/cat/cow): ");
//                        string animalType = Console.ReadLine();

//                        Console.WriteLine("enter animal name: ");
//                        string animalName = Console.ReadLine();

//                        if (animalType == "dog")
//                        {
//                            animals.Add(new Dog(animalName));
//                        }
//                        else if (animalType == "cat")
//                        {
//                            animals.Add(new Cat(animalName));
//                        }
//                        else if (animalType == "cow")
//                        {
//                            animals.Add(new Cow(animalName));
//                        }
//                        else
//                        {
//                            Console.WriteLine("invalid animal type");
//                        }
//                    }

//                    Console.WriteLine("\nAll animals making sounds :");
//                    Console.WriteLine("----------------------------");
//                    MakeAllAnimalsSound(animals);
//                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
//                }
//            }
//        }


//        // polymorphism Method
//        public static void MakeAllAnimalsSound(List<Animal> animals)
//        {
//            for (int i = 0; i < animals.Count; i++)
//            {
//                animals[i].MakeSound();
//            }
//        }
//    }
//}









// --------------------------------------------------- Assignment  6: Bank Account Management System ---------------------------------------------------


//namespace OppAssignment { 

//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("BANK ACCOUNT MANAGEMENT SYSTEM\n");

//            List<BankAccount> accounts = new List<BankAccount>();

//            // ----------------------- Creating Accounts
//            Console.WriteLine("how many accounts do u want to create? ");
//            int numberOfAccounts = int.Parse(Console.ReadLine());

//            for (int i = 0; i < numberOfAccounts; i++)
//            {
//                Console.WriteLine($"\n--- Account {i + 1} ---");

//                Console.WriteLine("enter account number: ");
//                int accountNumber = int.Parse(Console.ReadLine());

//                Console.WriteLine("enter owner name: ");
//                string ownerName = Console.ReadLine();

//                Console.WriteLine("enter initial balance: ");
//                decimal initialBalance = decimal.Parse(Console.ReadLine());

//                BankAccount account = new BankAccount(accountNumber, ownerName, initialBalance);
//                accounts.Add(account);
//            }

//            Console.WriteLine();
//            BankAccount.ShowTotalAccounts();
//            Console.WriteLine();

//            // ----------------------- Display All Accounts
//            Console.WriteLine("All Created Accounts:");
//            for (int i = 0; i < accounts.Count; i++)
//            {
//                accounts[i].DisplayAccountInfo();
//            }

//            // ----------------------- Perform Operations
//            bool continueOperations = true;

//            while (continueOperations)
//            {
//                Console.WriteLine("\ndo u want to perform any operations? (yes/no): ");
//                string answer = Console.ReadLine();

//                if (answer == "yes")
//                {
//                    Console.WriteLine("\nselect account number to perform operation: ");
//                    int selectedAccount = int.Parse(Console.ReadLine());

//                    BankAccount account = null;
//                    for (int i = 0; i < accounts.Count; i++)
//                    {
//                        if (accounts[i].AccountNumber == selectedAccount)
//                        {
//                            account = accounts[i];
//                            break;
//                        }
//                    }

//                    if (account == null)
//                    {
//                        Console.WriteLine("account not found");
//                        continue;
//                    }

//                    Console.WriteLine("\nselect operation:");
//                    Console.WriteLine("1. Deposit");
//                    Console.WriteLine("2. Withdraw");
//                    Console.WriteLine("3. View Account Info");
//                    int operation = int.Parse(Console.ReadLine());

//                    if (operation == 1)
//                    {
//                        Console.WriteLine("enter amount to deposit: ");
//                        decimal depositAmount = decimal.Parse(Console.ReadLine());
//                        account.Deposit(depositAmount);
//                    }
//                    else if (operation == 2)
//                    {
//                        Console.WriteLine("enter amount to withdraw: ");
//                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
//                        account.Withdraw(withdrawAmount);
//                    }
//                    else if (operation == 3)
//                    {
//                        account.DisplayAccountInfo();
//                    }
//                    else
//                    {
//                        Console.WriteLine("invalid operation");
//                    }
//                }
//                else
//                {
//                    continueOperations = false;
//                }
//            }

//            // ----------------------- Final Summary
//            Console.WriteLine("\n\nFinal Summary of All Accounts:");
//            Console.WriteLine("================================");
//            for (int i = 0; i < accounts.Count; i++)
//            {
//                accounts[i].DisplayAccountInfo();
//            }

//            BankAccount.ShowTotalAccounts();
//            Console.WriteLine("\nThank you for using our bank system!");
//        }
//    }
//}







// --------------------------------------------------- Assignment7: Smart Home Device Control (Hard) ---------------------------------------------------

//namespace OppAssignments
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("SMART HOME DEVICE CONTROL SYSTEM\n");

//            Controller controller = new Controller();
//            List<IDevice> devices = new List<IDevice>();

//            // ----------------------- Creating Devices
//            Light livingRoomLight = new Light("Living Room");
//            Light bedroomLight = new Light("Bedroom");
//            Thermostat livingRoomThermostat = new Thermostat("Living Room");
//            Thermostat bedroomThermostat = new Thermostat("Bedroom");

//            devices.Add(livingRoomLight);
//            devices.Add(bedroomLight);
//            devices.Add(livingRoomThermostat);
//            devices.Add(bedroomThermostat);

//            Console.WriteLine($"\nTotal devices: {devices.Count}\n");

//            // ----------------------- Testing Individual Device Control
//            Console.WriteLine("Testing Individual Device Control:");
//            Console.WriteLine("================================");

//            controller.OperateDevice(livingRoomLight, "on");
//            livingRoomLight.SetBrightness(75);

//            controller.OperateDevice(livingRoomThermostat, "on");
//            livingRoomThermostat.SetTemperature(24);

//            Console.WriteLine("\nChecking Status:");
//            controller.OperateDevice(livingRoomLight, "status");
//            controller.OperateDevice(livingRoomThermostat, "status");

//            // ----------------------- Testing All Devices Control
//            Console.WriteLine("\nTurning ON all devices:");
//            controller.OperateAllDevices(devices, "on");

//            Console.WriteLine("Status of all devices:");
//            controller.OperateAllDevices(devices, "status");

//            Console.WriteLine("Turning OFF all devices:");
//            controller.OperateAllDevices(devices, "off");

//            // ----------------------- User Interaction
//            bool continueControl = true;

//            while (continueControl)
//            {
//                Console.WriteLine("\ndo u want to control a device? (yes/no): ");
//                string answer = Console.ReadLine();

//                if (answer == "yes")
//                {
//                    Console.WriteLine("\nSelect device:");
//                    Console.WriteLine("1. Living Room Light");
//                    Console.WriteLine("2. Bedroom Light");
//                    Console.WriteLine("3. Living Room Thermostat");
//                    Console.WriteLine("4. Bedroom Thermostat");
//                    int deviceChoice = int.Parse(Console.ReadLine());

//                    IDevice selectedDevice = null;

//                    if (deviceChoice == 1)
//                    {
//                        selectedDevice = livingRoomLight;
//                    }
//                    else if (deviceChoice == 2)
//                    {
//                        selectedDevice = bedroomLight;
//                    }
//                    else if (deviceChoice == 3)
//                    {
//                        selectedDevice = livingRoomThermostat;
//                    }
//                    else if (deviceChoice == 4)
//                    {
//                        selectedDevice = bedroomThermostat;
//                    }

//                    if (selectedDevice != null)
//                    {
//                        Console.WriteLine("\nSelect operation:");
//                        Console.WriteLine("1. Turn ON");
//                        Console.WriteLine("2. Turn OFF");
//                        Console.WriteLine("3. Show Status");
//                        Console.WriteLine("4. Adjust Settings");
//                        int operation = int.Parse(Console.ReadLine());

//                        if (operation == 1)
//                        {
//                            controller.OperateDevice(selectedDevice, "on");
//                        }
//                        else if (operation == 2)
//                        {
//                            controller.OperateDevice(selectedDevice, "off");
//                        }
//                        else if (operation == 3)
//                        {
//                            controller.OperateDevice(selectedDevice, "status");
//                        }
//                        else if (operation == 4)
//                        {
//                            if (selectedDevice is Light)
//                            {
//                                Console.WriteLine("enter brightness level (0-100): ");
//                                int brightness = int.Parse(Console.ReadLine());
//                                ((Light)selectedDevice).SetBrightness(brightness);
//                            }
//                            else if (selectedDevice is Thermostat)
//                            {
//                                Console.WriteLine("enter temperature (10-35): ");
//                                int temp = int.Parse(Console.ReadLine());
//                                ((Thermostat)selectedDevice).SetTemperature(temp);
//                            }
//                        }
//                    }
//                }
//                else
//                {
//                    continueControl = false;
//                }
//            }

//            Console.WriteLine("\nThank you for using Smart Home Control System!");
//        }
//    }
//}









// --------------------------------------------------- Assignment 8: Employee Management System with Polymorphism ---------------------------------------------------