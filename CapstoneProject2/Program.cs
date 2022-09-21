using System;
using System.Security.Cryptography.X509Certificates;

namespace CapstoneProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Librarian l = new Librarian();
            Borrower b = new Borrower(); 

                     
                int task = 1;
                while (task!=0)
                {
                    Console.WriteLine("ENTER YOUR ROLE");
                Console.WriteLine();
                Console.WriteLine("1. LIBRARAIN");
                Console.WriteLine();
                Console.WriteLine("2. BORROWER");

                    int a =(int) int.Parse(Console.ReadLine());

                  if (a == 1)
                {


                    Console.WriteLine();
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("ENTER THE TASK TO DO");
                    Console.WriteLine("-------------------------------");


                    Console.WriteLine("1. ADD A NEW BOOK");
                    Console.WriteLine();
                    Console.WriteLine("2.  DISPLAY THE AVAILABLE BOOKS");
                    Console.WriteLine();
                    Console.WriteLine("3. REMOVE A  BOOK");
                    Console.WriteLine();
                    Console.WriteLine("4. Sort The Library");
                    Console.WriteLine();
                    Console.WriteLine("5. SORT LIBRARY USING LINQ");
                    Console.WriteLine();
                    Console.WriteLine("6. EXIT");
                   
                    Console.WriteLine("-------------------------------");
                    task = (int)int.Parse(Console.ReadLine());

                    {

                        switch (task)
                        {
                            case 1:

                                               l.add();                 //Calling Add Method 
                            break;
                            case 2:
                                             Console.WriteLine("************************************************************************************************************************");
                                             Console.WriteLine();
                                             Console.WriteLine("{0,72}"," WELCOME TO MYLAB");
                                             Console.WriteLine();
                                             Console.WriteLine("************************************************************************************************************************");
                                             l.Disp();
                                              Console.WriteLine();

                            break;

                            case 3:
                                             l.Removedata();            //Calling Remove Method

                            break;

                            case 4:
                                              Console.WriteLine("************************************************************************************************************************");
                                              Console.WriteLine();
                                              Console.WriteLine("{0,72}", " WELCOME TO MYLAB");
                                              Console.WriteLine();
                                              Console.WriteLine("************************************************************************************************************************");
                                              l.DispIcom();
                            break;

                            case 5:
                                              l.Llinq();          //Calling LINQ Method to Display Sort Data (BY BOOK AUTHORS NAME)
                            break;
                            case 6:
                                              Console.WriteLine("THANK YOU !!!!! VISIT AGAIN!!!!");
                            break;

                            default:
                                               Console.WriteLine("INVALID CHOICE");
                             break;

                        }

                    }
                }

                    if (a == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("ENTER THE TASK TO DO");
                        Console.WriteLine("-------------------------------");

                        Console.WriteLine("1. BORROW A Book");
                        Console.WriteLine();
                       
                        Console.WriteLine("2. Display the DETAIlS");
                        Console.WriteLine();
                        Console.WriteLine("3. Return the DETAIlS");
                        Console.WriteLine();
                        Console.WriteLine("4. SORT BORROWER DETAILS(LINQ)");
                        Console.WriteLine();
                        Console.WriteLine("-------------------------------");
                    int m = int.Parse(Console.ReadLine());
                        switch (m)
                        {
                           case 1:
                                               l.Disp();
                                               l.BorrowBOOK();                  //Calling Disp And Borrow Method
                           break;

                           case 2:
                                               Console.WriteLine();
                                               l.BDisp();                     //Calling Display Method

                           break;

                           case 3:
                                              l.BDisp();                       //Calling Disp And RetuenBook Method
                                             l.ReturnBook();
                           break;

                           case 4:

                                             l.CLlinq();                          //Calling linq method to display sort data (by Book Quantity)
                           break;

                           default:
                                              Console.WriteLine("INVALID CHOICE!! PLEASE ENTER A VALID CHOICE");
                              
                           break;


                        }
                }

            }
        }
    }
}

