using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
    public class SoftwareAttribute : System.Attribute  
    {
        private String projectName;
        private String description;
        private String clientName;
        private String startedDate;
        private String endDate;
  	public SoftwareAttribute(String Pn,String Dn,String Cn,String Sd,String Ed)
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
        }
        public String Description
        {
            get { return this.description; }    
        }
        public String ClientName
        {
            get { return this.clientName; }
        }
        public String StartedDate
        {
            get { return this.startedDate; }
        }
        public String EndingDate
        {
            get { return this.endDate; }
        }

    }
    [SoftwareAttribute("Life Insurance", "about gurantee", "prashanth", "15/3/2011" ,"12/3/2019")]
    [SoftwareAttribute("banking sector", "this is all about banks", "prashanth", "02/08/2018", "18/1/2021")]
    class Axis
    {
        //member variables
        protected int acNumber;
        protected String customerName;
        public Axis(int acNumber, String customerName)
        {
            this.acNumber = acNumber;
            this.customerName = customerName;
        }
        [SoftwareAttribute("Life Insurance", "about gurantee", "prashanth", "15/3/2011" ,"12/3/2019")]

        public int AcNumber
        {
            get
            {
                return this.acNumber;
            }
             
        }
        public String CustomerName
        {
            get { return this.customerName; }
        }

        public void DisplayAxisDetails()
        {
            Console.WriteLine("Axis Account number : " + acNumber);
            Console.WriteLine("Axis Customer Name : " + customerName);
            Console.ReadKey();
        }
        
    }
    [SoftwareAttribute("Life Insurance", "about gurantee", "prashanth", "15/3/2011" ,"12/3/2019")]
    [SoftwareAttribute("banking sector", "this is all about banks", "prashanth", "02/08/2018", "18/1/2021")]

    public class HDFCAccount
    {
        public int HDFCAcNumber;
        public String HDFCCustomerName;

        public HDFCAccount(int HDFCAcNumber,String HDFCCustomerName)
        {
            this.HDFCAcNumber = HDFCAcNumber; 
            this.HDFCCustomerName = HDFCCustomerName; 
        }
      [SoftwareAttribute("Life Insurance", "about gurantee", "prashanth", "15/3/2011" ,"12/3/2019")]	

        public int HDFCAcNumber
        {
            get { return this.HDFCAcNumber; }
        }
        public String  HDFCCustomerName
        {
            get { return this.HDFCCustomerName; }
        }
        public void DisplayHDFCAccountDetails()
        {
            Console.WriteLine("HDFC Account Number :  " + HDFCAcNumber);
            Console.WriteLine("HDFC Customer Name : " + HDFCCustomerName);
        }

    }

    public class TestAttribute
    {
        static void Main(String[] args)
        {
            Axis a= new Axis(7908654732,"Malinga");
            a.DisplayAxisDetails();
            Console.WriteLine("Please Press Enter to view HDFC Account Number : ");
            Console.ReadKey();
            HDFCAccount hdfc = new HDFCAccount(362528754, "manish");
            hdfc.DisplayHDFCAccountDetails();

            Accountatribute Aa = new Accountatribute("ims", "it deals with salary issues", "tcs", "12/2/2000", "22/3/2001");

        }
    }
}


    
