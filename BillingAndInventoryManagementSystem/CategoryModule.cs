using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingAndInventoryManagementSystem
{
    internal class CategoryModule
    {
        //        2. Category Module - Manages all the Category for products
        //Read Category details(categoryid, categorytype) from console and store it in category.txt file
        int categoryId; string categoryType;
        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\iamte\source\repos\BillingAndInventoryManagementSystem\categoryFile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);


            streamWriterObj.WriteLine("CategoryId\tCategoryType");
            Console.WriteLine("Enter product category Id");
            categoryId = Convert.ToInt32(Console.ReadLine());
            streamWriterObj.Write(categoryId + "\t\t");

            Console.WriteLine("Enter category type of product");
            categoryType = Console.ReadLine();
            streamWriterObj.Write(categoryType);

            streamWriterObj.Close();
            fileStreamObj.Close();
            Console.WriteLine("File write operation completed");
        }
    }
}
