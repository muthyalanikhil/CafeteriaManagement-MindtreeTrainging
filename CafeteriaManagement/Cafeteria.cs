using System;
using System.Collections.Generic;
using System.Collections;


namespace CafeteriaManagement
{
    class Cafeteria
    {
        Queue cafeteriaQueue = new Queue();

        /// <summary>
        /// Method used to add employees to the queue
        /// </summary>
        public void AddEmployeeInQueue()
        {
            Console.WriteLine("\nEnter the number of employees to be added in the queue:");
            int numberOfEmployees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter names of the employees to be added in the queue:");
           
            for (int index = 0; index < numberOfEmployees; index++)
            {
                string nameOfEmployee = Console.ReadLine();
                cafeteriaQueue.Enqueue(nameOfEmployee);
            }
            GetToken();
        }

        public void GetToken()
        {
            Console.WriteLine("\n1.All the employees standing in the queue.\n2.Add employees to the queue.\n3.To remove employees from the queue.\n4.Exit.");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FindEmployeesInQueue();
                    break;
                case 2:
                    AddEmployeeInQueue();
                    break;
                case 3:
                    LeaveQueue();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Method used to remove employees from the queue.
        /// </summary>
        public void LeaveQueue()
        {
            Console.WriteLine("\nEnter numbers of employees leaving the queue.");
            int numberOfEmployees = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < numberOfEmployees ; index++)
            {
                cafeteriaQueue.Dequeue();
            }
            GetToken();
        }

        /// <summary>
        /// This method is used to display employees in the queue.
        /// </summary>
        public void FindEmployeesInQueue()
        {
            Console.WriteLine("\nEmployees in queue are:");
            foreach (var queueValue in cafeteriaQueue)
            {
                Console.WriteLine(queueValue);
            }
            GetToken();
        }
    }
}
