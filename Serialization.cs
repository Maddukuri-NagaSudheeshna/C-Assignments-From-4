using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BinarySerialization
{
    
    public class Employee
    {
        public int empId = 111;
        public string empName = "sudheeshna";
        public string empDesignation = "analystA4";

    }
    public class Manager1
    {
        public int managerId = 1111;
        public String managerName = "revathi";
        public double managerBasicPayScale = 100000;

    }
    public class MarketingExecutive
    {
        public int markExId = 11111;
        public String markExName = "Mark Juten berg";
        public String markExDesignation = "BDA";

    }
    internal class Serialization
    {
        static void Main(String[] args)
        {
            //Serializing Manager Object
            Manager1 manager = new Manager1();
            FileStream fileStream = new FileStream(@"c:\Serialization1.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, manager);
            Console.ReadKey();

            //Serializing Employee Object
            Employee employee = new Employee();
            FileStream fileStream1 = new FileStream(@"c:\Serialization2.txt",FileMode.Create);
            BinaryFormatter formatter1 = new BinaryFormatter();
            formatter1.Serialize(fileStream, employee); 
            Console.ReadKey();

            //Serializing MarketingExecutive Object
            MarketingExecutive marketingExecutive = new MarketingExecutive();
            FileStream fileStream2 = new FileStream(@"c:\Serialization3.txt", FileMode.Create);
            BinaryFormatter formatter2 = new BinaryFormatter();
            formatter2.Serialize(fileStream2, marketingExecutive);
            Console.ReadKey();

        }
    }
}
