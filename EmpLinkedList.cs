using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    internal class EmpLinkedList
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starts...");
            LinkedList<String> list = new LinkedList<String>();
            Console.WriteLine("Adding Employee Details");
            list.AddFirst("sudheeshna"); 
            list.AddLast("revathi");   
            list.AddLast("maneesha");  
            list.AddLast("srilekha");   
            list.AddLast("sireeshna");  

            foreach (String item in list)   
            {
                Console.WriteLine("We are happily welcoming the new Joiners : {0} ",item);    
            }
            Console.WriteLine("===============================================================");
            Console.WriteLine(list.Contains("sudheeshna"));  
            Console.WriteLine(list.Contains("maneesha"));
            Console.WriteLine("===============================================================");
            //total number of employees in the list/Count of employees
            Console.WriteLine("Total number of employees in the linked list is : {0} ", list.Count); 
            Console.WriteLine("Program ends...");
        }
    }
}
