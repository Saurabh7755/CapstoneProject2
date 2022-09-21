using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CapstoneProject2
{
    internal class Borrower : IComparable
    {
        public List<Borrower> dataBorrower = new List<Borrower>();


      
        public int Custid { get; set; }
        public string Bname { get; set; }

        public string Address { get; set; }
        public int CBOOKID { get; set; }

        public int CQUAN { get; set; }

        public int fine
        {
            get
            {
                return CQUAN * 20;
            }
        }
   
        public DateTime date { get; set; }

        public DateTime Rdate { get; set; }

        public void BDisp()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("{0,5} {1,15} {2,15} {3,15} {4,15} {5,15}{6,15} {7,15}", "Cust_ID", "CUST_NAME","CUST_ADD","BOOKID", "BOOKQUANTITY", "BORROW DATE", "RETUEN DATE", "DUEFINE");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            foreach (Borrower b in this.dataBorrower)
            {
                Console.WriteLine("{0,5} {1,15} {2,15} {3,15} {4,15} {5,15} {6,15} {7,15} ",b.Custid , b.Bname, b.Address,b.CBOOKID, b.CQUAN, b.date.ToShortDateString(),b.Rdate.ToShortDateString(),b.fine+"RS");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }

        }
        public int CompareTo(Object objp)
        {
            if (objp == null)
            {
                return 1;
            }
            else
            {
                Borrower Other = objp as Borrower;
                return this.Bname.CompareTo(Other.Bname);
            }
        }

      
    }
}


    



