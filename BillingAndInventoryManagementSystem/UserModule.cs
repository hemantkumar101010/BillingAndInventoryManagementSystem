using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingAndInventoryManagementSystem
{
    internal class UserModule
    {
        // 1. User Module - Manages all the User
        //Read input user details(userid, fname, lname, email, phone) from console and store it in user.txt file
        private int userId, phone;
        public string fName, lName, email;


        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\iamte\source\repos\BillingAndInventoryManagementSystem\usersFile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);

            int i = 1;
            streamWriterObj.WriteLine("FName\tLName\tId\tPhone\tEmail");
            while (i <= 5)
            {
                Console.WriteLine("Enter user "+i+" first name");
                fName = Console.ReadLine();
                streamWriterObj.Write(fName + "\t");

                Console.WriteLine("Enter  last name");
                lName = Console.ReadLine();
                streamWriterObj.Write(lName + "\t");

                Console.WriteLine("Enter Id.");
                userId = Convert.ToInt32(Console.ReadLine());
                streamWriterObj.Write(userId + "\t");

                Console.WriteLine("Enter phone");
                phone = Convert.ToInt32(Console.ReadLine());
                streamWriterObj.Write(phone + "\t");

                Console.WriteLine("Enter users email");
                email = Console.ReadLine();
                streamWriterObj.WriteLine(email);
                i++;

            }
            streamWriterObj.Close();
            fileStreamObj.Close();
            Console.WriteLine("File write operation completed");

        }
    }
}
