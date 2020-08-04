using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nebula
{
    // Answers for Questions 1-3 is provided below question 4 

    //QUESTION 4
    public class Program
    {
        static void fib(int n)
        {
            int c;
            Console.Write("Enter First number:");
            string First = Console.ReadLine();

            Console.Write("Enter Second number:");
            string Second = Console.ReadLine();

            int firstresult = 0;
            int secondresult = 0;
            if (int.TryParse(First, out firstresult) && int.TryParse(Second, out secondresult))
            {
                if (firstresult >= 0 && secondresult >= 0)
                {
                    for (int i = 2; i <= n; i++)
                    {
                        c = firstresult + secondresult;
                        Console.Write("Next Fibonacci number is:" + c);
                        Console.ReadLine();
                        firstresult = secondresult;
                        secondresult = c;
                    }
                }
                else
                {
                    Console.Write("Please enter vaild number");
                    Console.ReadLine();
                }
            }

            else
            {
                Console.Write("Please enter vaild number");
                Console.ReadLine();
            }



        }

        public static void Main()
        {
            fib(6);

        }
    }
}


//QUESTION 1

//* The foregin key of Event Detail table should be the primary key of the employee table since EmployeeGUID is unique.
//* I would change the relationships between the two tables to, an Employee can have zero to many Event Details and
//  an Event Detail can have one to many employees.
//* I would avoid data redundancy by removing vendor from the Employee table and Cellphone number from the
//  Event detail table, since there is a foreign key and relations between both tables.



//QUESTION 2

//Select* from dbo.[Employee File.csv]

//Begin Tran
//UPDATE dbo.[Employee File.csv]
//SET email = REPLACE(dbo.[Employee File.csv].email, SUBSTRING(dbo.[Employee File.csv].email, CHARINDEX('@', dbo.[Employee File.csv].email), LEN(dbo.[Employee File.csv].email) - CHARINDEX(dbo.[Employee File.csv].email, '@')), '@company.co.za')
//WHERE dbo.[Employee File.csv].email LIKE '%@%';


//QUESTION 3

//Begin Tran
//Select Movies.Genre
//, COUNT(*)
//From tickets
//INNER JOIN Movies
//on tickets.MovieID=Movies.MovieID
//Group BY Movies.Genre