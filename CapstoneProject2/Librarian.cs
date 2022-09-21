using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace CapstoneProject2
{
    internal class Librarian : Borrower, IComparable
    {

        public List<Librarian> datalab = new List<Librarian>();



        public static int IdCounter;
        private static int SIdCounter;

        private int _BookID;
        private int _SId;


        static Librarian()
        {
            Librarian.IdCounter = 99;

            Librarian.SIdCounter = 0;

        }

        public Librarian()
        {
            this._BookID = Librarian.IdCounter++;

            this._SId = Librarian.SIdCounter++;                        //automatic id generator

        }


        public int BookId
        {
            get
            {
                return _BookID;

            }
        }
        public int SId
        {
            get
            {
                return _SId;

            }
        }


        private string _BookName;
        //ENCAPSULATION
        public string Bookname
        {
            get
            {
                return _BookName;
            }
            set
            {
                while (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("BOOK NAME CANNOT BE EMPTY");
                    Console.WriteLine();
                    Console.WriteLine("ENTER A VALID BOOK NAME!!!");
                    value = Console.ReadLine();
                }

                if (!string.IsNullOrEmpty(value))
                {
                    _BookName = value;                  //string validation

                }



            }
        }

        private string _BookAuthor;
        //ENCAPSULATION
        public string BookAuthor
        {
            get
            {
                return _BookAuthor;
            }
            set
            {
                while (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("AUthor NAME CANNOT BE EMPTY");
                    Console.WriteLine();
                    Console.WriteLine("Please Enter A AUTHOR NAME!!!");
                    value = Console.ReadLine();
                }

                if (!string.IsNullOrEmpty(value))
                {
                    _BookAuthor = value;                   //String Validation

                }

            }

        }

        private int _BookPrice;
        //ENCAPSULATION
        public int BookPrice
        {

            get
            {
                return _BookPrice;
            }
            set
            {
                while (value <= 0)
                {
                    Console.WriteLine("INVALID PRICE");
                    Console.WriteLine();
                    Console.WriteLine("PLEASE ENTER A VALID PRICE OF A BOOK");
                    value = int.Parse(Console.ReadLine());
                }
                if (value > 0)
                {
                    _BookPrice = value;                  //validation of data
                }
            }
        }

        private int _Bookquantity;
        //ENCAPSULATION
        public int Bookquantity
        {
            get
            {
                return _Bookquantity;
            }
            set
            {
                while (value <= 0)
                {
                    Console.WriteLine("INVALID PRICE");
                    Console.WriteLine();
                    Console.WriteLine("PLEASE ENTER A VALID  BOOK Quantity");
                    value = int.Parse(Console.ReadLine());
                }
                if (value > 0)
                {
                    _Bookquantity = value;                   //VAlidation of data
                }
            }
        }






        //ADDING THE LIBRARY DATA
        public void add()
        {

            Librarian l = new Librarian();


            Console.WriteLine("ENTER THE BOOK NAME");
            l.Bookname = Console.ReadLine();

            Console.WriteLine("ENTER THE NAME OF AUTHOR");
            l.BookAuthor = Console.ReadLine();

            Console.WriteLine("ENTER THE PRICE OF BOOK");
            l.BookPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER THE BOKK QUANTITY");
            l.Bookquantity = int.Parse(Console.ReadLine());

            this.datalab.Add(l);
            Console.WriteLine(datalab.Count);                          //ADDING The Data In Librarian List
        }



        //DISPLAYING LIBRARY DATA
        public void Disp()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("{0,5} {1,15} {2,15} {3,15} {4,15} {5,15}  ", "SR_NO", "BOOKID", "BOOKName", "BOOKAUTHOR", "BookPrice", "Bookquantity");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            foreach (Librarian l in this.datalab)
            {
                Console.WriteLine("{0,5} {1,15} {2,15} {3,15} {4,15} {5,15}  ", l._SId, l._BookID, l.Bookname, l.BookAuthor, l.BookPrice, l.Bookquantity);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
        }
        //SORTING LIBRARY DATA BY ICOMPARABLE
        public void DispIcom()
        {
            Console.WriteLine();
            Console.WriteLine("************************************************************************************************************************");

            Console.WriteLine("{0,5} {1,15} {2,15} {3,15} {4,15} {5,15} {6,15} ", "SR_NO", "BOOKID", "BOOKName", "BOOKAUTHOR", "BookPrice", "Bookquantity", "BOOKFINE");
            datalab.Sort();
            foreach (Librarian l in datalab)
            {
                Console.WriteLine();
                Console.WriteLine(l);
            }
        }
        //SORTING DATA USING LINQ
        public void Llinq()
        {
            var quary = from lb in datalab
                        orderby lb._BookAuthor
                        select lb;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("{0,10} {1,15} {2,15}", "BOOKID", "BOOKNAME", "BOOKAUTHOR");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var l in quary)
            {

                Console.WriteLine("{0,10} {1,15} {2,15}", l.BookId, l.Bookname, l.BookAuthor);
                Console.WriteLine("-------------------------------------------------------");
            }
        }

        //REMOVING THE DATA OF LIBRARY
        public void Removedata()
        {
            this.Disp();
            Console.WriteLine("Enter the ID of the product to remove:");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < datalab.Count; i++)
            {
                Librarian l = this.datalab[i] as Librarian;        // unboxing
                if (l._BookID == id)
                {
                    Console.WriteLine("BOOK IS AVAILABLE");
                    this.datalab.Remove(l);
                    break;          // exit the for loop
                }
            }

        }
        //ICOMPARABLE METHOD
        public new int CompareTo(Object objp)
        {
            if (objp == null)
            {
                return 1;
            }
            else
            {
                Librarian Other = objp as Librarian;
                return this._BookName.CompareTo(Other._BookName);
            }
        }
        // Override the string
        public override string ToString()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            return $"{_SId,5} {_BookID,15} {_BookName,15} {BookAuthor,15} {BookPrice + "Rs",15} {Bookquantity,15} ";


        }



        //ADDING DATA OF BORROWER
        public void BorrowBOOK()

        {
            Borrower b = new Borrower();

            Console.WriteLine("ENTER Customer ID");
            b.Custid =int.Parse( Console.ReadLine());

            Console.WriteLine("ENTER Customer name");
            b.Bname = Console.ReadLine();

            Console.WriteLine("ENTER Customer ADDRESS");
            b.Address = Console.ReadLine();

            Console.WriteLine("ENTER BOOK ID TO BORROW");
            b.CBOOKID = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER THE QUANTITY To Borrow");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < datalab.Count; i++)
            {
                Librarian l = this.datalab[i] as Librarian;
                // unboxing
                if (l.BookId == b.CBOOKID)
                {
                    Console.WriteLine("BOOK IS AVAILABLE");

                    while (l.Bookquantity < value)
                    {
                        Console.WriteLine("PLEASE ENTER VALID QUANTITY!!!");  //VALIDATION OF DATA
                        value = int.Parse(Console.ReadLine());

                    }
                    if (l.Bookquantity > value)
                    {
                        l.Bookquantity -= value;
                        b.CQUAN = value;                           //If BOOKID IS MATCHED THEN QUANTITY VALUE Will Be Assign TO Quantity


                    }

                }

            }

            Console.WriteLine();

            b.date = DateTime.Now;
            Console.WriteLine("THE BORROW DATE IS : {0} ", b.date.ToShortDateString());

                                                                                            
            Console.WriteLine("THE BORROW TIME IS : {0} ", b.date.ToShortTimeString());
            Console.WriteLine();

            b.Rdate = b.date.AddDays(20);
            Console.WriteLine("THE RETURN DATE IS: {0}", b.date.AddDays(20));         //ADDING 20 Days For Returning The Book

            this.dataBorrower.Add(b);

        }
        //RETURNING BORROW BOOK DATA
        public void ReturnBook()
        {

            Console.WriteLine("Enter the BOOK ID");
            int bid = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE QUANTITY TO RETURN");
            int value = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < datalab.Count; i++)
            {
                Librarian l = this.datalab[i] as Librarian;
                Borrower b = this.dataBorrower[i] as Borrower;

                if (l._BookID == bid)
                {
                   
                    while(b.CQUAN<value)
                    {
                        Console.WriteLine("PLEASE ENTER A VALID QUANTITY OF BOOKS");
                        value=int.Parse(Console.ReadLine());
                    }
                    if (b.CQUAN >= value)
                    {
                        l.Bookquantity += value;
                        b.CQUAN -= value;
                    }

                }

            }

        }

        //USING LINQ
        //DISPLAYING BORROWER BOOK QUANTITY IN DEDCENDING ORDER

        public void CLlinq()
        {
            var query = from b in dataBorrower
                        orderby b.CQUAN descending
                        select b;

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("{0,5} {1,15} {2,15} {3,15} {4,15} {5,15}{6,15} {7,15}", "Cust_ID", "CUST_NAME", "CUST_ADD", "BOOKID", "BOOKQUANTITY", "BORROW DATE", "RETUEN DATE", "DUEFINE");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            foreach (Borrower b in query)
            {

                Console.WriteLine("{0,5} {1,15} {2,15} {3,15} {4,15} {5,15} {6,15} {7,15} ", b.Custid, b.Bname, b.Address, b.CBOOKID, b.CQUAN, b.date.ToShortDateString(), b.Rdate.ToShortDateString(), b.fine + "RS");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
        }

    }
}
       
       