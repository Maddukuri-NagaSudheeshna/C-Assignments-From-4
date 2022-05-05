using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGeneric
{
    public class CustomGeneric<String>  
    {
        public string Name { get; set; }    
        int MAX2 = 500;  
        int top2;                        
        String[] str = new String[MAX2]; 
       
       public void Push(String data)  
        {
            if(top2 > MAX2)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                str[top2++]=data;
                Console.WriteLine("people who applied for job those are going to added in stack : " + data);
            }
        }
        public void Pop()  
        {
            if(top2 < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                String value = str[top2--];
                Console.WriteLine(value);
                Console.WriteLine("who are withdraw their application for the applied job  " + value);
            }
        }
    }
    internal class CustomClassGeneric
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starts...");
            CustomGeneric<String> cg = new CustomGeneric<String>();           
            cg.Push("sudheeshna");  
            cg.Push("revathi");
            cg.Push("maneesha");
            cg.Push("srilekha");
            cg.Push("sireesha");

            cg.Pop();  
            Console.WriteLine("Program ends...");
        }
    }
}
