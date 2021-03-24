//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MorningChallengeW2D3
//{
//    class ProgramUI
//    {

//        private readonly KomodoCustomerRepo _customerDirectory = new KomodoCustomerRepo
//        public void Run()
//        {
//            SeedContentList();
//            RunMenu();
//        }
//        private void RunMenu()
//        {
//            bool continueToRun = true;
//            while (continueToRun)
//            {
//                Console.Clear();

//                Console.WriteLine("What would you like to do?\n" +
//                    "1. Add a customer\n" +
//                    "2. Delete a customer by ID\n" +
//                    "3. Delete a customer by last name\n" +
//                    "4. View all customers\n" +
//                    "5. Send thank you notes\n" +
//                    "6. Exit");

//                string userInput = Console.ReadLine();

//                switch (userInput)
//                {
//                    case "1":
//                        AddCustomer();
//                        break;
//                    case "2":
//                        DeleteCustomerByID();
//                        break;
//                    case "3":
//                        DeleteCustomerByName();
//                        break;
//                    case "4":
//                        ShowAllCustomers();
//                        break;
//                    case "5":
//                        SendNote();
//                        break;
//                    default:
//                        Console.WriteLine("Please select a valid number between 1 and 6\n" +
//                            "Press any key to continue.....");
//                        Console.ReadKey();
//                        break;
//                }
//            }
//        }

//        private void AddCustomer()
//        {
//            Console.Clear();
//            Customer customer = new Customer();

//            Console.WriteLine("Adding a new customer...");

//            Console.WriteLine("Please enter the customer's ID number...");
//            customer.IDNumber = Int32.Parse(Console.ReadLine());

//            Console.WriteLine("Please enter the customer's last name");
//            customer.LastName = Console.ReadLine();

//            Console.WriteLine("Please enter the customer's age");
//            customer.Age = Int32.Parse(Console.ReadLine());

//            Console.WriteLine("Please enter the customer's enrollment date as Jan. 1, 2021");
//            customer.EnrollmentDate = DateTime.Parse(Console.ReadLine());

//            Console.WriteLine("Please enter how long they've been a customer");
//            customer.YearsUsing = Int32.Parse(Console.ReadLine());

//            _customerDirectory.AddCustomer(customer);
//        }

//        private void DeleteCustomerByID()
//        {
//            Console.Clear();
//            Console.WriteLine("Which customer would you like to delete?");
//            List<Customer> customerList = _customerDirectory.GetAllCustomers();
//            int count = 0;
//            foreach (Customer customer in customerList)
//            {
//                count++;
//                Console.WriteLine($"{count}. {customer.IDNumber}");
//            }

//            int targetCustomerID = int.Parse(Console.ReadLine());
//            int targetIndex = targetCustomerID - 1;

//            if (targetIndex >= 0 && targetIndex < customerList.Count)
//            {
//                Customer desiredCustomer = customerList[targetIndex];
//                if (_customerDirectory.DeleteCustomerByID(desiredCustomer))
//                {
//                    Console.WriteLine($"{desiredCustomer.IDNumber} was removed.");
//                }
//                else
//                {
//                    Console.WriteLine("Something went wrong.");
//                }

//            }
//            else
//            {
//                Console.WriteLine("No customer has that ID");
//            }
//            Console.WriteLine("Press any key to continue.......");
//            Console.ReadKey();
//        }

//        private void DeleteCustomerByName()
//        {
//            Console.Clear();
//            Console.WriteLine("Which customer would you like to delete?");
//            List<Customer> customerList = _customerDirectory.GetAllCustomers();
//            int count = 0;
//            foreach (Customer customer in customerList)
//            {
//                count++;
//                Console.WriteLine($"{count}. {customer.LastName}");
//            }

//            int targetCustomerName = int.Parse(Console.ReadLine());
//            int targetIndex = targetCustomerName - 1;

//            if (targetIndex >= 0 && targetIndex < customerList.Count)
//            {
//                Customer desiredCustomer = customerList[targetIndex];
//                if (_customerDirectory.DeleteCustomerByName(desiredCustomer))
//                {
//                    Console.WriteLine($"{desiredCustomer.LastName} was removed.");
//                }
//                else
//                {
//                    Console.WriteLine("Something went wrong.");
//                }

//            }
//            else
//            {
//                Console.WriteLine("No customer has that last name");
//            }
//            Console.WriteLine("Press any key to continue.......");
//            Console.ReadKey();
//        }

//        private void ShowAllCustomers()
//        {
//            Console.Clear();

//            List<Customer> listOfCustomers = _customerDirectory.GetAllCustomers();
//            foreach (Customer customer in customerList)
//            {
//                DisplayCustomers(customer);
//            }
//            Console.WriteLine("Press any key to continue......");
//            Console.ReadKey();
//        }

//        private void DisplayCustomers(Customer customer)
//        {
//            Console.WriteLine($"ID Number: {customer.IDNumber}\n" +
//            $"Last Name: {customer.LastName}\n" +
//            $"Age: {customer.Age}\n" +
//            $"Enrollment Date: {customer.EnrollmentDate}\n" +
//            $"Years using program: {customer.YearsUsing}");          
//        }

//    }
//}
