using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BinarySerializer
{
    public class Manager
    {
        public int managerId = 107;
        public string managerName = "Sudheeshna";
        public double managerBasicSalary = 100000;
    }


    internal class BinarySerializer 
    {
        static void Main(string[] args)
        {
            //Binary Serialization
            Manager manager = new Manager();
            FileStream fileStream = new FileStream(@"c:\BinarySerialization.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, manager); 
            Console.ReadKey();
            Manager managerAskingToDeserialize = (Manager) formatter.Deserialize(fileStream);
            Console.WriteLine(managerAskingToDeserialize.managerId);
            Console.WriteLine(managerAskingToDeserialize.managerName);
            Console.WriteLine(managerAskingToDeserialize.managerBasicSalary);
            Console.ReadKey();

        }
    }
}
