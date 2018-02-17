using System;
using System.Collections.Generic;

namespace CafeteriaManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cafeteria queue = new Cafeteria();
                queue.AddEmployeeInQueue();
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid input.\nPlease try again.");
                Cafeteria queue = new Cafeteria();
                queue.AddEmployeeInQueue();
            }
          
        }
    }
}
