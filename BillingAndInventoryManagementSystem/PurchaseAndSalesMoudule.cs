using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingAndInventoryManagementSystem
{
    internal class PurchaseAndSalesMoudule
    {
        //        4.Purchase and Sales Module - Purchase Products from Dealer and Sell Products to Consumers
        //Read product details(SalesId, Productid, price, salesdate) from console and store it in purchase.txt file

        int salesId, productId, price;
        string salesDate;
        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\iamte\source\repos\BillingAndInventoryManagementSystem\purchaseAndSalesMouduleFile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);


            streamWriterObj.WriteLine("SalesId \t Productid\tprice\tsalesdate");
            Console.WriteLine("Enter sales Id");
            salesId = Convert.ToInt32(Console.ReadLine());
            streamWriterObj.Write(salesId + "\t\t");

            Console.WriteLine("Enter product id");
            productId = Convert.ToInt32( Console.ReadLine());
            streamWriterObj.Write(productId+"\t\t");

            Console.WriteLine("Enter price");
            price = Convert.ToInt32(Console.ReadLine());
            streamWriterObj.Write(price + "\t");

            Console.WriteLine("Enter slaes date");
            salesDate = (Console.ReadLine());
            streamWriterObj.Write(salesDate);

            streamWriterObj.Close();
            fileStreamObj.Close();
            Console.WriteLine("File write operation completed");
        }
    }
}
