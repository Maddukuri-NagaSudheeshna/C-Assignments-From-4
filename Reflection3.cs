using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]

    public class Accountatribute : System.Attribute  
    {
        private String projectName;
        private String description;
        private String clientName;
        private String startedDate;
        private String endDate;

        
        public Accountatribute(String Pn,String Dn,String Cn,String Sd,String Ed)
        {
            this.projectName = Pn;
            this.description = Dn;
            this.clientName = Cn;
            this.startedDate = Sd;
            this.endDate = Ed;
        }
        
        public String ProjectName
        {
            get { return this.projectName; }
            set { this.projectName = value; }
        }
        public String Description
        {
            get { return this.description; } 
            set { this.description = value; }
        }
        public String ClientName
        {
            get { return this.clientName; }
            set { this.clientName = value; }
        }
        public String StartedDate
        {
            get { return this.startedDate; }
            set { this.startedDate = value; }
        }
        public String EndingDate
        {
            get { return this.endDate; }
            set { this.endDate = value; }
        }

    }
    [SoftwareAttribute("Life Insurance", "about gurantee", "prashanth", "15/3/2011" ,"12/3/2019")]
    [SoftwareAttribute("banking sector", "this is all about banks", "prashanth", "02/08/2018", "18/1/2021")]
   
    class Axis1 :Accountatribute
    {//[SoftwareAttribute("Life Insurance", "about gurantee", "prashanth", "15/3/2011" ,"12/3/2019")]
        public void displayAccount(string projectName, string description, string clientname)
        {
            this.Description = description;
            this.ProjectName = projectName;
            this.ClientName = clientname;
            Console.WriteLine("Project Description : " + Description);
            Console.WriteLine("Projectname : " + ProjectName);
            Console.WriteLine("Project Client Name : " + ClientName);
        }
    }
       
        
    
    public class HDFCAccount1 : Accountatribute
    {
        public void displayAccount(string description, string projectName, string clientname, string startdate, string enddate)
        {
            this.Description = description;
            this.ProjectName = projectName;
            this.ClientName = clientname;
            //this.StartedDate = startdate;
            //this.endDate = enddate;
            Console.WriteLine("\nProject Description : " + Description);
            Console.WriteLine("Projectname : " + ProjectName);
            Console.WriteLine("Project Client Name : " + ClientName);
            //Console.WriteLine("Project Started Date : " + StartedDate);
            //Console.WriteLine("Project End Date : \n" + EndDate);
        }

    }

    public class TestAttribute
    {
        static void Main(String[] args)
        {
            /*Axis a = new Axis(7908654732,"Malinga");
            a.DisplayAxisDetails();
            Console.WriteLine("Please Press Enter to view HDFC Account Number : ");
            Console.ReadKey();
            HDFCAccount hdfc1 = new HDFCAccount(362528754, "manish");
            hdfc1.DisplayHDFCAccountDetails();*/
            Axis1 a1 = new Axis1();
            a1.displayAccount("reflection assignment", "reflection", "capgemini");
            HDFCAccount1 hdfc2 = new HDFCAccount1();
            hdfc2.displayAccount("reflection assignment", "reflection", "capgemini", "12-08-2022", "12-09-2022");



            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();
            foreach (Type t in types)
            {
                MethodInfo[] mi = t.GetMethods();
                foreach (var m in mi)
                {
                    Console.WriteLine(m);
                }
            }

        }

    }

}


    
